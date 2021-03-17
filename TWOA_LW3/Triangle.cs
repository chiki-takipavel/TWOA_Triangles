using System;
using System.Linq;

namespace TWOA_LW3
{
    public enum TriangleType
    {
        Incorrect,
        Scalene,
        Isosceles,
        Equilateral,
    }

    public static class Triangle
    {
        public static TriangleType CheckTypeOfTriangle(params int[] sides)
        {
            if (sides is null)
            {
                throw new ArgumentNullException(nameof(sides));
            }

            if (sides.Length != 3)
            {
                throw new ArgumentException("Количество сторон должно ровняться 3.", nameof(sides));
            }

            if (sides.Any(x => x <= 0))
            {
                throw new ArgumentOutOfRangeException(nameof(sides), "Сторона треугольника должна быть целым числом из диапазона [1..2147483647].");
            }

            if (!IsTriangle(sides[0], sides[1], sides[2]))
            {
                return TriangleType.Incorrect;
            }

            if (IsEquilateral(sides[0], sides[1], sides[2]))
            {
                return TriangleType.Equilateral;
            }

            if (IsIsosceles(sides[0], sides[1], sides[2]))
            {
                return TriangleType.Isosceles;
            }

            return TriangleType.Scalene;
        }

        private static bool IsTriangle(int a, int b, int c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        private static bool IsEquilateral(int a, int b, int c)
        {
            return (a == c) && (a == b);
        }

        private static bool IsIsosceles(int a, int b, int c)
        {
            return (a == b) || (a == c) || (b == c);
        }
    }
}
