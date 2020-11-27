using System;

namespace basic1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 42;
            int b = 119;
            int c = a + b;
            int d = a - b;
            float e = a * b;
            double f = a / b;
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.ReadKey();//等待用户按下任意按键，每次读取一个字符
        }
    }
}
