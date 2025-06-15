using System.Text.Json.Serialization;

namespace TeslaMonitor.Entities.Vehicle;

public class ClimateState
{
    [JsonPropertyName("allow_cabin_overheat_protection")]
    public bool AllowCabinOverheatProtection { get; set; }

    [JsonPropertyName("auto_seat_climate_left")]
    public bool AutoSeatClimateLeft { get; set; }

    [JsonPropertyName("auto_seat_climate_right")]
    public bool AutoSeatClimateRight { get; set; }

    [JsonPropertyName("auto_steering_wheel_heat")]
    public bool AutoSteeringWheelHeat { get; set; }

    [JsonPropertyName("battery_heater")] public bool BatteryHeater { get; set; }

    [JsonPropertyName("battery_heater_no_power")]
    public string BatteryHeaterNoPower { get; set; }

    [JsonPropertyName("bioweapon_mode")] public bool BioweaponMode { get; set; }

    [JsonPropertyName("cabin_overheat_protection")]
    public string CabinOverheatProtection { get; set; }

    [JsonPropertyName("cabin_overheat_protection_actively_cooling")]
    public bool CabinOverheatProtectionActivelyCooling { get; set; }

    [JsonPropertyName("climate_keeper_mode")]
    public string ClimateKeeperMode { get; set; }

    [JsonPropertyName("cop_activation_temperature")]
    public string CopActivationTemperature { get; set; }

    [JsonPropertyName("defrost_mode")] public long DefrostMode { get; set; }

    [JsonPropertyName("driver_temp_setting")]
    public long DriverTempSetting { get; set; }

    [JsonPropertyName("fan_status")] public long FanStatus { get; set; }

    [JsonPropertyName("hvac_auto_request")]
    public string HvacAutoRequest { get; set; }

    [JsonPropertyName("inside_temp")] public double InsideTemp { get; set; }

    [JsonPropertyName("is_auto_conditioning_on")]
    public bool IsAutoConditioningOn { get; set; }

    [JsonPropertyName("is_climate_on")] public bool IsClimateOn { get; set; }

    [JsonPropertyName("is_front_defroster_on")]
    public bool IsFrontDefrosterOn { get; set; }

    [JsonPropertyName("is_preconditioning")]
    public bool IsPreconditioning { get; set; }

    [JsonPropertyName("is_rear_defroster_on")]
    public bool IsRearDefrosterOn { get; set; }

    [JsonPropertyName("left_temp_direction")]
    public long LeftTempDirection { get; set; }

    [JsonPropertyName("max_avail_temp")] public long MaxAvailTemp { get; set; }

    [JsonPropertyName("min_avail_temp")] public long MinAvailTemp { get; set; }

    [JsonPropertyName("outside_temp")] public long OutsideTemp { get; set; }

    [JsonPropertyName("passenger_temp_setting")]
    public long PassengerTempSetting { get; set; }

    [JsonPropertyName("remote_heater_control_enabled")]
    public bool RemoteHeaterControlEnabled { get; set; }

    [JsonPropertyName("right_temp_direction")]
    public long RightTempDirection { get; set; }

    [JsonPropertyName("seat_heater_left")] public long SeatHeaterLeft { get; set; }

    [JsonPropertyName("seat_heater_rear_center")]
    public long SeatHeaterRearCenter { get; set; }

    [JsonPropertyName("seat_heater_rear_left")]
    public long SeatHeaterRearLeft { get; set; }

    [JsonPropertyName("seat_heater_rear_right")]
    public long SeatHeaterRearRight { get; set; }

    [JsonPropertyName("seat_heater_right")]
    public long SeatHeaterRight { get; set; }

    [JsonPropertyName("side_mirror_heaters")]
    public bool SideMirrorHeaters { get; set; }

    [JsonPropertyName("steering_wheel_heat_level")]
    public long SteeringWheelHeatLevel { get; set; }

    [JsonPropertyName("steering_wheel_heater")]
    public bool SteeringWheelHeater { get; set; }

    [JsonPropertyName("supports_fan_only_cabin_overheat_protection")]
    public bool SupportsFanOnlyCabinOverheatProtection { get; set; }

    [JsonPropertyName("timestamp")] public long Timestamp { get; set; }

    [JsonPropertyName("wiper_blade_heater")]
    public bool WiperBladeHeater { get; set; }
}