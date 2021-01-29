using System;
using System.Linq;

namespace Test_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
            int[] leftArr = new int[nLines];
            int[] rightArr = new int[nLines];

            for (int i = 1; i <= nLines; i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                if (i % 2 != 0)  //if we are on odd Row
                {
                    leftArr[i - 1] = numbers[0];
                    rightArr[i - 1] = numbers[1];
                }
                else // if we are on even row .. i % 2 == 0
                {
                    leftArr[i - 1] = numbers[1];
                    rightArr[i - 1] = numbers[0];
                }
            }

            Console.WriteLine(string.Join(" ", leftArr));
            Console.WriteLine(string.Join(" ", rightArr));
        }
    }
}
