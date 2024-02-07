namespace Examples.AspNetCore.Controllers;

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class AirQualityController : ControllerBase
{
    private static readonly string[] Cities = new[]
    {
        "New York", "Los Angeles", "Chicago", "Houston", "Phoenix"
    };

    [HttpGet("get-telemetry")]
    public IEnumerable<AirQualityReport> Get()
    {
        var rng = new Random();
        return Enumerable.Range(1, 5).Select(index => new AirQualityReport
        {
            Date = DateTime.Now.AddDays(index),
            City = Cities[rng.Next(Cities.Length)],
            AQI = rng.Next(0, 500)  // Simulated AQI value
        }).ToArray();
    }
}
