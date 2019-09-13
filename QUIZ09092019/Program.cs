using System;

namespace QUIZ09092019
{
    class Program
    {
        static void Main(string[] args)
        {
            BangunDatar Kelas = new BangunDatar();
            BangunRuang Kelas2 = new BangunRuang();

            BangunDatar.Luas_Persegi();
            Console.WriteLine("------------------");

            BangunDatar.Luas_Segitiga();
            Console.WriteLine("------------------");

            BangunDatar.Luas_Lingkaran();
            Console.WriteLine("------------------");

            BangunRuang.Volume_Balok();
            Console.WriteLine("------------------");

            BangunRuang.Volume_Kubus();
            Console.WriteLine("------------------");
        }
    }
}
