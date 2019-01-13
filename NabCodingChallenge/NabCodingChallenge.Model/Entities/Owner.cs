using System;
using System.Collections.Generic;
using NabCodingChallenge.Model.Interfaces;
using Newtonsoft.Json;

namespace NabCodingChallenge.Model.Entities
{
    public class Owner : IOwner
    {
        public Owner(List<Pets> pets)
        {
            this.Pets = new List<IPets>();

            if (pets != null)
            {
                this.Pets.AddRange(pets);
            }
        }

        [JsonProperty("name")]
        public string Name { get; set;  }
        [JsonProperty("gender")]
        public string Gender { get; set; }
        [JsonProperty("age")]
        public int Age { get; set; }
        [JsonProperty("pets")]
        public List<IPets> Pets { get; set; }
    }
}
