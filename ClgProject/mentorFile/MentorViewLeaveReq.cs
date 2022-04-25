using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using Toolbar = AndroidX.AppCompat.Widget.Toolbar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClgProject.mentorFile
{
    [Activity(Label = "MentorViewLeaveReq")]
    public class MentorViewLeaveReq : AppCompatActivity
    {
        public Toolbar toolbar;
         public TextView _name, _from, _to, _date, _type, _viewleaverequest;
        public Button _revoke, _reject, _accept;
        protected override void OnCreate(Bundle savedInstanceState)
        {
         
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.ViewLeaveRequest);
            UIreference();
            toolbar.Click += Toolbar_Click;
        }

        private void Toolbar_Click(object sender, EventArgs e)
        {
            Finish();
        }

       

        private void UIreference()
        {
            toolbar = FindViewById<Toolbar>(Resource.Id.toolbarArrowBack);
            _name = FindViewById<TextView>(Resource.Id.textViewName);
            _from = FindViewById<TextView>(Resource.Id.textViewFrom);
            _to = FindViewById<TextView>(Resource.Id.textViewTo);
            _date = FindViewById<TextView>(Resource.Id.textViewDate);
            _type = FindViewById<TextView>(Resource.Id.textViewType);
            _viewleaverequest = FindViewById<TextView>(Resource.Id.textViewLeaveRequest);
            _revoke = FindViewById<Button>(Resource.Id.materialButtonRevoke);
            _reject = FindViewById<Button>(Resource.Id.materialButtonreject);
            _accept = FindViewById<Button>(Resource.Id.materialButtonAccept);

            SetSupportActionBar(toolbar);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetDisplayShowHomeEnabled(true);
            toolbar.NavigationClick += Toolbar_NavigationClick;
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