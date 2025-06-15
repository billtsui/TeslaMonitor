using System.Text.Json.Serialization;

namespace TeslaMonitor.Entities.OAuth;

public class Auth
{
    [JsonPropertyName("baseUri")]
    public string BaseUri { get; set; }

    [JsonPropertyName("authorize")]
    public string Authorize { get; set; }

    [JsonPropertyName("token")]
    public string Token { get; set; }

    [JsonPropertyName("audience")]
    public string Audience { get; set; }
}