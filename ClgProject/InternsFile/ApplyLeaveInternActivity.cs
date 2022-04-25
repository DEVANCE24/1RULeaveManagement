using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using Google.Android.Material.Tabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fragment = AndroidX.Fragment.App.Fragment;
using Toolbar = AndroidX.AppCompat.Widget.Toolbar;

namespace ClgProject.InternsFile
{
    [Activity( Theme = "@style/AppTheme",  ConfigurationChanges = Android.Content.PM.ConfigChanges.Orientation | Android.Content.PM.ConfigChanges.ScreenSize)]
    public class ApplyLeaveInternActivity : AppCompatActivity
    {
        public TabLayout _mytabLayout;
        public TextView _mytextView;
        public FrameLayout frameLayout;
       
        public Button _myApplyButton;

        private LoginSuccessfullFragment _loginSuccessfullFragment;

        public ApplyLeaveFragment  _fragmentApplyLeave;
        public ApplyWrokfromhomeFragment _fragmentApplyWorkfromhome;

        public Toolbar toolbar;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.applyLeaveLayout);

            UIReferences();
            UIEventClick();
            ObjectCreation();
            setTabName();

            SupportFragmentManager.BeginTransaction().Replace(Resource.Id.frameLayoutEx, _fragmentApplyLeave).Commit();

            toolbar = FindViewById<Toolbar>(Resource.Id.toolbarBack);

            SetSupportActionBar(toolbar);
            SupportActionBar.SetDisplayShowHomeEnabled(true);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            toolbar.NavigationClick += Toolbar_NavigationOnClick;
        }

        private void Toolbar_NavigationOnClick(object sender, EventArgs e)
        {
            Finish();
        }

        public override bool OnSupportNavigateUp()
        {
            OnBackPressed();
            return true;
        }

        private void UIReferences()
        {
            _mytabLayout = FindViewById<TabLayout>(Resource.Id.tabLayout);
            _myApplyButton = FindViewById<Button>(Resource.Id.applyButton);
            
           
        }
        private void UIEventClick()
        {
            _mytabLayout.TabSelected += _mytabLayout_TabSelected;
            _myApplyButton.Click += _myApplyButton_Click;

            
            
        }

        private void _myImageViewApplyLeave_Click(object sender, EventArgs e)
        {
            Finish();
        }

        private void _mytabLayout_TabSelected(object sender, TabLayout.TabSelectedEventArgs e)
        {
            Fragment _selected = null;
            switch (e.Tab.Position)
            {

                case 0:
                    _selected = _fragmentApplyLeave;
                    SupportFragmentManager.BeginTransaction().Replace(Resource.Id.frameLayoutEx, _selected).Commit();
                    break;
                case 1:
                    _selected = _fragmentApplyWorkfromhome;
                    SupportFragmentManager.BeginTransaction().Replace(Resource.Id.frameLayoutEx, _selected).Commit();
                    break;
           
            }

            SupportFragmentManager.BeginTransaction().Replace(Resource.Id.frameLayoutEx, _selected).Commit();
        }

        private void _myApplyButton_Click(object sender, EventArgs e)
        {
            if(_fragmentApplyLeave !=null)
            {
                if(!_fragmentApplyLeave.firsthalf.Checked && !_fragmentApplyLeave.fullday.Checked && !_fragmentApplyLeave.secondhalf.Checked)
                {
                    Toast.MakeText(this,"Please Select type of leave",ToastLength.Short).Show();
                }
                if(_fragmentApplyLeave.editTextleaveApplication.Text == "")
                {
                    _fragmentApplyLeave.editTextleaveApplication.Error = "Please type reson hear";
                }
                if(_fragmentApplyLeave._textViewFromDate.Text == "" && _fragmentApplyLeave._textViewToDate.Text == "")
                {
                    _fragmentApplyLeave._textViewFromDate.Error = "Please Select Date";
                    _fragmentApplyLeave._textViewToDate.Error = "Please Select Date";
                }
            }
            else if(_fragmentApplyWorkfromhome !=null)
            {
                if(_fragmentApplyWorkfromhome.applyleaveapplication.Text =="")
                {
                    _fragmentApplyWorkfromhome.applyleaveapplication.Error = "Please type Reason";
                }
                if(_fragmentApplyWorkfromhome._textViewFromWfh.Text == "" && _fragmentApplyWorkfromhome._textViewToWfh.Text == "")
                {
                    _fragmentApplyWorkfromhome._textViewFromWfh.Error = "Please Select Date";
                    _fragmentApplyWorkfromhome._textViewToWfh.Error = "Please Select Date";
                }

            }
            else
            {
                _loginSuccessfullFragment = new LoginSuccessfullFragment();
                var frag = SupportFragmentManager.BeginTransaction();
                _loginSuccessfullFragment.Cancelable = false;
                _loginSuccessfullFragment.Show(frag, "loginFrag");
            }
            
        }


        private void ObjectCreation()
        {
            _fragmentApplyLeave = new ApplyLeaveFragment();
            _fragmentApplyWorkfromhome = new ApplyWrokfromhomeFragment();
            
        }
        private void setTabName()
        {
            _mytabLayout.AddTab(_mytabLayout.NewTab().SetText(Resource.String.leave));
            _mytabLayout.AddTab(_mytabLayout.NewTab().SetText(Resource.String.workFromHome));
        }
    }
}