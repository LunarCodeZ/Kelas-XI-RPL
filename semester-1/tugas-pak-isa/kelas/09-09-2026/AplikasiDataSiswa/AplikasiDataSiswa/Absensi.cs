using System;

namespace AplikasiDataSiswa
{
    class Absensi
    {
        public static void januari(string method = "")
        {
            if (method == "")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("------------------------------");
                Console.WriteLine("|   Data Absensi - Januari   |");
                Console.WriteLine("------------------------------");

                int opsi;
                List<string> daftarAksi = ["Tambah Absensi Baru", "Lihat Data Absensi", "Impor Data Absensi"];
                if (DataStorage.jumlahAbsenJanuari > 0)
                {
                    daftarAksi.Insert(2, "Ubah Data Absensi");
                    daftarAksi.Insert(3, "Hapus Data Absensi");
                    daftarAksi.Insert(4, "Reset Data Absensi");
                    daftarAksi.Add("Ekspor Data Absensi");
                }

                Console.WriteLine("\n>> Daftar Aksi <<");
                Console.ForegroundColor = ConsoleColor.Gray;
                for (int i = 0; i < daftarAksi.Count; i++)
                {
                    Console.WriteLine($"[{i + 1}] {daftarAksi[i]}");
                }
                Console.WriteLine("[0] Kembali");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Pilih aksi: ");
                Console.ForegroundColor = ConsoleColor.Gray;
                opsi = Convert.ToInt32(Console.ReadLine());

                if (opsi >= 0 && opsi <= 7)
                {
                    switch (opsi)
                    {
                        // kembali ke home
                        case 0:
                            Console.Clear();
                            Home.absensi();
                            break;

                        // tambah absensi baru
                        case 1:
                            januari("create");
                            break;

                            
                        // lihat data absensi
                        case 2:
                            if (DataStorage.jumlahAbsenJanuari > 0)
                            {
                                januari("read");
                                januari();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nData absensi kosong!");
                                Console.WriteLine("Mohon tambahkan terlebih dahulu...\n");
                                januari();
                            }
                            break;


                        // impor data absensi / ubah data absensi
                        case 3:
                            if (DataStorage.jumlahAbsenJanuari > 0)
                            {
                                // ubah data absensi
                                januari("in development");
                            }
                            else
                            {
                                // impor data absensi
                                januari("in development");
                            }
                            break;


                        // hapus data absensi
                        case 4:
                            if (DataStorage.jumlahAbsenJanuari > 0)
                            {
                                januari("in development");
                            }
                            else
                            {
                                januari("invalid");
                            }
                            break;


                        // reset data absensi
                        case 5:
                            if (DataStorage.jumlahAbsenJanuari > 0)
                            {
                                januari("in development");
                            }
                            else
                            {
                                januari("invalid");
                            }
                            break;


                        // impor data absensi
                        case 6:
                            if (DataStorage.jumlahAbsenJanuari > 0)
                            {
                                januari("in development");
                            }
                            else
                            {
                                januari("invalid");
                            }
                            break;


                        // ekspor data absensi
                        default:
                            if (DataStorage.jumlahAbsenJanuari > 0)
                            {
                                januari("in development");
                            }
                            else
                            {
                                januari("invalid");
                            }
                            break;
                    }
                }
                else
                {

                }
            }
            else if (method == "create")
            {
                string nisn;
                string namaLengkap;
                int hadir;
                int sakit;
                int izin;
                int alfa;
                string alamat;

                bool isLoop = true;
                while (isLoop)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n>> Tambah Siswa Baru <<");

                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Nama lengkap: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    namaLengkap = Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Jumlah hadir: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    hadir = Convert.ToInt32(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Jumlah sakit: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    sakit = Convert.ToInt32(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Jumlah izin: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    izin = Convert.ToInt32(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Jumlah alfa: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    alfa = Convert.ToInt32(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Alamat: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    alamat = Console.ReadLine();

                    DataStorage.namaLengkapJanuariColumn = Math.Max(DataStorage.namaLengkapJanuariColumn, namaLengkap.Length);
                    DataStorage.alamatAbsensiJanuariColumn = Math.Max(DataStorage.alamatAbsensiJanuariColumn, alamat.Length);
                    DataStorage.jumlahAbsenJanuari++;
                    nisn = DataStorage.nisnTemplate.Substring(0, (DataStorage.nisnTemplate.Length - Convert.ToInt32(Math.Floor(Math.Log(DataStorage.jumlahAbsenJanuari))))) + DataStorage.jumlahAbsenJanuari;

                    DataStorage.daftarNisnAbsensiJanuari.Add(nisn);
                    DataStorage.daftarNamaLengkapAbsensiJanuari.Add(namaLengkap);
                    DataStorage.daftarAbsensiHadirJanuari.Add(hadir);
                    DataStorage.daftarAbsensiSakitJanuari.Add(sakit);
                    DataStorage.daftarAbsensiIzinJanuari.Add(izin);
                    DataStorage.daftarAbsensiAlfaJanuari.Add(alfa);
                    DataStorage.daftarAlamatAbsensiJanuari.Add(alamat);

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Data absensi bulan Januari");
                    Console.WriteLine("telah berhasil ditambahkan!\n");
                    isLoop = false;
                    januari();
                }
            }
            else if (method == "read")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n>> Daftar Data Absensi Januari <<");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"+-----+------------+--------------{new string('-', DataStorage.namaLengkapJanuariColumn - DataStorage.NAMA_LENGKAP_COLUMN)}+-------+------+-------+------+--------{new string('-', DataStorage.alamatAbsensiJanuariColumn - DataStorage.ALAMAT_COLUMN)}+");
                Console.WriteLine($"| No. | Nisn       | Nama Lengkap{new string(' ', DataStorage.namaLengkapJanuariColumn - DataStorage.NAMA_LENGKAP_COLUMN)} | Hadir | Izin | Sakit | Alfa | Alamat{new string(' ', DataStorage.alamatAbsensiJanuariColumn - DataStorage.ALAMAT_COLUMN)} |");
                Console.WriteLine($"+-----+------------+--------------{new string('-', DataStorage.namaLengkapJanuariColumn - DataStorage.NAMA_LENGKAP_COLUMN)}+-------+------+-------+------+--------{new string('-', DataStorage.alamatAbsensiJanuariColumn - DataStorage.ALAMAT_COLUMN)}+");

                for (int i = 0; i < DataStorage.jumlahAbsenJanuari; i++)
                {
                    // no
                    Console.Write($"| {i + 1}. {new string(' ', 2 - i.ToString().Length)}| ");

                    // nisn
                    Console.Write($"{DataStorage.daftarNisnAbsensiJanuari[i]} | ");

                    // nama lengkap
                    Console.Write($"{DataStorage.daftarNamaLengkapAbsensiJanuari[i]} {new string(' ', DataStorage.namaLengkapJanuariColumn - DataStorage.daftarNamaLengkapAbsensiJanuari[i].Length)}| ");

                    // hadir
                    Console.Write($"{DataStorage.daftarAbsensiHadirJanuari[i]} {new string(' ', 5 - DataStorage.daftarAbsensiHadirJanuari[i].ToString().Length)}| ");

                    // izin
                    Console.Write($"{DataStorage.daftarAbsensiIzinJanuari[i]} {new string(' ', 4 - DataStorage.daftarAbsensiIzinJanuari[i].ToString().Length)}| ");

                    // sakit
                    Console.Write($"{DataStorage.daftarAbsensiSakitJanuari[i]} {new string(' ', 5 - DataStorage.daftarAbsensiSakitJanuari[i].ToString().Length)}| ");

                    // alfa
                    Console.Write($"{DataStorage.daftarAbsensiAlfaJanuari[i]} {new string(' ', 4 - DataStorage.daftarAbsensiAlfaJanuari[i].ToString().Length)}| ");

                    // alamat
                    Console.WriteLine($"{DataStorage.daftarAlamatAbsensiJanuari[i]} {new string(' ', DataStorage.alamatAbsensiJanuariColumn - DataStorage.daftarAlamatAbsensiJanuari[i].Length)}|");
                }

                Console.WriteLine($"+-----+------------+--------------{new string('-', DataStorage.namaLengkapJanuariColumn - DataStorage.NAMA_LENGKAP_COLUMN)}+-------+------+-------+------+--------{new string('-', DataStorage.alamatAbsensiJanuariColumn - DataStorage.ALAMAT_COLUMN)}+\n");
            }
            else if (method == "update")
            {

            }
            else if (method == "invalid")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nAksi tidak valid!");
                Console.WriteLine("Silakan coba lagi...\n");
                januari();
            }
            else if (method == "in development")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nAksi masih dalam proses pengembangan!");
                Console.WriteLine("Mohon bersabar :)");
                Console.WriteLine("Silakan coba aksi lain...\n");
                januari();
            }
        }
    }
}