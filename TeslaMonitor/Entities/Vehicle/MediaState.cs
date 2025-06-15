using System.Text.Json.Serialization;

namespace TeslaMonitor.Entities.Vehicle;

public class MediaState
{
    [JsonPropertyName("remote_control_enabled")]
    public bool RemoteControlEnabled { get; set; }
}