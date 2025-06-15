using System.Text.Json.Serialization;

namespace TeslaMonitor.Entities.Vehicle;

public class DriveState
{
    [JsonPropertyName("power")] public long Power { get; set; }

    [JsonPropertyName("shift_state")] public string ShiftState { get; set; }

    [JsonPropertyName("speed")] public string Speed { get; set; }

    [JsonPropertyName("timestamp")] public long Timestamp { get; set; }
}