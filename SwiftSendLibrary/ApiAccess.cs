using System.Text.Json;

namespace SwiftSendLibrary;

public class ApiAccess
{
    private readonly HttpClient client = new();
    public async Task<string> CallApiAsync(string url, bool formatOutput = true)
    {
        var response = await client.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            string json = await response.Content.ReadAsStringAsync();
            var jsonElement = JsonSerializer.Deserialize<JsonElement>(json);
            json = JsonSerializer.Serialize(jsonElement,
                new JsonSerializerOptions { WriteIndented = true });

            return json;
        }
        else
        {
            return $"Error: {response.StatusCode}";
        }
        
    }
}
