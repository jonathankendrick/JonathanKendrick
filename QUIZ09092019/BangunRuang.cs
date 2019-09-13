using System;

namespace QUIZ09092019
{
    class BangunRuang
    {
        public static void Volume_Balok()
        {
            Console.WriteLine("Menghitung Volume Balok");

            int panjang, lebar, tinggi, volume;

            Console.Write("panjang =");
            panjang = Convert.ToInt32(Console.ReadLine());

            Console.Write("lebar =");
            lebar = Convert.ToInt32(Console.ReadLine());

            Console.Write("tinggi =");
            tinggi = Convert.ToInt32(Console.ReadLine());

            volume = panjang * lebar * tinggi;

            Console.WriteLine("volume = "+volume);
        }
        public static void Volume_Kubus()
        {
            Console.WriteLine("Menghitung Volume Kubus");

            int sisi, volume;

            Console.Write("sisi =");
            sisi = Convert.ToInt32(Console.ReadLine());

            volume = sisi * sisi * sisi;

            Console.WriteLine("volume = "+volume);
        }
    }
}