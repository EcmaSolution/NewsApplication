using Newtonsoft.Json;

namespace NewsApplication.Models;

class Root
{
    [JsonProperty("totalArticles")]
    public int TotalArticles { get; set; }

    [JsonProperty("articles")]
    public List<Article> Articles { get; set; }
}

