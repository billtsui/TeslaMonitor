namespace TeslaMonitor.Library.Models
{
    public class Tokens
    {
        public string AccessToken { get; set; }

        public string RefreshToken { get; set; }

        public int ExpiresIn { get; set; }

        public string State { get; set; }

        public string TokenType { get; set; }

        public string IdToken { get; set; }

        public long DataCreateTime { get; set; }
        public long DataUpdateTime { get; set; }
    }
}
