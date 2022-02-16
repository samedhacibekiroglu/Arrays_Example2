using System;

namespace Arrays_Example2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] dizi = new int[20];
            int sayac = 0;
            Random rnd = new Random();

            for (int i = 0; i < 20; i++)
            {
                dizi[i] = rnd.Next(1, 100);
                if (dizi[i] < 50)
                {
                    Console.WriteLine("Dizinin {0}. elemanı = {1}", i, dizi[i]);
                    sayac++;
                }
            }
            Console.WriteLine("===================================");
            Console.WriteLine("50' den küçük sayı adeti : " + sayac);
            Console.ReadKey();

        }
    }
}
