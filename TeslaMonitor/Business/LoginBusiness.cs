using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Web;
using TeslaMonitor.Entities.OAuth;
using TeslaMonitor.Entities.Api;

namespace TeslaMonitor.Business;

public class LoginBusiness
{
    public string? CodeVerifier { get; set; }
    public string? CodeChallenge { get; set; }

    private const string ClientId = "ownerapi";
    private const string ClientSecret = "c7257eb71a564034f9419ee651c7d0e5f7aa6bfbd18bafb5c5c033b093bb2fa3";
    private const string CodeChallengeMethod = "S256";
    private const string RedirectUri = "https://auth.tesla.com/void/callback";
    private const string ResponseType = "code";
    private const string Scope = "openid email offline_access";
    private const string Locale = "zh-CN";
    private const string ApiConfigFilePath = "./Configs/api.json";
    private const string GrantType = "authorization_code";
    private const int RandomStringLength = 86;
    private const int StateStringLength = 20;


    private string FileContent { get; set; }
    public ApiUri? WebApi { get; set; }
    public string? Code { get; set; }
    public Tokens tokens { get; set; }

    public LoginBusiness()
    {
        FileContent = File.ReadAllText(ApiConfigFilePath);
        WebApi = JsonSerializer.Deserialize<ApiUri>(FileContent);
    }

    public string GetLoginUrlForWebView()
    {
        CodeVerifier = RandomString(RandomStringLength);
        CodeChallenge = Base64UrlEncode(ComputeSHA256HashInBytes(CodeVerifier));
        var parameters = new Dictionary<string, string>(8)
        {
            { "client_id", ClientId },
            { "code_challenge", CodeChallenge },
            { "code_challenge_method", CodeChallengeMethod },
            { "redirect_uri",  RedirectUri},
            { "response_type", ResponseType },
            { "scope", Scope },
            { "state", RandomString(StateStringLength) },
            { "locale", Locale }
        };

        var uriBuilder = new UriBuilder(WebApi?.Auth?.BaseUri + WebApi?.Auth?.Authorize)
        {
            Port = -1
        };
        var queryParameters = HttpUtility.ParseQueryString(uriBuilder.Query);
        foreach (var item in parameters)
        {
            queryParameters.Set(item.Key, item.Value);
        }

        uriBuilder.Query = queryParameters.ToString();
        return uriBuilder.ToString();
    }

    public void GetCode(string requestUri)
    {
        var uri = new Uri(requestUri);
        var code = HttpUtility.ParseQueryString(uri.Query).Get("code");
        if(string.IsNullOrEmpty(code))
        {
            throw new InvalidOperationException("Authorization code not found in the request URI.");
        }
        else
        {
            Code = code;
        }
    }

    public async Task<Tokens> GetToken()
    {
        var tokens = new Tokens();

        if (Code != null && CodeVerifier != null)
        {
            var parameters = new Dictionary<string, string>(8)
            {
                { "grant_type", GrantType },
                { "client_id", ClientId },
                { "client_secret", ClientSecret },
                { "code", Code },
                { "code_verifier", CodeVerifier },
                { "redirect_uri", RedirectUri },
                { "audience", WebApi?.Auth?.Audience }
            };

            var uri = WebApi?.Auth?.BaseUri + WebApi?.Auth?.Token;
            var client = new HttpClient();
            var content = new StringContent(JsonSerializer.Serialize(parameters), Encoding.UTF8,
                MediaTypeHeaderValue.Parse("application/json"));

            var response = await client.PostAsync(uri, content);
            if (response is { IsSuccessStatusCode: true, ReasonPhrase: "OK" })
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                tokens = JsonSerializer.Deserialize<Tokens>(responseContent);
            }
        }

        return tokens;
    }

    private static string RandomString(int length)
    {
        const string pool = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        var builder = new StringBuilder();
        var random = new Random();
        for (var i = 0; i < length; i++)
        {
            var c = pool[random.Next(0, pool.Length)];
            builder.Append(c);
        }

        return builder.ToString();
    }

    
    private static byte[] ComputeSHA256HashInBytes(string data)
    {
        using var sha256 = SHA256.Create();
        var hash = sha256.ComputeHash(Encoding.Default.GetBytes(data));
        return hash;
    }

    public static string Base64UrlEncode(byte[] bytes)
    {
        string base64 = Convert.ToBase64String(bytes);
        string encoded = base64
            .Replace('+', '-')
            .Replace('/', '_')
            .TrimEnd('=');
        return encoded;
    }
}