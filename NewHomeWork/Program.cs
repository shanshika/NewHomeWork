using NewHomeWork;
using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Xml.Linq;

class HomeWork8
{

    static void Main(string[] args)
    {
        //1
        Console.WriteLine("Enter your FirstName: ");
        string FirstName = Console.ReadLine();

        Console.WriteLine("Enter yoyr Age: ");
        int Age = Convert.ToInt32(Console.ReadLine());

        FirstNameAge YourFirstNameAge = new FirstNameAge(FirstName, Age);
        YourFirstNameAge.GetNameAge();
        Console.ReadLine();
        
        //2

        Console.WriteLine("Please, Enter your Number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        OddNumb Answers = new OddNumb();
        Answers.GetOddNumb(number);

        Console.ReadLine();

        //3
        Console.WriteLine("Please, Enter numbers  - From 0 to 6: ");
        int Numbers = int.Parse(Console.ReadLine());

        WeekDay Result = new WeekDay();
        Result.Days(Numbers);

        Console.ReadLine();

        //4

        Console.WriteLine(DateTime.Now);
       
        Console.ReadLine();

    }
}