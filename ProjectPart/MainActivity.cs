using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace ProjectPart
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        ImageView imageViewBack;
        EditText editUser, editPassword;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            // SetContentView(Resource.Layout.activity_main);
            SetContentView(Resource.Layout.Profile);

            imageViewBack = FindViewById<ImageView>(Resource.Id.imageViewBackImg);

                   

        }
        
    }
}