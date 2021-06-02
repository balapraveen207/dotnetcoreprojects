using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPI
{
    public class WeatherForecast
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int TemperatureC { get; internal set; }
        public string Summary { get; internal set; }
        public DateTime Date { get; internal set; }
    }
}
