package crc642ba228e9d986bebf;


public class Adapter1ViewHolder
	extends androidx.recyclerview.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("intern_profile.Adapter1ViewHolder, intern_profile", Adapter1ViewHolder.class, __md_methods);
	}


	public Adapter1ViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == Adapter1ViewHolder.class)
			mono.android.TypeManager.Activate ("intern_profile.Adapter1ViewHolder, intern_profile", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
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
