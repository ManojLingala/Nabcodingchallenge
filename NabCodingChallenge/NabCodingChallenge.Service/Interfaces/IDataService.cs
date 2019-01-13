using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NabCodingChallenge.Model.Interfaces;

namespace NabCodingChallenge.Service.Interfaces
{
    public interface IDataService
    {
       
        Task<List<IOwner>> FetchDataAsync();
     
    }
}
