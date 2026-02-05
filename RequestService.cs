using System.Text.Json;
namespace LinqPractice;

public static class Utils
{
    private static string Endpoint = "https://prices.runescape.wiki/api/v1/osrs/mapping";

    private static JsonSerializerOptions Options = new()
    {
        PropertyNameCaseInsensitive = true
    };

    public static async Task<List<Item>> GetAllItems()
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                client.DefaultRequestHeaders.Add("User-Agent", "Linq Practice");
                HttpResponseMessage res = await client.GetAsync($"{Endpoint}");
                
                res.EnsureSuccessStatusCode();
                string body = await res.Content.ReadAsStringAsync();
                var items = JsonSerializer.Deserialize<List<Item>>(body, Options);

                return items;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}