using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelApp
{
    internal class Program
    {
        static void Main()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Enter Screen dimensions");
                Console.WriteLine("2. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        PixelCalc.EnterDimensions();
                        break;
                    case "2":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
