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

            /*Console.WriteLine("=== Pilih merk baju ===");
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
            Console.WriteLine("===============");*/

            /*LOGIN SEDERHANA*/

            /*Console.WriteLine("Login sederhana");
            Console.WriteLine();
            Console.WriteLine("==== LOGIN USER ====");
            Console.Write("Masukkan Username : ");
            string username = Console.ReadLine();
            Console.Write("Masukkan Password : ");
            string password = "";
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    password += key.KeyChar;
                    Console.Write("*");
                }
                else if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                {
                    password = password.Substring(0, (password.Length - 1));
                    Console.Write("\b \b");
                }
            } while (key.Key != ConsoleKey.Enter);
            string correctUsername = "Hasan";
            string correctPassword = "admin123";
            if (username == correctUsername && password == correctPassword)
            {
                Console.WriteLine("Login Berhasil, Selamat Datang " + username);
                Console.WriteLine("==== TEKAN ENTER UNTUK LANJUT ====");
                Console.ReadLine();  
            }
            else
            {
                Console.WriteLine("Username atau Password Anda Salah");
                Console.WriteLine("==== TEKAN ENTER UNTUK KELUAR ====");
                Console.ReadLine();
            }*/

            /*StudyCase29*/

            /*int i = 1;
            while (i <= 5)
            {
                Console.WriteLine("Selamat pagi Indonesia");
                i++;
            }*/

            /*StudyCase30*/

            /*Console.Write("Masukkan Tulisan : ");
            string tulisan = Console.ReadLine();
             for (int i = 1; i <= 5; i++)
             {
                Console.WriteLine(tulisan);
             }*/

            // StudyCase 43

            // minta input jumlah tangga dari user
            /*Console.Write("Masukan Jumlah Tangga * yang akan dimasukan : ");
            int jumlahTangga = int.Parse(Console.ReadLine());

            Console.WriteLine("==============================");

            // Loop for untuk menampilkan tangga dari bintang
            for (int i = 1; i <= jumlahTangga; i++)
            {
                // nyetak bintang sesuai sama inmput i
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(); // buat pindah ke baris berikutnya
            }*/

            //StudyCase38

            /*Console.Write("Masukkan nilai awal : ");
            int nilaiAwal = int.Parse(Console.ReadLine());
            Console.Write("Masukkan jumlah perulangan : ");
            int nilaiAkhir = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("==============================");
            int i = nilaiAwal;
            do
            {
                Console.WriteLine(" Ini adalah perulangan ke " + i);
                i++;
            } while (i <= nilaiAkhir);
            Console.WriteLine("==============================");*/

            //Perulangan FOR

            /*Console.Write("Masukkan Nilai awal : ");
            int nilaiAwal = int.Parse(Console.ReadLine());
            Console.Write("Masukkan nilai akhir : ");
            int nilaiAkhir = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("==============================");
            for (int i = nilaiAwal; i >= nilaiAkhir; i--)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine("==============================");

            for (int i = nilaiAwal; i <= nilaiAkhir; i+=2)
            {
                Console.WriteLine(i + " ");
            }*/
            
            
            /*Console.WriteLine("===== Input data pasiean =====");
            Console.Write("Nama pasien : ");
            string nama = Console.ReadLine();
            Console.Write("umur pasien : ");
            int umur = int.Parse(Console.ReadLine());
            Console.Write("alamat pasien : ");
            string alamat = Console.ReadLine();
            Console.WriteLine("==============================");
            Console.WriteLine("Nama pasien : " + nama);
            Console.WriteLine("Umur pasien : " + umur); 
            Console.WriteLine("Alamat pasien : " + alamat);
            Console.WriteLine("==============================");
            do
            {
                Console.Write("Apakah data pasien sudah benar? (y/n) : ");
                string konfirmasi = Console.ReadLine();
                if (konfirmasi.ToLower() == "y")
                {
                    Console.WriteLine("Data pasien telah disimpan.");
                    break;
                }
                else if (konfirmasi.ToLower() == "n")
                {
                    Console.WriteLine("Silakan masukkan data pasien kembali.");
                    Console.Write("Nama pasien : ");
                    nama = Console.ReadLine();
                    Console.Write("Umur pasien : ");
                    umur = int.Parse(Console.ReadLine());
                    Console.Write("Alamat pasien : ");
                    alamat = Console.ReadLine();
                    Console.WriteLine("==============================");
                    Console.WriteLine("Nama pasien : " + nama);
                    Console.WriteLine("Umur pasien : " + umur);
                    Console.WriteLine("Alamat pasien : " + alamat);
                    Console.WriteLine("==============================");
                }
                else
                {
                    Console.WriteLine("Input tidak valid. Silakan masukkan 'y' atau 'n'.");
                }
            } while (true); */

            //materi looping bersarang


            /*Console.Write("Masukkan jumlah data: ");
            int jumlah = int.Parse(Console.ReadLine());
            int total = 0;
            
            for (int i = 1; i <= jumlah; i++)
            {
                Console.Write("Masukkan angka ke-" + i + ": ");
                int angka = int.Parse(Console.ReadLine());
                total += angka;
            }
            Console.WriteLine("Total dari semua angka yang dimasukkan: " + total);*/

            /*for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Jogja ");
                }
                Console.WriteLine();
            }*/

            /*for (int i = 0; i < 55; i+=2)
            {
                if ( i == 52)
                {
                    break;
                }
                Console.WriteLine("Perulangan ke-" + i);
            }*/

            /*for (int i = 0; i < 11; i++)
            {
                if (i == 3 || i == 6 || i == 9)
                {
                    continue;
                }
                Console.WriteLine(i);
            }*/


            /*Console.WriteLine("====== pilih study case yang ingin anda coba ======");
            Console.WriteLine();
            Console.WriteLine("1. Study Case 45");
            Console.WriteLine("2. Study Case 46");
            Console.WriteLine("3. Study Case 47");
            Console.WriteLine("4. Study Case 48");
            Console.WriteLine("5. Study Case 49");
            Console.WriteLine("6. Study Case 50");
            Console.Write("Masukkan pilihan Anda (1-6): ");
            Console.WriteLine();
            int pilihan = int.Parse(Console.ReadLine());
            Console.WriteLine("");
                switch (pilihan)
                {
                    case 1:
                        Console.WriteLine("membuat program perulangan untuk menampilkan angka dari 1 sampai 100 namun ketika sampai 25 dia akan berhenti");
                        for (int i = 1; i <= 100; i++)
                        {
                            if (i == 25)
                            {
                                break;
                            }
                            Console.WriteLine(i);
                        }
                        break;
                    case 2:
                        Console.WriteLine("membbuat program untuk mencari angka pertama yang habis dibagi 7 dalam rentang angka 1-100");
                        for (int i = 1; i <= 100; i++)
                        {
                            if (i % 7 == 0)
                            {
                                Console.WriteLine("Angka pertama yang habis dibagi 7 adalah: " + i);
                                break;
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("membuat program untuk mencari angka 5 pertama kelipatan 9 dalam rentang angka 1-100");
                        int count = 0;
                        for (int i = 1; i <= 100; i++)
                        {
                            if (i % 9 == 0)
                            {
                                Console.WriteLine("Angka kelipatan 9: " + i);
                                count++;
                                if (count == 5)
                                {
                                    break;
                                }
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("membuat program untuk menampilkan angka 1-20, tetapi setiap kelipatan 5 akan terlewati");
                        for (int i = 1; i <= 20; i++)
                        {
                            if (i % 5 == 0)
                            {
                                continue;
                            }
                            Console.WriteLine(i);
                        }
                        break;
                    case 5:
                        Console.WriteLine("membuat program untuk mencetak semua angka dari 1-20, tetapi melewati angka ganjil dengan menerapkan continue");
                        for (int i = 1; i <= 20; i++)
                        {
                            if (i % 2 != 0)
                            {
                                continue;
                            }
                            Console.WriteLine(i);
                        }
                        break;
                    case 6:
                        Console.WriteLine("membuat program untuk mencetak angka dari 1 hingga 20, tetapi melewati angka kelipatan 3 atau kelipatan 5 sekaligus");
                        for (int i = 1; i <= 20; i++)
                        {
                            if (i % 3 == 0 || i % 5 == 0)
                            {
                                continue;
                            }
                            Console.WriteLine(i);
                        }
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid.");
                        break;
                }
                Console.WriteLine("Ada ingin mencoba lagi? (y/n): ");
                string cobaLagi = Console.ReadLine();
                if (cobaLagi.ToLower() == "y")
                {
                    Console.Clear();
                    Main(args); 
                }
                else
                {
                    Console.WriteLine("Terima kasih telah mencoba!");
                }*/
                
                //ABSEN SEDRHANA
                Console.WriteLine("----- Presensi Digital SMKN 1 Bantul -----");
                Console.WriteLine("Pilih presensi : ");
                Console.WriteLine("1. Presensi guru");
                Console.WriteLine("2. Presensi siswa");
                Console.Write("Masukkan pilihan (1/2) : ");
                string pilihan = Console.ReadLine();
                if (pilihan == "1")
                {
                    Console.WriteLine("Anda memilih presensi guru.");
                    Console.Write("Masukkan nama lengkap : ");
                    string nama = Console.ReadLine();
                    Console.Write("Masukkan NIP : ");
                    string nip = Console.ReadLine();
                    Console.Write("Masukkan mapel yang diampu : ");
                    string jenisGuru = Console.ReadLine();
                    Console.WriteLine("\n--- Data Presensi Guru ---");
                    Console.WriteLine("Nama lengkap : " + nama);
                    Console.WriteLine("NIP : " + nip);
                    Console.WriteLine("Mapel yang diampu : " + jenisGuru);
                    Console.WriteLine("Selamat mengajar hari ini Bapak/Ibu " + nama + "!");
                    Console.WriteLine("-------------------------");
                }
                else
                {
                    Console.WriteLine("Anda memilih presensi siswa.");
                    Console.Write("Masukkan nama lengkap : ");
                    string nama = Console.ReadLine();
                    Console.Write("Masukkan NIS : ");
                    string nis = Console.ReadLine();
                    Console.Write("Masukkan kelas : ");
                    string kelas = Console.ReadLine();
                    Console.WriteLine("\n--- Data Presensi Siswa ---");
                    Console.WriteLine("Nama lengkap : " + nama);
                    Console.WriteLine("NIS : " + nis);
                    Console.WriteLine("Kelas : " + kelas);
                    Console.WriteLine("Selamat belajar hari ini " + nama + "!");
                    Console.WriteLine("-------------------------");
                }

        }
    } 
}        



