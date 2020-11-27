using System;

namespace SimpleCalculator
{
    class SimpleProgram
    {
        static void oldMain(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            Console.WriteLine("console calculator in C#");
            Console.WriteLine("------------------------");
            Console.WriteLine("type a number, and then press Enter");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("type another number, and press Enter");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("choose an option from the following list:");
            Console.WriteLine("\ta - add");
            Console.WriteLine("\ts - subtract");
            Console.WriteLine("\tm - multiply");
            Console.WriteLine("\td - divide");
            Console.WriteLine("your option?");
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1+num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1-num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1*num2));
                    break;
                case "d":
                    while (num2 == 0)
                    {
                        Console.WriteLine("enter a non-zero divisor:");
                        num2 = Convert.ToDouble(Console.ReadLine());
                    }
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1/num2));
                    break;
                default: Console.WriteLine("fuck you bitch");
                    break;
            }
            Console.WriteLine("press any key to close the calculator app ...");
            Console.ReadKey();
        }
    }
}
