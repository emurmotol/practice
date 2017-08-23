using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int fact = 1;
            int n = Int32.Parse(Console.ReadLine());

            for (int i = n; i > 0; i--)
            {
                fact = fact * i;
            }
            Console.Write(fact);
            Console.ReadLine();
        }
    }
}
