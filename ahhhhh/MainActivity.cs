using Android.App;
using Android.Widget;
using Android.OS;
using Java.Lang;

namespace ahhhhh
{
    [Activity(Label = "Portfolio", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            

            FindViewById<Button>(Resource.Id.opt1).Click += delegate
            {
                
                var b = FindViewById<TextView>(Resource.Id.entry1).Text;
                var f = FindViewById<TextView>(Resource.Id.entry2).Text;
                var t = FindViewById<TextView>(Resource.Id.entry3).Text;
                double bV = System.Convert.ToDouble(b);
                double fV = System.Convert.ToDouble(f);
                double tV = System.Convert.ToDouble(t);
                var h = (Math.Log(2) / 2.302585092994046) * tV / (Math.Log(bV / fV) / 2.302585092994046);
                var calculate = FindViewById<Button>(Resource.Id.btnCalc);
                calculate.Click += delegate
                {
                    var display = FindViewById<TextView>(Resource.Id.textView2);
                    display.Text = "Half-Life: " + h;
                };
            };
            FindViewById<Button>(Resource.Id.opt2).Click += delegate
            {
                FindViewById<TextView>(Resource.Id.entry2).Text ="Half-Life: ";
                var b = FindViewById<TextView>(Resource.Id.entry1).Text;
                var h = FindViewById<TextView>(Resource.Id.entry2).Text;
                var t = FindViewById<TextView>(Resource.Id.entry3).Text;
                double bV = System.Convert.ToDouble(b);
                double hV = System.Convert.ToDouble(h);
                double tV = System.Convert.ToDouble(t);
                var f = bV / Math.Pow(2, tV / hV);
                var calculate = FindViewById<Button>(Resource.Id.btnCalc);
                calculate.Click += delegate
                {
                    var display = FindViewById<TextView>(Resource.Id.textView2);
                    display.Text = "Final Amount: " + f;
                };
            };
            FindViewById<Button>(Resource.Id.opt3).Click += delegate
            {
                FindViewById<TextView>(Resource.Id.entry3).Text = "Half-Life: ";
                var b = FindViewById<TextView>(Resource.Id.entry1).Text;
                var f = FindViewById<TextView>(Resource.Id.entry2).Text;
                var h = FindViewById<TextView>(Resource.Id.entry3).Text;
                double fV = System.Convert.ToDouble(f);
                double hV = System.Convert.ToDouble(h);
                double bV = System.Convert.ToDouble(b);
                var e = (Math.Log(bV / fV) / 2.302585092994046) / (Math.Log(2) / 2.302585092994046);
                var calculate = FindViewById<Button>(Resource.Id.btnCalc);
                calculate.Click += delegate
                {
                    var display = FindViewById<TextView>(Resource.Id.textView2);
                    display.Text = "Elapsed Time: " + e;
                };
            };

            }
        }
    }

