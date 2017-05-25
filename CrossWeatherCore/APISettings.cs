using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossWeatherCore
{
    public class APISettings
    {

        /* public static string GetUrl(string city)
         {
             //string apikey = "be71a4c8e88cd1f4efa07e60e077ca80";
             //http://api.openweathermap.org/data/2.5/weather?q=Sydney&units=imperial&appid=fc9f6c524fc093759cd28d41fda89a1b

             return $"http://api.openweathermap.org/data/2.5/weather?q={0}&units={1}&appid=be71a4c8e88cd1f4efa07e60e077ca80";
         } */

        public static async Task<WeatherA> GetWeather(string city)
        {
            //Sign up for a free API key at http://openweathermap.org/appid
            //string key = "be71a4c8e88cd1f4efa07e60e077ca80";
            string key = "fc9f6c524fc093759cd28d41fda89a1b";
            string queryString = "http://api.openweathermap.org/data/2.5/weather?q="
                + city + ",&units=imperial&appid=" + key;
            //Hardcoded IN for India, need to add this for other countries
            var results = await WeatherRepository.GetDataFromService(queryString).ConfigureAwait(false);

            if (results["weather"] != null)
            {
                WeatherA weather = new WeatherA();
               
                weather.Title = (string)results["name"];
                weather.Temperature = (string)results["main"]["temp"] + " F";
                weather.Longitude = (string)results["coord"]["lon"];
                weather.Latitude = (string)results["coord"]["lat"];
                weather.Wind = (string)results["wind"]["speed"] + " mph";
                weather.Humidity = (string)results["main"]["humidity"] + " %";
                weather.Visibility = (string)results["weather"][0]["main"];

                DateTime time = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
                DateTime sunrise = time.AddSeconds((double)results["sys"]["sunrise"]);
                DateTime sunset = time.AddSeconds((double)results["sys"]["sunset"]);
                weather.Sunrise = sunrise.ToString() + " UTC";
                weather.Sunset = sunset.ToString() + " UTC";
                return weather;
            }
            else
            {
                return null;
            }
        }

        public Task GetWeather()
        {
            throw new NotImplementedException();
        }
    }
}
