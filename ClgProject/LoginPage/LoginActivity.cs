using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using ClgProject.Forget_Password;
using ClgProject.Models;
using Google.Android.Material.TextField;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClgProject
{
    [Activity(Label = "@string/app_name", MainLauncher = true, Theme = "@style/AppTheme")]
    public class LoginActivity : AppCompatActivity
    {
        private TextInputLayout usernamelyt, passwordlyt;
        private EditText usernametxt, passwordtxt;
        private TextView forget;
        private Button LoginButton;
        private Regex validUsername = new Regex("^[A-Z]+[a-zA-Z]+(@)+[0-9]*$");
        //private string endurl = "api/Login/AuthenticateUser";

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.login_page);
            UIReferences();
            UIClickEvent(); 
        }
     

        private void UIClickEvent()
        {
            forget.Click += Forget_Click;
            LoginButton.Click += LoginButton_ClickAsync;
        }

        private async void LoginButton_ClickAsync(object sender, EventArgs e)
        {
            if (!checkusername() && !checkpassword())
            {

                Toast.MakeText(this, "Please Fill the Required Information", ToastLength.Long).Show();

                
            }

            else
            if (checkusername() && checkpassword())
            {

                Toast.MakeText(this, "LoggedIn Successfully", ToastLength.Short).Show();
                passwordlyt.Error = null;
                usernamelyt.Error = null;           

              
                Intent Dashboard = new Intent(this, typeof(DashboardInterns));
                StartActivity(Dashboard);
                usernametxt.Text = null;
                passwordtxt.Text = null;

            }

            
        }

        private bool checkpassword()
        {

            if (passwordtxt.Text.Length == 0)
            {
                passwordlyt.Error = "Enter Password";
                return false;
            }

            else if (passwordtxt.Text.Length < 8)
            {
                passwordlyt.Error = "Enter Valid Password";
                return false;
            }


            return true;
        }

        private bool checkusername()
        {
            if (usernametxt.Text.Length == 0)
            {

                usernamelyt.Error = "Enter Username";
                return false;

            }
            else if (!isValidateUsername(usernametxt.Text))

            {
                usernamelyt.Error = "Enter Valid Username";
                return false;
            }
           
            return true;
        }

        private bool isValidateUsername(string text)
        {
            if (string.IsNullOrEmpty(text))

                return false;

            return validUsername.IsMatch(text);
        }

        private void Forget_Click(object sender, EventArgs e)
        {
            Intent FP = new Intent(this, typeof(ForgetPassword));
            StartActivity(FP);
        }

        private void UIReferences()
        {
            usernamelyt = FindViewById<TextInputLayout>(Resource.Id.usernameInputLayout);
            passwordlyt = FindViewById<TextInputLayout>(Resource.Id.PasswordInputLayout);
            usernametxt = FindViewById<EditText>(Resource.Id.usernametxt);
            passwordtxt = FindViewById<EditText>(Resource.Id.Passwordtxt);
            forget = FindViewById<TextView>(Resource.Id.Forgetpasswordtxt);
            LoginButton = FindViewById<Button>(Resource.Id.loginButton);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        
    }
}