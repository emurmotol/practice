using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeatingArrangement
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int n = Int32.Parse(Console.ReadLine());
                int x, k, l;

                k = (n - 1) / 12;
                l = (n - 1) % 12;

                x = 12 * (k + 1) - l;

                if (n % 6 == 0 || n % 6 == 1)
                {
                    Console.WriteLine(x + " WS");
                }
                else if (n % 6 == 2 || n % 6 == 5)
                {
                    Console.WriteLine(x + " MS");
                }
                else
                {
                    Console.WriteLine(x + " AS");
                }
            }
            Console.ReadKey();
        }
    }
}
