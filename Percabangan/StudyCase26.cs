using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Latihan4percabangan_Hasan_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan tanggal lahir (1-31)");
            int tanggal = int.Parse(Console.ReadLine());
            Console.Write("Masukkan bulan lahir (1-12)");
            int bulan = int.Parse(Console.ReadLine());
            string zodiak = TentukanZodiak(tanggal, bulan);
            Console.WriteLine("zodiak kamu adalah: " + zodiak);
        }
        static string TentukanZodiak(int tanggal, int bulan)
        {
            if ((bulan == 1 && tanggal >= 20) || (bulan == 2 && tanggal <= 18))
                return "Aquarius";
            else if ((bulan == 2 && tanggal >= 19) || (bulan == 3 && tanggal <= 20))
                return "Pisces";
            else if ((bulan == 3 && tanggal >= 21) || (bulan == 4 && tanggal <= 19))
                return "Aries";
            else if ((bulan == 4 && tanggal >= 20) || (bulan == 5 && tanggal <= 20))
                return "Taurus";
            else if ((bulan == 5 && tanggal >= 21) || (bulan == 6 && tanggal <= 20))
                return "Gemini";
            else if ((bulan == 6 && tanggal >= 21) || (bulan == 7 && tanggal <= 22))
                return "Cancer";
            else if ((bulan == 7 && tanggal >= 23) || (bulan == 8 && tanggal <= 22))
                return "Leo";
            else if ((bulan == 8 && tanggal >= 23) || (bulan == 9 && tanggal <= 22))
                return "Virgo";
            else if ((bulan == 9 && tanggal >= 23) || (bulan == 10 && tanggal <= 22))
                return "Libra";
            else if ((bulan == 10 && tanggal >= 23) || (bulan == 11 && tanggal <= 21))
                return "Scorpio";
            else if ((bulan == 11 && tanggal >= 22) || (bulan == 12 && tanggal <= 21))
                return "Sagittarius";
            else if ((bulan == 12 && tanggal >= 22) || (bulan == 1 && tanggal <= 19))
                return "Capricorn";
            else
                return "Tanggal tidak valid";
        }
    }
}
    