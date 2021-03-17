using System;
using System.Collections.Generic;

namespace TWOA_LW3
{
    static class Program
    {
        private static readonly Dictionary<TriangleType, string> ResultMessage = new Dictionary<TriangleType, string>()
        {
            { TriangleType.Incorrect, "неправильный" },
            { TriangleType.Scalene, "неравносторонний" },
            { TriangleType.Isosceles, "равнобедренный" },
            { TriangleType.Equilateral, "равносторонний" },
        };

        static void Main()
        {
            try
            {
                int[] sides = new int[3];
                bool isInvalidSides = false;
                for (int index = 0; index < 3; index++)
                {
                    Console.WriteLine($"Введите число №{index + 1}:");
                    string str = Console.ReadLine();
                    isInvalidSides |= !(int.TryParse(str, out sides[index]));
                }

                if (isInvalidSides)
                {
                    Console.WriteLine("Введённые значения не являются целыми числами из диапазона [1..2147483647].");
                }

                TriangleType result = Triangle.CheckTypeOfTriangle(sides);
                Console.WriteLine($"Результат: треугольник {ResultMessage[result]}.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
