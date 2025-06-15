using System.Text.Json.Serialization;

namespace TeslaMonitor.Entities.Vehicle;

public class VehicleDataDto
{
    [JsonPropertyName("response")] public Response Response { get; set; }
}