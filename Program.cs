using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilim231006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir sayı giriniz");
            int sayi= Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("yüzde girin");
            int yuzde= Convert.ToInt16(Console.ReadLine());
            int sonuc = sayi * yuzde / 100;
            Console.WriteLine($"girilen sayının yüzde {yuzde} {sonuc}");
            Console.ReadKey();
        }
    }
}
