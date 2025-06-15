using System.Text.Json.Serialization;

namespace TeslaMonitor.Entities.Vehicle;

public class GuiSettings
{
    [JsonPropertyName("gui_24_hour_time")] public bool Gui24_HourTime { get; set; }

    [JsonPropertyName("gui_charge_rate_units")]
    public string GuiChargeRateUnits { get; set; }

    [JsonPropertyName("gui_distance_units")]
    public string GuiDistanceUnits { get; set; }

    [JsonPropertyName("gui_range_display")]
    public string GuiRangeDisplay { get; set; }

    [JsonPropertyName("gui_temperature_units")]
    public string GuiTemperatureUnits { get; set; }

    [JsonPropertyName("gui_tirepressure_units")]
    public string GuiTirepressureUnits { get; set; }

    [JsonPropertyName("show_range_units")] public bool ShowRangeUnits { get; set; }

    [JsonPropertyName("timestamp")] public long Timestamp { get; set; }
}