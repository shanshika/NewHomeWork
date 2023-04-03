using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHomeWork
{
    public class FirstNameAge
    {
        public string FirstName { get; set; }
        public int Age { get; set; }
        public FirstNameAge(string a, int b)
        {

            FirstName = a;
            Age = b;

        }

        public void GetNameAge()
        {
            Console.WriteLine("Your Name is " + FirstName + " " + "And Your Age is " + Age);
        }

    }

}
