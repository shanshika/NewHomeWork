using System;
using System.Runtime.InteropServices;

class HomeWork7
{
    static void Main(string[] args)
    {
     // FirstTask

        Console.WriteLine("please enter number x: ");
        int x = Int32.Parse(Console.ReadLine());

        if (x % 2 ==0)
        {
            Console.WriteLine("Your number is even");
        }
        else
        {
            Console.WriteLine("Your number is odd ");
        }
        Console.ReadLine();

     //ThecondTask
        Console.WriteLine("Write your number to know what the day is today: ");
        int WeekDay = Convert.ToInt32(Console.ReadLine());
     
      switch (WeekDay)
            {
            case 1:
                Console.WriteLine("Today is Monday");
                break;
            case 2:
                Console.WriteLine("Today is Tuesday");
                break;
            case 3:
                Console.WriteLine("Today is Wednesday");
                break;
            case 4:
                Console.WriteLine("Today is Thursday");
                break;
            case 5:
                Console.WriteLine("Today is Friday");
                break;
            case 6:
                Console.WriteLine("Today is Saturday");
                break;
            case 7:
                Console.WriteLine("Today is Sunday");
                break;
            default:
                Console.WriteLine("We have no more week days");
                break;
      } Console.ReadLine();

     // ThirdTask

        int a = 5;

        while (a >= 0)
        {
            Console.WriteLine("number = {0} ", a );
            a--;
        }
        Console.ReadLine();
        
     //FourthTask
        Console.WriteLine("Enter Your Number y:");
        int y = Int32.Parse(Console.ReadLine());

        do
        {
          Console.WriteLine("Number = {0}", y);
            y--;
        } while (y >= 0);
          Console.ReadLine();

     //FivesTask
        Console.WriteLine("Enter Your Year of Birth: ");
        int Date = Int32.Parse(Console.ReadLine());

        do
        {
            Console.WriteLine("Year of Birth is = {0}", Date);
            Date++;
        } while (Date < 2016);
        Console.ReadLine();

     //SixthTask
        int b = 0;

        while (b <10)
        {
            Console.WriteLine("numebr = {0}", b);
            b++;
        }
        Console.ReadLine();

        //SeventhTask

        Console.WriteLine("Write Your First Number w: ");
        int w = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Write Your Thecond Number t: ");
        int t = Int32.Parse(Console.ReadLine());

        int Fnum = 0;
        int Snum = 0;

        if (w == t)
        {
            Console.WriteLine("Your values are wrong");
        }
        if (w > t)
        {
            Fnum = w;
            Snum = t;
        }
        if (t > w)
        {
            Fnum = w;
            Snum = t;
        }

        for (int i = Fnum; i < Snum  ; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(" Your Numbers is: " + i);
            }
        }
        Console.ReadLine();
    }
}