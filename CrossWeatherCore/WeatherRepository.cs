using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CrossWeatherCore
{
    public class WeatherRepository
    {

       // private string url;
        private string text;

        public WeatherRepository(string text)
        {
            this.text = text;
        }

        /* public  WeatherRepository(string city)
         {

             url = APISettings.GetWeather(city);


         }*/


       /* public async Task<WeatherRoot> GetWeather()
        {
            WeatherRoot weather = null;

            using (var client = new HttpClient())
            {
                var json = await client.GetStringAsync(url);
                await Task.Run(() => { weather = JsonConvert.DeserializeObject<WeatherRoot>(json); });

            }
            return weather;
        }*/


        public static async Task<JContainer> GetDataFromService(string queryString)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(queryString);

            JContainer data = null;


            if (response != null)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                data = (JContainer)JsonConvert.DeserializeObject(json);
            }

            return data;
        }
    }


    
}
