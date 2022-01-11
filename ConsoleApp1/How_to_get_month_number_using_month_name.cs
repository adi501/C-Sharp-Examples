using System;

namespace ConsoleApp1
{
    public class How_to_get_month_number_using_month_name
    {
        public void getMonthNumber()
        {
            string  monthName = "feb";//February
            int monthNumber = Convert.ToDateTime("01-" + monthName + "-2011").Month;
            Console.WriteLine(monthNumber);  //Output: 2
        }
    }
}
