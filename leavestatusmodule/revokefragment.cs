using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leavestatusmodule
{
    public class revokefragment : DialogFragment
    {
        TextView yes, no;
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

          
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
           View view =   inflater.Inflate(Resource.Layout.dialoguefrag, container, false);
            yes = view.FindViewById<TextView>(Resource.Id.yestext);
            no = view.FindViewById<TextView>(Resource.Id.notext);
            no.Click += No_Click;
            return view;
        }

        private void No_Click(object sender, EventArgs e)
        {
            this.Dismiss(); 
        }
    }
}