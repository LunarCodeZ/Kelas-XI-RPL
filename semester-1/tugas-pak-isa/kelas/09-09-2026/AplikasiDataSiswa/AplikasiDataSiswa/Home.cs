using System;

namespace AplikasiDataSiswa
{
    class Home
    {
        public static void Main(string[] args)
        {
            int opsi = -1;

            while (true)
            {
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

            int opsi;
            string[] daftarAksi = { "Identitas", "Absensi", "Mata Pelajaran", "Nilai" };

            Console.WriteLine("\n>> Daftar Aksi <<");
            Console.ForegroundColor = ConsoleColor.Gray;
            for (int i = 0; i < daftarAksi.Length; i++)
            {
                Console.WriteLine($"[{i + 1}] {daftarAksi[i]}");
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Pilih aksi: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            opsi = Convert.ToInt32(Console.ReadLine());
            
            if (opsi >= 1 && opsi <= 4)
            {
                Console.Clear();

                switch (opsi)
                {
                    case 1:
                        identitas();
                        break;

                    case 2:
                        absensi();
                        break;

                    case 3:
                        mataPelajaran();
                        break;

                    case 4:
                        nilai();
                        break;

                    default:
                        break;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nAksi tidak valid!");
                Console.WriteLine("Silahkan coba lagi...\n");
                Console.ForegroundColor = ConsoleColor.Gray;
                mulai();
            }
        }

        public static void identitas()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----------------------");
            Console.WriteLine("|   Data Identitas   |");
            Console.WriteLine("----------------------");

            int opsi;
            string[] daftarAksi = { "Kembali", "Siswa", "Wali", "Sekolah" };
            Console.WriteLine("\n>> Daftar Aksi <<");
            Console.ForegroundColor = ConsoleColor.Gray;
            for (int i = 0; i < daftarAksi.Length; i++)
            {
                Console.WriteLine($"[{i}] {daftarAksi[i]}");
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Pilih aksi: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            opsi = Convert.ToInt32(Console.ReadLine());

            if (opsi >= 0 && opsi <= 3)
            {
                Console.Clear();

                switch (opsi)
                {
                    case 0:
                        mulai();
                        break;

                    case 1:
                        Identitas.siswa();
                        break;

                    case 2:
                        Identitas.wali();
                        break;

                    case 3:
                        Identitas.sekolah();
                        break;

                    default:
                        break;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nAksi tidak valid!");
                Console.WriteLine("Silahkan coba lagi...\n");
                identitas();
            }
        }

        public static void absensi()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------------");
            Console.WriteLine("|   Data Absensi   |");
            Console.WriteLine("--------------------");
        }

        public static void mataPelajaran()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-----------------------------");
            Console.WriteLine("|   Daftar Mata Pelajaran   |");
            Console.WriteLine("-----------------------------");
        }

        public static void nilai()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------------------");
            Console.WriteLine("|   Data Nilai   |");
            Console.WriteLine("------------------");
        }
    }
}