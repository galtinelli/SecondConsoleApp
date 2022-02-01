using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karesi2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Sayı: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gidiğiiz sayının karesi: "+(sayi*sayi));
            Console.ReadKey();
        }
    }
}
