using Android.App;
using Android.Widget;
using Android.OS;
using Java.Lang;
using System;

namespace ahhhhh
{
    [Activity(Label = "Portfolio", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            FindViewById<Button>(Resource.Id.opt1).Click += delegate
            {
                HalfLife();
            };
            FindViewById<Button>(Resource.Id.opt2).Click += delegate
            {
                FinalAmount();
            };
            FindViewById<Button>(Resource.Id.opt3).Click += delegate
            {
                ElapsedTime();
            };
        }

        private void ElapsedTime()
        {

            FindViewById<TextView>(Resource.Id.entry3).Text = "Half-Life: ";
            var b = FindViewById<TextView>(Resource.Id.entry1).Text;
            var f = FindViewById<TextView>(Resource.Id.entry2).Text;
            var h = FindViewById<TextView>(Resource.Id.entry3).Text;
            double fV = Convert.ToDouble(f);
            double hV = Convert.ToDouble(h);
            double bV = Convert.ToDouble(b);
            var e = (Java.Lang.Math.Log(bV / fV) / 2.302585092994046) / (Java.Lang.Math.Log(2) / 2.302585092994046);
            var calculate = FindViewById<Button>(Resource.Id.btnCalc);
            calculate.Click += delegate
            {
                var display = FindViewById<TextView>(Resource.Id.textView2);
                display.Text = "Elapsed Time: " + e;
            };
        }

        private void FinalAmount()
        {
            FindViewById<TextView>(Resource.Id.entry2).Text = "Half-Life: ";
            var b = FindViewById<TextView>(Resource.Id.entry1).Text;
            var h = FindViewById<TextView>(Resource.Id.entry2).Text;
            var t = FindViewById<TextView>(Resource.Id.entry3).Text;
            double bV = Convert.ToDouble(b);
            double hV = Convert.ToDouble(h);
            double tV = Convert.ToDouble(t);
            var f = bV / Java.Lang.Math.Pow(2, tV / hV);
            var calculate = FindViewById<Button>(Resource.Id.btnCalc);
            calculate.Click += delegate
            {
                var display = FindViewById<TextView>(Resource.Id.textView2);
                display.Text = "Final Amount: " + f;
            };
        }

        public void HalfLife()
        {
            var b = FindViewById<TextView>(Resource.Id.entry1).Text;
            var f = FindViewById<TextView>(Resource.Id.entry2).Text;
            var t = FindViewById<TextView>(Resource.Id.entry3).Text;
            double bV = Convert.ToDouble(b);
            double fV = Convert.ToDouble(f);
            double tV = Convert.ToDouble(t);
            var h = (Java.Lang.Math.Log(2) / 2.302585092994046) * tV / (Java.Lang.Math.Log(bV / fV) / 2.302585092994046);
            var calculate = FindViewById<Button>(Resource.Id.btnCalc);
            calculate.Click += delegate
            {
                var display = FindViewById<TextView>(Resource.Id.textView2);
                display.Text = "Half-Life: " + h;
            };
        }
    }
}
