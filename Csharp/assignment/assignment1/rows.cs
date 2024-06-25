using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rows
{
    class rows
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a digit: ");
            string input = Console.ReadLine();

            //Displaying the number four times with spaces in between
            Console.WriteLine($"{input} {input} {input} {input}");

            //Displaying the number four times without spaces
            Console.WriteLine($"{input}{input}{input}{input}");

            //Repeating the display
            Console.WriteLine($"{input} {input} {input} {input}");
            Console.WriteLine($"{input}{input}{input}{input}");
            Console.Read();
        }
    }

}
    
