using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using Java.Lang;
using System;


namespace ProjectPart
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false)]
    public class WorkFromHome : AppCompatActivity
    {
        TextView textViewOne, textViewTwo;
        ImageView imageViewOne, imageViewTwo;
        private DateFromPickerDialoguefragment dateFromPickerDialoguefragment;
        private DateToPickerDialoguefragment dateToPickerDialoguefragment;
        private readonly string _tag = "Main Activity";

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.WorkFromHomeLayout);

            imageViewOne = FindViewById<ImageView>(Resource.Id.imageViewFromCalender);
            textViewOne = FindViewById<TextView>(Resource.Id.textViewShowDateFrom);

            imageViewTwo = FindViewById<ImageView>(Resource.Id.imageViewToCalender);
            textViewTwo = FindViewById<TextView>(Resource.Id.textViewShowDateTo);
            


            imageViewOne.Click += FromDatePicker;
            imageViewTwo.Click += ToDatePicker;
            ObjectCreation();
            BindEventofDateChange();


        }

        private void FromDatePicker(object sender, EventArgs e)
        {
            dateFromPickerDialoguefragment.Show(SupportFragmentManager, _tag);
            
        }

        private void ToDatePicker(object sender, EventArgs e)
        {
            dateToPickerDialoguefragment.Show(SupportFragmentManager, _tag);
        }

        
        private void ObjectCreation()
        {
            dateFromPickerDialoguefragment = new DateFromPickerDialoguefragment();
            dateToPickerDialoguefragment = new DateToPickerDialoguefragment();
        }
        private void BindEventofDateChange()
        {
            dateFromPickerDialoguefragment.OnDateChangeHandler += DatePickerDialoguefragment_FromDateChangeHandler;
            dateToPickerDialoguefragment.OnDateChangeHandler += DatePickerDialoguefragment_ToDateChangeHandler;
        }

        private void DatePickerDialoguefragment_FromDateChangeHandler(object sender,DateTime e)
        {
            textViewOne.Text = e.ToString(format: "dd/MM/yyyy");
        }
        private void DatePickerDialoguefragment_ToDateChangeHandler(object sender, DateTime e)
        {
            
            textViewTwo.Text = e.ToString(format: "dd/MM/yyyy");
        }

    }
}