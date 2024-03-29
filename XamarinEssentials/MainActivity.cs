﻿using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Xamarin.Essentials;
using System;

namespace XamarinEssentials
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView _batteryLevelTextView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            var batteryLevel = Battery.ChargeLevel;

            _batteryLevelTextView = FindViewById<TextView>(Resource.Id.textView2);
            _batteryLevelTextView.Text = batteryLevel.ToString();
            Battery.BatteryInfoChanged += Battery_BatteryInfoCharged;

            var deviceModel = DeviceInfo.Model;
            var manufacturer = DeviceInfo.Manufacturer;
            var deviceName = DeviceInfo.Name;
            var version = DeviceInfo.Version;
            var platform = DeviceInfo.Platform;
            var idiom = DeviceInfo.Idiom;
            var deviceType = DeviceInfo.DeviceType;


            System.Diagnostics.Debug.WriteLine("DeviceInfo: {1}, {2}, {3}, {4}, {5}, {6}",
            deviceModel, manufacturer, deviceName, version, platform, idiom, deviceType);





        }

        private void Battery_BatteryInfoCharged(object sender, BatteryInfoChangedEventArgs e)
        {
            _batteryLevelTextView.Text = Battery.ChargeLevel.ToString();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}