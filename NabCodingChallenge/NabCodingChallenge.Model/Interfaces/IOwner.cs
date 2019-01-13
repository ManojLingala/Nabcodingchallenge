using System;
using System.Collections.Generic;

namespace NabCodingChallenge.Model.Interfaces
{
    public interface IOwner
    {
        string Name { get; set; }
        string Gender { get; set; }
        int Age { get; set; }
        List<IPets> Pets { get; set; }
    }
}
