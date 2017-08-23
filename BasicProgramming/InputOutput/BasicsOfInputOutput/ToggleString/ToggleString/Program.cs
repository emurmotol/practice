using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToggleString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] s = input.ToCharArray();

            for (int i = 0; i < s.Length; i++)
            {
                char letter = s[i];

                if (char.IsUpper(letter))
                {
                    Console.Write(char.ToLower(letter));
                    continue;
                }
                Console.Write(char.ToUpper(letter));
            }
            Console.ReadKey();
        }
    }
}
