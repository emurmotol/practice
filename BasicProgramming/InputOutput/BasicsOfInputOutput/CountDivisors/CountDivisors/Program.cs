using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDivisors
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
            int r = arr[1];
            int k = arr[2];
            int count = 0;

            for (int l = arr[0]; l <= r; l++)
            {
                if ((l % k) == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
