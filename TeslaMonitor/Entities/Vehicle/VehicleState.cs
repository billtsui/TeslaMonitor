using System.Text.Json.Serialization;

namespace TeslaMonitor.Entities.Vehicle;

public class VehicleState
{
    [JsonPropertyName("api_version")] public long ApiVersion { get; set; }

    [JsonPropertyName("autopark_state_v2")]
    public string AutoparkStateV2 { get; set; }

    [JsonPropertyName("calendar_supported")]
    public bool CalendarSupported { get; set; }

    [JsonPropertyName("car_version")] public string CarVersion { get; set; }

    [JsonPropertyName("center_display_state")]
    public long CenterDisplayState { get; set; }

    [JsonPropertyName("dashcam_clip_save_available")]
    public bool DashcamClipSaveAvailable { get; set; }

    [JsonPropertyName("dashcam_state")] public string DashcamState { get; set; }

    [JsonPropertyName("df")] public long Df { get; set; }

    [JsonPropertyName("dr")] public long Dr { get; set; }

    [JsonPropertyName("fd_window")] public long FdWindow { get; set; }

    [JsonPropertyName("feature_bitmask")] public string FeatureBitmask { get; set; }

    [JsonPropertyName("fp_window")] public long FpWindow { get; set; }

    [JsonPropertyName("ft")] public long Ft { get; set; }

    [JsonPropertyName("is_user_present")] public bool IsUserPresent { get; set; }

    [JsonPropertyName("locked")] public bool Locked { get; set; }

    [JsonPropertyName("media_info")] public MediaInfo MediaInfo { get; set; }

    [JsonPropertyName("media_state")] public MediaState MediaState { get; set; }

    [JsonPropertyName("notifications_supported")]
    public bool NotificationsSupported { get; set; }

    [JsonPropertyName("odometer")] public double Odometer { get; set; }

    [JsonPropertyName("parsed_calendar_supported")]
    public bool ParsedCalendarSupported { get; set; }

    [JsonPropertyName("pf")] public long Pf { get; set; }

    [JsonPropertyName("pr")] public long Pr { get; set; }

    [JsonPropertyName("rd_window")] public long RdWindow { get; set; }

    [JsonPropertyName("remote_start")] public bool RemoteStart { get; set; }

    [JsonPropertyName("remote_start_enabled")]
    public bool RemoteStartEnabled { get; set; }

    [JsonPropertyName("remote_start_supported")]
    public bool RemoteStartSupported { get; set; }

    [JsonPropertyName("rp_window")] public long RpWindow { get; set; }

    [JsonPropertyName("rt")] public long Rt { get; set; }

    [JsonPropertyName("santa_mode")] public long SantaMode { get; set; }

    [JsonPropertyName("sentry_mode")] public bool SentryMode { get; set; }

    [JsonPropertyName("sentry_mode_available")]
    public bool SentryModeAvailable { get; set; }

    [JsonPropertyName("service_mode")] public bool ServiceMode { get; set; }

    [JsonPropertyName("service_mode_plus")]
    public bool ServiceModePlus { get; set; }

    [JsonPropertyName("software_update")] public SoftwareUpdate SoftwareUpdate { get; set; }

    [JsonPropertyName("speed_limit_mode")] public SpeedLimitMode SpeedLimitMode { get; set; }

    [JsonPropertyName("timestamp")] public long Timestamp { get; set; }

    [JsonPropertyName("tpms_hard_warning_fl")]
    public bool TpmsHardWarningFl { get; set; }

    [JsonPropertyName("tpms_hard_warning_fr")]
    public bool TpmsHardWarningFr { get; set; }

    [JsonPropertyName("tpms_hard_warning_rl")]
    public bool TpmsHardWarningRl { get; set; }

    [JsonPropertyName("tpms_hard_warning_rr")]
    public bool TpmsHardWarningRr { get; set; }

    [JsonPropertyName("tpms_last_seen_pressure_time_fl")]
    public long TpmsLastSeenPressureTimeFl { get; set; }

    [JsonPropertyName("tpms_last_seen_pressure_time_fr")]
    public long TpmsLastSeenPressureTimeFr { get; set; }

    [JsonPropertyName("tpms_last_seen_pressure_time_rl")]
    public long TpmsLastSeenPressureTimeRl { get; set; }

    [JsonPropertyName("tpms_last_seen_pressure_time_rr")]
    public long TpmsLastSeenPressureTimeRr { get; set; }

    [JsonPropertyName("tpms_pressure_fl")] public double TpmsPressureFl { get; set; }

    [JsonPropertyName("tpms_pressure_fr")] public double TpmsPressureFr { get; set; }

    [JsonPropertyName("tpms_pressure_rl")] public double TpmsPressureRl { get; set; }

    [JsonPropertyName("tpms_pressure_rr")] public double TpmsPressureRr { get; set; }

    [JsonPropertyName("tpms_rcp_front_value")]
    public double TpmsRcpFrontValue { get; set; }

    [JsonPropertyName("tpms_rcp_rear_value")]
    public double TpmsRcpRearValue { get; set; }

    [JsonPropertyName("tpms_soft_warning_fl")]
    public bool TpmsSoftWarningFl { get; set; }

    [JsonPropertyName("tpms_soft_warning_fr")]
    public bool TpmsSoftWarningFr { get; set; }

    [JsonPropertyName("tpms_soft_warning_rl")]
    public bool TpmsSoftWarningRl { get; set; }

    [JsonPropertyName("tpms_soft_warning_rr")]
    public bool TpmsSoftWarningRr { get; set; }

    [JsonPropertyName("valet_mode")] public bool ValetMode { get; set; }

    [JsonPropertyName("valet_pin_needed")] public bool ValetPinNeeded { get; set; }

    [JsonPropertyName("vehicle_name")] public string VehicleName { get; set; }

    [JsonPropertyName("vehicle_self_test_progress")]
    public long VehicleSelfTestProgress { get; set; }

    [JsonPropertyName("vehicle_self_test_requested")]
    public bool VehicleSelfTestRequested { get; set; }

    [JsonPropertyName("webcam_available")] public bool WebcamAvailable { get; set; }
}