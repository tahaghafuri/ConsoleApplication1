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
            string str="";
            try
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Enter To Echo:");
                Console.ResetColor();
                str = Convert.ToString(Console.ReadLine());
                str = str.ToLower();
            }
            catch(FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            finally {
                Console.WriteLine("Finally");
            }
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
