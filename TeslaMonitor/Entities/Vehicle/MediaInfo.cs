using System.Text.Json.Serialization;

namespace TeslaMonitor.Entities.Vehicle;

public class MediaInfo
{
    [JsonPropertyName("audio_volume")] public double AudioVolume { get; set; }

    [JsonPropertyName("audio_volume_increment")]
    public double AudioVolumeIncrement { get; set; }

    [JsonPropertyName("audio_volume_max")] public double AudioVolumeMax { get; set; }

    [JsonPropertyName("media_playback_status")]
    public string MediaPlaybackStatus { get; set; }

    [JsonPropertyName("now_playing_album")]
    public string NowPlayingAlbum { get; set; }

    [JsonPropertyName("now_playing_artist")]
    public string NowPlayingArtist { get; set; }

    [JsonPropertyName("now_playing_duration")]
    public long NowPlayingDuration { get; set; }

    [JsonPropertyName("now_playing_elapsed")]
    public long NowPlayingElapsed { get; set; }

    [JsonPropertyName("now_playing_source")]
    public string NowPlayingSource { get; set; }

    [JsonPropertyName("now_playing_station")]
    public string NowPlayingStation { get; set; }

    [JsonPropertyName("now_playing_title")]
    public string NowPlayingTitle { get; set; }
}