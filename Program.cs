using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ternaryOperator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kitap Okumayı Seviyor musunuz? (e, h): ");
            string durum = Console.ReadLine();
            Console.Write(durum == "e" ? "Alışkanlığınız İçin Tebrikler!!" : "Alışkanlık Edinmeniz Sizin İçin En İyisi");
            Console.ReadLine();
        }
    }
}
