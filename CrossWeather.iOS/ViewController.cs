using CrossWeatherCore;
using System;
using System.Linq;
using UIKit;
using System.Runtime;

namespace CrossWeather.iOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            GetWeather.TouchUpInside += async (sender, e) =>
            {
               // var APISettings = new WeatherRepository(citytxtbx.Text);
                //var weather = await APISettings.GetWeather();
                WeatherA weather = await APISettings.GetWeather(citytxtbx.Text);
                //if (weather != null)
                //{
                    Longitude.Text = weather.Longitude;
                    Latitude.Text = weather.Latitude;
                    CurrentTemp.Text = weather.Temperature;
                   

                    //Longitude.Text = $"Longitude : {weather?.city?.Coord?.Longitude.ToString()}";
                    //Latitude.Text = $"Latitude : {weather?.city?.Coord?.Latitude.ToString()}";
                    //CurrentTemp.Text = $"Current Temp : {weather?.list?.FirstOrDefault()?.main?.Temperature.ToString()}";
                //}

            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}