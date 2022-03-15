using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.Fragment.App;
using AndroidX.ViewPager.Widget;
using Google.Android.Material.Tabs;
using Java.Lang;
using System;
using ActionBar = Android.App.ActionBar;


namespace ProjectPart
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TabLayout _mytabLayout;
        TextView _mytextView;
        ViewPager _myViewPager;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.ApplyLeave);

            _mytabLayout = FindViewById<TabLayout>(Resource.Id.tabLayout);
            _mytextView = FindViewById<TextView>(Resource.Id.textViewName);
            _myViewPager = FindViewById<ViewPager>(Resource.Id.viewPagerEx);

           

            _mytabLayout.TabSelected += _myTabSelected;
            
            setTabName();
                     
        }

        private void _myTabSelected(object sender, TabLayout.TabSelectedEventArgs e)
        {
            
        }
        private void setTabName()
        {
            _mytabLayout.AddTab(_mytabLayout.NewTab().SetText(Resource.String.leave));
            _mytabLayout.AddTab(_mytabLayout.NewTab().SetText(Resource.String.workFromHome));

        }       
    }  
}