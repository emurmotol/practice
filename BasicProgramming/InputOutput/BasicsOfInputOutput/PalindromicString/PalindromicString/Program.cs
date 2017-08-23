using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromicString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] s = input.ToCharArray();
            Array.Reverse(s);

            if (string.Join("", s) == input)
            {
                Console.Write("YES");
            }
            else
            {
                Console.Write("NO");
            }
            Console.ReadKey();
        }
    }
}
