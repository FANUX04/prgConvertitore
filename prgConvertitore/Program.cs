using System;

namespace prgConvertitore
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int r;
            string nconvertito="";
            int divisore;
            Console.WriteLine("inserisci numero decimale senza virgola:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inserisci il divisore (2)");
            divisore = Convert.ToInt32(Console.ReadLine());

            while(n>0)
            {
                r = n % divisore;
                n = n / 2;
                nconvertito = Convert.ToString(r) + nconvertito;
            }
            Console.WriteLine($"{nconvertito}");
        }
    }
}
