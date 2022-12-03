using System;

namespace lab2ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex 1: Scrieti un program care va afisa suma cifrelor unui numar n, n fiind citit de la tastatura.
            int n, suma = 0, m;

            Console.WriteLine("Introduceti un numar");

            n = int.Parse(Console.ReadLine());

            while (n>0)
            {
                m = n % 10;
                suma = suma + m;
                n = n / 10;
            }
            Console.WriteLine("Suma cifrelor este " + suma);

        }
    }
}
