using System;

namespace PrivateRectangleApp
{
    public class PrivateRectangle
    {
        private double length;
        private double width;
        public void Acceptdetails()
        {
            Console.WriteLine("请输入长度");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入宽度");
            width = Convert.ToDouble(Console.ReadLine());
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("长度：{0}", length);
            Console.WriteLine("宽度：{0}", width);
            Console.WriteLine("面积：{0}", GetArea());
        }
    }
}