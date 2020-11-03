using System;

namespace prgConvertitore
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int r;         
            string nconvertito = "";
            int divisore;
            Console.WriteLine("inserisci numero decimale senza virgola:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"inserisci il divisore:");
            divisore = Convert.ToInt32(Console.ReadLine());
            

            while (n > 0)
            {
                r = n % divisore;
                n = n / divisore;
                

                if (r == 10)
                {
                    nconvertito = "A" + nconvertito;
                }
                else if (r == 11)
                {
                    nconvertito = "B" + nconvertito;
                }
                else if (r == 12)
                {
                    nconvertito = "C" + nconvertito;
                }
                else if (r == 13)
                {
                    nconvertito = "D" + nconvertito;

                }
                else if (r == 14)
                {
                    nconvertito = "E" + nconvertito;
                }
                else if(r==15)
                {
                    nconvertito = "F" + nconvertito;

                }
                else
                {
                    nconvertito = Convert.ToString(r) + nconvertito;
                }



            }

            Console.WriteLine($"{nconvertito}");

            
        }
    }
}
