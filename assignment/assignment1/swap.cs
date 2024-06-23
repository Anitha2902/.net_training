using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap
{
    class Program
    {
        private static int num1;
        private static int num2;

        static void Main(string[] args)
        {
            int temp;
            Console.WriteLine("enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swapping:");
            Console.WriteLine("first number:" + num1);
            Console.WriteLine("second number:" + num2);

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("after swapping:");
            Console.WriteLine("first number:" + num1);
            Console.WriteLine("second number:" + num2);
            Console.Read();
        }
    }
}
