using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Deliverable_27.Models;
using System.Net.Http;
using Deliverable_27.APIModels;

namespace Deliverable_27.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Forecast(string lat, string lon)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://forecast.weather.gov");
            client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (compatible; GrandCircus/1.0)");
            var response = await client.GetAsync("MapClick.php ? lat = 38.4247341 & lon = -86.9624086 & FcstType = json");
            var forecast = await response.Content.ReadAsAsync<Weather>();
            return View(forecast);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
