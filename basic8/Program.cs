using System;
using PrivateRectangleApp;
//当两个cs文件在同一文件夹下 命名空间不一样的时候需要使用using引用

namespace RectangleApp
{
    class Rectangle
    {
        public double length;
        public double width;
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("长度：{0}",length);
            Console.WriteLine("宽度：{0}",width);
            Console.WriteLine("面积：{0}",GetArea());
        }
        
    }

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.length = 4.5;
            r.width = 3.5;
            Console.WriteLine("public 矩形");
            r.Display();
            PrivateRectangle re = new PrivateRectangle();
            Console.WriteLine("private 矩形");
            re.Acceptdetails();
            re.Display();
        }
    }
}
