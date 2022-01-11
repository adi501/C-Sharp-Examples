using System;

namespace ConsoleApp1
{
    public class How_to_get_month_name_using_month_number
    {
        public void getMonthName()
        {
            int monthNumber = 2;
            DateTime date = new DateTime(2020, monthNumber, 1);
            string monthName = date.ToString("MMMM");
            Console.WriteLine(monthName);  //Output: February
        }
    }
}
