using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t8._3
{
    internal class Program
    {
        public static int Max(int a, int b)
        {
            return (a > b) ? a : b;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter d: ");
            int d = Convert.ToInt32(Console.ReadLine());

            //int s = Max(a, b) + Max(c, d);
            //Console.Write(s);
            int s = Max(a, 2 * b) + Max(2 * a - b, b);
            Console.Write(s);
            Console.ReadKey();
        }
    }
}
