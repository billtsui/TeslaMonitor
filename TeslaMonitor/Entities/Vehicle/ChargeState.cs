using System.Text.Json.Serialization;

namespace TeslaMonitor.Entities.Vehicle;

public class ChargeState
{
    [JsonPropertyName("battery_heater_on")]
    public bool BatteryHeaterOn { get; set; }

    [JsonPropertyName("battery_level")] public long BatteryLevel { get; set; }

    [JsonPropertyName("battery_range")] public double BatteryRange { get; set; }

    [JsonPropertyName("charge_amps")] public long ChargeAmps { get; set; }

    [JsonPropertyName("charge_current_request")]
    public long ChargeCurrentRequest { get; set; }

    [JsonPropertyName("charge_current_request_max")]
    public long ChargeCurrentRequestMax { get; set; }

    [JsonPropertyName("charge_enable_request")]
    public bool ChargeEnableRequest { get; set; }

    [JsonPropertyName("charge_energy_added")]
    public double ChargeEnergyAdded { get; set; }

    [JsonPropertyName("charge_limit_soc")] public long ChargeLimitSoc { get; set; }

    [JsonPropertyName("charge_limit_soc_max")]
    public long ChargeLimitSocMax { get; set; }

    [JsonPropertyName("charge_limit_soc_min")]
    public long ChargeLimitSocMin { get; set; }

    [JsonPropertyName("charge_limit_soc_std")]
    public long ChargeLimitSocStd { get; set; }

    [JsonPropertyName("charge_miles_added_ideal")]
    public long ChargeMilesAddedIdeal { get; set; }

    [JsonPropertyName("charge_miles_added_rated")]
    public long ChargeMilesAddedRated { get; set; }

    [JsonPropertyName("charge_port_cold_weather_mode")]
    public bool ChargePortColdWeatherMode { get; set; }

    [JsonPropertyName("charge_port_color")]
    public string ChargePortColor { get; set; }

    [JsonPropertyName("charge_port_door_open")]
    public bool ChargePortDoorOpen { get; set; }

    [JsonPropertyName("charge_port_latch")]
    public string ChargePortLatch { get; set; }

    [JsonPropertyName("charge_rate")] public long ChargeRate { get; set; }

    [JsonPropertyName("charger_actual_current")]
    public long ChargerActualCurrent { get; set; }

    [JsonPropertyName("charger_phases")] public string ChargerPhases { get; set; }

    [JsonPropertyName("charger_pilot_current")]
    public long ChargerPilotCurrent { get; set; }

    [JsonPropertyName("charger_power")] public long ChargerPower { get; set; }

    [JsonPropertyName("charger_voltage")] public long ChargerVoltage { get; set; }

    [JsonPropertyName("charging_state")] public string ChargingState { get; set; }

    [JsonPropertyName("conn_charge_cable")]
    public string ConnChargeCable { get; set; }

    [JsonPropertyName("est_battery_range")]
    public double EstBatteryRange { get; set; }

    [JsonPropertyName("fast_charger_brand")]
    public string FastChargerBrand { get; set; }

    [JsonPropertyName("fast_charger_present")]
    public bool FastChargerPresent { get; set; }

    [JsonPropertyName("fast_charger_type")]
    public string FastChargerType { get; set; }

    [JsonPropertyName("ideal_battery_range")]
    public double IdealBatteryRange { get; set; }

    [JsonPropertyName("max_range_charge_counter")]
    public long MaxRangeChargeCounter { get; set; }

    [JsonPropertyName("minutes_to_full_charge")]
    public long MinutesToFullCharge { get; set; }

    [JsonPropertyName("not_enough_power_to_heat")]
    public string NotEnoughPowerToHeat { get; set; }

    [JsonPropertyName("off_peak_charging_enabled")]
    public bool OffPeakChargingEnabled { get; set; }

    [JsonPropertyName("off_peak_charging_times")]
    public string OffPeakChargingTimes { get; set; }

    [JsonPropertyName("preconditioning_enabled")]
    public bool PreconditioningEnabled { get; set; }

    [JsonPropertyName("preconditioning_times")]
    public string PreconditioningTimes { get; set; }

    [JsonPropertyName("scheduled_charging_mode")]
    public string ScheduledChargingMode { get; set; }

    [JsonPropertyName("scheduled_charging_pending")]
    public bool ScheduledChargingPending { get; set; }

    [JsonPropertyName("scheduled_charging_start_time")]
    public string ScheduledChargingStartTime { get; set; }

    [JsonPropertyName("scheduled_departure_time")]
    public string ScheduledDepartureTime { get; set; }

    [JsonPropertyName("supercharger_session_trip_planner")]
    public bool SuperchargerSessionTripPlanner { get; set; }

    [JsonPropertyName("time_to_full_charge")]
    public long TimeToFullCharge { get; set; }

    [JsonPropertyName("timestamp")] public long Timestamp { get; set; }

    [JsonPropertyName("trip_charging")] public bool TripCharging { get; set; }

    [JsonPropertyName("usable_battery_level")]
    public long UsableBatteryLevel { get; set; }

    [JsonPropertyName("user_charge_enable_request")]
    public string UserChargeEnableRequest { get; set; }
}