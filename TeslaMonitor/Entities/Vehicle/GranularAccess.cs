using System.Text.Json.Serialization;

namespace TeslaMonitor.Entities.Vehicle;

public class GranularAccess
{
    [JsonPropertyName("hide_private")] public bool HidePrivate { get; set; }
}