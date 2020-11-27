using System;

namespace basic2 {
    class Program {
        static void Main (string[] args) {
            //int 类型
            /* int a = 7, b = 4, c = 3;
            int f = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine (f);
            double e = (a + b) / c;
            int d = (a + b) % c;
            Console.WriteLine ($"quotient:  {e}");
            Console.WriteLine ($"remainder: {d}");

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine ($"The range of integers is {min} to {max}");

            int what = max + 3;
            Console.WriteLine ($"An example of overflow: {what}"); */
            //double 类型
            /* double a = 19, b = 23, c = 8;
            double d = (a + b) / c;
            Console.WriteLine ($"type of double: {d}");

            double max = double.MaxValue, min = double.MinValue;
            Console.WriteLine ($"The range of double is {min} to {max}");

            double third = 1.0 / 3.0;
            Console.WriteLine (third);
            double third1 = 3.0 / 10;
            Console.WriteLine (third1);
            double third2 = 33.0 / 100;
            Console.WriteLine (third2); */
            //decimal 
            /* decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min} to {max}");

            double a = 1.0,b = 3.0;
            Console.WriteLine(a/b);

            decimal c = 1.0M,d = 3.0M;
            Console.WriteLine(c/d); */
            //circle
            /* double radius = 2.50;
            double area = Math.PI * radius * radius;
            Console.WriteLine(Math.PI);
            Console.WriteLine(area); */

            int a, b = 2;
            a = 7;
            int i = 1, c;
            while (true) {
                b += a;
                c = (a + b) * (a - b);
                i++;
                if (c >= 3968036) {
                    Console.WriteLine ("{0} {1}", i, c);
                    break;
                }
            }
        }
    }
}