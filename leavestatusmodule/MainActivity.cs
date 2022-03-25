using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using AndroidX.RecyclerView.Widget;
using System;
using System.Collections.Generic;

namespace leavestatusmodule
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.noActionbar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        RecyclerView.LayoutManager mLayoutManager;
       
        List<internsonleave> leavelist;
        recyclerviewadapter mAdapter;
        RecyclerView recycler;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            recycler = FindViewById<RecyclerView>(Resource.Id.recyclerviewId);
            datainput();
            mLayoutManager = new LinearLayoutManager(this);
            recycler.SetLayoutManager(mLayoutManager);
            mAdapter = new recyclerviewadapter(leavelist, this);
            recycler.SetAdapter(mAdapter);

        }
        private void datainput()
        {
            leavelist = new List<internsonleave>
            { 
               new internsonleave{
                   reason ="i have to visit a family function",day="Wed",
                   date="16 feb",typeofleave="half day",
                   seperatordate =" Jan 2022",
                   statusofleave="accepted",
                   buttontext="Revoke"
                                 },
               new internsonleave{ reason ="i have to visit a dentist ",day="Wed",date="14 feb",typeofleave="full day",statusofleave="pending",buttontext="Req to revoke"},
               new internsonleave{ reason ="i missed the bus",day="thu",date="17 feb",typeofleave="half day",seperatordate ="",statusofleave="accepted",buttontext="Revoke"},
               new internsonleave{ reason ="i missed the train",day="Friday",date="18 feb",typeofleave="full day",seperatordate =" Feb 2022",statusofleave="pending",buttontext="Revoke"},
               new internsonleave{ reason ="Mood nahi hai",day="Monday",date="20 feb",typeofleave="half day",seperatordate =" Mar 2022",statusofleave="accepted",buttontext="Req to revoke"},
               new internsonleave{ reason ="Shadi thi",day="Tue",date="25 feb",typeofleave="full day",seperatordate ="",statusofleave="accepted",buttontext="Revoke"},
               new internsonleave{ reason ="Dadi nahi  rahi",day="Wed",date="26 feb",typeofleave="full day",seperatordate =" Apr 2022",statusofleave="pending",buttontext="Revoke"},
               new internsonleave{ reason ="Baju wala nahi raha",day="Thu",date="27 feb",typeofleave="full day",seperatordate ="",statusofleave="accepted",buttontext="Revoke"},

            };
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}