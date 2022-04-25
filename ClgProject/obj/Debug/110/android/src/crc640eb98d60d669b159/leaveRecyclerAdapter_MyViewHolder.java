package crc640eb98d60d669b159;


public class leaveRecyclerAdapter_MyViewHolder
	extends androidx.recyclerview.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("ClgProject.MentorsFile.leaveRecyclerAdapter+MyViewHolder, ClgProject", leaveRecyclerAdapter_MyViewHolder.class, __md_methods);
	}


	public leaveRecyclerAdapter_MyViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == leaveRecyclerAdapter_MyViewHolder.class)
			mono.android.TypeManager.Activate ("ClgProject.MentorsFile.leaveRecyclerAdapter+MyViewHolder, ClgProject", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
