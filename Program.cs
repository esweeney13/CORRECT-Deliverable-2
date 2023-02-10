using System;

namespace Loops_Application
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer number");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("Specify the series: Even or Odd");
            string series = Console.ReadLine();

            Console.WriteLine("You have selected the" + series + "The numbers between 0 and " + input + " are:");

            if (series == "Even")
            {
                for (int i = 0; i < input; i = i + 2)
                {
                    Console.WriteLine(i + " is an even number");
                }
            }
        }
    }
}

