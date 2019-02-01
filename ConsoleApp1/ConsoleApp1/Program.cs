using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int t = 1; t <= T; t++)
            {
                ushort Snum = ushort.Parse(Console.ReadLine());
                if (PerfectSquare(Snum))
                {
                    Console.WriteLine($"Case {t}: YES", t);
                }
                else
                {
                    Console.WriteLine($"Case {t}: NO", t);
                }
            }
        }
        public static bool PerfectSquare(ushort n)
        {
            ushort root = (ushort)Math.Sqrt(n);
            return (int)Math.Pow(root, 2) == n;
        }
    }
}
