// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace CrossWeather.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField citytxtbx { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel CurrentTemp { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton GetWeather { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Latitude { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Longitude { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (citytxtbx != null) {
                citytxtbx.Dispose ();
                citytxtbx = null;
            }

            if (CurrentTemp != null) {
                CurrentTemp.Dispose ();
                CurrentTemp = null;
            }

            if (GetWeather != null) {
                GetWeather.Dispose ();
                GetWeather = null;
            }

            if (Latitude != null) {
                Latitude.Dispose ();
                Latitude = null;
            }

            if (Longitude != null) {
                Longitude.Dispose ();
                Longitude = null;
            }
        }
    }
}