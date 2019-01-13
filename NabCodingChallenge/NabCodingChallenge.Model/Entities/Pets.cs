
using NabCodingChallenge.Model.Interfaces;
using Newtonsoft.Json;

namespace NabCodingChallenge.Model.Entities
{
    public class Pets : IPets
    {
        public Pets()
        {
        }
        [JsonProperty("name")]
        public string Name { get ;set; }
        [JsonProperty("type")]
        public string Type { get ;set; }
    }
}
