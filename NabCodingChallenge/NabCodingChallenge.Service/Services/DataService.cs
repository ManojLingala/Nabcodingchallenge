﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using NabCodingChallenge.Model.Interfaces;
using NabCodingChallenge.Model.Entities;
using NabCodingChallenge.Service.Interfaces;
using NabCodingChallenge.Common;
using Newtonsoft.Json;
using System.Linq;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace NabCodingChallenge.Service.Services
{
    public class DataService : IDataService
    {
		const string GET_PETS_ENDPOINT = "/api/Pet.json";

		readonly HttpClient client;
        readonly ServiceConfig config;
        readonly ICacheService cacheService;
        readonly ILogger<DataService> logger;
        Object threadSafeLock = new object();

        public DataService(HttpClient client,
                           IOptions<ServiceConfig> serviceConfig, 
                           ICacheService cacheService,
                           ILogger<DataService> logger
                          )
        {
            this.logger = logger;
            this.client = client;
            this.config = serviceConfig.Value;
            this.cacheService = cacheService;
        }
        /// <summary>
        /// This will fetch data from Rest service , then transform data into flatten list that we can use to display in UI, transform for other services....
        /// 
        /// </summary>
        /// <returns>List Of flatten object </returns>
        ///
        public async Task<List<IOwner>> FetchDataAsync()
        {
           
                if (config.EnableCache)
                {
                    // Sometime , Depend on the project , I may add the callback is the Func<T> to re-cache expired object
                    var cachedData = cacheService.GetServiceData();
                    if (cachedData != null) return cachedData;
                }
                List<IOwner> ownersList = null;
            try
            {

                var content = await this.client.GetStringAsync(GET_PETS_ENDPOINT);
                var response = JsonConvert.DeserializeObject<ServiceResponse>(content);
                ownersList = new List<IOwner>(response);
            }
            catch (JsonReaderException ex)
            {
                // Because in real application, Each type of Exceptions will have separate logic to haldle Login so we have to catch all exception separately instead of using just Exception object
                logger.LogWarning(ex, ex.Message);
            }
            catch (AggregateException ex)
            {
                logger.LogError(ex, ex.Message);
            }
            catch (Exception ex)
            {
                // If we need to handle exception/business logic, throw or re-throw Business Exception here.
                //ex : throw new ServiceException(...)

                logger.LogError(ex, ex.Message);

            }
                return ownersList;
            
        }
    }
}
