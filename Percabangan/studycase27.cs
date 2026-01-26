using system;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Merk_Baju
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Pilih merk baju ===");
            Console.WriteLine("1. H&M");
            Console.WriteLine("2. UNIQLO");
            Console.WriteLine("3. ZARA");
            Console.Write("Masukkan merk baju anda : ");
            ToDowncase();
            Console.WriteLine("Masukkan ukuran baju anda (S, M, L, XL) : ");
            ToDowncase();
           string merk = Console.ReadLine();
           string ukuran = Console.ReadLine();

            if (merk == "H&M")
            {
                if (ukuran == "S" || ukuran == "M" || ukuran == "L" || ukuran == "XL")
                {
                    Console.WriteLine("Merk baju H&M dengan ukuran " + ukuran + " tersedia.");
                    if (ukuran == "S")
                    {
                        Console.WriteLine("Harga untuk ukuran S adalah Rp.49.000");
                    }
                    else if (ukuran == "M")
                    {
                        Console.WriteLine("Harga untuk ukuran M adalah Rp.54.000");
                    }
                    else if (ukuran == "L")
                    {
                        Console.WriteLine("Harga untuk ukuran L adalah Rp.59.000");
                    }
                    else if (ukuran == "XL")
                    {
                        Console.WriteLine("Hasrga untuk ukuran XL adalah Rp.69.000");
                    }
                    else
                    {
                        Console.WriteLine("Ukuran baju tidak tersedia.");
                    }
                }
                else
                {
                    Console.WriteLine("Ukuran baju tidak tersedia.");
                }
            }
            else if (merk == "Uniqlo")
            {
                if (ukuran == "S" || ukuran == "M" || ukuran == "L" || ukuran == "XL")
                {
                    Console.WriteLine("Merk baju Uniqlo dengan ukuran " + ukuran + " tersedia.");
                    if (ukuran == "S")
                    {
                        Console.WriteLine("Harga untuk ukuran S adalah Rp.44.000");
                    }
                    else if (ukuran == "M")
                    {
                        Console.WriteLine("Harga untuk ukuran M adalah Rp.49.000");
                    }
                    else if (ukuran == "L")
                    {
                        Console.WriteLine("Harga untuk ukuran L adalah Rp.54.000");
                    }
                    else if (ukuran == "XL")
                    {
                        Console.WriteLine("Hasrga untuk ukuran XL adalah Rp.64.000");
                    }
                    else
                    {
                        Console.WriteLine("Ukuran baju tidak tersedia.");
                    }
                }
                else
                {
                    Console.WriteLine("Ukuran baju tidak tersedia.");
                }
            }
            else if (merk == "Zara")
            {
                if (ukuran == "S" || ukuran == "M" || ukuran == "L" || ukuran == "XL")
                {
                    Console.WriteLine("Merk baju Zara dengan ukuran " + ukuran + " tersedia.");
                    if (ukuran == "S")
                    {
                        Console.WriteLine("Harga untuk ukuran S adalah Rp.69.000");
                    }
                    else if (ukuran == "M")
                    {
                        Console.WriteLine("Harga untuk ukuran M adalah Rp.74.000");
                    }
                    else if (ukuran == "L")
                    {
                        Console.WriteLine("Hrga untuk ukuran L adalah Rp.79.000");
                    }
                    else if (ukuran == "XL")
                    {
                        Console.WriteLine("Harga untuk ukuran XL adalah Rp.84.000");
                    }
                    else
                    {
                        Console.WriteLine("ukuran baju tidak tersedia......");
                    }
                }
                else
                {
                    Console.WriteLine("Ukuran baju tidak tersedia.");
                }
            }
            else
            {
                Console.WriteLine("Merk baju tidak tersedia.");
            }   
            
        }
    }

}