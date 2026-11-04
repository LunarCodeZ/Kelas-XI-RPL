using System;

namespace AplikasiDataSiswa
{
    class Home
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                mulai();
            }
        }

        public static void mulai()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("---------------------------");
            Console.WriteLine("|   Aplikasi Data Siswa   |");
            Console.WriteLine("|   oleh: LunarCodeZ      |");
            Console.WriteLine("---------------------------");
            Console.ResetColor();

            Console.WriteLine("\n>> Daftar Aksi <<");
            Console.WriteLine("[1] Identitas");
            Console.WriteLine("[2] Absensi");
            Console.WriteLine("[3] Mata Pelajaran");
            Console.WriteLine("[4] Nilai");
            Console.WriteLine("[0] Keluar");

            int opsi = BacaInt("Pilih aksi: ");

            switch (opsi)
            {
                case 1:
                    Console.Clear();
                    identitas();
                    break;
                case 2:
                    Console.Clear();
                    absensi();
                    break;
                case 3:
                    Console.Clear();
                    mataPelajaran();
                    break;
                case 4:
                    Console.Clear();
                    nilai();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    PesanInvalid();
                    break;
            }
        }

        public static void identitas()
        {
            while (true)
            {
                Console.Clear();
                Judul("Data Identitas");

                Console.WriteLine("[1] Siswa");
                Console.WriteLine("[2] Wali");
                Console.WriteLine("[3] Sekolah");
                Console.WriteLine("[0] Kembali");

                int opsi = BacaInt("Pilih aksi: ");

                switch (opsi)
                {
                    case 1:
                        Identitas.siswa();
                        break;
                    case 2:
                        Identitas.wali();
                        break;
                    case 3:
                        Identitas.sekolah();
                        break;
                    case 0:
                        return;
                    default:
                        PesanInvalid();
                        break;
                }
            }
        }

        public static void absensi()
        {
            while (true)
            {
                Console.Clear();
                Judul("Data Absensi");

                Console.WriteLine("[1] Januari");
                Console.WriteLine("[0] Kembali");

                int opsi = BacaInt("Pilih aksi: ");

                switch (opsi)
                {
                    case 1:
                        Absensi.januari();
                        break;
                    case 0:
                        return;
                    default:
                        PesanInvalid();
                        break;
                }
            }
        }

        public static void mataPelajaran()
        {
            MataPelajaran.Menu();
        }

        public static void nilai()
        {
            Nilai.Menu();
        }

        public static int BacaInt(string pesan)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(pesan);
                Console.ResetColor();

                if (int.TryParse(Console.ReadLine(), out int hasil))
                    return hasil;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Input harus berupa angka.");
                Console.ResetColor();
            }
        }

        public static double BacaDouble(string pesan)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(pesan);
                Console.ResetColor();

                if (double.TryParse(Console.ReadLine(), out double hasil))
                    return hasil;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Input harus berupa angka.");
                Console.ResetColor();
            }
        }

        public static string BacaString(string pesan)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(pesan);
                Console.ResetColor();

                string hasil = Console.ReadLine() ?? "";

                if (!string.IsNullOrWhiteSpace(hasil))
                    return hasil.Trim();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Input tidak boleh kosong.");
                Console.ResetColor();
            }
        }

        public static void Judul(string teks)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"-----------------------------");
            Console.WriteLine($"|   {teks}");
            Console.WriteLine($"-----------------------------");
            Console.ResetColor();
            Console.WriteLine();
        }

        public static void PesanInvalid()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nAksi tidak valid.");
            Console.ResetColor();
            Console.WriteLine("Tekan Enter untuk melanjutkan...");
            Console.ReadLine();
        }

        public static bool Konfirmasi(string pesan)
        {
            Console.Write($"{pesan} (y/n): ");
            string jawaban = (Console.ReadLine() ?? "").Trim().ToLower();
            return jawaban == "y" || jawaban == "ya";
        }

        public static void Tunggu()
        {
            Console.WriteLine("\nTekan Enter untuk melanjutkan...");
            Console.ReadLine();
        }
    }
}
