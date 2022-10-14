using System;

namespace Matrix
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Print size of matrix: ");
            int n = int.Parse(Console.ReadLine());
          
            Matrix mat = new Matrix(n);
            mat.WriteMartix();

            Console.WriteLine("Sum of the main diagonal: " + mat.GetSum());
            Console.WriteLine("Sum of multiples of 3: " + mat.GetMultiplesOf3());
        }
    }
}
