using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Enter To Echo:");
            Console.ResetColor();
            string str = Convert.ToString(Console.ReadLine());
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
