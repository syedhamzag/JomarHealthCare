using Newtonsoft.Json.Linq;

namespace JomarHealthCare.Application.Configs;

public static class GeoLocationHelper
{
    public static double GetDistanceInMeters(double lat1, double lon1, double lat2, double lon2)
    {
        const double R = 6371000; // Earth's radius in meters
        var latRad1 = lat1 * Math.PI / 180.0;
        var latRad2 = lat2 * Math.PI / 180.0;
        var deltaLat = (lat2 - lat1) * Math.PI / 180.0;
        var deltaLon = (lon2 - lon1) * Math.PI / 180.0;

        var a = Math.Sin(deltaLat / 2) * Math.Sin(deltaLat / 2) +
                Math.Cos(latRad1) * Math.Cos(latRad2) *
                Math.Sin(deltaLon / 2) * Math.Sin(deltaLon / 2);

        var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
        return R * c; // distance in meters
    }

    public static bool IsWithin30Meters(double lat1, double lon1, double lat2, double lon2)
    {
        double distance = GetDistanceInMeters(lat1, lon1, lat2, lon2);
        return distance <= 30; // Compare with 30 meters
    }


    public static async Task<string?> GetFullAddressFromCoordinates(double latitude, double longitude)
    {
        string url = $"https://api.bigdatacloud.net/data/reverse-geocode-client?latitude={latitude}&longitude={longitude}&localityLanguage=en";

        using (var httpClient = new HttpClient())
        {
            var response = await httpClient.GetStringAsync(url);
            var json = JObject.Parse(response);

            // Try to extract full formatted address
            string? city = json["city"]?.ToString();
            string? locality = json["locality"]?.ToString();
            string? principalSubdivision = json["principalSubdivision"]?.ToString();
            string? countryName = json["countryName"]?.ToString();

            // Combine to make a full readable address
            string? fullAddress = $"{locality}, {city}, {principalSubdivision}, {countryName}".Trim().Trim(',');

            return string.IsNullOrWhiteSpace(fullAddress) ? null : fullAddress;
        }
    }

}
