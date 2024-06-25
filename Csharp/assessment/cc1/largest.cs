using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace largest
{
    class largest
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LargestNumber(1, 2, 3));
            Console.WriteLine(LargestNumber(1, 3, 2));
            Console.WriteLine(LargestNumber(1, 1, 1));
            Console.WriteLine(LargestNumber(1, 2, 2));
            Console.ReadLine();
        }

        static int LargestNumber(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));

        }
    }
}
