using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadicalSimplifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the power: ");
            int power = int.Parse(Console.ReadLine());
            Console.Write("Enter the number: ");
            int baseNumber = int.Parse(Console.ReadLine());
            double remainder = 0;
            int highestFactor = 0;

            for (int i = 2; Math.Pow(i, power) <= baseNumber; i++)
            {
                if (baseNumber % Math.Pow(i, power) == 0)
                {
                    highestFactor = i;
                    remainder = Math.Round(baseNumber / Math.Pow(i, power));
                }
            }
            
            if (remainder > 1)
            {
                Console.OutputEncoding = Encoding.Unicode;
                Console.WriteLine(highestFactor + "\u221A" + remainder);
            }
            else if (highestFactor == 0)
            {
                Console.OutputEncoding = Encoding.Unicode;
                Console.WriteLine("\u221A" + baseNumber);
            }
            else
            {
                Console.WriteLine(highestFactor);
            }
            Console.ReadLine();
        }
    }
}