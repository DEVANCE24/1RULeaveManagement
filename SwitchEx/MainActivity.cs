using Android;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace SwitchEx
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private Switch _switch;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            _switch = FindViewById<Switch>(Resource.Id.switch1);
            _switch.CheckedChange += SwitchCheckedChange;
            _switch = FindViewById<Switch>(Resource.Id.switch2);
            _switch.CheckedChange += SwitchCheckedChange;
            _switch = FindViewById<Switch>(Resource.Id.switch3);
            _switch.CheckedChange += SwitchCheckedChange;
            _switch = FindViewById<Switch>(Resource.Id.switch4);
            _switch.CheckedChange += SwitchCheckedChange;
        }

       
        public void OnCheckedChange(CompoundButton buttonView, bool isChecked)
        {
            if (isChecked)
            {
                Toast.MakeText(Application.Context, "Enable", ToastLength.Short).Show();
            }
            else
            {
                Toast.MakeText(Application.Context, "Disable", ToastLength.Short).Show();
            }
        }
        private void SwitchCheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (e.IsChecked)
            {
                Toast.MakeText(Application.Context, "Enable", ToastLength.Short).Show();
            }
            else
            {
                Toast.MakeText(Application.Context, "Disable", ToastLength.Short).Show();
            }
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            // set the menu layout on Main Activity  
            MenuInflater.Inflate(Resource.Menu.item_menu, menu);
            return base.OnCreateOptionsMenu(menu);
        }


    }
}