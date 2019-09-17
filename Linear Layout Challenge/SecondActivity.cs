using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Linear_Layout_Challenge
{
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : Activity
    {
        //TextView _textView1;
        //TextView _textView2;
        //TextView _textView3;
        //TextView _textView4;
        //TextView _textView5;
        //TextView _textView6;
        //TextView _textView7;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.second_layout);
            //_textView1 = FindViewById<EditText>(Resource.Id.textView1);
            //_textView2 = FindViewById<EditText>(Resource.Id.textView2);
            //_textView3 = FindViewById<EditText>(Resource.Id.textView3);
            //_textView4 = FindViewById<EditText>(Resource.Id.textView4);
            //_textView5 = FindViewById<EditText>(Resource.Id.textView5);
            //_textView6 = FindViewById<EditText>(Resource.Id.textView6);
            //_textView7 = FindViewById<EditText>(Resource.Id.textView7);
            // Create your application here
        }
    }
}