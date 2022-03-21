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

namespace DashBoard
{
   class Holiday
    {
        public Holiday(string holidays, string date)
        {
            holidayName = holidays;
            holidayDate = date;
        }

      public string holidayName { get; set; }
      public string holidayDate { get; set; }
    
    }
    class HolidayList
    {
        static Holiday[] holidayNameList =
        {

            new Holiday("Makar Sankranti","14 JAN"),
            new Holiday("Republic Day","26 JAN"),
            new Holiday("MahaShiv Ratri", "1 MAR"),
            new Holiday("Dhuleti","18 MAR"),
            new Holiday("Ambedkar Jayanti","14 APR"),
            new Holiday("Good Friday","15 APR"),
            new Holiday("Raksha Bandhan","11 AUG"),
            new Holiday("Independence Day","15 AUG"),
            new Holiday("Parsi New Year","16 AUG"),
            new Holiday("Janmastami","19 AUG"),
            new Holiday("Ganesh Chaturthi","31 AUG"),
            new Holiday("Gandhi Jayanti","02 OCT"),
            new Holiday("Dussehra", "05 OCT"),
            new Holiday("Diwali","24 OCT"),
            new Holiday("Christmas Day","25 DEC"),

        };

        private Holiday[] myholidays;
        public HolidayList()
        {
            myholidays = holidayNameList;
        }

        public int holidayNumber
        { 
            get { return myholidays.Length; }
        }

        public Holiday this[int i]
        { 
        
            get { return myholidays[i]; }        
        }
    }
}