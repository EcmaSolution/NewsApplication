using Newtonsoft.Json;

namespace NewsApplication.Models;

public class Source
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }
}