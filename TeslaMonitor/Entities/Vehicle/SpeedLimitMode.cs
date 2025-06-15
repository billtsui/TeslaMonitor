using System.Text.Json.Serialization;

namespace TeslaMonitor.Entities.Vehicle;

public class SpeedLimitMode
{
    [JsonPropertyName("active")] public bool Active { get; set; }

    [JsonPropertyName("current_limit_mph")]
    public long CurrentLimitMph { get; set; }

    [JsonPropertyName("max_limit_mph")] public long MaxLimitMph { get; set; }

    [JsonPropertyName("min_limit_mph")] public long MinLimitMph { get; set; }

    [JsonPropertyName("pin_code_set")] public bool PinCodeSet { get; set; }
}