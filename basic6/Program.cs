using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class ExcuteFactorial
    {
        static void Main(string[] args)
        {
            Factorial fc = new Factorial();
            Console.WriteLine("请输入一个整数");
            int result = fc.Factor(Convert.ToInt16(Console.ReadLine()));
            Console.WriteLine("result is {0}", result);
        }
    }

    class Factorial 
    {
        public int Factor(int num)
        {
            return num > 0 ? num * Factor(num - 1) : 1;
        }
    }
}
