using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deliverable_27.APIModels
{
    public class Weather
    {
        public WeatherTime Time { get; set; }
        public WeatherData Data { get; set; }
    }
}
