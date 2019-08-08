using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using CN.Iwgang.Countdownview;

namespace appCountDown
{
    [Activity(Label = "appCountDown", MainLauncher = true, Icon = "@mipmap/icon", Theme ="@style/Theme.AppCompat.NoActionBar")]

    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
             SetContentView(Resource.Layout.Main);

            CountdownView countDownTimer = FindViewById<CountdownView>(Resource.Id.countDownView);
            countDownTimer.Start(90400);
             }
        }
    }


