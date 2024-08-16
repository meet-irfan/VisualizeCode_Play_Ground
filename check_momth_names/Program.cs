using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm
{
    using System;

    namespace MonthNameSwitchCase
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter a number between 1 and 12 to get the month name:");
                int monthNumber = int.Parse(Console.ReadLine());

                string monthName;

                switch (monthNumber)
                {
                    case 1:
                        monthName = "January";
                        break;
                    case 2:
                        monthName = "February";
                        break;
                    case 3:
                        monthName = "March";
                        break;
                    case 4:
                        monthName = "April";
                        break;
                    case 5:
                        monthName = "May";
                        break;
                    case 6:
                        monthName = "June";
                        break;
                    case 7:
                        monthName = "July";
                        break;
                    case 8:
                        monthName = "August";
                        break;
                    case 9:
                        monthName = "September";
                        break;
                    case 10:
                        monthName = "October";
                        break;
                    case 11:
                        monthName = "November";
                        break;
                    case 12:
                        monthName = "December";
                        break;
                    default:
                        monthName = "Invalid input! Please enter a number between 1 and 12.";
                        break;
                }

                Console.WriteLine("Month: " + monthName);
                Console.ReadKey();
            }
        }
    }



}
