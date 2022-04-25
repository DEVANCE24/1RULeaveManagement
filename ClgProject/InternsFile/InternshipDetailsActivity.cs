using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.RecyclerView.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Toolbar = AndroidX.AppCompat.Widget.Toolbar;

namespace ClgProject.InternsFile
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", ConfigurationChanges = Android.Content.PM.ConfigChanges.Orientation | Android.Content.PM.ConfigChanges.ScreenSize)]

    public class InternshipDetailsActivity : AppCompatActivity
    {
        public RecyclerView _recyclerViewmentorDetails;
        private  MentorDetailsAdapter _mentorDetailsAdapter;
        public ImageView _imageViewBack;
        private Toolbar toolbar; 
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.internshipDetailsLayout);
            toolbar = FindViewById<AndroidX.AppCompat.Widget.Toolbar>(Resource.Id.toolbar1);
            

            SetSupportActionBar(toolbar);
            SupportActionBar.Title = null;
            AndroidX.AppCompat.App.ActionBar actionbar = SupportActionBar;
            //actionbar.SetHomeAsUpIndicator(Resource.Drawable.menuact);
            // .
            // SupportActionBar.SetDisplayShowHomeEnabled(true);
            actionbar.SetDisplayHomeAsUpEnabled(true);

            actionbar.SetDefaultDisplayHomeAsUpEnabled(true);
            toolbar.NavigationClick += Toolbar_NavigationClick;
            _recyclerViewmentorDetails = FindViewById<RecyclerView>(Resource.Id.recycleViewMentorDetails);
            

            string[] names = new string[] { "Shivam Mistry", "Daniel Richard", "Sam Paul", "Will Smith", "Shivam Mistry", "Mit", "Raju", "sagar" };

            _mentorDetailsAdapter = new MentorDetailsAdapter(names);
            _recyclerViewmentorDetails.SetAdapter(_mentorDetailsAdapter);

            


        }

        private void Toolbar_NavigationClick(object sender, Toolbar.NavigationClickEventArgs e)
        {
            Finish();
        }
        public override bool OnSupportNavigateUp()
        {
            OnBackPressed();
            return true;
        }

    }
}