using System;

namespace AdjacentElementsProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 6, -2, -5, 7, 3 };
            Console.WriteLine(adjacentElementsProduct(array));
        }
        static int adjacentElementsProduct(int[] inputArray)
        {
            int max = inputArray[0] * inputArray[1];
            for(int i = 0; i< inputArray.Length - 1; i++)
            {
                var produce = inputArray[i] * inputArray[i + 1];
                if (produce > max)
                    max = produce;
            }

            return max;
        }

    }
}
