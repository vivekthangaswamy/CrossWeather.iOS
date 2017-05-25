using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using CrossWeatherCore;

namespace CrossWeather.Android
{
    [Activity(Label = "CrossWeather.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        //int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            var getweather = FindViewById<Button>(Resource.Id.btngetweather);
            var city = FindViewById<EditText>(Resource.Id.citytxt);
            var longitude = FindViewById<TextView>(Resource.Id.longtxt);
            var latitude = FindViewById<TextView>(Resource.Id.latitudetxt);
            var temprature = FindViewById<TextView>(Resource.Id.curtemptxt);

            getweather.Click += async (sender, e) =>
            {

                WeatherA weather = await APISettings.GetWeather(city.Text);

                //if (weather != null)
                //{
                longitude.Text = weather.Longitude;
                latitude.Text = weather.Latitude;
                temprature.Text = weather.Temperature;

                //}

            };
        }
    }
}


