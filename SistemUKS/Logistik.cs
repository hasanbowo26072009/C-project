using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistem_UKS
{
    class Logistik
    {
        // mwmbuat variabel
        public string nama_ruang { get; set; }
        private string nama;
        private string id_ruang;
        private float luas;
        private int kapasitas;
        private string daftar_barang;
        public string penanggung_jawab { get; set; }
        private int rak;
 


        public Logistik()
        {
        this.nama = "Logistik";
        this.id_ruang = "IsNullorwhiteSpace";
        this.luas = 502;
        this.kapasitas = 4;
        this.daftar_barang = "data_pasien";
        this.penanggung_jawab = "fassa";
        this.rak = 2;
        }

        public Logistik(string a, string b, float c, int d, string e, string f, int g)
        {
            this.nama = a;
            this.id_ruang = b; 
            this.luas = c;
            this.kapasitas = d;
            this.daftar_barang = e;
            this.penanggung_jawab = f;
            this.rak = g;                
        }
            public void cekData()
            {
                Console.WriteLine("======== Data Logistik ========");
                Console.WriteLine("Nama = "+nama +"\n"+
                    "ID_Ruang = "+id_ruang +"\n"+
                    "Luas = "+luas +"\n"+
                    "Kapasitas = "+kapasitas +"\n"+
                    "Daftar_Barang = "+daftar_barang +"\n"+
                    "Penanggung_Jawab ="+penanggung_jawab +"\n"+
                    "Rak = "+rak +"/n" );
            }
            public string NamaRuang
            {
                get
                {
                    return nama_ruang;
                }
                set
                {
                    if (nama_ruang == "Logistik")
                    {
                        nama_ruang = "Logistik";
                    }
                    else if (nama_ruang == "Logistik UKS")
                    {
                        nama_ruang = "Logsitik UKS";
                    }
                    else
                    {
                        Console.WriteLine("Tidak Teridentifikasi");
                    }
                }
            }
            public string PenanggungJawab
            {
                get
                {
                    return penanggung_jawab;
                }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException("Penanggung Jawab tidak boleh kosong.");
                    }
                    if (!value.StartsWith("G", StringComparison.OrdinalIgnoreCase))
                    {
                        throw new ArgumentException("Penanggung jawab harus dimulai dengan huruf 'F'.");
                    }
                    penanggung_jawab = value;
                }
            }
          
    }
}

