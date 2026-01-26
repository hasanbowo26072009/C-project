using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace Sistem_UKS
{
    class RuangPeriksa
    {
        string ruang;
        int jumlah;
        int kursi;
        string jenis_obat;
        int ranjang_uks;
        int wastafel;
        int handsanitizer;

        public RuangPeriksa()
        {
            this.ruang = "Anggrek";
            this.jumlah = 01;
            this.kursi = 02;
            this.jenis_obat = "Paracetamol";
            this.ranjang_uks = 02;
            this.wastafel = 01;
            this.handsanitizer = 03;
        }
        public RuangPeriksa(string a, int b, int c, string d, int e, int f, int g)
        {
            this.ruang = a;
            this.jumlah = b;
            this.kursi = c;
            this.jenis_obat = d;
            this.ranjang_uks = e;
            this.wastafel = f;
            this.handsanitizer = g;
        }
        public void cekData()
        {
            Console.WriteLine("======== Data RuangPeriksa ========");
            Console.WriteLine("Ruang =" + ruang + "\n" +
                "Jumlah =" + jumlah + "\n" +
                "Kursi =" + kursi + "\n" +
                "Jenis_Obat =" + jenis_obat + "\n" +
                "Ranjang_Uks =" + ranjang_uks + "\n" +
                "Wastafel =" + wastafel + "\n" +
                "Handsanitizer =" + handsanitizer + "\n");
        }
    }
}


