using System;

namespace PI_Zadanie_4
{
    class Program
    {
        static void Main()
        {

            int n = 10, i, j;

            int[,] a = new int[n, n]; //Tablica Mnożenia A.
            int[,] b = new int[n, n]; //Tablica Mnożenia B.
            int[,] c = new int[n, n];   //Tablica Mnożenia C.



            Console.WriteLine("Tablica mnożenia A");

            for (i = 0; i < n; i++)

                for (j = 0; j < n; j++)
                {
                    a[i, j] = (i + 1) * (j + 1);

                    Console.Write(a[i, j]);

                    if (j < 9) Console.Write("\t");

                    else Console.WriteLine();

                }



            Console.WriteLine("Tablica mnożenia B");

            for (i = 0; i < n; i++)

                for (j = 0; j < n; j++)
                {
                    b[i, j] = (i + 1) * (j + 1);

                    Console.Write(b[i, j]);

                    if (j < 9) Console.Write("\t");

                    else Console.WriteLine();

                }



            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    c[i, j] = 0;

                    for (int k = 0; k < n; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];


                    }

                }
            }
            Console.WriteLine("\n\n\n\n");



            Console.WriteLine("Macierz Tablica C = Tablica A * Tablica B");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(c[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.Read();



            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    c[i, j] = 0;

                    for (int k = 0; k < n; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
        }

    }
}
