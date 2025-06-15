using System.Text.Json.Serialization;
using TeslaMonitor.Entities.OAuth;

namespace TeslaMonitor.Entities.Api;

public class ApiUri
{
    [JsonPropertyName("vehicle")]
    public Vehicle? Vehicle { get; set; }

    [JsonPropertyName("auth")]
    public Auth? Auth { get; set; }

}