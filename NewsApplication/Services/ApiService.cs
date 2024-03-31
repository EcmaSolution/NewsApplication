using NewsApplication.Models;
using Newtonsoft.Json;

namespace NewsApplication.Services;
public class ApiService
{
    public async Task<Root?> GetNews(string category, string lang)
    {
        var apiKey = "c6702d47191f163ed3d11909feaa1e99";
        var client = new HttpClient();
        var response = await client.GetStringAsync(
            $"https://gnews.io/api/v4/top-headlines?category={category.ToLower()}" +
            $"&apikey={apiKey}" +
            $"&lang={lang.ToLower()}");

        return JsonConvert.DeserializeObject<Root>(response);
    }
}
