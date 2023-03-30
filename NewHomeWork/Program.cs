using System;
using System.Runtime.InteropServices;
using System.Xml.Linq;

class HomeWork7
{
    static void Main(string[] args)
    {
        MyFirstMethod();
        Console.ReadLine();
        Examples();
        Params();
        WeightParms();

        var result = NameSurnameAge("Nata", "Shanshiashvili", 34);
        Console.WriteLine(result);
        Console.ReadLine();
    }    
    //1
    static void MyFirstMethod()
    {
        Console.Write("Enter your Name: ");
        string FirstName = Console.ReadLine();

        Console.Write("Enter Current Date In Format (DD/MM/YYYY): ");
        string CurrentDate = Console.ReadLine();

        Console.Write("Enter your Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Your Name: " + FirstName + " / " + "Current Date is: " + CurrentDate + " / " + "Your Age: " + age);

        Console.ReadLine();
    }
    //2
    static void Examples()
    {
        Console.WriteLine("Please enter First Number: ");
        int FirstNumber = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Please enter Second Number: ");
        int SecondNumber = Int32.Parse (Console.ReadLine());

        Console.WriteLine("Please Try Symbol + or * ");
        string Symbol = Console.ReadLine();

        if (Symbol == "+")
        {
            Console.WriteLine("Your result is: "+ (FirstNumber + SecondNumber));
            Console.ReadLine();
        }else if (Symbol == "*")
        {
            Console.WriteLine("Your result is: " + (FirstNumber * SecondNumber));
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your Entered Symbol Is Wrong!");
            Console.ReadLine();
        }
    }
    //3
    static void Params()
    {
        Console.WriteLine("Please Enter Wish Number:");
        int WishNumber = Int32.Parse(Console.ReadLine());

        if (WishNumber < 0)
        {
            Console.WriteLine("Your answer is {0}");
            Console.ReadLine();
        }
        else 
        {
            Console.WriteLine("Your answer is: " + WishNumber);
            Console.ReadLine();
        }
    }
    //4
    static void WeightParms()
    {
        Console.WriteLine("Enter One Item Weight in killogramms: ");
        double kg = double.Parse(Console.ReadLine());

        Console.WriteLine("Your Items are 50 Pices ");
        int pc = 50;

        Console.WriteLine("Your transportation params is: " + (kg * pc) + "killogramms");
        Console.ReadLine();
    }
    //5
    
      static string NameSurnameAge(string name, string surname)
      {
        return name + surname;
      }
      static string NameSurnameAge(string name, string surname, int age)
      {
         return name + surname + age;
      }
    

}