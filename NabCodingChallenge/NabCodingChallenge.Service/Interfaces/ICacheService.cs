using System;
using System.Collections.Generic;
using NabCodingChallenge.Model.Interfaces;

namespace NabCodingChallenge.Service.Interfaces
{
    public interface ICacheService
    {
        void CacheServiceData(List<IOwner> data);
        List<IOwner> GetServiceData();
        void CacheServiceData(List<IData> list);
    }
}
