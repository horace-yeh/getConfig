using getConfigExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace getConfigExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppSettings _appSettings;
        private readonly IConfiguration _configuration;
        private readonly CountrySetting _countrySetting;
        private readonly ILogger<HomeController> _logger;

        public HomeController
        (
            ILogger<HomeController> logger,
            IConfiguration configuration,
            IOptions<AppSettings> appSettings,
            IOptions<CountrySetting> countrySetting
        )
        {
            _logger = logger;
            _configuration = configuration;
            _appSettings = appSettings.Value;
            _countrySetting = countrySetting.Value;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Index()
        {
            var BuyKey = _configuration.GetValue<string>("AppSettings:BuyKey");
            var BuyKey2 = _appSettings.BuyKey;

            var TWLang = _configuration.GetValue<string>("CountrySetting:TW:Lang");
            var TWLang2 = _countrySetting.TW.Lang;

            var twInfo = _countrySetting.TW;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}