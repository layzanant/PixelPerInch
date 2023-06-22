using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelApp
{
    public static class PixelCalc
    {
        public static void EnterDimensions()
        {
            int width, height, diagonalSize;

            Console.Write("Enter Screen width (in pixels): ");
            if (!int.TryParse(Console.ReadLine(), out width))
            {
                Console.WriteLine("Invalid input for width. Please enter integer.");
                return;
            }

            Console.Write("Enter Screen height (in pixels): ");
            if (!int.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("Invalid input for height. Please enter integer.");
                return;
            }

            Console.Write("Enter Diagonal size (in inches): ");
            if (!int.TryParse(Console.ReadLine(), out diagonalSize))
            {
                Console.WriteLine("Invalid input for Diagonal size. Please enter integer.");
                return;
            }

            int diagonalPixels = CalculateDiagonalPix(width, height, diagonalSize);
            double ppi = CalculatePPI(width, height, diagonalPixels);
            double dotPitch = CalculateDotPitch(width, height, diagonalPixels);

            Console.WriteLine("PPI: " + ppi);
            Console.WriteLine("Diagonal (in pixels): " + diagonalPixels);
            Console.WriteLine("Dot pitch: " + dotPitch);
        }

        public static int CalculateDiagonalPix(int width, int height, int diagonalSize)
        {
            double diagonalPixelsSquared = Math.Pow(width, 2) + Math.Pow(height, 2);
            double diagonalPixels = Math.Sqrt(diagonalPixelsSquared);
            return (int)Math.Round(diagonalPixels);
        }

        public static double CalculatePPI(int width, int height, int diagonalPixels)
        {
            double diagonalInches = diagonalPixels / (Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2)));
            return diagonalPixels / diagonalInches;
        }

        public static double CalculateDotPitch(int width, int height, int diagonalPixels)
        {
            double diagonalInches = diagonalPixels / (Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2)));
            return diagonalInches / Math.Sqrt(width * width + height * height);
        }
    }
}
