using Dapper;
using Microsoft.Data.Sqlite;
using TeslaMonitor.Library.Models;

namespace TeslaMonitor.Library.Sql
{
    public class Dal
    {
        private static string GetConnectionString()
        {
            return $"Data Source={Environment.CurrentDirectory}\\Database\\teslamonitor.db";
        }

        public static Tokens? InsertOrUpdateTokens(Tokens tokens)
        {
            using var connection = new SqliteConnection(GetConnectionString());
            const string querySql = """
                                    select access_token    as AccessToken,
                                           refresh_token   as RefreshToken,
                                           state,
                                           token_type      as TokenType,
                                           id_token        as IdToken,
                                           expires_in      as ExpiresIn,
                                           data_createtime as DataCreateTime,
                                           data_updatetime as DataUpdateTime
                                    from db_tokens;
                                    """;
            var result = connection.QueryFirstOrDefault<Tokens>(querySql);
            int executeResult = 0;
            // If the result is null, it means there are no tokens in the database, so we insert a new record.
            if (null == result)
            {
                const string insertSql = """
                                         insert into db_tokens (access_token, refresh_token, state, token_type, id_token, expires_in, data_createtime, data_updatetime)
                                         values (@AccessToken, @RefreshToken, @State, @TokenType, @IdToken, @ExpiresIn, @DataCreateTime, @DataUpdateTime);
                                         """;
                var unixTimeMilliseconds = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                tokens.DataCreateTime = unixTimeMilliseconds;
                tokens.DataUpdateTime = unixTimeMilliseconds;

                executeResult = connection.Execute(insertSql, tokens);
                if (executeResult > 0)
                {
                    return tokens;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                string updateSql = """
                                   update db_tokens
                                   set access_token = @AccessToken,
                                       refresh_token = @RefreshToken,
                                       state = @State,
                                       token_type = @TokenType,
                                       id_token = @IdToken,
                                       expires_in = @ExpiresIn,
                                       data_updatetime = @DataUpdateTime
                                   where id = 1;
                                   """;
                long currentDateTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                tokens.DataUpdateTime = currentDateTime;
                executeResult = connection.Execute(updateSql, tokens);
                return tokens;
            }
        }
    }
}