﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NabCodingChallenge.Models;
using NabCodingChallenge.Model.Entities;
using Microsoft.Extensions.Options;
using NabCodingChallenge.Service.Interfaces;
using NabCodingChallenge.Common;

namespace NabCodingChallenge.Controllers
{
    public class HomeController : Controller
    {
        readonly ServiceConfig serviceConfig;
        readonly IDataService dataService;

        public HomeController(IOptions<ServiceConfig> serviceConfig, IDataService dataService) {
            this.serviceConfig = serviceConfig.Value;
            this.dataService = dataService;
        }
    
        public async Task<IActionResult> Index()
        {
            var data =  await this.dataService.FetchDataAsync();
        
            var viewModel = new HomeViewModel(data.ToSortedDictionary());
                
            return View(viewModel);
        }

        public IActionResult About()
        {
            return View();
        }

    
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
