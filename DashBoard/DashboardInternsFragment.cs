
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
using Fragment = AndroidX.Fragment.App.Fragment;

namespace DashBoard
{


    class DashboardInternsFragment : Fragment
    {

        private RecyclerView _recyclerViewHolidayList;
        private RecyclerView.LayoutManager _layoutmanager;
        private HolidayListAdapter _holidayListAdapter;
        private HolidayList _holidaylist;
        private Context context;

        public DashboardInternsFragment(Context context)
        {
            this.context= context;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.dashboardInternsFragmentLayout, container, false);
            _recyclerViewHolidayList = view.FindViewById<RecyclerView>(Resource.Id.recyclerViewHolidayList);

            _recyclerViewHolidayList.AddItemDecoration(new DividerItemDecoration(Activity.ApplicationContext, DividerItemDecoration.Vertical));
            
            _layoutmanager = new LinearLayoutManager(context);
            _recyclerViewHolidayList.SetLayoutManager(_layoutmanager);
            _holidaylist = new HolidayList();

            _holidayListAdapter = new HolidayListAdapter(_holidaylist, context);
            _recyclerViewHolidayList.SetAdapter(_holidayListAdapter);
            
            return view;

          
        }
    }
}