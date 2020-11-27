using System;

namespace TypeConversionApplication {
    class ExplicitConversion {
        static void Main (string[] args) {
            double d = 5673.34;
            int i;
            //强制转换double为int
            i = (int) d;
            Console.WriteLine (i);
            StringConversion.strCon ();
            Console.WriteLine (Definition.def ());
            EscaperChar.esc ();
            ConstClass.constTest ();
        }
    }
    /*静态方法与非静态方法的区别：
    1.静态方法属于类所有，类实例化前就可以使用；
    2.非静态方法可以访问类中任何成员，静态方法只能访问类中的静态成员；
    3.静态方法在类实例化前就可以使用，而类中的非静态变量必须在实例化后才能分配内存；
    4.static内部只能出现static变量和其他static方法，而且static方法不能使用this关键字，因为它属于整个类
    */
    class StringConversion {
        public static void strCon () {
            int i = 75;
            float f = 53.005f;
            double d = 2345.7652;
            bool b = true;
            Console.WriteLine (i.ToString ());
            Console.WriteLine (f.ToString ());
            Console.WriteLine (d.ToString ());
            Console.WriteLine (b.ToString ());
        }
    }

    class Definition {
        public static string def () {
            int i = 1, j = 2, k = 3;
            float f = 4.0f;
            double d = 3.1415926;
            char c = '中', ch = '国';
            string s;
            s = "string";
            Console.WriteLine ("{0} {1} {2} {3} {4} {5} {6}", i, j, k, f, d, c, ch);
            return s;
        }
    }

    class EscaperChar {
        public static void esc () {
            string a = "hello, world";
            string b = @"hello, world";
            string c = "hello \t world";
            string d = @"hello \t world";
            string e = "Joe said \"Hello\" to me";
            string f = @"Joe said ""Hello"" to me";
            string g = "\\\\server\\share\\file.txt";
            string h = @"\\server\\share\\file.txt";
            string i = "one\r\ntwo\r\nthree";
            string j = @"one
two
three";
            Console.WriteLine ("Hello\tWorld\n\n");
            Console.WriteLine ("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", a, b, c, d, e, f, g, h, i, j);
        }
    }

    class SampleClass {
        public int x;
        public int y;
        public const int c1 = 5;
        public const int c2 = c1 + 5;

        public SampleClass (int p1, int p2) {
            x = p1;
            y = p2;
        }
    }

    //命名空间不能直接包含字段或方法之类的成员
    class ConstClass {
        public static void constTest () {
            SampleClass mc = new SampleClass (11, 22);
            Console.WriteLine ("x = {0}, y = {1}", mc.x, mc.y);
            Console.WriteLine ("c1 = {0}, c2 = {1}", SampleClass.c1, SampleClass.c2);
        }
    }
}