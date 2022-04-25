package crc640edc275a75d24d81;


public class AdapterMoreLeaves_ViewHolderMoreLeaves
	extends androidx.recyclerview.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("ClgProject.AdapterMoreLeaves+ViewHolderMoreLeaves, ClgProject", AdapterMoreLeaves_ViewHolderMoreLeaves.class, __md_methods);
	}


	public AdapterMoreLeaves_ViewHolderMoreLeaves (android.view.View p0)
	{
		super (p0);
		if (getClass () == AdapterMoreLeaves_ViewHolderMoreLeaves.class)
			mono.android.TypeManager.Activate ("ClgProject.AdapterMoreLeaves+ViewHolderMoreLeaves, ClgProject", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
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
