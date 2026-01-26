using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace latihan3Arithmatika_HasanNurAdhiWibowo._13
{
    class Program
    {
        static void Main(string[] args)
        {
            int bilangan1, bilangan2;
            bool bilangan3;
           
            Console.Write("masukan bilangan1    :   ");
            bilangan1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("masukan bilangan2    :   ");
            bilangan2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("masukan bilangan3    :   ");
            bilangan3 = Convert.ToBoolean(Console.ReadLine());
            Console.Write("masukan bilangan4    :   ");
            int tambah = bilangan1 + bilangan2;
            int kurang = bilangan1 - bilangan2;
            int bagi = bilangan1 / bilangan2;
            int kali = bilangan1 * bilangan2;
            bilangan1++;
            bilangan2--;
            Console.WriteLine("hasil tambah bilangan 1 dan bilangan 2   :" + tambah);
            Console.WriteLine("hasil kurang bilangan 1 dan bilangan 2   :" + kurang);
            Console.WriteLine("hasil bagi bilangan 1 dan bilangan 2     :" + bagi);
            Console.WriteLine("hasil kali bilangan 1 dan bilangan 2     :" + kali);
            Console.WriteLine("hasil increment dari bilangan1   :" + bilangan1);
            Console.WriteLine("hasil increment dari bilangan2   :" + bilangan2);
            Console.WriteLine();
        }
    }
}