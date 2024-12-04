using System;

namespace progtetel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 7, 2, -5, 12, 5, 1 };

            //Párosak kiválogatása - 1
            int[] paros_szamok = new int[100];
            int db = 0;
            int i;
            for (i = 0; 1 <= x.Length; i++)
            {
                if (x[i] % 2 == 0)
                {
                    paros_szamok[db] = x[i];
                    db++;
                }
            }
            for (i = 0; i < db; i++)
            {
                Console.WriteLine(paros_szamok[i] + " ");
            }

            // Maximum kiválasztás - 2
            int i;
            int n = x.Length;

            int maxi = 0;
            for (i = 0; i < n; i++)
            {
                if (x[i] > x[maxi])
                {
                    maxi = i;
                }
            }
            Console.WriteLine($"{maxi + 1}. , {x[maxi]}");


            Console.ReadKey();
        }
    }
}
