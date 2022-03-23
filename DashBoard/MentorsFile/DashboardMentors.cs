using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using Google.Android.Material.BottomNavigation;
using Google.Android.Material.FloatingActionButton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Google.Android.Material.BottomNavigation.BottomNavigationView;

namespace DashBoard
{ 
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class DashboardMentors : AppCompatActivity, IOnNavigationItemSelectedListener
    {
        private BottomNavigationView _bottomNavigationViewMentors;
        private DashboardMentorsFragment _dashboardMentorsFragment;
        private RequestsMentorsFragment _requestsMentorsFragment;
        private ProfileMentorsFragment _profileMentorsFragment;
     
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            
            SetContentView(Resource.Layout.dashboardMentorsLayout);
            _bottomNavigationViewMentors = FindViewById<BottomNavigationView>(Resource.Id.bottonNavigationViewMentors);
            _bottomNavigationViewMentors.SetOnNavigationItemSelectedListener(this);
            
            _dashboardMentorsFragment = new DashboardMentorsFragment(this);
            _requestsMentorsFragment = new RequestsMentorsFragment();
            _profileMentorsFragment = new ProfileMentorsFragment();

            SupportFragmentManager.BeginTransaction().Replace(Resource.Id.frameLayoutDashBoardMentors, _dashboardMentorsFragment).Commit();


        }

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {

                case Resource.Id.dashboardmentors:
                    SupportFragmentManager.BeginTransaction().Replace(Resource.Id.frameLayoutDashBoardMentors, _dashboardMentorsFragment).Commit();
                    break;

                case Resource.Id.requestsmentors:
                    SupportFragmentManager.BeginTransaction().Replace(Resource.Id.frameLayoutDashBoardMentors, _requestsMentorsFragment).Commit();
                    break;

                case Resource.Id.profilementors:
                    SupportFragmentManager.BeginTransaction().Replace(Resource.Id.frameLayoutDashBoardMentors, _profileMentorsFragment).Commit();
                    break;

            }

            return true;
        }
    }

   
}