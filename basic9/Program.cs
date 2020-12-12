using System;

namespace CalculatorApplication {
    class NumberManipulator {
        public int FindMax (int num1, int num2) {
            int result;
            if (num1 > num2)
                result = num1;
            else
                result = num2;
            return result;
        }
        static void insideFun () {
            int a = 290;
            int b = 190;
            int result;
            NumberManipulator n = new NumberManipulator ();
            result = n.FindMax (a, b);
            Console.WriteLine ("最大值是{0}", result);
        }
        public int factorial (int num) {
            int result;
            if (num == 1) {
                return 1;
            } else {
                result = factorial (num - 1) * num;
            }
            return result;
        }
        public void swap (int x, int y) { //按值传参
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
        public void refSwap (ref int x, ref int y) { //按引用传递参数
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
        public void getValue (out int x) { //按输出传递参数
            int temp = 555;
            x = temp;
        }
        public void getNoValue (out int x, out int y) {
            Console.WriteLine ("输入一个整数");
            x = Convert.ToInt32 (Console.ReadLine ());
            Console.WriteLine ("输入另一个整数");
            y = Convert.ToInt32 (Console.ReadLine ());
        }
    }
    class Test {
        static void Main (string[] args) {
            int a = 100;
            int b = 200;
            int ret;
            NumberManipulator n = new NumberManipulator ();
            ret = n.FindMax (a, b);
            Console.WriteLine ("最大值：{0}", ret);
            Console.WriteLine ("6的阶乘是{0}", n.factorial (6));
            Console.WriteLine ("7的阶乘是{0}", n.factorial (7));
            int c = 222;
            int d = 333;
            Console.WriteLine ("按值传参交换之前的c是=>{0}", c);
            Console.WriteLine ("按值传参交换之前的d是=>{0}", d);
            n.swap (c, d);
            Console.WriteLine ("按值传参交换之后的c是=>{0}", c);
            Console.WriteLine ("按值传参交换之后的d是=>{0}", d);
            int e = 123;
            int f = 321;
            Console.WriteLine ("按引用传递参数交换之前的e是=>{0}", e);
            Console.WriteLine ("按引用传递参数交换之前的f是=>{0}", f);
            n.refSwap (ref e, ref f);
            Console.WriteLine ("按引用传递参数交换之后的e是=>{0}", e);
            Console.WriteLine ("按引用传递参数交换之后的f是=>{0}", f);
            int g = 158;
            Console.WriteLine ("按输出传递参数调用函数之前的g是=>{0}", g);
            n.getValue (out g);
            Console.WriteLine ("按输出传递参数调用函数之后的g是=>{0}", g);
            int aa, bb;
            n.getNoValue (out aa, out bb);
            Console.WriteLine ("按输出传递参数调用函数之后的aa=>{0},bb是=>{1}", aa, bb);
        }
    }
}