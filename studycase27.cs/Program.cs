using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Merk_Baju
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("=== Pilih merk baju ===");
            Console.Write("Masukkan merk baju anda H&M/UNIQLO/ZARA  : ");
            string merk = Console.ReadLine();
            Console.Write("Masukkan ukuran baju anda (S, M, L, XL) : ");
            string ukuran = Console.ReadLine();

            int harga = 0;

            if (merk == "H&M")
            {
                    if (ukuran == "S")
                        harga = 49000;
                    else if (ukuran == "M")
                        harga = 54000;
                    else if (ukuran == "L")
                        harga = 59000;
                    else if (ukuran == "XL")
                        harga = 69000;
                    else 
                        Console.WriteLine("Ukuran baju tidak tersedia.");  
            }
            else if (merk == "UNIQLO")
            {
                    if (ukuran == "S")
                        harga = 44000;
                    else if (ukuran == "M")
                        harga = 49000;
                    else if (ukuran == "L")
                        harga = 54000;
                    else if (ukuran == "XL")
                        harga = 64000;
                    else
                        Console.WriteLine("Ukuran baju tidak tersedia.");
            }
            else if (merk == "ZARA")
            {
                    if (ukuran == "S")
                        harga = 69000;
                    else if (ukuran == "M")
                        harga = 74000;
                    else if (ukuran == "L")
                        harga = 79000;
                    else if (ukuran == "XL")
                        harga = 84000;
                    else
                        Console.WriteLine("ukuran baju tidak tersedia");
            }
            else
            {
                Console.WriteLine("Merk baju tidak tersedia.");
            }
            Console.WriteLine("===============");
            Console.WriteLine("merk     : " + merk);
            Console.WriteLine("ukuran   : " + ukuran);
            Console.WriteLine("harga    : " + harga);
            Console.WriteLine("===============");*/

            Console.WriteLine("=== Pilih merk baju ===");
            Console.Write("Masukkan merk baju anda H&M/UNIQLO/ZARA  : ");
            string merk = Console.ReadLine();
            Console.Write("Masukkan ukuran baju anda (S, M, L, XL) : ");
            string ukuran = Console.ReadLine();

            int harga = 0;

            switch (merk)
            {
                case "H&M":
                    switch (ukuran)
                    {
                        case "S":
                            harga = 49000;
                            break;
                        case "M":
                            harga = 54000;
                            break;
                        case "L":
                            harga = 59000;
                            break;
                        case "XL":
                            harga = 69000;
                            break;
                        default:
                            Console.WriteLine("Ukuran baju tidak tersedia.");
                            break;
                    }
                    break;

                case "UNIQLO":
                    switch (ukuran)
                    {
                        case "S":
                            harga = 44000;
                            break;
                        case "M":
                            harga = 49000;
                            break;
                        case "L":
                            harga = 54000;
                            break;
                        case "XL":
                            harga = 64000;
                            break;
                        default:
                            Console.WriteLine("Ukuran baju tidak tersedia.");
                            break;
                    }
                    break;

                case "ZARA":
                    switch (ukuran)
                    {
                        case "S":
                            harga = 69000;  
                            break;
                        case "M":
                            harga = 74000;
                            break;
                        case "L":
                            harga = 79000;
                            break;
                        case "XL":
                            harga = 84000;
                            break;
                        default:
                            Console.WriteLine("Ukuran baju tidak tersedia.");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Merk baju tidak tersedia.");
                    break;
            }
            Console.WriteLine("===============");
            Console.WriteLine("merk     : " + merk);
            Console.WriteLine("ukuran   : " + ukuran);
            Console.WriteLine("harga    : " + harga);
            Console.WriteLine("===============");

        }
    }

}