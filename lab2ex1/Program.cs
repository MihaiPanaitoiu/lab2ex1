using System;

namespace lab2ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex 1: Scrieti un program care va afisa suma cifrelor unui numar n, n fiind
                    citit de la tastatura.
             */

            Console.WriteLine("Numarul n este: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            while (n > 0)
            {
                sum = sum + n % 10;
                n = n / 10;
            }

            Console.WriteLine("Suma cifrelor numarului este: " + sum);
        }
    }
}
