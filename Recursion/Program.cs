using System;

namespace Recursion
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Input number: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Fiban(n));

            Console.WriteLine("Input number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input power: ");
            int an = int.Parse(Console.ReadLine());

            Console.WriteLine("Result: " + Pow(a,an));
        }

        static int Fiban(int n)
        {
            if (n <= 0) throw new ArgumentException("Incorrect number");
            if (n == 1 || n == 2) return 1;
            else return Fiban(n - 1) + Fiban(n - 2);
        }

        static double Pow(int a, int n)
        {
            if (n == 0) return 1;
            if (n < 0) return 1d / a * Pow(a, ++n);
            return a * Pow(a, --n);
        }
    }
}
