using System;

namespace QUIZ09092019
{
    class BangunDatar
    {
       public static void Luas_Persegi()
        {
            Console.WriteLine("Menghitung Luas Persegi");

            int sisi, luas;

            Console.Write("sisi = ");
            sisi = Convert.ToInt32(Console.ReadLine());

            luas = sisi * sisi;

            Console.WriteLine("luas ="+luas);
        }

        public static void Luas_Segitiga()
        {
            Console.WriteLine("Menghitung Luas Segitiga");

            int alas, tinggi, luas;

            Console.Write("alas = ");
            alas = Convert.ToInt32(Console.ReadLine());

            Console.Write("tinggi = ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            luas = alas * tinggi / 2;

            Console.WriteLine("luas ="+luas);
         }  

         public static void Luas_Lingkaran()
         {
            Console.WriteLine("Menghitung Luas Lingkaran");

            int radius;
            double phi, luas;
            phi = 3.14;

            Console.Write("radius = ");
            radius = Convert.ToInt32(Console.ReadLine());

            luas = phi * radius * radius;

            Console.WriteLine("luas ="+luas);
         }         
    }
}