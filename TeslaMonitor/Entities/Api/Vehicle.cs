using System.Text.Json.Serialization;

namespace TeslaMonitor.Entities.Api;

public class Vehicle
{
    [JsonPropertyName("baseUri")]
    private string BaseUri { get; set; }
}