using Newtonsoft.Json;

namespace NewsApplication.Models;

class Source
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }
}