using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j != 0)
                    {
                        count += 1;
                    }
                }

                if (count == (i - 2))
                {
                    Console.Write(i + " ");
                }
                count = 0;
            }
            Console.ReadKey();
        }
    }
}
