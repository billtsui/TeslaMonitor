using System.Text.Json.Serialization;

namespace TeslaMonitor.Entities.Vehicle;

public class Response
{
    [JsonPropertyName("id")] public long Id { get; set; }

    [JsonPropertyName("user_id")] public long UserId { get; set; }

    [JsonPropertyName("vehicle_id")] public long VehicleId { get; set; }

    [JsonPropertyName("vin")] public string Vin { get; set; }

    [JsonPropertyName("color")] public string Color { get; set; }

    [JsonPropertyName("access_type")] public string AccessType { get; set; }

    [JsonPropertyName("granular_access")] public GranularAccess GranularAccess { get; set; }

    [JsonPropertyName("tokens")] public string Tokens { get; set; }

    [JsonPropertyName("state")] public string State { get; set; }

    [JsonPropertyName("in_service")] public bool InService { get; set; }

    [JsonPropertyName("id_s")] public string IdS { get; set; }

    [JsonPropertyName("calendar_enabled")] public bool CalendarEnabled { get; set; }

    [JsonPropertyName("api_version")] public long ApiVersion { get; set; }

    [JsonPropertyName("backseat_token")] public string BackseatToken { get; set; }

    [JsonPropertyName("backseat_token_updated_at")]
    public string BackseatTokenUpdatedAt { get; set; }

    [JsonPropertyName("ble_autopair_enrolled")]
    public bool BleAutopairEnrolled { get; set; }

    [JsonPropertyName("supercharger_payment_needed")]
    public bool SuperchargerPaymentNeeded { get; set; }

    [JsonPropertyName("supercharging_enabled")]
    public bool SuperchargingEnabled { get; set; }

    [JsonPropertyName("charge_state")] public ChargeState ChargeState { get; set; }

    [JsonPropertyName("climate_state")] public ClimateState ClimateState { get; set; }

    [JsonPropertyName("drive_state")] public DriveState DriveState { get; set; }

    [JsonPropertyName("gui_settings")] public GuiSettings GuiSettings { get; set; }

    [JsonPropertyName("vehicle_config")] public VehicleConfig VehicleConfig { get; set; }

    [JsonPropertyName("vehicle_state")] public VehicleState VehicleState { get; set; }
}