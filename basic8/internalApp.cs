using System;

namespace InternalRectangleApp {
    class InternalRectangle {
        internal double length;
        internal double width;
        double GetArea () {
            return length * width;
        }
        public void Display () {
            Console.WriteLine ("internal 长度为{0}", length);
            Console.WriteLine ("internal 宽度为{0}", width);
            Console.WriteLine ("internal 面积为{0}", GetArea ());
        }
    }
    class ExecuteRectangle {
        static void main (string[] args) {
            InternalRectangle r = new InternalRectangle ();
            r.length = 4.5;
            r.width = 3.5;
            r.Display ();
            Console.WriteLine ("over");
        }
    }
}