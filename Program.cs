using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio24
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[10] {4, 5, 2, 6, 7, 10, 30, 15, 17, 3};
            int[] B = new int[10] {1, 6, 3, 5, 8, 9, 31, 16, 18, 2};

            int[] C = new int[10];

            for (int i = 0; i < 10; i++)
            {
                if (A[i] < B[i])
                {
                    C[i] = A[i];
                }
                else
                {
                    C[i] = B[i];
                }
            }

            for(int i=0; i<10; i++)
                Console.WriteLine(C[i]);

            Console.ReadKey();
        }
    }
}
