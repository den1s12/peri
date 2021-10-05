using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2; int b = 3; int c = 4;
            if (Treug(a, b, c))
                Console.WriteLine($"Периметр треугольника {PeriTreug(a, b, c)}");
            Console.WriteLine($"Площадь треугольника {SquaTreug(a, b, c)}");

        }
        static bool Treug(int a, int b, int c)
        {
            if ((a + b > c) && (a + c > b) && (c + b > a))
                return true;
            else
                return false;
        }
        static int PeriTreug(int a, int b, int c)
        {
            return a + b + c;

        }
        static Double SquaTreug(int a, int b, int c)
        {
            float ppp = PeriTreug(a, b, c);
            ppp /= 2;
            return Math.Sqrt(ppp * (ppp - a) * (ppp - b) * (ppp - c));
        }
    }
}
