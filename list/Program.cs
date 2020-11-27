using System;
using System.Collections.Generic; //引入此项之后才能使用Lis<T>

namespace lists {
    class Program {
        static void Main (string[] args) {
            // var names = new List<string> { "AriesXmz", "Ana", "Felipe" };
            /* foreach (var name in names) {
                Console.WriteLine ($"Hello {name.ToUpper()}!");
            } */
            /* Console.WriteLine ();
            names.Add ("Maria");
            names.Add ("Bill");
            names.Remove ("Ana"); */
            /* foreach (var name in names) {
                Console.WriteLine ($"Hello {name.ToUpper()}!");
            } */
            /* Console.WriteLine ($"My name is {names[0]}");
            Console.WriteLine ($"I've added {names[2]} and {names[3]} to the list");
            Console.WriteLine ($"The list has {names.Count} people in it");
            var index = names.IndexOf ("Felipe");
            if (index != -1) {
                Console.WriteLine ($"The name {names[index]} is at index {index}");
            }
            var notFound = names.IndexOf ("Not Found");
            Console.WriteLine ($"When an item is not found, IndexOf returns {notFound}");

            names.Sort ();
            foreach (var name in names) {
                Console.WriteLine ($"Hello {name.ToUpper()}!");
            } */
            //斐波那契数列
            /* var fibonacciNumbers = new List<int> { 1, 1 };
            var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
            fibonacciNumbers.Add (previous + previous2);
            foreach (var item in fibonacciNumbers) {
                Console.WriteLine (item);
            } */

            /* See if you can put together some of the concepts from this and earlier lessons.
            Expand on what you've built so far with Fibonacci Numbers.
            Try and write the code to generate the first 20 numbers in the sequence.
            (As a hint, the 20th Fibonacci number is 6765.) */

            var fibonacciNumbers = new List<int> { 1, 1 };
            var pre = fibonacciNumbers[fibonacciNumbers.Count - 1];
            var pre2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
            for (int i = 0; i < 18; i++) {
                fibonacciNumbers.Add (pre + pre2);
                pre = fibonacciNumbers[fibonacciNumbers.Count - 1];
                pre2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
            }
            foreach (var item in fibonacciNumbers) {
                Console.WriteLine (item);
            }

            //the answer
            /* var fibonacciNumbers = new List<int> { 1, 1 };

            while (fibonacciNumbers.Count < 20) {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add (previous + previous2);
            }
            foreach (var item in fibonacciNumbers) Console.WriteLine (item); */
        }
    }
}