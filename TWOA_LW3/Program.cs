using System;

namespace TWOA_LW3
{
    static class Program
    {
        static void Main()
        {
            try
            {
                int[] sides = new int[3];
                bool isInvalidSides = false;
                for (int index = 0; index < 3; index++)
                {
                    Console.WriteLine($"Enter integer #{index + 1}:");
                    string str = Console.ReadLine();
                    isInvalidSides |= !(int.TryParse(str, out sides[index]));
                }

                if (isInvalidSides)
                {
                    Console.WriteLine("Entered values aren't integers in range [1..2147483647].");
                }

                Console.WriteLine($"Triangle is {Triangle.CheckTypeOfTriangle(sides)}.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
