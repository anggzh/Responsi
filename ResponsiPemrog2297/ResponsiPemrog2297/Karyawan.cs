using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2297
{
    class Karyawan
    {
        // Properties
        public string Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }

        // Konstruktor
        public Karyawan(string nik, string nama, int gajibulanan)
        {
            Nik = nik;
            Nama = nama;
            if (gajibulanan <= 0)    
            {
                GajiBulanan = 0;
            }
            else
            {
                GajiBulanan = gajibulanan;
            }

        }
    }
}
