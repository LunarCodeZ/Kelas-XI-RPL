using System;

namespace AplikasiDataSiswa
{
    class Identitas
    {
        public void siswa()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------------------------------");
            Console.WriteLine("|   Data Identitas - Siswa   |");
            Console.WriteLine("------------------------------");

            int opsi;
            List<string> daftarAksi = [ "Kembali", "Tambah Siswa Baru", "Lihat Data Siswa", "Impor Data" ];
            if (DataStorage.jumlahSiswa > 0)
            {
                daftarAksi.Add("Ekspor Data");
            }

            Console.WriteLine("\n>> Daftar Aksi <<");
            Console.ForegroundColor = ConsoleColor.Gray;
            for (int i = 0; i < daftarAksi.Count; i++)
            {
                Console.WriteLine($"[{i}] {daftarAksi[i]}");
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Pilih aksi: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            opsi = Convert.ToInt32(Console.ReadLine());

            if (opsi >= 0 && opsi <= 2)
            {
                switch (opsi)
                {
                    // kembali ke home
                    case 0:
                        Console.Clear();
                        Home.identitas();
                        break;

                    // tambah siswa baru
                    case 1:
                        string nisn;
                        string namaLengkap;
                        string namaPanggilan;
                        string jenisKelamin;
                        int umur;
                        string alamat;
                        string namaSekolah;

                        bool isLoop = true;
                        while (isLoop)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n>> Tambah Siswa Baru <<");

                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("Nama lengkap: ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            namaLengkap = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("Nama panggilan: ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            namaPanggilan = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("Jenis kelamin (l/p): ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            jenisKelamin = Console.ReadLine().ToUpper();

                            if (jenisKelamin.Length > 1)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nJenis kelamin tidak valid,");
                                Console.WriteLine("harap ketikkan 'l' ataupun 'p'!");
                                Console.WriteLine("Coba lagi...");
                            }
                            else if (jenisKelamin[0] == 'L' || jenisKelamin[0] == 'P')
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("Umur: ");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                umur = Convert.ToInt32(Console.ReadLine());
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("Alamat: ");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                alamat = Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("Nama Sekolah: ");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                namaSekolah = Console.ReadLine();
                                DataStorage.namaSekolahSiswaColumn = Math.Max(DataStorage.namaSekolahSiswaColumn, namaSekolah.Length);

                                DataStorage.jumlahSiswa++;
                                nisn = DataStorage.nisnTemplate.Substring(0, (DataStorage.nisnTemplate.Length - Convert.ToInt32(Math.Floor(Math.Log(DataStorage.jumlahSiswa))))) + DataStorage.jumlahSiswa;
                                DataStorage.daftarNisnSiswa.Add(nisn);
                                DataStorage.daftarNamaLengkapSiswa.Add(namaLengkap);
                                DataStorage.daftarNamaPanggilanSiswa.Add(namaPanggilan);
                                DataStorage.daftarJenisKelaminSiswa.Add(jenisKelamin[0]);
                                DataStorage.daftarUmurSiswa.Add(umur);
                                DataStorage.daftarAlamatSiswa.Add(alamat);
                                DataStorage.daftarSekolahSiswa.Add(namaSekolah);
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Data siswa berhasil ditambahkan!\n");
                                isLoop = false;
                                siswa();
                            }
                            else
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nJenis kelamin tidak valid,");
                                Console.WriteLine("harap ketikkan 'l' ataupun 'p'!");
                                Console.WriteLine("Coba lagi...");
                            }
                        }
                        break;

                    // lihat data siswa
                    default:
                        if (DataStorage.jumlahSiswa > 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n>> Daftar Data Siswa <<\n");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("+-------+------------+------------------------------------------+----------------+---------------+------+----------------------+--------------");
                            Console.Write($"{new string('-', DataStorage.namaSekolahSiswaColumn - 12)}+\n");
                            Console.Write("| No.   | NISN       | Nama Lengkap                             | Nama Panggilan | Jenis Kelamin | Umur | Alamat               | Nama Sekolah");
                            Console.Write($"{new string(' ', DataStorage.namaSekolahSiswaColumn + 1 - 12)}|\n");
                            Console.Write("+-------+------------+------------------------------------------+----------------+---------------+------+----------------------+--------------");
                            Console.Write($"{new string('-', DataStorage.namaSekolahSiswaColumn - 12)}+\n");

                            for (int i = 0; i < DataStorage.jumlahSiswa; i++)
                            {
                                // no
                                if (i >= 0 && i < 9)
                                {
                                    Console.Write($"| {i + 1}.    | ");
                                }
                                else
                                {
                                    Console.Write($"| {i + 1}.   | ");
                                }

                                // nisn
                                Console.Write($"{DataStorage.daftarNisnSiswa[i]} | ");

                                // nama lengkap
                                Console.Write($"{DataStorage.daftarNamaLengkapSiswa[i]} ");
                                for (int j = 1; j <= 39 - DataStorage.daftarNamaLengkapSiswa[i].Length; j++)
                                {
                                    Console.Write(" ");
                                }
                                Console.Write(" | ");

                                // nama panggilan
                                Console.Write($"{DataStorage.daftarNamaPanggilanSiswa[i]} ");
                                for (int j = 1; j <= 13 - DataStorage.daftarNamaPanggilanSiswa[i].Length; j++)
                                {
                                    Console.Write(" ");
                                }
                                Console.Write(" | ");

                                // jenis kelamin
                                Console.Write($"{DataStorage.daftarJenisKelaminSiswa[i]}             | ");

                                // umur
                                if (DataStorage.daftarUmurSiswa[i] >= 10)
                                {
                                    Console.Write($"{DataStorage.daftarUmurSiswa[i]}   | ");
                                }
                                else
                                {
                                    Console.Write($"{DataStorage.daftarUmurSiswa[i]}    | ");
                                }

                                // alamat
                                Console.Write($"{DataStorage.daftarAlamatSiswa[i]} ");
                                for (int j = 1; j <= 19 - DataStorage.daftarAlamatSiswa[i].Length; j++)
                                {
                                    Console.Write(" ");
                                }
                                Console.Write(" | ");

                                // nama sekolah
                                Console.Write($"{DataStorage.daftarSekolahSiswa[i]}");
                                if (DataStorage.daftarSekolahSiswa[i].Length == DataStorage.namaSekolahSiswaColumn)
                                {
                                    Console.Write(" |\n");
                                }
                                else
                                {
                                    Console.Write($"{new string(' ', DataStorage.namaSekolahSiswaColumn - 12 - 1)}|\n");
                                }
                            }

                            Console.Write("+-------+------------+------------------------------------------+----------------+---------------+------+----------------------+--------------");
                            Console.Write($"{new string('-', DataStorage.namaSekolahSiswaColumn - 12)}+\n\n");
                            siswa();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nTidak ada data siswa satupun!");
                            Console.WriteLine("Mohon tambahkan siswa terlebih dahulu...\n");
                            siswa();
                        }
                        break;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nAksi tidak valid!");
                Console.WriteLine("Silahkan coba lagi...\n");
                siswa();
            }
        }

        public static void wali()
        {

        }

        public static void sekolah()
        {

        }
    }
}