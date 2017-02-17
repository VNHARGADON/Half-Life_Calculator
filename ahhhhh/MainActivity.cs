using Android.App;
using Android.Widget;
using Android.OS;

namespace ahhhhh
{
    [Activity(Label = "Portfolio", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            var opt1 = FindViewById<Button>(Resource.Id.opt1);
            var opt2 = FindViewById<Button>(Resource.Id.opt2);
            var opt3 = FindViewById<Button>(Resource.Id.opt3);
            
                opt1.Click += delegate
                { 

                    var b = FindViewById<TextView>(Resource.Id.entry1).Text;
                    var f = FindViewById<TextView>(Resource.Id.entry2).Text;
                    var t = FindViewById<TextView>(Resource.Id.entry3).Text;
                    double bV = System.Convert.ToDouble(b);
                    double fV = System.Convert.ToDouble(f);
                    double tV = System.Convert.ToDouble(t);
                    var h = (Java.Lang.Math.Log(2) / 2.302585092994046) * tV / (Java.Lang.Math.Log(bV / fV) / 2.302585092994046);
                    var calculate = FindViewById<Button>(Resource.Id.btnCalc);
                    calculate.Click += delegate
                    {
                        var display = FindViewById<TextView>(Resource.Id.output);
                        display.Text = "Half-Life: " + h;
                    };
                };
            }
        }
    
}

