using Android.Content;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using System;
using System.Collections.Generic;


namespace leavestatusmodule
{
    class recyclerviewadapter : RecyclerView.Adapter
    {
        RecyclerView.ViewHolder viewHolder;
        public const  int USER = 0, IMAGE = 1;
        List<internsonleave> leavelist;
        MyViewHolder viewholder1;
        MyViewHolder2 viewHolder2;
        Context con;

        //public event EventHandler<int> itemClick;


        public recyclerviewadapter(List<internsonleave> leavelist, Context context)
        {
            this.leavelist = leavelist;
            con = context;
        }

        //public override int ItemCount => throw new NotImplementedException();
        public override int ItemCount
        {
            get { return leavelist.Count; }
        }


        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            switch (holder.ItemViewType)
            { 
            case USER:
                    MyViewHolder viewHolder1 = holder as MyViewHolder;
                    configureViewHolder1(viewHolder1, position);
                    break;
                case IMAGE:
                    MyViewHolder2 viewholder2 = holder as MyViewHolder2;
                    configureViewHolder2(viewholder2, position);
                    break;
            }
            //MyViewHolder vh1 = holder as MyViewHolder;
           
            //vh1.reaasonTextView.Text = leavelist[position].reason;
            //vh1.dayDateTextview.Text = leavelist[position].date;
            //vh1.typeofleaveTextview.Text = leavelist[position].typeofleave;
            //vh1.leavestatusbutton.Text = leavelist[position].statusofleave;
            //vh1.revokebutton.Text = leavelist[position].buttontext;
            //MyViewHolder2 vh2 = holder as MyViewHolder2;
            //vh2.monthnameTextView.Text = leavelist[position].seperatordate;
        }



        private void configureViewHolder2(MyViewHolder2 vh2, int position)
        {
            vh2.monthnameTextView.Text = leavelist[position].seperatordate;
            vh2.monthtext2.Text = leavelist[position].day;
        }

        private void configureViewHolder1(MyViewHolder vh1, int position)
        {
            vh1.reaasonTextView.Text = leavelist[position].reason;
            vh1.dayDateTextview.Text = leavelist[position].date;
            vh1.typeofleaveTextview.Text = leavelist[position].typeofleave;
            vh1.leavestatusbutton.Text = leavelist[position].statusofleave;
            vh1.revokebutton.Text = leavelist[position].buttontext;
            
        }

        public override int GetItemViewType(int position)
        {
            if(leavelist[position].seperatordate != "" )
                return USER;
            else
                return IMAGE;

        }


        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
         
            switch (viewType)
            {
                case USER:
                    View v1 = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.hetrogenousRowitem, parent, false);
                    viewHolder = new MyViewHolder(v1);
                    break;
                case IMAGE:
                    View v2 = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.hetrogenouslayout2, parent, false);
                    viewHolder = new MyViewHolder2(v2);
                    break;
            }
            return viewHolder;
        }
        public class MyViewHolder : RecyclerView.ViewHolder
        {
            //private readonly Action<int> listener;
            public Button leavestatusbutton,revokebutton;
            public TextView reaasonTextView,dayDateTextview,typeofleaveTextview;
            public MyViewHolder(View itemView) : base(itemView)
            {
                reaasonTextView = itemView.FindViewById<TextView>(Resource.Id.textviewitem1);
                dayDateTextview = itemView.FindViewById<TextView>(Resource.Id.textviewitem2);
                typeofleaveTextview = itemView.FindViewById<TextView>(Resource.Id.textviewitem3);
                leavestatusbutton = itemView.FindViewById<Button>(Resource.Id.textviewitem4);
                revokebutton = itemView.FindViewById<Button>(Resource.Id.textviewitem5);
            
            }

          
        }
        public class MyViewHolder2 : RecyclerView.ViewHolder
        {
            //private readonly Action<int> listener;
            public TextView monthnameTextView,monthtext2;
            public MyViewHolder2(View itemView) : base(itemView)
            {
                monthnameTextView = itemView.FindViewById<TextView>(Resource.Id.monthid);
                monthtext2 = itemView.FindViewById<TextView>(Resource.Id.monthid2);
            }


        }

    }
}