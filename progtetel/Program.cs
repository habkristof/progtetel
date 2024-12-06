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
            for (i = 0; i < x.Length; i++)
            {
                if (x[i] % 2 == 0)
                {
                    paros_szamok[db] = x[i];
                    db++;
                }
            }
            Console.WriteLine("Maximum kiválasztás:");
            for (i = 0; i < db; i++)
            {
                Console.WriteLine(paros_szamok[i]);
            }


       
            // Maximum kiválasztás - 2
            int n = x.Length;

            int maxi = 0;
            for (i = 0; i < n; i++)
            {
                if (x[i] > x[maxi])
                {
                    maxi = i;
                }
            }

            Console.WriteLine($"Legnagyobb számok: {maxi + 1}. helyen, {x[maxi]}");


            Console.ReadKey();
        }
    }
}
