using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2297
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Karyawan k1 = new Karyawan("190302123", "Paijo", 30000000);
            Karyawan k2 = new Karyawan("190302123", "Jono", 20000000);
     
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("No.\tNik\t\tNama\tGaji Bulanan");
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("1.\t{0}\t{1}\t{2}", k1.Nik, k1.Nama, k1.GajiBulanan);
            Console.WriteLine("2.\t{0}\t{1}\t{2}", k2.Nik, k2.Nama, k2.GajiBulanan);
            
          

            Console.WriteLine();
            Console.WriteLine("Asyikk Kenaikan Gaji 10% !!!");
            Console.WriteLine();


            k1.GajiBulanan = k1.GajiBulanan + k1.GajiBulanan * 10 / 100;
            k2.GajiBulanan = k2.GajiBulanan + k2.GajiBulanan * 10 / 100;

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("No.\tNik\t\tNama\tGaji Bulanan");
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("1.\t{0}\t{1}\t{2}", k1.Nik, k1.Nama, k1.GajiBulanan);
            Console.WriteLine("2.\t{0}\t{1}\t{2}", k2.Nik, k2.Nama, k2.GajiBulanan);

           
            Console.ReadKey();
         
        }

        
    }
}
