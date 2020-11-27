using System;

namespace DataTypeApplication {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("size of int: {0}", sizeof (int));
            Console.WriteLine ("size of bool: {0}", sizeof (bool));
            Console.WriteLine ("size of char: {0}", sizeof (char));
            Console.WriteLine ("size of double: {0}", sizeof (double));
            Console.WriteLine ("size of float: {0}", sizeof (float));
            Console.WriteLine ("size of long: {0}", sizeof (long));
            Console.WriteLine ("size of short: {0}", sizeof (short));
            Console.WriteLine ("Hello World!");
            packing ();
            trends ();
        }
        // 要使用Class非静态成员，必须先实例化Class
        // 注意：变量引用类型的
        // 如果不实例化Class，调用非静态成员时就会出错！
        public static void packing () {
            Object obj;
            obj = 100;
            Console.WriteLine ("obj=>{0}", obj);
        }
        public static void trends () {
            dynamic a = 20;
            Console.WriteLine ("dynamic=>{0}", a);
        }
    }
}