using System;

namespace DecisionMaking {
    class Program {
        static void Main (string[] args) {
            int a;
            Console.WriteLine ("请输入一个整数");
            a = Convert.ToInt16 (Console.ReadLine ());
            if (a < 20) {
                Console.WriteLine ("a 小于20");
            } else if (a == 20) {
                Console.WriteLine ("a 等于 20");
            } else {
                Console.WriteLine ("a 大于 20");
            }
        }
    }
}