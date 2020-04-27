using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deliverable_27.APIModels
{
    public class WeatherData
    {
        public string[] temperature { get; set; }
        public string[] pop { get; set; }
        public string[] weather { get; set; }
        public string[] iconLink { get; set; }
        public string[] hazard { get; set; }
        public string[] hazardUrl { get; set; }
        public string[] text { get; set; }
    }
}
