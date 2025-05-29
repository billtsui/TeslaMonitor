using System.Text.Json.Serialization;

namespace TeslaMonitor.Dto;

public class Vehicle
{
    [JsonPropertyName("baseUri")]
    private string BaseUri { get; set; }
}