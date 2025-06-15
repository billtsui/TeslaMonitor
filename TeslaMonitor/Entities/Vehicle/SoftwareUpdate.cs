using System.Text.Json.Serialization;

namespace TeslaMonitor.Entities.Vehicle;

public class SoftwareUpdate
{
    [JsonPropertyName("download_perc")] public long DownloadPerc { get; set; }

    [JsonPropertyName("expected_duration_sec")]
    public long ExpectedDurationSec { get; set; }

    [JsonPropertyName("install_perc")] public long InstallPerc { get; set; }

    [JsonPropertyName("status")] public string Status { get; set; }

    [JsonPropertyName("version")] public string Version { get; set; }
}