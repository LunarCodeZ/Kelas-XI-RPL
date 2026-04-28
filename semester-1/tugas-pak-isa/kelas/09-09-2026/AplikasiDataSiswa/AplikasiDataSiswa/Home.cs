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
                mulai(opsi);
            }
        }

        public static void mulai(int opsi)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("|   Aplikasi Data Siswa   |");
            Console.WriteLine("|   oleh: LunarCodeZ      |");
            Console.WriteLine("---------------------------");
            string[] daftarAksi = { "Identitas", "Absensi", "Mata Pelajaran", "Nilai" };

            Console.WriteLine("\n>> Daftar Aksi <<");
            for (int i = 0; i < daftarAksi.Length; i++)
            {
                Console.WriteLine($"[{i + 1}] {daftarAksi[i]}");
            }
            Console.Write("Pilih aksi: ");
            opsi = Convert.ToInt32(Console.ReadLine());
            
            if (opsi >= 1 && opsi <= 4)
            {
                Console.Clear();

                switch (opsi)
                {
                    case 1:
                        identitas(opsi);
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
                Console.WriteLine("\nAksi tidak valid!");
                Console.WriteLine("Silahkan coba lagi...");
                mulai(opsi);
            }
        }

        public static void identitas(int opsi)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("|   Data Identitas   |");
            Console.WriteLine("----------------------");

            string[] daftarAksi = { "Kembali", "Siswa", "Wali", "Sekolah" };
            Console.WriteLine("\n>> Daftar Aksi <<");
            for (int i = 0; i < daftarAksi.Length; i++)
            {
                Console.WriteLine($"[{i}] {daftarAksi[i]}");
            }
            Console.Write("Pilih aksi: ");
            opsi = Convert.ToInt32(Console.ReadLine());

            if (opsi >= 0 && opsi <= 3)
            {
                Console.Clear();

                switch (opsi)
                {
                    case 0:
                        mulai(opsi);
                        break;

                    case 1:
                        Identitas aksiSiswa = new Identitas();
                        aksiSiswa.siswa(opsi);
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nAksi tidak valid!");
                Console.WriteLine("Silahkan coba lagi...");
                identitas(opsi);
            }
        }

        public static void absensi()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("|   Data Absensi   |");
            Console.WriteLine("--------------------");
        }

        public static void mataPelajaran()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("|   Daftar Mata Pelajaran   |");
            Console.WriteLine("-----------------------------");
        }

        public static void nilai()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("|   Data Nilai   |");
            Console.WriteLine("------------------");
        }
    }
}