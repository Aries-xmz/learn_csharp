using System;
namespace Calculator {
    class Calculator {
        public static double DoOperation (double num1, double num2, string op) {
            double result = double.NaN; //默认值设为NaN
            switch (op) {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    if (num2 != 0) {
                        result = num1 / num2;
                    }
                    break;
                default:
                    break;
            }
            return result;
        }
    }

    class Program {
        static void Main (string[] args) {
            bool endApp = false;
            Console.WriteLine ("console calculator in C#\r");
            Console.WriteLine ("------------------------\n");
            while (!endApp) {
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                Console.WriteLine ("type a number, and then press Enter");
                numInput1 = Console.ReadLine ();
                double cleanNum1 = 0;
                while (!double.TryParse (numInput1, out cleanNum1)) {
                    Console.WriteLine ("This is not valid input. Please enter an integer value:");
                    numInput1 = Console.ReadLine ();
                }

                Console.WriteLine ("type another number, and press Enter");
                numInput2 = Console.ReadLine ();
                double cleanNum2 = 0;
                while (!double.TryParse (numInput2, out cleanNum2)) {
                    Console.WriteLine ("This is not valid input. Please enter an integer value:");
                    numInput2 = Console.ReadLine ();
                }

                Console.WriteLine ("choose an option from the following list:");
                Console.WriteLine ("\ta - add");
                Console.WriteLine ("\ts - subtract");
                Console.WriteLine ("\tm - multiply");
                Console.WriteLine ("\td - divide");
                Console.WriteLine ("your option?");

                string op = Console.ReadLine ();

                try {
                    result = Calculator.DoOperation (cleanNum1, cleanNum2, op);
                    if (double.IsNaN (result)) {
                        Console.WriteLine ("This operation will result in a mathematical error.\n");
                    } else {
                        Console.WriteLine ("Your result: {0:0.##}\n",result);
                    }
                } catch (Exception e) {
                    Console.WriteLine ("Oh no! An exception occurred trying to do the math.\n - Details:" + e.Message);
                }
                Console.WriteLine ("----------------------\n");
            }
            return;
        }
    }
}