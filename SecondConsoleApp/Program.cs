using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp
{
    class Program
    {
        //1.Adım:Başla
        //2.Adım:Kullanıcıdan sayi verisi al
        //3.karesi değişken ata
        //4.karesi=sayi^2 olsun
        //5.karesi ekrana yaz
        //6.Bitir
        static void Main(string[] args)
        {
            Console.Write("Bir sayi giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            float karesi = sayi*sayi;
            Console.Write("Girilen sayının karesi: "+karesi);
            Console.ReadKey();

        }
    }
}
