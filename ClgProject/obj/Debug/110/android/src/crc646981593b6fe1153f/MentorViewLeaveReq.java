package crc646981593b6fe1153f;


public class MentorViewLeaveReq
	extends androidx.appcompat.app.AppCompatActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onSupportNavigateUp:()Z:GetOnSupportNavigateUpHandler\n" +
			"";
		mono.android.Runtime.register ("ClgProject.mentorFile.MentorViewLeaveReq, ClgProject", MentorViewLeaveReq.class, __md_methods);
	}


	public MentorViewLeaveReq ()
	{
		super ();
		if (getClass () == MentorViewLeaveReq.class)
			mono.android.TypeManager.Activate ("ClgProject.mentorFile.MentorViewLeaveReq, ClgProject", "", this, new java.lang.Object[] {  });
	}


	public MentorViewLeaveReq (int p0)
	{
		super (p0);
		if (getClass () == MentorViewLeaveReq.class)
			mono.android.TypeManager.Activate ("ClgProject.mentorFile.MentorViewLeaveReq, ClgProject", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public boolean onSupportNavigateUp ()
	{
		return n_onSupportNavigateUp ();
	}

	private native boolean n_onSupportNavigateUp ();

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
