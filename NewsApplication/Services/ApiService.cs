using NewsApplication.Models;
using Newtonsoft.Json;

namespace NewsApplication.Services;
public class ApiService
{
    public async Task<Root?> GetNews()
    {
        var client = new HttpClient();
        var response = await client.GetStringAsync(
            "https://gnews.io/api/v4/top-headlines?category=technology&apikey=c6702d47191f163ed3d11909feaa1e99&lang=en");

        return JsonConvert.DeserializeObject<Root>(response);
    }
}
