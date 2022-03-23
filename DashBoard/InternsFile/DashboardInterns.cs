using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.AppCompat.App;
using Google.Android.Material.BottomNavigation;
using Google.Android.Material.FloatingActionButton;
using static Google.Android.Material.BottomNavigation.BottomNavigationView;
using Fragment = AndroidX.Fragment.App.Fragment;

namespace DashBoard
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class DashboardInterns : AppCompatActivity, IOnNavigationItemSelectedListener
    {
        private BottomNavigationView _bottomNavigationViewInterns;
        private DashboardInternsFragment _dasboardInternsFragment;
        private StatusInternFragment _statusInternFragment;
        private ProfileInternFragment _profileInternFragment;
        private FloatingActionButton _buttonApplyLeave;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.dashboardInternsLayout);

            
            _bottomNavigationViewInterns = FindViewById<BottomNavigationView>(Resource.Id.bottonNavigationViewInterns);
            _buttonApplyLeave = FindViewById<FloatingActionButton>(Resource.Id.floatingActionButtonApplyLeave);

            _bottomNavigationViewInterns.SetOnNavigationItemSelectedListener(this);
            _dasboardInternsFragment = new DashboardInternsFragment(this);
            _statusInternFragment = new StatusInternFragment();
            _profileInternFragment = new ProfileInternFragment();
            SupportFragmentManager.BeginTransaction().Replace(Resource.Id.frameLayoutDashBoard, _dasboardInternsFragment).Commit();
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            
            switch (item.ItemId)
            {
                case Resource.Id.dashboard:
                    SupportFragmentManager.BeginTransaction().Replace(Resource.Id.frameLayoutDashBoard, _dasboardInternsFragment).Commit();
                    _buttonApplyLeave.Visibility = ViewStates.Visible;
                    break;

                case Resource.Id.status:
                    SupportFragmentManager.BeginTransaction().Replace(Resource.Id.frameLayoutDashBoard, _statusInternFragment).Commit();
                    _buttonApplyLeave.Visibility = ViewStates.Gone;
                    break;

                case Resource.Id.profile:
                    SupportFragmentManager.BeginTransaction().Replace(Resource.Id.frameLayoutDashBoard, _profileInternFragment).Commit();
                    _buttonApplyLeave.Visibility = ViewStates.Gone;
                    break;


            }

          

            return true;
        }
    }
}