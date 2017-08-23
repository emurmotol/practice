using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            long answer = 1;
            int n = Int32.Parse(Console.ReadLine());
            int[] a = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
            double ten = Convert.ToDouble(10);
            double nine = Convert.ToDouble(9);
            double seven = Convert.ToDouble(7);
            int mod = Convert.ToInt32(Math.Pow(ten, nine) + seven);

            for (var i = 0; i < n; i++)
            {
                answer = (answer * a[i]) % mod;
            }
            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}
