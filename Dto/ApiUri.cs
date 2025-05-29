using System.Text.Json.Serialization;

namespace TeslaMonitor.Dto;

public class ApiUri
{
    [JsonPropertyName("vehicle")]
    public Vehicle? Vehicle { get; set; }

    [JsonPropertyName("auth")]
    public Auth? Auth { get; set; }

}