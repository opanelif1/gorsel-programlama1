﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1, s2;
            int sayi1, sayi2;
            int Toplam;
            Console.Write("Birinci sayıyı girin: ");
            s1 = Console.ReadLine();
            Console.Write("İkinci sayıyı girin: ");
            s2 = Console.ReadLine();
            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            Toplam = sayi1 + sayi2;
            Console.Write("Toplam= " + Toplam);
            Console.ReadLine();
        }
    }
}
