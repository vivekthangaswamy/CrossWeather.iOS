using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossWeatherCore
{





    public class List
    {
        public int dt { get; set; }
        public Main main { get; set; }
        public List<Weather> weather { get; set; }
        public Clouds clouds { get; set; }
        public Wind wind { get; set; }
        public Snow snow { get; set; }
        public Sys sys { get; set; }
        public string dt_txt { get; set; }
        public Rain rain { get; set; }
    }

    public class Snow
    {

        public string snow3h { get; set; } = string.Empty;
    }

    public class Rain
    {

        public string rain3h { get; set; } = string.Empty;
    }

    public class Main
    {
       
        public double Temperature { get; set; } = 0;
   
        public double Pressure { get; set; } = 0;

  
        public double Humidity { get; set; } = 0;
        
        public double MinTemperature { get; set; } = 0;

        public double MaxTemperature { get; set; } = 0;
    }

    public class Clouds
    {

        public int CloudinessPercent { get; set; } = 0;
    }

    public class Wind
    {
        
        public double Speed { get; set; } = 0;

       
        public double WindDirectionDegrees { get; set; } = 0;

    }

    public class Weather
    {
       
        public int Id { get; set; } = 0;

      
        public string Main { get; set; } = string.Empty;

    
        public string Description { get; set; } = string.Empty;

  
        public string Icon { get; set; } = string.Empty;

        public static implicit operator Weather(WeatherA v)
        {
            throw new NotImplementedException();
        }
    }

    public class Coord
    {
        
        public double Longitude { get; set; } = 0;

        
        public double Latitude { get; set; } = 0;
    }

    public class Sys
    {

        public string Message { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
    }


    public class City
    {
        
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public Coord Coord { get; set; }
       
        public string Country { get; set; }
      
        public int Population { get; set; }
       
        public Sys Sys { get; set; }
    }

    public class WeatherRoot
    {
        public City city { get; set;  }
        public string cod { get; set; }
        public double message { get; set; }
        public int cnt { get; set; }
        public List<List> list { get; set; }
    }


}
