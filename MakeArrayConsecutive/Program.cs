using System;

namespace MakeArrayConsecutive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArr = new int[] { 0, 3 };
            var count = makeArrayConsecutive2(testArr);
            Console.WriteLine(count);
        }

        static int makeArrayConsecutive2(int[] statues)
        {
            var count = 0;
            Array.Sort(statues);
            for(int i= 0;i<statues.Length - 1; i++)
            {
                if(statues[i+1] - statues[i] > 1)
                {
                    count += statues[i + 1] - statues[i] - 1;
                }
            }

            return count;
        }

    }
}
