using System;

namespace banchAndLoop {
    class Program {
        static void Main (string[] args) {
            /* int a = 5;
            int b = 3;
            if(a + b > 10) Console.WriteLine("The answer is greater than 10");
            else Console.WriteLine("The answer is less than 10"); */

            /* int a = 5, b = 4, c = 5;
            if (a + b + c > 10 && a == b) {
                Console.WriteLine ("The answer is greater than 10");
                Console.WriteLine ("And the first number is equal to the second");
            } else {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            } */

            /* int a = 5,b=4,c=2;
            if(a+b+c > 10 || a == b){
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("or the first number is equal to the second");
            }else {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not equal to the second");
            } */

            // int counter = 5;
            // while (counter < 5) {
            //     Console.WriteLine ($"Hello World! The counter is {counter}");
            //     counter++;
            // }
            // Console.WriteLine($"At last,the counter is {counter}");

            /* int counter = 5;
            do {
                Console.WriteLine ($"Hello World! The counter is {counter}");
                counter++;
            } while (counter < 5);
            Console.WriteLine ($"At last,the counter is {counter}"); */

            /* int counter = 0;
            for (; counter < 10; counter++) {
                Console.WriteLine ($"Hello World!The counter is {counter}");
            }
            Console.WriteLine($"At last,the counter is {counter}"); */

            /* for (int row = 1; row < 11; row++) {
                Console.WriteLine ($"The row is {row+1}");
            }

            for (char column = 'a'; column < 'k'; column++) {
                Console.WriteLine ($"The column is {column}");
            }

            for (int row = 1; row < 11; row++) {
                for (char column = 'a'; column < 'k'; column++) {
                    Console.WriteLine ($"The cell is ({row},{column})");
                }
            } */

            /* 既然您已经了解了c#语言中的if语句和循环结构，
            那么看看您是否可以编写c#代码来查找所有从1到20可以被3整除的整数的和。
            这里有一些提示:%操作符给出除法操作的余数。
            if语句为您提供了条件，以确定一个数字是否应该成为和的一部分。
            for循环可以帮助您为所有数字1到20重复一系列步骤。您可以自己试试。
            然后看看你做得怎么样。作为提示，答案应该是63。 */

            int result = 0;
            for (int i = 1; i <= 20; i++) {
                if(i % 3 == 0){
                    result += i;
                }
            }
            Console.WriteLine(result);
        }
    }
}