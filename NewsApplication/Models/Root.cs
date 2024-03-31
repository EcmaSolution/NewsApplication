using Newtonsoft.Json;

namespace NewsApplication.Models;

public class Root
{
    [JsonProperty("totalArticles")]
    public int TotalArticles { get; set; }

    [JsonProperty("articles")]
    public List<Article> Articles { get; set; }
}

