using System;

namespace Matematika
{
    class Home
    {
        static void Main(String[] args) {
            Console.WriteLine("Belajar PBO");

            // membuat instansi objek
            Kalkulator kal = new Kalkulator();
            BangunRuang bRuang = new BangunRuang();

            // memanggil fungsi
            kal.penjumlahan();
            //kal.pengurangan();
            //kal.perkalian();
            //kal.pembagian();

            BangunDatar.luasLingkaran();

            bRuang.volumeBalok();
            //bRuang.volumeTabung();
            //bRuang.volumePiramida();
        }
    }

    class Kalkulator
    {
        public void penjumlahan() {
            Console.WriteLine("Penjumlahan");
        }

        public void pengurangan() {
            Console.WriteLine("Pengurangan");
        }

        public void perkalian()
        {
            Console.WriteLine("Perkalian");
        }

        public void pembagian()
        {
            Console.WriteLine("Pembagian");
        }
    }

    class BangunDatar
    {
        public static void kelilingPersegiPanjang() {
            Console.WriteLine("Keliling persegi panjang");
        }

        public static void kelilingLingkaran() {
            Console.WriteLine("Keliling lingkaran");
        }

        public static void luasPersegiPanjang() {
            Console.WriteLine("Luas persegi panjang");
        }

        public static void luasLingkaran() {
            Console.WriteLine("Luas lingkaran");
        }
    }

    class BangunRuang
    {
        public void volumeBalok() {
            Console.WriteLine("Volume balok");
        }

        public void volumeTabung() {
            Console.WriteLine("Volume tabung");
        }

        public void volumePiramida() {
            Console.WriteLine("Volume piramida");
        }
    }
}