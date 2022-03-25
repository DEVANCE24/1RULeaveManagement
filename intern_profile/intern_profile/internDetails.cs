using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace intern_profile
{
    [Activity(Label = "internDetails")]
    public class internDetails : Activity
    {
        public RecyclerView recyclerView;
        public internAdapter adapter1;
        public ImageView image;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.internDetails);
            // Create your application here
            string[] names = new string[] { "Shivam Mistry", "Daniel Richard", "Sam Paul", "Will Smith", "Shivam Mistry", "Mit", "Raju", "sagar" };
            adapter1 = new internAdapter(names);
            recyclerView = FindViewById<RecyclerView>(Resource.Id.testrecycleview);
            image = FindViewById<ImageView>(Resource.Id.Backimage);
            recyclerView.SetAdapter(adapter1);
            image.Click += Back_button;
        }

        private void Back_button(object sender, EventArgs e)
        {
            Intent v = new Intent(this,typeof(MainActivity));
            StartActivity(v);
        }
    }
}