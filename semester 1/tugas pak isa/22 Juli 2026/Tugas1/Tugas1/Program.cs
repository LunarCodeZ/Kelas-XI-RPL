namespace Tugas1
{
    class Kalkulator
    {
        double c;

        public void Penjumlahan(int a, int b)
        {
            c = a + b;
            Console.WriteLine($"{a} + {b}");
            Console.WriteLine($"hasil = {c}");
            Console.WriteLine("");
        }

        public void Pengurangan(int a, int b)
        {
            c = a - b;
            Console.WriteLine($"{a} - {b}");
            Console.WriteLine($"hasil = {c}");
            Console.WriteLine("");
        }

        public void Perkalian(int a, int b)
        {
            c = a * b;
            Console.WriteLine($"{a} x {b}");
            Console.WriteLine($"hasil = {c}");
            Console.WriteLine("");
        }

        public void Pembagian(int a, int b)
        {
            c = a / b;
            Console.WriteLine($"{a} : {b}");
            Console.WriteLine($"hasil = {c}");
            Console.WriteLine("");
        }
    }

    class BangunDatar
    {
        double keliling, luas;

        public void KelilingPersegi(int s)
        {
            keliling = 4 * s;
            Console.WriteLine("--- Keliling Persegi ---");
            Console.WriteLine($"Sisi = {s}");
            Console.WriteLine($"Hasil = 4 x sisi");
            Console.WriteLine($"      = 4 x {s}");
            Console.WriteLine($"      = {keliling}");
            Console.WriteLine("");
        }

        public void LuasPersegi(int s)
        {
            luas = s * s;
            Console.WriteLine("--- Luas Persegi ---");
            Console.WriteLine($"Sisi = {s}");
            Console.WriteLine($"Hasil = sisi x sisi");
            Console.WriteLine($"      = {s} x {s}");
            Console.WriteLine($"      = {luas}");
            Console.WriteLine("");
        }

        public void KelilingPersegiPanjang(int p, int l)
        {
            keliling = 2 * (p + l);
            Console.WriteLine("--- Keliling Persegi Panjang ---");
            Console.WriteLine($"Panjang = {p}");
            Console.WriteLine($"Lebar = {l}");
            Console.WriteLine($"Hasil = 2 x (panjang + lebar)");
            Console.WriteLine($"      = 2 x ({p} + {l})");
            Console.WriteLine($"      = 2 x {p + l}");
            Console.WriteLine($"      = {keliling}");
            Console.WriteLine("");
        }

        public void LuasPersegiPanjang(int p, int l)
        {
            luas = p * l;
            Console.WriteLine("--- Luas Persegi Panjang ---");
            Console.WriteLine($"Panjang = {p}");
            Console.WriteLine($"Lebar = {l}");
            Console.WriteLine($"Hasil = panjang x lebar");
            Console.WriteLine($"      = {p} x {l}");
            Console.WriteLine($"      = {luas}");
            Console.WriteLine("");
        }

        public void KelilingSegitiga(int s)
        {
            keliling = 3 * s;
            Console.WriteLine("--- Keliling Segitiga ---");
            Console.WriteLine($"Sisi = {s}");
            Console.WriteLine($"Hasil = 3 x sisi");
            Console.WriteLine($"      = 3 x {s}");
            Console.WriteLine($"      = {keliling}");
            Console.WriteLine("");
        }

        public void LuasSegitiga(int a, int t)
        {
            luas = (a * t) / 2;
            Console.WriteLine("--- Luas Segitiga ---");
            Console.WriteLine($"Alas = {a}");
            Console.WriteLine($"Tinggi = {t}");
            Console.WriteLine($"Hasil = 1/2 x alas x tinggi");
            Console.WriteLine($"      = 1/2 x {a} x {t}");
            Console.WriteLine($"      = 1/2 x {a * t}");
            Console.WriteLine($"      = {luas}");
            Console.WriteLine("");
        }
    }

    class BangunRuang
    {
        int volume;
        int luasPermukaan;

        public void VolumeKubus(int s)
        {
            volume = s * s * s;
            Console.WriteLine("--- Volume Kubus ---");
            Console.WriteLine($"Sisi = {s}");
            Console.WriteLine($"Hasil = sisi x sisi x sisi");
            Console.WriteLine($"      = {s} x {s} x {s}");
            Console.WriteLine($"      = {volume}");
            Console.WriteLine("");
        }

        public void LuasKubus(int s)
        {
            luasPermukaan = 6 * s;
            Console.WriteLine("--- Luas Kubus ---");
            Console.WriteLine($"Sisi = {s}");
            Console.WriteLine($"Hasil = 6 x sisi");
            Console.WriteLine($"      = 6 x {s}");
            Console.WriteLine($"      = {luasPermukaan}");
            Console.WriteLine("");
        }
    }

    class Zodiak
    {
        string hasilZodiak;

        public void LihatZodiak(int bulan, int tanggal)
        {
            if (bulan >= 1 && bulan <= 12)
            {
                switch (bulan)
                {
                    case 1:
                        if (tanggal >= 1 && tanggal < 20)
                        {
                            hasilZodiak = "Capricorn";
                        }
                        else if (tanggal >= 20 && tanggal <= 31)
                        {
                            hasilZodiak = "Aquarius";
                        }
                        break;

                    case 2:
                        if (tanggal >= 1 && tanggal <= 18)
                        {
                            hasilZodiak = "Aquarius";
                        }
                        else if (tanggal >= 19 && tanggal <= 28)
                        {
                            hasilZodiak = "Pisces";
                        }
                        break;

                    case 3:
                        if (tanggal >= 1 && tanggal <= 20)
                        {
                            hasilZodiak = "Pisces";
                        }
                        else if (tanggal >= 21 && tanggal <= 31)
                        {
                            hasilZodiak = "Aries";
                        }
                        break;

                    case 4:
                        if (tanggal >= 1 && tanggal <= 19)
                        {
                            hasilZodiak = "Aries";
                        }
                        else if (tanggal >= 20 && tanggal <= 30)
                        {
                            hasilZodiak = "Taurus";
                        }
                        break;

                    case 5:
                        if (tanggal >= 1 && tanggal <= 20)
                        {
                            hasilZodiak = "Taurus";
                        }
                        else if (tanggal >= 21 && tanggal <= 31)
                        {
                            hasilZodiak = "Gemini";
                        }
                        break;

                    case 6:
                        if (tanggal >= 1 && tanggal <= 20)
                        {
                            hasilZodiak = "Gemini";
                        }
                        else if (tanggal >= 21 && tanggal <= 30)
                        {
                            hasilZodiak = "Cancer";
                        }
                        break;

                    case 7:
                        if (tanggal >= 1 && tanggal <= 22)
                        {
                            hasilZodiak = "Cancer";
                        }
                        else if (tanggal >= 23 && tanggal <= 31)
                        {
                            hasilZodiak = "Leo";
                        }
                        break;

                    case 8:
                        if (tanggal >= 1 && tanggal <= 22)
                        {
                            hasilZodiak = "Leo";
                        }
                        else if (tanggal >= 23 && tanggal <= 31)
                        {
                            hasilZodiak = "Virgo";
                        }
                        break;

                    case 9:
                        if (tanggal >= 1 && tanggal <= 22)
                        {
                            hasilZodiak = "Virgo";
                        }
                        else if (tanggal >= 23 && tanggal <= 30)
                        {
                            hasilZodiak = "Libra";
                        }
                        break;

                    case 10:
                        if (tanggal >= 1 && tanggal <= 22)
                        {
                            hasilZodiak = "Libra";
                        }
                        else if (tanggal >= 23 && tanggal <= 31)
                        {
                            hasilZodiak = "Scorpio";
                        }
                        break;

                    case 11:
                        if (tanggal >= 1 && tanggal <= 21)
                        {
                            hasilZodiak = "Scorpio";
                        }
                        else if (tanggal >= 22 && tanggal <= 30)
                        {
                            hasilZodiak = "Sagittarius";
                        }
                        break;

                    default:
                        if (tanggal >= 1 && tanggal <= 21)
                        {
                            hasilZodiak = "Sagittarius";
                        }
                        else if (tanggal >= 22 && tanggal <= 31)
                        {
                            hasilZodiak = "Capricorn";
                        }
                        break;
                }

                Console.WriteLine($"Zodiak anda: {hasilZodiak}");
            }
            else
            {
                Console.WriteLine("Bulan tidak valid!");
                Console.WriteLine("Mohon coba lagi...");
            }
        }
    }

    class Menu
    {
        public void Jalankan()
        {
            string[] daftarAplikasi = { "Kalkulator", "Bangun Datar", "Bangun Ruang", "Zodiak" };
            int input, inputAksi;
            Console.WriteLine("Halo, selamat datang!");
            Console.WriteLine("dibuat oleh: LunarCodeZ\n");
            Console.WriteLine(">>> Daftar Aplikasi <<<");
            for (int i = 0; i < daftarAplikasi.Length; i++) {
                Console.WriteLine($"[{i+1}] {daftarAplikasi[i]}");
            }

            Console.Write("Pilih aplikasi: ");
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            switch (input)
            {
                case 1:
                    Kalkulator kalkulasi = new Kalkulator();
                    string[] aksiKalkulator = { "Penjumlahan", "Pengurangan", "Perkalian", "Pembagian" };
                    Console.WriteLine("=== Aplikasi Kalkulator ===");
                    for (int i = 0; i < aksiKalkulator.Length; i++)
                    {
                        Console.WriteLine($"[{i + 1}] {aksiKalkulator[i]}");
                    }
                    Console.Write("Pilih aksi: ");
                    inputAksi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");

                    int angka1, angka2;
                    if (inputAksi == 1)
                    {
                        Console.WriteLine("> Penjumlahan");
                    }
                    else if (inputAksi == 2)
                    {
                        Console.WriteLine("> Pengurangan");
                    }
                    else if (inputAksi == 3)
                    {
                        Console.WriteLine("> Perkalian");
                    }
                    else if (inputAksi == 4)
                    {
                        Console.WriteLine("> Pembagian");
                    }

                    Console.Write("Masukkan angka pertama: ");
                    angka1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Masukkan angka kedua: ");
                    angka2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");

                    if (inputAksi == 1)
                    {
                        kalkulasi.Penjumlahan(angka1, angka2);
                    }
                    else if (inputAksi == 2)
                    {
                        kalkulasi.Pengurangan(angka1, angka2);
                    }
                    else if (inputAksi == 3)
                    {
                        kalkulasi.Perkalian(angka1, angka2);
                    }
                    else if (inputAksi == 4)
                    {
                        kalkulasi.Pembagian(angka1, angka2);
                    }
                    break;

                case 2:
                    BangunDatar bangunDatar = new BangunDatar();

                    string[] aksiBangunDatar =
                    {
                        "Keliling Persegi",
                        "Luas Persegi",
                        "Keliling Persegi Panjang",
                        "Luas Persegi Panjang",
                        "Keliling Segitiga",
                        "Luas Segitiga"
                    };

                    Console.WriteLine("=== Aplikasi Bangun Datar ===");

                    for (int i = 0; i < aksiBangunDatar.Length; i++)
                    {
                        Console.WriteLine($"[{i + 1}] {aksiBangunDatar[i]}");
                    }

                    Console.Write("Pilih bangun: ");
                    inputAksi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    int s, p, l, a, t;

                    switch (inputAksi)
                    {
                        case 1:
                            Console.Write("Masukkan sisi: ");
                            s = Convert.ToInt32(Console.ReadLine());
                            bangunDatar.KelilingPersegi(s);
                            break;

                        case 2:
                            Console.Write("Masukkan sisi: ");
                            s = Convert.ToInt32(Console.ReadLine());
                            bangunDatar.LuasPersegi(s);
                            break;

                        case 3:
                            Console.Write("Masukkan panjang: ");
                            p = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Masukkan lebar: ");
                            l = Convert.ToInt32(Console.ReadLine());
                            bangunDatar.KelilingPersegiPanjang(p, l);
                            break;

                        case 4:
                            Console.Write("Masukkan panjang: ");
                            p = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Masukkan lebar: ");
                            l = Convert.ToInt32(Console.ReadLine());
                            bangunDatar.LuasPersegiPanjang(p, l);
                            break;

                        case 5:
                            Console.Write("Masukkan sisi: ");
                            s = Convert.ToInt32(Console.ReadLine());
                            bangunDatar.KelilingSegitiga(s);
                            break;

                        case 6:
                            Console.Write("Masukkan alas: ");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Masukkan tinggi: ");
                            t = Convert.ToInt32(Console.ReadLine());
                            bangunDatar.LuasSegitiga(a, t);
                            break;
                    }
                    break;

                case 3:
                    BangunRuang bangunRuang = new BangunRuang();

                    string[] aksiBangunRuang =
                    {
                        "Volume Kubus",
                        "Luas Kubus"
                    };

                    Console.WriteLine("=== Aplikasi Bangun Ruang ===");

                    for (int i = 0; i < aksiBangunRuang.Length; i++)
                    {
                        Console.WriteLine($"[{i + 1}] {aksiBangunRuang[i]}");
                    }

                    Console.Write("Pilih bangun: ");
                    inputAksi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    Console.Write("Masukkan sisi: ");
                    int sisi = Convert.ToInt32(Console.ReadLine());

                    if (inputAksi == 1)
                    {
                        bangunRuang.VolumeKubus(sisi);
                    }
                    else if (inputAksi == 2)
                    {
                        bangunRuang.LuasKubus(sisi);
                    }

                    break;

                case 4:
                    Zodiak zodiak = new Zodiak();

                    Console.Write("Masukkan bulan lahir: ");
                    int bulan = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Masukkan tanggal lahir: ");
                    int tanggal = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();

                    zodiak.LihatZodiak(bulan, tanggal);

                    break;

                default:
                    Console.WriteLine("Pilihan tidak valid!");
                    Console.WriteLine("Mohon coba lagi...\n\n");
                    break;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // === Menu ===
            Menu proses = new Menu();
            while (true) {
                proses.Jalankan();
                Console.WriteLine("__________________________\n");
            }
        }
    }
}