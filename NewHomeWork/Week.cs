using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHomeWork
{
    internal class WeekDay
    {
        enum WeekDays
        {
            Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
        }
        public void Days(int Numbers)
        {
            switch (Numbers)
            {
                case 0:
                    Console.WriteLine("Monday");
                    break;
                case 1:
                    Console.WriteLine("Tuesday");
                    break;
                case 2:
                    Console.WriteLine("Wednesday");
                    break;
                case 3:
                    Console.WriteLine("Thursday");
                    break;

                case 4:
                    Console.WriteLine("Friday");
                    break;
                case 5:
                    Console.WriteLine("Saturday");
                    break;
                case 6:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Your Entered Number Had No Any Week Day");
                    break;
            }
        }
    }
}
