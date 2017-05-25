using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using CrossWeatherCore;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CrossWeather.Wind
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            Get_Me_Details.Click += async (sender, e) =>
            {

                WeatherA weather = await APISettings.GetWeather(txtcity.Text);

                //if (weather != null)
                //{
                txtlong.Text = weather.Longitude;
                txtlatit.Text = weather.Latitude;
                txttemp.Text = weather.Temperature;

                //}

            };
        }
    }
}
