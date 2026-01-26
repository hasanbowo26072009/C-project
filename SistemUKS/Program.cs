using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System;

namespace Sistem_UKS
{
    class Program
    {
        static void Main(string[] args)
        {
            RuangPeriksa ruang_periksa1 = new RuangPeriksa();
            ruang_periksa1.cekData();
            Console.WriteLine();
            Logistik logistik1 = new Logistik();
            logistik1.cekData();
            Console.WriteLine();
            Petugas petugas1 = new Petugas();
            petugas1.cekData();
            Console.WriteLine();
            Toilet toilet1 = new Toilet();
            toilet1.cekData();
            Console.WriteLine();
            Pasien pasien1 = new Pasien();
            pasien1.cekData();

        }
    }
}
