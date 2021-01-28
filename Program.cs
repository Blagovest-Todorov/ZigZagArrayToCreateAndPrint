using System;
using System.Linq;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int nRow = int.Parse(Console.ReadLine());  //We  read number

            int[] firstArr = new int[nRow];         // we create two int array ;
            int[] secArr = new int[nRow];

           

            for (int i = 1; i <= nRow; i++)
            {
                string[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray(); // we read form console the string , we remove the intervals
                                                                        // We push strings into array of strings/
                if (i % 2 != 0) // Odd Row
                {
                    firstArr[i - 1] = int.Parse(line[line.Length - 2]);
                    secArr[i - 1] = int.Parse(line[line.Length-1]);
                }
                else // if i % 2 == 0 -> Even Row;
                {
                    firstArr[i - 1] = int.Parse(line[line.Length-1]);
                    secArr[i - 1] = int.Parse(line[line.Length-2]);
                }
            }

            Console.WriteLine();
            Console.WriteLine(string.Join(" ", firstArr));
            Console.WriteLine();
            Console.WriteLine(string.Join(" ", secArr));
        }
    }
}
