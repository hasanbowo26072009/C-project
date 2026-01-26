using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main()
        {
            Console.Write("Masukan sebuah bilangan : ");
            int bilangan = Convert.ToInt32(Console.ReadLine());

            if (bilangan > 0)
            {
                Console.WriteLine("Hasil : Bilangan tersebut adalah POSITIF (+)");
                if (bilangan >= 10)
                {
                    Console.WriteLine("Lebih dari 10");
                }
                else
                {
                    Console.WriteLine("kurang dari 10");
                }
            }
            else if (bilangan == 0)
            {
                Console.WriteLine("Hasil : Bilangan tersebut adalah Nol (0)");
            }
            else
            {
                Console.WriteLine("Hasil : Bilangan tersebut adalah NEGATIF (-)");
            }
        }
    }
}