using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compiiler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to write C# code");
            Console.WriteLine("Press F5 to compile code");
            Console.WriteLine("Press Escape to EXIT");

            Console.WriteLine("Enter your option: ");
            int A = '1';
            int CHOICE = (int)Console.Read();

            if (CHOICE == '1')
            {
                Console.Clear();
                writecode();

            }
            else
            {
                Console.WriteLine(" wrong choice: ");
            }
            Console.Read();

        }

        public static void writecode()
        {
            string input = "";
            Console.WriteLine("Enter your code: ");
            input = input + Console.ReadLine();
            ConsoleKey readKey = Console.ReadKey().Key;
            if (readKey == ConsoleKey.F5)
            {
                Console.WriteLine(input);
            }
            else if (readKey == ConsoleKey.Escape)
            {
                return;
            }
            input = input + Console.ReadLine();

        }
    }
}
