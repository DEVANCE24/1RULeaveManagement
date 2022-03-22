
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using System;

namespace LeaveManageMent_InternSide
{
    internal class Adapter1 : RecyclerView.Adapter
    {
        //public event EventHandler<Adapter1ClickEventArgs> ItemClick;
        //public event EventHandler<Adapter1ClickEventArgs> ItemLongClick;
        string[] items;

        public Adapter1(string[] data)
        {
            items = data;
        }

        // Create new views (invoked by the layout manager)
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {

            //Setup your layout here
            View itemView = null;
            var id = Resource.Layout.Rowitem1;
            itemView = LayoutInflater.From(parent.Context).
                   Inflate(id, parent, false);

            //var vh = new Adapter1ViewHolder(itemView, OnClick, OnLongClick);
            var vh = new Adapter1ViewHolder(itemView);
            return vh;
        }

        // Replace the contents of a view (invoked by the layout manager)
        public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
        {
            var item = items[position];

            // Replace the contents of the view with that element
            var holder = viewHolder as Adapter1ViewHolder;
            holder.TextView.Text = items[position];
        }

        public override int ItemCount => items.Length;

        //void OnClick(Adapter1ClickEventArgs args) => ItemClick?.Invoke(this, args);
        //void OnLongClick(Adapter1ClickEventArgs args) => ItemLongClick?.Invoke(this, args);

    }

    public class Adapter1ViewHolder : RecyclerView.ViewHolder
    {
        public TextView TextView;

        public Adapter1ViewHolder(View itemView) : base(itemView)
        {
            TextView = itemView.FindViewById<TextView>(Resource.Id.textView1);

        }
    }
}
