using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class DateModifier
    {
        //private string dateOne;
        //private string dateTwo;

        public void CalculateDateDifference(string dateOne, string dateTwo)
        {
            var dateOneDetails = dateOne.Split().Select(int.Parse).ToArray();
            var dateTwoDetails = dateTwo.Split().Select(int.Parse).ToArray();

            DateTime date1 = new DateTime(dateOneDetails[0], dateOneDetails[1], dateOneDetails[2]);
            DateTime date2 = new DateTime(dateTwoDetails[0], dateTwoDetails[1], dateTwoDetails[2]);

            Console.WriteLine(Math.Abs((date2 - date1).TotalDays));
        }
    }
}
