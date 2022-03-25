using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Google.Android.Material.TextField;

namespace intern_profile
{
    [Activity(Label = "ChangePassword")]
    public class ChangePassword : Activity
    {
        Google.Android.Material.TextField.TextInputLayout editTextConfirmPass, editTextPass, editTextNewPass;
        public EditText editTextPassET, editTextNewPassET, editTextConfirmPassET;
        public TextView forgotText;
        public Button changePassBtn;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.changePassword);
            // Create your application here
            // edit texts
            editTextPassET = FindViewById<EditText>(Resource.Id.oldPassEditText);
            editTextNewPassET = FindViewById<EditText>(Resource.Id.NewPassEditText);
            editTextConfirmPassET = FindViewById<EditText>(Resource.Id.confirmPassEditText);
      
            forgotText = FindViewById<TextView>(Resource.Id.Forgetpassword);

            //Text input layout
            editTextConfirmPass = FindViewById<TextInputLayout>(Resource.Id.confirmPassInputLayout);
            editTextPass = FindViewById<TextInputLayout>(Resource.Id.oldPassInputLayout);
            editTextNewPass = FindViewById<TextInputLayout>(Resource.Id.newPassInputLayout);

            changePassBtn = FindViewById<Button>(Resource.Id.changePasswordBtn);
            editTextConfirmPassET.TextChanged += EditTextConfirmPassET_TextChanged;
            changePassBtn.Click += ChangePass_Successfully;
            editTextPassET.TextChanged += EditTextPassET_TextChanged;
            editTextNewPassET.TextChanged += EditTextNewPassET_TextChanged;


        }

        private void EditTextNewPassET_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            editTextNewPass.Error = null;
        }

        private void EditTextPassET_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            editTextPass.Error = null;
        }

        private void ChangePass_Successfully(object sender, EventArgs e) 
        {
            if (editTextPassET.Text == "" && editTextNewPassET.Text == "" && editTextConfirmPassET.Text == "")
            {
                editTextPass.Error = "Please Enter-old Password";
                editTextNewPass.Error = "Please Enter-New Password";
                editTextConfirmPass.Error = "Please Re-enter Password";

            }
            else if (editTextPassET.Text == "")
            {
                editTextPass.Error = "Please Enter-old Password";
            }
            else if (editTextPassET.Text.Length < 8)
            {
                editTextPass.Error = "Must be at least 8 characters";
            }
            else if (editTextNewPassET.Text == "")
            {
                editTextNewPass.Error = "Please Enter-New Password";
            }
            else if (editTextNewPassET.Text.Length < 8)
            {
                editTextNewPass.Error = "Must be at least 8 characters";
            }
            else if (editTextConfirmPassET.Text == "")
            {
                editTextConfirmPass.Error = "Please Re-enter Password";
            }
          
            else if (editTextNewPassET.Text != editTextConfirmPassET.Text)
            {
                Toast.MakeText(this, "Your NewPass Or ConfirmPass Not Same.", ToastLength.Short).Show();
            }

            else
            {
                Intent b = new Intent(this, typeof(MainActivity));
                StartActivity(b);
                Toast.MakeText(this, "Password Change Successsfully", ToastLength.Short).Show();
            }
            
        }

        private void EditTextConfirmPassET_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
           if(editTextNewPassET.Text != editTextConfirmPassET.Text)
            {
                editTextConfirmPass.Error = "Please Re-enter Password";
            }
            else
            {
                editTextConfirmPass.Error = null;
            }
        }
    }
}