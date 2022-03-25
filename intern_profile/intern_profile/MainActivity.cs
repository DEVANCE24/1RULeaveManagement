using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.CardView.Widget;
using DE.Hdodenhof.Circleimageview;
using System;
using Xamarin.Essentials;
using Path = System.IO.Path;

namespace intern_profile
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
      
        public ImageView imageView,imageViewTwo;
        public CircleImageView profileImage;
        public CardView cardViewProfileImage;
        public int getImage;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            imageView = FindViewById<ImageView>(Resource.Id.interDetailsNextImageView);
            imageViewTwo = FindViewById<ImageView>(Resource.Id.internChangePassNextImageView);
            cardViewProfileImage = FindViewById<CardView>(Resource.Id.internCardView);
            profileImage = FindViewById<CircleImageView>(Resource.Id.profileImageImageView);
            imageView.Click += InternDetails_Click;
            imageViewTwo.Click += ChangePassword_Click;
            profileImage.Click += ProfileImage_Click;
            imageSetter(getImage);        
        }
        private void imageSetter(int profileImages)
        {
            profileImage.SetImageResource(profileImages);
        }

        private void ProfileImage_Click(object sender, EventArgs e)
        {
            
            AndroidX.AppCompat.App.AlertDialog.Builder alert = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
            alert.SetTitle("Select Profile");
            alert.SetMessage("Select your Image");

            alert.SetPositiveButton("Gallery", (senderAlert, args) =>
            {
                MyLayoutPickimage_Click();
            });

            alert.SetNegativeButton("Camera", (senderAlert, args) =>
            {
                MyLayoutTakeimage_Click();
            });

            Dialog dialog = alert.Create();
            dialog.Show();
        }



        private void ChangePassword_Click(object sender, EventArgs e)
        {
            Intent s = new Intent(this, typeof(ChangePassword));
            StartActivity(s);
        }

        private void InternDetails_Click(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(internDetails));
            StartActivity(i);
        }

        private async void MyLayoutPickimage_Click()
        {
            var res = await MediaPicker.PickPhotoAsync();
            if (res.FileName.EndsWith("jpg", StringComparison.OrdinalIgnoreCase) || (res.FileName.EndsWith("png", StringComparison.OrdinalIgnoreCase))) ;
            {
                var stream = await res.OpenReadAsync();
                profileImage.SetImageBitmap(BitmapFactory.DecodeStream(stream));

            }
        }

        private async void MyLayoutTakeimage_Click()
        {
            var photo = await MediaPicker.CapturePhotoAsync();

            var newFile = Path.Combine(FileSystem.CacheDirectory, photo.FileName);
            using (var stream = await photo.OpenReadAsync())
            {
                profileImage.SetImageBitmap(BitmapFactory.DecodeStream(stream));
            }

        }
    }
}