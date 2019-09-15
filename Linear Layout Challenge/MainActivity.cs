using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace Linear_Layout_Challenge
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            Button button1 = FindViewById<Button>(Resource.Id.button1);
            Button button2 = FindViewById<Button>(Resource.Id.button2);
            Button button3 = FindViewById<Button>(Resource.Id.button3);
            Button button4 = FindViewById<Button>(Resource.Id.button4);


            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            button3.Click += Button1_Click;
            button4.Click += Button1_Click;

        }

        private void Button1_Click(object sender, System.EventArgs e)
        {

            SetContentView(Resource.Layout.second_layout);

        }
        private void Button2_Click(object sender, System.EventArgs e)
        {

        }
        private void Button3_Click(object sender, System.EventArgs e)
        {

        }
        private void Button4_Click(object sender, System.EventArgs e)
        {

        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
       
    }
}