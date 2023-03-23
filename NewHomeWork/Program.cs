using System;

class HomeWork7
{
    static void Main(string[] args)
    {
        // davaleba 1

        Console.WriteLine("Please enter number x:");
        int x = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Please enter number y: ");
        int y = Int32.Parse(Console.ReadLine());

        int Sum = x * y;
        Console.WriteLine("Your answer is : " + Sum);

        Console.ReadLine();


        //davaleba 2

        Console.WriteLine("Enter your name: ");
        Console.ReadLine();

        Console.WriteLine("Enter your surname: ");
        Console.ReadLine();

        Console.WriteLine("Enter your age: ");
        int age = Int32.Parse(Console.ReadLine());

        // davaleba 3

        Console.WriteLine("enter number a: ");
        int a = Int32.Parse(Console.ReadLine());

        Console.WriteLine("enter number b: ");
        int b = Int32.Parse(Console.ReadLine());

        int Div = a / b;
        Console.WriteLine("Your answer is: " + Div);
        Console.ReadLine();

        // davaleba 4
        Console.WriteLine("Please enter your number z:");
        int z = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Please enter your number q:");
        int q = Int32.Parse(Console.ReadLine());

        bool Answ = z == q;

        Console.WriteLine("Your biggest number is: " + Answ);
        Console.ReadLine();

        // davaleba 5
        int A = 5;
        int B = 4;
        int C = 7;

        bool numb = true;

        if (numb)
        {
            numb = (A > B || A > C || A > B);
        }
        Console.WriteLine("Your answer is: " + numb);
        Console.ReadLine();

        //davaleba 6

        int[] numbers = new int[10] { 5, 10, 15, 20, 18, 5, 7, 0, 2, 5 };

        Console.WriteLine(numbers[0] + "," + numbers[6]);
        Console.ReadLine();

        // davaleba 7

        int[,] Two = new int[3, 2]

        { {111, 125 },{987,254 }, {165,931 } };

        Console.WriteLine(Two[3, 2]);
        Console.ReadLine();

        int[,] Four = new int[4, 2]
            {{112,115}, {1589,1572},{365,0}, {993,140}};

        Console.WriteLine(Four[4, 2]);
        Console.ReadLine();

        int[,,] Three = new int[2, 2, 2]
        {
           { {22 , 33}, {44 , 55}, },
           { { 66 , 77} , { 88 , 99} }
         };
        Console.WriteLine(Three[2, 2, 2]);
        Console.ReadLine();

        int[,,] Therd = new int[1, 2, 3]
        {
           { {123,545,3245 }, {198,358,658} }
        };
        Console.WriteLine(Therd[1, 2, 3]);
        Console.ReadLine();
    }
}