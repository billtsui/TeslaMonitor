using System.Text.Json.Serialization;

namespace TeslaMonitor.Entities.Vehicle;

public class VehicleConfig
{
    [JsonPropertyName("aux_park_lamps")] public string AuxParkLamps { get; set; }

    [JsonPropertyName("badge_version")] public long BadgeVersion { get; set; }

    [JsonPropertyName("can_accept_navigation_requests")]
    public bool CanAcceptNavigationRequests { get; set; }

    [JsonPropertyName("can_actuate_trunks")]
    public bool CanActuateTrunks { get; set; }

    [JsonPropertyName("car_special_type")] public string CarSpecialType { get; set; }

    [JsonPropertyName("car_type")] public string CarType { get; set; }

    [JsonPropertyName("charge_port_type")] public string ChargePortType { get; set; }

    [JsonPropertyName("cop_user_set_temp_supported")]
    public bool CopUserSetTempSupported { get; set; }

    [JsonPropertyName("dashcam_clip_save_supported")]
    public bool DashcamClipSaveSupported { get; set; }

    [JsonPropertyName("default_charge_to_max")]
    public bool DefaultChargeToMax { get; set; }

    [JsonPropertyName("driver_assist")] public string DriverAssist { get; set; }

    [JsonPropertyName("ece_restrictions")] public bool EceRestrictions { get; set; }

    [JsonPropertyName("efficiency_package")]
    public string EfficiencyPackage { get; set; }

    [JsonPropertyName("eu_vehicle")] public bool EuVehicle { get; set; }

    [JsonPropertyName("exterior_color")] public string ExteriorColor { get; set; }

    [JsonPropertyName("exterior_trim")] public string ExteriorTrim { get; set; }

    [JsonPropertyName("exterior_trim_override")]
    public string ExteriorTrimOverride { get; set; }

    [JsonPropertyName("has_air_suspension")]
    public bool HasAirSuspension { get; set; }

    [JsonPropertyName("has_ludicrous_mode")]
    public bool HasLudicrousMode { get; set; }

    [JsonPropertyName("has_seat_cooling")] public bool HasSeatCooling { get; set; }

    [JsonPropertyName("headlamp_type")] public string HeadlampType { get; set; }

    [JsonPropertyName("interior_trim_type")]
    public string InteriorTrimType { get; set; }

    [JsonPropertyName("key_version")] public long KeyVersion { get; set; }

    [JsonPropertyName("motorized_charge_port")]
    public bool MotorizedChargePort { get; set; }

    [JsonPropertyName("paint_color_override")]
    public string PaintColorOverride { get; set; }

    [JsonPropertyName("performance_package")]
    public string PerformancePackage { get; set; }

    [JsonPropertyName("plg")] public bool Plg { get; set; }

    [JsonPropertyName("pws")] public bool Pws { get; set; }

    [JsonPropertyName("rear_drive_unit")] public string RearDriveUnit { get; set; }

    [JsonPropertyName("rear_seat_heaters")]
    public long RearSeatHeaters { get; set; }

    [JsonPropertyName("rear_seat_type")] public long RearSeatType { get; set; }

    [JsonPropertyName("rhd")] public bool Rhd { get; set; }

    [JsonPropertyName("roof_color")] public string RoofColor { get; set; }

    [JsonPropertyName("seat_type")] public string SeatType { get; set; }

    [JsonPropertyName("sentry_preview_supported")]
    public bool SentryPreviewSupported { get; set; }

    [JsonPropertyName("spoiler_type")] public string SpoilerType { get; set; }

    [JsonPropertyName("sun_roof_installed")]
    public string SunRoofInstalled { get; set; }

    [JsonPropertyName("supports_qr_pairing")]
    public bool SupportsQrPairing { get; set; }

    [JsonPropertyName("third_row_seats")] public string ThirdRowSeats { get; set; }

    [JsonPropertyName("timestamp")] public long Timestamp { get; set; }

    [JsonPropertyName("trim_badging")] public long TrimBadging { get; set; }

    [JsonPropertyName("use_range_badging")]
    public bool UseRangeBadging { get; set; }

    [JsonPropertyName("utc_offset")] public long UtcOffset { get; set; }

    [JsonPropertyName("webcam_selfie_supported")]
    public bool WebcamSelfieSupported { get; set; }

    [JsonPropertyName("webcam_supported")] public bool WebcamSupported { get; set; }

    [JsonPropertyName("wheel_type")] public string WheelType { get; set; }
}