namespace Examples.AspNetCore;
public class AirQualityReport
{
    public DateTime Date { get; set; }
    public string? City { get; set; }
    public int AQI { get; set; }  // Air Quality Index
    public string Category => GetCategory(AQI);

    private static string GetCategory(int aqi)
    {
        if (aqi <= 50) return "Good";
        if (aqi <= 100) return "Moderate";
        if (aqi <= 150) return "Unhealthy for Sensitive Groups";
        if (aqi <= 200) return "Unhealthy";
        if (aqi <= 300) return "Very Unhealthy";
        return "Hazardous";
    }
}
