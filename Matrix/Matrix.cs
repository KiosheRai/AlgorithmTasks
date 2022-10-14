using System;
using System.Security.Cryptography;

namespace Matrix
{
    internal class Matrix
    {
        private readonly int _n;
        private int[,] matrix;

        public Matrix(int n)
        {
            if (n <= 0) throw new ArgumentException("Incorrect matrix size");
            this._n = n;
            Init();
        }

        private void Init()
        {
            matrix = new int[_n, _n];

            using (var rg = new RNGCryptoServiceProvider())
            {
                for (int i = 0; i < _n; i++)
                {
                    for (int j = 0; j < _n; j++)
                    {
                        byte[] rno = new byte[5];
                        rg.GetBytes(rno);
                        matrix[i, j] = BitConverter.ToInt32(rno, 0) % 100;
                    }
                }
            }
        }

        public void WriteMartix()
        {
            for(int i = 0; i < _n; i++)
            {
                for (int j = 0; j < _n; j++)
                    Console.Write("{0,5}", matrix[i, j]);
                
                Console.WriteLine();
            }
        }

        public int GetSum()
        {
            int sum = 0;
            for (int i = 0; i < _n; i++)
                sum += matrix[i, i];
            
            return sum;
        }

        public int GetMultiplesOf3()
        {
            int sum = 0;
            foreach (var x in matrix)
                sum += x % 3 == 0 ? x : 0;

            return sum;
        }
    }
}
