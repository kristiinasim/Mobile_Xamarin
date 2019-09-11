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

namespace Kalkukas
{
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : Activity
    {
        EditText _edittext1;
        EditText _edittext2;
        Button _button1;
        Button _button2;
        Button _button3;
        Button _button4;
        TextView _textView1;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.second_layout);

            int count = 0;
            _edittext1 = FindViewById<EditText>(Resource.Id.first);
            _edittext2 = FindViewById<EditText>(Resource.Id.second);

            _button1 = FindViewById<Button>(Resource.Id.button1);
            _button2 = FindViewById<Button>(Resource.Id.button2);
            _button3 = FindViewById<Button>(Resource.Id.button3);
            _button4 = FindViewById<Button>(Resource.Id.button4);
            _textView1 = FindViewById<TextView>(Resource.Id.textView1);

            decimal n1 = decimal.Parse(Console.ReadLine());
            decimal n2 = decimal.Parse(Console.ReadLine());


            _button1.Click += delegate
            {
                decimal add = (n1 + n2);

                _textView1.Text = Convert.ToString(add);










                //public void button.Click
                //{
                //    textView.Text = "New Text";
                //button.SetText(textField.Text);
                //TextView.Text = textField.Text;
            };

        }
    }
}
