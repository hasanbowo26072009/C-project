 using System;
namespace Latihan4percabangan_Hasan_13
{
    class Program
    {
        static void Main(string[] args)
        {
 Console.Write("Masukan angka (1-7): ");
            int angka = int.Parse(Console.ReadLine());
            switch (angka)
            {
                case 1:
                    Console.WriteLine("Hari: senin");
                    break;
                case 2:
                    Console.WriteLine("Hari: selasa");
                    break;
                case 3:
                    Console.WriteLine("Hari: Rabu");
                    break;
                case 4:
                    Console.WriteLine("Hari: Kamis");
                    break;
                case 5:
                    Console.WriteLine("Hari: Jumat");
                    break;
                case 6:
                    Console.WriteLine("Hari: Sabtu");
                    break;
                case 7:
                    Console.WriteLine("Hari: Minggu");
                    break;
                default:
                    Console.WriteLine("Angka tidak valid. Masukkan angka 1-7.");
                    break;
            }
        }
    }
}
