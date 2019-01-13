using System;
using System.Collections.Generic;

namespace NabCodingChallenge.Models
{
    public class HomeViewModel
    {
        public Dictionary<string, List<string>> Pets;
        public HomeViewModel(Dictionary<string, List<string>> pets)
        {
            this.Pets = pets;
        }
    }
}
