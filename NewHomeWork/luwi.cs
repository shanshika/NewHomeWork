using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHomeWork
{
    internal class OddNumb
    {


        public void GetOddNumb(int numb)
        {
            if (numb % 2 == 0)
            {
                Console.WriteLine("Your Number is even ");
            }
            else
            {
                Console.WriteLine("Your number is odd ");
            }
        }
    }

}
