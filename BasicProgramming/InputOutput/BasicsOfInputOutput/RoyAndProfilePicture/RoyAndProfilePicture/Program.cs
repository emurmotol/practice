using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyAndProfilePicture
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = Int32.Parse(Console.ReadLine());
            int n = Int32.Parse(Console.ReadLine());
            List<int[]> photoDims = new List<int[]>();

            for (int i = 0; i < n; i++)
            {
                int[] photoDim = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
                photoDims.Add(photoDim);
            }

            for (int i = 0; i < photoDims.Count(); i++)
            {
                int w = photoDims[i][0];
                int h = photoDims[i][1];

                if (w < l || h < l)
                {
                    Console.WriteLine("UPLOAD ANOTHER");
                }
                else
                {
                    if (w == h)
                    {
                        Console.WriteLine("ACCEPTED");
                    }
                    else
                    {
                        Console.WriteLine("CROP IT");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
