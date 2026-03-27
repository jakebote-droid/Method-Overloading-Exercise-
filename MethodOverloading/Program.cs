using System;

class Program
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static decimal Add(decimal c, decimal d)
    {
        return c + d;
    }

    public static string Add(int e, int f, bool dollars)
    {
        int sum = e + f;

        if (dollars)
        {
            if (sum == 1)
            {
                return sum + " dollar";
            }
            else
            {
                return sum + " dollars";
            }
        }

        return sum.ToString();
    }

    static void Main()
    {
        Console.WriteLine("Are we going to be adding 1. whole numbers 2. deciamls or 3.dollars.");
      string input = Console.ReadLine();
       int choice;
       if (int.TryParse(input, out choice))
       {
           switch (choice)
           { 
               case 1:
                   Console.WriteLine("what is are first number?");
                  int a = int.Parse(Console.ReadLine());
                   Console.WriteLine("what is second number?");
                   int b = int.Parse(Console.ReadLine());
                  int result = Add(a, b);
                   Console.WriteLine("your answer is " + result);
                   break;
              
               case 2:Console.WriteLine("what is your first decimal");
                   decimal c = decimal.Parse(Console.ReadLine());
                   Console.WriteLine("what is your second decimal?");
                   decimal d = decimal.Parse(Console.ReadLine());
                   decimal result2 = Add(c, d);
                   Console.WriteLine("your answer is " + result2);
                   break;
               
               case 3:
                   bool dollars = true;
                   Console.WriteLine("what is your first dollor amount?");
                   int e = int.Parse(Console.ReadLine());
                   Console.WriteLine("what is your second dollor amount?");
                   int f = int.Parse(Console.ReadLine());
                   string result3 = Add(e, f, dollars);
                   Console.WriteLine("your answer is " + result3);
                   break;
               default:
                   Console.WriteLine("invalid choice please pick 1 2 or 3 ");
                   break;

           }
       }
       else
           {
           Console.WriteLine("Please enter a valid number.");
           }
    }
}