using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistem_UKS
{
    class Toilet
    {
        string nama;
        int id_kamarmandi;
        int jumlah;
        string kondisi;
        float luas;
        int jumlah_shower;
        int kaca;

        public Toilet()
        {
            this.nama = "Toilet";
            this.id_kamarmandi = 221;
            this.jumlah = 01;
            this.kondisi = "bersih";
            this.luas = 27;
            this.jumlah_shower = 2;
            this.kaca = 01;
        }
        public Toilet(string a, int b, int c, string d, float e, int f, int g)
        {
            this.nama = a;
            this.id_kamarmandi = b;
            this.jumlah = c;
            this.kondisi = d;
            this.luas = e;
            this.jumlah_shower = f;
            this.kaca = g;
        }
        public void cekData()
        {
            Console.WriteLine("======== Data Toilet ========");
            Console.WriteLine("Nama =" + nama + "\n" +
                "Id_KamarMandi =" + id_kamarmandi + "\n" +
                "Jumlah =" + jumlah + "\n" +
                "Kondisi =" + kondisi + "\n" +     
                "Luas =" + luas + "\n" +
                "Jumlah_Shower =" + jumlah_shower + "\n" +
                "Kaca =" + kaca + "\n");
        }
    }
}
