using Android.App;
using Android.Widget;
using Android.OS;
using Java.Lang;
using System;

namespace ahhhhh
{
    [Activity(Label = "Half-Life Calculator", MainLauncher = true, Icon = "@drawable/icon")]
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

        public void HalfLife()
        {
            var b = double.Parse(FindViewById<EditText>(Resource.Id.entry1).Text);
            var f = double.Parse(FindViewById<EditText>(Resource.Id.entry2).Text);
            var t = double.Parse(FindViewById<EditText>(Resource.Id.entry3).Text);
            var h = ((Java.Lang.Math.Log(2) / 2.302585092994046) * t / (Java.Lang.Math.Log(b / f) / 2.302585092994046));
            if (f > b)
            {
                var message = (new AlertDialog.Builder(this)).Create();
                message.SetTitle("Input Error");
                message.SetMessage("The final amount cannot be larger than the initial amount");
                message.SetButton("Okay", HandleButtonClick);
                message.Show();
            }
            var calculate = FindViewById<Button>(Resource.Id.btnCalc);
            calculate.Click += delegate
            {
                var dis = FindViewById<TextView>(Resource.Id.result);
                var display = FindViewById<TextView>(Resource.Id.textView2);
                dis.Text = "Half-Life: ";
                display.Text = Convert.ToString(h);
            };
        }
		
        private void FinalAmount()
        {
            var b = double.Parse(FindViewById<EditText>(Resource.Id.entry1).Text);
            var t = double.Parse(FindViewById<EditText>(Resource.Id.entry3).Text);
            var h = double.Parse(FindViewById<EditText>(Resource.Id.entry4).Text);
            var f = (b / Java.Lang.Math.Pow(2, t / h));
            var calculate = FindViewById<Button>(Resource.Id.btnCalc);
            calculate.Click += delegate
            {
                var dis = FindViewById<TextView>(Resource.Id.result);
                var display = FindViewById<TextView>(Resource.Id.textView2);
                dis.Text = "Final Amount: ";
                display.Text =  Convert.ToString(f);
            };
        }
		private void ElapsedTime()
        {
            var b = double.Parse(FindViewById<EditText>(Resource.Id.entry1).Text);
            var f = double.Parse(FindViewById<EditText>(Resource.Id.entry2).Text);
            var h = double.Parse(FindViewById<EditText>(Resource.Id.entry4).Text);
            var t = ((Java.Lang.Math.Log(b / f)) / (Java.Lang.Math.Log(2)))*h;
            if (f > b)
            {
                var message = (new AlertDialog.Builder(this)).Create();
                message.SetTitle("Input Error");
                message.SetMessage("The final amount cannot be larger than the initial amount");
                message.SetButton("Okay", HandleButtonClick);
                message.Show();
            }
            var calculate = FindViewById<Button>(Resource.Id.btnCalc);
            calculate.Click += delegate
            {
                var dis = FindViewById<TextView>(Resource.Id.result);
                var display = FindViewById<TextView>(Resource.Id.textView2);
                dis.Text = "Elapsed Time: ";
                display.Text = Convert.ToString(t);
            };
        }
        private void HandleButtonClick(object sender, EventArgs e) {
        }
    }
}