using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistem_UKS
{
    class Pasien
    {
        string nama;
        int umur;
        int berat_badan;
        int tinggi_badan;
        string golongan_darah;
        string penyakit;

        public Pasien()
        {
            this.nama = "Kalis";
            this.umur = 15;
            this.berat_badan = 50;
            this.tinggi_badan = 171;
            this.golongan_darah = "A";
            this.penyakit = "asma";
        }
        public Pasien(string a, int b, int c, int d, string e, string f)
        {
            this.nama = a;
            this.umur = b;
            this.berat_badan = c;
            this.tinggi_badan = d;
            this.golongan_darah = e;
            this.penyakit = f;
        }
        public void cekData()
        {
            Console.WriteLine("======== Data Pasien ========");
            Console.WriteLine("Nama =" + nama + "\n" +
                "Umur =" + umur + "\n" +
                "Berat_Badan =" + berat_badan + "\n" +
                "Tinggi_Badan =" + tinggi_badan + "\n" +
                "Golongan_Darah =" + golongan_darah + "\n" +
                "Penyakit =" + penyakit + "\n");
        }  
    }
}
