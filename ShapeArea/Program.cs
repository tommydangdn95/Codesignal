using System;

namespace ShapeArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(shapeArea(4));
        }

        static int shapeArea(int n)
        {
            return (n * n) + (n - 1) * (n - 1);
        }

    }
}
