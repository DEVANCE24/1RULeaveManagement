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
    public class LeaveLayout : AppCompatActivity
    {
        private ImageView imageViewOne, imageViewTwo;
        private TextView textViewOne, textViewTwo;
        private DateFromPickerDialoguefragment dateFromPickerDialoguefragment;
        private DateToPickerDialoguefragment dateToPickerDialoguefragment;
        private readonly string _tag = "Main Activity";

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.LeaveLayout);

            imageViewOne = FindViewById<ImageView>(Resource.Id.imageViewFromCalender);
            textViewOne = FindViewById<TextView>(Resource.Id.textViewFromDate);

            imageViewTwo = FindViewById<ImageView>(Resource.Id.imageViewToCalender);
            textViewTwo = FindViewById<TextView>(Resource.Id.textViewToDate);


            imageViewOne.Click += FromDateClick;
            imageViewTwo.Click += ToDateClick;
            ObjectCreation();
            BindEventofDateChange();
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

        private void DatePickerDialoguefragment_FromDateChangeHandler(object sender, DateTime e)
        {
            textViewOne.Text = e.ToString(format: "dd/MM/yyyy");
        }

        private void DatePickerDialoguefragment_ToDateChangeHandler(object sender, DateTime e)
        {
            textViewTwo.Text = e.ToString(format: "dd/MM/yyyy");
        }

        private void FromDateClick(object sender, EventArgs e)
        {
            dateFromPickerDialoguefragment.Show(SupportFragmentManager, _tag);
        }

        private void ToDateClick(object sender, EventArgs e)
        {
            dateToPickerDialoguefragment.Show(SupportFragmentManager, _tag);
        }
    }
}