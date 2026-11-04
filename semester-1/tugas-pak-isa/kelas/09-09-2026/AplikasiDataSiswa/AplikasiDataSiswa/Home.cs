using System;

namespace AplikasiDataSiswa
{
    class Home
    {
        public static void Main(string[] args)
        {
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



        public static void identitas(string method = "")
        {
            if (method == "")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("----------------------");
                Console.WriteLine("|   Data Identitas   |");
                Console.WriteLine("----------------------");

                int opsi;
                string[] daftarAksi = { "Siswa", "Wali", "Sekolah" };
                Console.WriteLine("\n>> Daftar Aksi <<");
                Console.ForegroundColor = ConsoleColor.Gray;
                for (int i = 0; i < daftarAksi.Length; i++)
                {
                    Console.WriteLine($"[{i + 1}] {daftarAksi[i]}");
                }
                Console.WriteLine("[0] Kembali");

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
                    identitas("invalid");
                }
            }
            else if (method == "invalid")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nAksi tidak valid!");
                Console.WriteLine("Silakan coba lagi...\n");
                identitas();
            }
            else if (method == "in development")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nAksi masih dalam proses pengembangan!");
                Console.WriteLine("Mohon bersabar :)");
                Console.WriteLine("Silakan coba aksi lain...\n");
                identitas();
            }
        }



        public static void absensi(string method = "")
        {
            if (method == "")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("--------------------");
                Console.WriteLine("|   Data Absensi   |");
                Console.WriteLine("--------------------");

                int opsi;
                string[] daftarAksi = {
                    "Januari", "Februari", "Maret", "April", "Mei", "Juni",
                    "Juli", "Agustus", "September", "Oktober", "November", "Desember"
                };
                Console.WriteLine("\n>> Daftar Aksi <<");
                Console.ForegroundColor = ConsoleColor.Gray;
                for (int i = 0; i < daftarAksi.Length; i++)
                {
                    Console.WriteLine($"[{i + 1}] {daftarAksi[i]}");
                }
                Console.WriteLine("[0] Kembali");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Pilih aksi: ");
                Console.ForegroundColor = ConsoleColor.Gray;
                opsi = Convert.ToInt32(Console.ReadLine());

                if (opsi >= 0 && opsi <= 12)
                {
                    // Console.Clear();

                    switch (opsi)
                    {
                        // kambali
                        case 0:
                            Console.Clear();
                            mulai();
                            break;

                        // januari
                        case 1:
                            Console.Clear();
                            Absensi.januari();
                            break;

                        // februari
                        case 2:
                            absensi("in development");
                            break;

                        // maret
                        case 3:
                            absensi("in development");
                            break;

                        // april
                        case 4:
                            absensi("in development");
                            break;

                        // mei
                        case 5:
                            absensi("in development");
                            break;

                        // juni
                        case 6:
                            absensi("in development");
                            break;

                        // juli
                        case 7:
                            absensi("in development");
                            break;

                        // agustus
                        case 8:
                            absensi("in development");
                            break;

                        // september
                        case 9:
                            absensi("in development");
                            break;

                        // oktober
                        case 10:
                            absensi("in development");
                            break;

                        // november
                        case 11:
                            absensi("in development");
                            break;

                        // desember
                        default:
                            absensi("in development");
                            break;
                    }
                }
                else
                {
                    absensi("invalid");
                }
            }
            else if (method == "invalid")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nAksi tidak valid!");
                Console.WriteLine("Silakan coba lagi...\n");
                absensi();
            }
            else if (method == "in development")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nAksi masih dalam proses pengembangan!");
                Console.WriteLine("Mohon bersabar :)");
                Console.WriteLine("Silakan coba aksi lain...\n");
                absensi();
            }
        }



        public static void mataPelajaran(string method = "")
        {
            if (method == "")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("-----------------------------");
                Console.WriteLine("|   Daftar Mata Pelajaran   |");
                Console.WriteLine("-----------------------------");
            }
            else if (method == "invalid")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nAksi tidak valid!");
                Console.WriteLine("Silakan coba lagi...\n");
                mataPelajaran();
            }
            else if (method == "in development")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nAksi masih dalam proses pengembangan!");
                Console.WriteLine("Mohon bersabar :)");
                Console.WriteLine("Silakan coba aksi lain...\n");
                mataPelajaran();
            }
        }



        public static void nilai(string method = "")
        {
            if (method == "")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("------------------");
                Console.WriteLine("|   Data Nilai   |");
                Console.WriteLine("------------------");
            }
            else if (method == "invalid")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nAksi tidak valid!");
                Console.WriteLine("Silakan coba lagi...\n");
                nilai();
            }
            else if (method == "in development")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nAksi masih dalam proses pengembangan!");
                Console.WriteLine("Mohon bersabar :)");
                Console.WriteLine("Silakan coba aksi lain...\n");
                nilai();
            }
        }



        public static void invalid(string action, string innerAction = "")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nAksi tidak valid!");
            Console.WriteLine("Silakan coba lagi...\n");

            switch (action)
            {
                // mulai
                case "mulai":
                    mulai();
                    break;

                // identitas
                case "identitas":
                    mulai();
                    break;

                // absensi
                case "absensi":
                    mulai();
                    break;

                // mata pelajaran
                case "mata pelajaran":
                    mulai();
                    break;

                // nilai
                default:
                    break;
            }
        }



        public static void inDevelopment(string action, string innerAction)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nAksi masih dalam proses pengembangan!");
            Console.WriteLine("Mohon bersabar :)");
            Console.WriteLine("Silakan coba aksi lain...\n");

            switch (action)
            {
                // mulai
                case "mulai":
                    mulai();
                    break;

                // identitas
                case "identitas":
                    mulai();
                    break;

                // absensi
                case "absensi":
                    mulai();
                    break;

                // mata pelajaran
                case "mata pelajaran":
                    mulai();
                    break;

                // nilai
                default:
                    break;
            }
        }
    }
}