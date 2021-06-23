using System;

namespace pointIt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Point p1 = new Point(47, 24);
            p1.moveX(12);
            p1.symX();
            float x = 20f / 3f;
            Console.WriteLine(x);
        }
    }
}
