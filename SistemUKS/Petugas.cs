using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistem_UKS
{
    class Petugas
    {
        string nama;
        string alamat;
        string kelas;
        int umur;
        int tingggi_badan;
        int berat_badan;
        string golongan_darah;

        public Petugas()
        {
            this.nama = "Fassa";
            this.alamat = "Lendah";
            this.kelas = "XRPL1";
            this.umur = 16;
            this.tingggi_badan = 170;
            this.berat_badan = 60;
            this.golongan_darah = "o";
        }
        public Petugas(string a, string b, string c, int d, int e, int f, string g)
        {
            this.nama = a;
            this.alamat = b;
            this.kelas = c;
            this.umur = d;
            this.tingggi_badan = e;
            this.berat_badan = f;
            this.golongan_darah = g;
        }
        public void cekData()
        {
            Console.WriteLine("======== Data Petugas ========");
            Console.WriteLine("Nama = " + nama + "\n" +
                "Alamat = " + alamat + "\n" +
                "Kelas = " + kelas + "\n" +
                "Umur = " + umur + "\n" +
                "Tinggi_Badan = " + tingggi_badan + "\n" +
                "Berat_Badan = " + berat_badan + "\n" +
                "Golongan_Darah = " + golongan_darah + "\n" );
        }
    }
}
