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

        public static void februari(string method = "")
        {
            if (method == "")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("-------------------------------");
                Console.WriteLine("|   Data Absensi - Februari   |");
                Console.WriteLine("-------------------------------");

                int opsi;
                List<string> daftarAksi = ["Tambah Absensi Baru", "Lihat Data Absensi", "Impor Data Absensi"];
                if (DataStorage.jumlahAbsenFebruari > 0)
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
                            februari("create");
                            break;


                        // lihat data absensi
                        case 2:
                            if (DataStorage.jumlahAbsenFebruari > 0)
                            {
                                februari("read");
                                februari();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nData absensi kosong!");
                                Console.WriteLine("Mohon tambahkan terlebih dahulu...\n");
                                februari();
                            }
                            break;


                        // impor data absensi / ubah data absensi
                        case 3:
                            if (DataStorage.jumlahAbsenFebruari > 0)
                            {
                                // ubah data absensi
                                februari("in development");
                            }
                            else
                            {
                                // impor data absensi
                                februari("in development");
                            }
                            break;


                        // hapus data absensi
                        case 4:
                            if (DataStorage.jumlahAbsenFebruari > 0)
                            {
                                februari("in development");
                            }
                            else
                            {
                                februari("invalid");
                            }
                            break;


                        // reset data absensi
                        case 5:
                            if (DataStorage.jumlahAbsenFebruari > 0)
                            {
                                februari("in development");
                            }
                            else
                            {
                                februari("invalid");
                            }
                            break;


                        // impor data absensi
                        case 6:
                            if (DataStorage.jumlahAbsenFebruari > 0)
                            {
                                februari("in development");
                            }
                            else
                            {
                                februari("invalid");
                            }
                            break;


                        // ekspor data absensi
                        default:
                            if (DataStorage.jumlahAbsenFebruari > 0)
                            {
                                februari("in development");
                            }
                            else
                            {
                                februari("invalid");
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

                    DataStorage.namaLengkapFebruariColumn = Math.Max(DataStorage.namaLengkapFebruariColumn, namaLengkap.Length);
                    DataStorage.alamatAbsensiFebruariColumn = Math.Max(DataStorage.alamatAbsensiFebruariColumn, alamat.Length);
                    DataStorage.jumlahAbsenFebruari++;
                    nisn = DataStorage.nisnTemplate.Substring(0, (DataStorage.nisnTemplate.Length - Convert.ToInt32(Math.Floor(Math.Log(DataStorage.jumlahAbsenFebruari))))) + DataStorage.jumlahAbsenFebruari;

                    DataStorage.daftarNisnAbsensiFebruari.Add(nisn);
                    DataStorage.daftarNamaLengkapAbsensiFebruari.Add(namaLengkap);
                    DataStorage.daftarAbsensiHadirFebruari.Add(hadir);
                    DataStorage.daftarAbsensiSakitFebruari.Add(sakit);
                    DataStorage.daftarAbsensiIzinFebruari.Add(izin);
                    DataStorage.daftarAbsensiAlfaFebruari.Add(alfa);
                    DataStorage.daftarAlamatAbsensiFebruari.Add(alamat);

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Data absensi bulan Februari");
                    Console.WriteLine("telah berhasil ditambahkan!\n");
                    isLoop = false;
                    februari();
                }
            }
            else if (method == "read")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n>> Daftar Data Absensi Februari <<");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"+-----+------------+--------------{new string('-', DataStorage.namaLengkapFebruariColumn - DataStorage.NAMA_LENGKAP_COLUMN)}+-------+------+-------+------+--------{new string('-', DataStorage.alamatAbsensiFebruariColumn - DataStorage.ALAMAT_COLUMN)}+");
                Console.WriteLine($"| No. | Nisn       | Nama Lengkap{new string(' ', DataStorage.namaLengkapFebruariColumn - DataStorage.NAMA_LENGKAP_COLUMN)} | Hadir | Izin | Sakit | Alfa | Alamat{new string(' ', DataStorage.alamatAbsensiFebruariColumn - DataStorage.ALAMAT_COLUMN)} |");
                Console.WriteLine($"+-----+------------+--------------{new string('-', DataStorage.namaLengkapFebruariColumn - DataStorage.NAMA_LENGKAP_COLUMN)}+-------+------+-------+------+--------{new string('-', DataStorage.alamatAbsensiFebruariColumn - DataStorage.ALAMAT_COLUMN)}+");

                for (int i = 0; i < DataStorage.jumlahAbsenFebruari; i++)
                {
                    // no
                    Console.Write($"| {i + 1}. {new string(' ', 2 - i.ToString().Length)}| ");

                    // nisn
                    Console.Write($"{DataStorage.daftarNisnAbsensiFebruari[i]} | ");

                    // nama lengkap
                    Console.Write($"{DataStorage.daftarNamaLengkapAbsensiFebruari[i]} {new string(' ', DataStorage.namaLengkapFebruariColumn - DataStorage.daftarNamaLengkapAbsensiFebruari[i].Length)}| ");

                    // hadir
                    Console.Write($"{DataStorage.daftarAbsensiHadirFebruari[i]} {new string(' ', 5 - DataStorage.daftarAbsensiHadirFebruari[i].ToString().Length)}| ");

                    // izin
                    Console.Write($"{DataStorage.daftarAbsensiIzinFebruari[i]} {new string(' ', 4 - DataStorage.daftarAbsensiIzinFebruari[i].ToString().Length)}| ");

                    // sakit
                    Console.Write($"{DataStorage.daftarAbsensiSakitFebruari[i]} {new string(' ', 5 - DataStorage.daftarAbsensiSakitFebruari[i].ToString().Length)}| ");

                    // alfa
                    Console.Write($"{DataStorage.daftarAbsensiAlfaFebruari[i]} {new string(' ', 4 - DataStorage.daftarAbsensiAlfaFebruari[i].ToString().Length)}| ");

                    // alamat
                    Console.WriteLine($"{DataStorage.daftarAlamatAbsensiFebruari[i]} {new string(' ', DataStorage.alamatAbsensiFebruariColumn - DataStorage.daftarAlamatAbsensiFebruari[i].Length)}|");
                }

                Console.WriteLine($"+-----+------------+--------------{new string('-', DataStorage.namaLengkapFebruariColumn - DataStorage.NAMA_LENGKAP_COLUMN)}+-------+------+-------+------+--------{new string('-', DataStorage.alamatAbsensiFebruariColumn - DataStorage.ALAMAT_COLUMN)}+\n");
            }
            else if (method == "update")
            {

            }
            else if (method == "invalid")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nAksi tidak valid!");
                Console.WriteLine("Silakan coba lagi...\n");
                februari();
            }
            else if (method == "in development")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nAksi masih dalam proses pengembangan!");
                Console.WriteLine("Mohon bersabar :)");
                Console.WriteLine("Silakan coba aksi lain...\n");
                februari();
            }
        }

        public static void maret(string method = "")
        {
            if (method == "")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("----------------------------");
                Console.WriteLine("|   Data Absensi - Maret   |");
                Console.WriteLine("----------------------------");

                int opsi;
                List<string> daftarAksi = ["Tambah Absensi Baru", "Lihat Data Absensi", "Impor Data Absensi"];
                if (DataStorage.jumlahAbsenMaret > 0)
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
                            maret("create");
                            break;


                        // lihat data absensi
                        case 2:
                            if (DataStorage.jumlahAbsenMaret > 0)
                            {
                                maret("read");
                                maret();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nData absensi kosong!");
                                Console.WriteLine("Mohon tambahkan terlebih dahulu...\n");
                                maret();
                            }
                            break;


                        // impor data absensi / ubah data absensi
                        case 3:
                            if (DataStorage.jumlahAbsenMaret > 0)
                            {
                                // ubah data absensi
                                maret("in development");
                            }
                            else
                            {
                                // impor data absensi
                                maret("in development");
                            }
                            break;


                        // hapus data absensi
                        case 4:
                            if (DataStorage.jumlahAbsenMaret > 0)
                            {
                                maret("in development");
                            }
                            else
                            {
                                maret("invalid");
                            }
                            break;


                        // reset data absensi
                        case 5:
                            if (DataStorage.jumlahAbsenMaret > 0)
                            {
                                maret("in development");
                            }
                            else
                            {
                                maret("invalid");
                            }
                            break;


                        // impor data absensi
                        case 6:
                            if (DataStorage.jumlahAbsenMaret > 0)
                            {
                                maret("in development");
                            }
                            else
                            {
                                maret("invalid");
                            }
                            break;


                        // ekspor data absensi
                        default:
                            if (DataStorage.jumlahAbsenMaret > 0)
                            {
                                maret("in development");
                            }
                            else
                            {
                                maret("invalid");
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

                    DataStorage.namaLengkapMaretColumn = Math.Max(DataStorage.namaLengkapMaretColumn, namaLengkap.Length);
                    DataStorage.alamatAbsensiMaretColumn = Math.Max(DataStorage.alamatAbsensiMaretColumn, alamat.Length);
                    DataStorage.jumlahAbsenMaret++;
                    nisn = DataStorage.nisnTemplate.Substring(0, (DataStorage.nisnTemplate.Length - Convert.ToInt32(Math.Floor(Math.Log(DataStorage.jumlahAbsenMaret))))) + DataStorage.jumlahAbsenMaret;

                    DataStorage.daftarNisnAbsensiMaret.Add(nisn);
                    DataStorage.daftarNamaLengkapAbsensiMaret.Add(namaLengkap);
                    DataStorage.daftarAbsensiHadirMaret.Add(hadir);
                    DataStorage.daftarAbsensiSakitMaret.Add(sakit);
                    DataStorage.daftarAbsensiIzinMaret.Add(izin);
                    DataStorage.daftarAbsensiAlfaMaret.Add(alfa);
                    DataStorage.daftarAlamatAbsensiMaret.Add(alamat);

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Data absensi bulan Maret");
                    Console.WriteLine("telah berhasil ditambahkan!\n");
                    isLoop = false;
                    maret();
                }
            }
            else if (method == "read")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n>> Daftar Data Absensi Maret <<");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"+-----+------------+--------------{new string('-', DataStorage.namaLengkapMaretColumn - DataStorage.NAMA_LENGKAP_COLUMN)}+-------+------+-------+------+--------{new string('-', DataStorage.alamatAbsensiMaretColumn - DataStorage.ALAMAT_COLUMN)}+");
                Console.WriteLine($"| No. | Nisn       | Nama Lengkap{new string(' ', DataStorage.namaLengkapMaretColumn - DataStorage.NAMA_LENGKAP_COLUMN)} | Hadir | Izin | Sakit | Alfa | Alamat{new string(' ', DataStorage.alamatAbsensiMaretColumn - DataStorage.ALAMAT_COLUMN)} |");
                Console.WriteLine($"+-----+------------+--------------{new string('-', DataStorage.namaLengkapMaretColumn - DataStorage.NAMA_LENGKAP_COLUMN)}+-------+------+-------+------+--------{new string('-', DataStorage.alamatAbsensiMaretColumn - DataStorage.ALAMAT_COLUMN)}+");

                for (int i = 0; i < DataStorage.jumlahAbsenMaret; i++)
                {
                    // no
                    Console.Write($"| {i + 1}. {new string(' ', 2 - i.ToString().Length)}| ");

                    // nisn
                    Console.Write($"{DataStorage.daftarNisnAbsensiMaret[i]} | ");

                    // nama lengkap
                    Console.Write($"{DataStorage.daftarNamaLengkapAbsensiMaret[i]} {new string(' ', DataStorage.namaLengkapMaretColumn - DataStorage.daftarNamaLengkapAbsensiMaret[i].Length)}| ");

                    // hadir
                    Console.Write($"{DataStorage.daftarAbsensiHadirMaret[i]} {new string(' ', 5 - DataStorage.daftarAbsensiHadirMaret[i].ToString().Length)}| ");

                    // izin
                    Console.Write($"{DataStorage.daftarAbsensiIzinMaret[i]} {new string(' ', 4 - DataStorage.daftarAbsensiIzinMaret[i].ToString().Length)}| ");

                    // sakit
                    Console.Write($"{DataStorage.daftarAbsensiSakitMaret[i]} {new string(' ', 5 - DataStorage.daftarAbsensiSakitMaret[i].ToString().Length)}| ");

                    // alfa
                    Console.Write($"{DataStorage.daftarAbsensiAlfaMaret[i]} {new string(' ', 4 - DataStorage.daftarAbsensiAlfaMaret[i].ToString().Length)}| ");

                    // alamat
                    Console.WriteLine($"{DataStorage.daftarAlamatAbsensiMaret[i]} {new string(' ', DataStorage.alamatAbsensiMaretColumn - DataStorage.daftarAlamatAbsensiMaret[i].Length)}|");
                }

                Console.WriteLine($"+-----+------------+--------------{new string('-', DataStorage.namaLengkapMaretColumn - DataStorage.NAMA_LENGKAP_COLUMN)}+-------+------+-------+------+--------{new string('-', DataStorage.alamatAbsensiMaretColumn - DataStorage.ALAMAT_COLUMN)}+\n");
            }
            else if (method == "update")
            {

            }
            else if (method == "invalid")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nAksi tidak valid!");
                Console.WriteLine("Silakan coba lagi...\n");
                maret();
            }
            else if (method == "in development")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nAksi masih dalam proses pengembangan!");
                Console.WriteLine("Mohon bersabar :)");
                Console.WriteLine("Silakan coba aksi lain...\n");
                maret();
            }
        }

        public static void april(string method = "")
        {
            if (method == "")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("----------------------------");
                Console.WriteLine("|   Data Absensi - April   |");
                Console.WriteLine("----------------------------");

                int opsi;
                List<string> daftarAksi = ["Tambah Absensi Baru", "Lihat Data Absensi", "Impor Data Absensi"];
                if (DataStorage.jumlahAbsenApril > 0)
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
                            april("create");
                            break;


                        // lihat data absensi
                        case 2:
                            if (DataStorage.jumlahAbsenApril > 0)
                            {
                                april("read");
                                april();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nData absensi kosong!");
                                Console.WriteLine("Mohon tambahkan terlebih dahulu...\n");
                                april();
                            }
                            break;


                        // impor data absensi / ubah data absensi
                        case 3:
                            if (DataStorage.jumlahAbsenApril > 0)
                            {
                                // ubah data absensi
                                april("in development");
                            }
                            else
                            {
                                // impor data absensi
                                april("in development");
                            }
                            break;


                        // hapus data absensi
                        case 4:
                            if (DataStorage.jumlahAbsenApril > 0)
                            {
                                april("in development");
                            }
                            else
                            {
                                april("invalid");
                            }
                            break;


                        // reset data absensi
                        case 5:
                            if (DataStorage.jumlahAbsenApril > 0)
                            {
                                april("in development");
                            }
                            else
                            {
                                april("invalid");
                            }
                            break;


                        // impor data absensi
                        case 6:
                            if (DataStorage.jumlahAbsenApril > 0)
                            {
                                april("in development");
                            }
                            else
                            {
                                april("invalid");
                            }
                            break;


                        // ekspor data absensi
                        default:
                            if (DataStorage.jumlahAbsenApril > 0)
                            {
                                april("in development");
                            }
                            else
                            {
                                april("invalid");
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

                    DataStorage.namaLengkapAprilColumn = Math.Max(DataStorage.namaLengkapAprilColumn, namaLengkap.Length);
                    DataStorage.alamatAbsensiAprilColumn = Math.Max(DataStorage.alamatAbsensiAprilColumn, alamat.Length);
                    DataStorage.jumlahAbsenApril++;
                    nisn = DataStorage.nisnTemplate.Substring(0, (DataStorage.nisnTemplate.Length - Convert.ToInt32(Math.Floor(Math.Log(DataStorage.jumlahAbsenApril))))) + DataStorage.jumlahAbsenApril;

                    DataStorage.daftarNisnAbsensiApril.Add(nisn);
                    DataStorage.daftarNamaLengkapAbsensiApril.Add(namaLengkap);
                    DataStorage.daftarAbsensiHadirApril.Add(hadir);
                    DataStorage.daftarAbsensiSakitApril.Add(sakit);
                    DataStorage.daftarAbsensiIzinApril.Add(izin);
                    DataStorage.daftarAbsensiAlfaApril.Add(alfa);
                    DataStorage.daftarAlamatAbsensiApril.Add(alamat);

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Data absensi bulan April");
                    Console.WriteLine("telah berhasil ditambahkan!\n");
                    isLoop = false;
                    april();
                }
            }
            else if (method == "read")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n>> Daftar Data Absensi April <<");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"+-----+------------+--------------{new string('-', DataStorage.namaLengkapAprilColumn - DataStorage.NAMA_LENGKAP_COLUMN)}+-------+------+-------+------+--------{new string('-', DataStorage.alamatAbsensiAprilColumn - DataStorage.ALAMAT_COLUMN)}+");
                Console.WriteLine($"| No. | Nisn       | Nama Lengkap{new string(' ', DataStorage.namaLengkapAprilColumn - DataStorage.NAMA_LENGKAP_COLUMN)} | Hadir | Izin | Sakit | Alfa | Alamat{new string(' ', DataStorage.alamatAbsensiAprilColumn - DataStorage.ALAMAT_COLUMN)} |");
                Console.WriteLine($"+-----+------------+--------------{new string('-', DataStorage.namaLengkapAprilColumn - DataStorage.NAMA_LENGKAP_COLUMN)}+-------+------+-------+------+--------{new string('-', DataStorage.alamatAbsensiAprilColumn - DataStorage.ALAMAT_COLUMN)}+");

                for (int i = 0; i < DataStorage.jumlahAbsenApril; i++)
                {
                    // no
                    Console.Write($"| {i + 1}. {new string(' ', 2 - i.ToString().Length)}| ");

                    // nisn
                    Console.Write($"{DataStorage.daftarNisnAbsensiApril[i]} | ");

                    // nama lengkap
                    Console.Write($"{DataStorage.daftarNamaLengkapAbsensiApril[i]} {new string(' ', DataStorage.namaLengkapAprilColumn - DataStorage.daftarNamaLengkapAbsensiApril[i].Length)}| ");

                    // hadir
                    Console.Write($"{DataStorage.daftarAbsensiHadirApril[i]} {new string(' ', 5 - DataStorage.daftarAbsensiHadirApril[i].ToString().Length)}| ");

                    // izin
                    Console.Write($"{DataStorage.daftarAbsensiIzinApril[i]} {new string(' ', 4 - DataStorage.daftarAbsensiIzinApril[i].ToString().Length)}| ");

                    // sakit
                    Console.Write($"{DataStorage.daftarAbsensiSakitApril[i]} {new string(' ', 5 - DataStorage.daftarAbsensiSakitApril[i].ToString().Length)}| ");

                    // alfa
                    Console.Write($"{DataStorage.daftarAbsensiAlfaApril[i]} {new string(' ', 4 - DataStorage.daftarAbsensiAlfaApril[i].ToString().Length)}| ");

                    // alamat
                    Console.WriteLine($"{DataStorage.daftarAlamatAbsensiApril[i]} {new string(' ', DataStorage.alamatAbsensiAprilColumn - DataStorage.daftarAlamatAbsensiApril[i].Length)}|");
                }

                Console.WriteLine($"+-----+------------+--------------{new string('-', DataStorage.namaLengkapAprilColumn - DataStorage.NAMA_LENGKAP_COLUMN)}+-------+------+-------+------+--------{new string('-', DataStorage.alamatAbsensiAprilColumn - DataStorage.ALAMAT_COLUMN)}+\n");
            }
            else if (method == "update")
            {

            }
            else if (method == "invalid")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nAksi tidak valid!");
                Console.WriteLine("Silakan coba lagi...\n");
                april();
            }
            else if (method == "in development")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nAksi masih dalam proses pengembangan!");
                Console.WriteLine("Mohon bersabar :)");
                Console.WriteLine("Silakan coba aksi lain...\n");
                april();
            }
        }

        public static void mei(string method = "")
        {
            if (method == "")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("--------------------------");
                Console.WriteLine("|   Data Absensi - Mei   |");
                Console.WriteLine("--------------------------");

                int opsi;
                List<string> daftarAksi = ["Tambah Absensi Baru", "Lihat Data Absensi", "Impor Data Absensi"];
                if (DataStorage.jumlahAbsenMei > 0)
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
                            mei("create");
                            break;


                        // lihat data absensi
                        case 2:
                            if (DataStorage.jumlahAbsenMei > 0)
                            {
                                mei("read");
                                mei();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nData absensi kosong!");
                                Console.WriteLine("Mohon tambahkan terlebih dahulu...\n");
                                mei();
                            }
                            break;


                        // impor data absensi / ubah data absensi
                        case 3:
                            if (DataStorage.jumlahAbsenMei > 0)
                            {
                                // ubah data absensi
                                mei("in development");
                            }
                            else
                            {
                                // impor data absensi
                                mei("in development");
                            }
                            break;


                        // hapus data absensi
                        case 4:
                            if (DataStorage.jumlahAbsenMei > 0)
                            {
                                mei("in development");
                            }
                            else
                            {
                                mei("invalid");
                            }
                            break;


                        // reset data absensi
                        case 5:
                            if (DataStorage.jumlahAbsenMei > 0)
                            {
                                mei("in development");
                            }
                            else
                            {
                                mei("invalid");
                            }
                            break;


                        // impor data absensi
                        case 6:
                            if (DataStorage.jumlahAbsenMei > 0)
                            {
                                mei("in development");
                            }
                            else
                            {
                                mei("invalid");
                            }
                            break;


                        // ekspor data absensi
                        default:
                            if (DataStorage.jumlahAbsenMei > 0)
                            {
                                mei("in development");
                            }
                            else
                            {
                                mei("invalid");
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

                    DataStorage.namaLengkapMeiColumn = Math.Max(DataStorage.namaLengkapMeiColumn, namaLengkap.Length);
                    DataStorage.alamatAbsensiMeiColumn = Math.Max(DataStorage.alamatAbsensiMeiColumn, alamat.Length);
                    DataStorage.jumlahAbsenMei++;
                    nisn = DataStorage.nisnTemplate.Substring(0, (DataStorage.nisnTemplate.Length - Convert.ToInt32(Math.Floor(Math.Log(DataStorage.jumlahAbsenMei))))) + DataStorage.jumlahAbsenMei;

                    DataStorage.daftarNisnAbsensiMei.Add(nisn);
                    DataStorage.daftarNamaLengkapAbsensiMei.Add(namaLengkap);
                    DataStorage.daftarAbsensiHadirMei.Add(hadir);
                    DataStorage.daftarAbsensiSakitMei.Add(sakit);
                    DataStorage.daftarAbsensiIzinMei.Add(izin);
                    DataStorage.daftarAbsensiAlfaMei.Add(alfa);
                    DataStorage.daftarAlamatAbsensiMei.Add(alamat);

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Data absensi bulan Mei");
                    Console.WriteLine("telah berhasil ditambahkan!\n");
                    isLoop = false;
                    mei();
                }
            }
            else if (method == "read")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n>> Daftar Data Absensi Mei <<");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"+-----+------------+--------------{new string('-', DataStorage.namaLengkapMeiColumn - DataStorage.NAMA_LENGKAP_COLUMN)}+-------+------+-------+------+--------{new string('-', DataStorage.alamatAbsensiMeiColumn - DataStorage.ALAMAT_COLUMN)}+");
                Console.WriteLine($"| No. | Nisn       | Nama Lengkap{new string(' ', DataStorage.namaLengkapMeiColumn - DataStorage.NAMA_LENGKAP_COLUMN)} | Hadir | Izin | Sakit | Alfa | Alamat{new string(' ', DataStorage.alamatAbsensiMeiColumn - DataStorage.ALAMAT_COLUMN)} |");
                Console.WriteLine($"+-----+------------+--------------{new string('-', DataStorage.namaLengkapMeiColumn - DataStorage.NAMA_LENGKAP_COLUMN)}+-------+------+-------+------+--------{new string('-', DataStorage.alamatAbsensiMeiColumn - DataStorage.ALAMAT_COLUMN)}+");

                for (int i = 0; i < DataStorage.jumlahAbsenMei; i++)
                {
                    // no
                    Console.Write($"| {i + 1}. {new string(' ', 2 - i.ToString().Length)}| ");

                    // nisn
                    Console.Write($"{DataStorage.daftarNisnAbsensiMei[i]} | ");

                    // nama lengkap
                    Console.Write($"{DataStorage.daftarNamaLengkapAbsensiMei[i]} {new string(' ', DataStorage.namaLengkapMeiColumn - DataStorage.daftarNamaLengkapAbsensiMei[i].Length)}| ");

                    // hadir
                    Console.Write($"{DataStorage.daftarAbsensiHadirMei[i]} {new string(' ', 5 - DataStorage.daftarAbsensiHadirMei[i].ToString().Length)}| ");

                    // izin
                    Console.Write($"{DataStorage.daftarAbsensiIzinMei[i]} {new string(' ', 4 - DataStorage.daftarAbsensiIzinMei[i].ToString().Length)}| ");

                    // sakit
                    Console.Write($"{DataStorage.daftarAbsensiSakitMei[i]} {new string(' ', 5 - DataStorage.daftarAbsensiSakitMei[i].ToString().Length)}| ");

                    // alfa
                    Console.Write($"{DataStorage.daftarAbsensiAlfaMei[i]} {new string(' ', 4 - DataStorage.daftarAbsensiAlfaMei[i].ToString().Length)}| ");

                    // alamat
                    Console.WriteLine($"{DataStorage.daftarAlamatAbsensiMei[i]} {new string(' ', DataStorage.alamatAbsensiMeiColumn - DataStorage.daftarAlamatAbsensiMei[i].Length)}|");
                }

                Console.WriteLine($"+-----+------------+--------------{new string('-', DataStorage.namaLengkapMeiColumn - DataStorage.NAMA_LENGKAP_COLUMN)}+-------+------+-------+------+--------{new string('-', DataStorage.alamatAbsensiMeiColumn - DataStorage.ALAMAT_COLUMN)}+\n");
            }
            else if (method == "update")
            {

            }
            else if (method == "invalid")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nAksi tidak valid!");
                Console.WriteLine("Silakan coba lagi...\n");
                mei();
            }
            else if (method == "in development")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nAksi masih dalam proses pengembangan!");
                Console.WriteLine("Mohon bersabar :)");
                Console.WriteLine("Silakan coba aksi lain...\n");
                mei();
            }
        }

        public static void juni(string method = "")
        {
            if (method == "")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("---------------------------");
                Console.WriteLine("|   Data Absensi - Juni   |");
                Console.WriteLine("---------------------------");

                int opsi;
                List<string> daftarAksi = ["Tambah Absensi Baru", "Lihat Data Absensi", "Impor Data Absensi"];
                if (DataStorage.jumlahAbsenJuni > 0)
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
                            juni("create");
                            break;


                        // lihat data absensi
                        case 2:
                            if (DataStorage.jumlahAbsenJuni > 0)
                            {
                                juni("read");
                                juni();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nData absensi kosong!");
                                Console.WriteLine("Mohon tambahkan terlebih dahulu...\n");
                                juni();
                            }
                            break;


                        // impor data absensi / ubah data absensi
                        case 3:
                            if (DataStorage.jumlahAbsenJuni > 0)
                            {
                                // ubah data absensi
                                juni("in development");
                            }
                            else
                            {
                                // impor data absensi
                                juni("in development");
                            }
                            break;


                        // hapus data absensi
                        case 4:
                            if (DataStorage.jumlahAbsenJuni > 0)
                            {
                                juni("in development");
                            }
                            else
                            {
                                juni("invalid");
                            }
                            break;


                        // reset data absensi
                        case 5:
                            if (DataStorage.jumlahAbsenJuni > 0)
                            {
                                juni("in development");
                            }
                            else
                            {
                                juni("invalid");
                            }
                            break;


                        // impor data absensi
                        case 6:
                            if (DataStorage.jumlahAbsenJuni > 0)
                            {
                                juni("in development");
                            }
                            else
                            {
                                juni("invalid");
                            }
                            break;


                        // ekspor data absensi
                        default:
                            if (DataStorage.jumlahAbsenJuni > 0)
                            {
                                juni("in development");
                            }
                            else
                            {
                                juni("invalid");
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

                    DataStorage.namaLengkapJuniColumn = Math.Max(DataStorage.namaLengkapJuniColumn, namaLengkap.Length);
                    DataStorage.alamatAbsensiJuniColumn = Math.Max(DataStorage.alamatAbsensiJuniColumn, alamat.Length);
                    DataStorage.jumlahAbsenJuni++;
                    nisn = DataStorage.nisnTemplate.Substring(0, (DataStorage.nisnTemplate.Length - Convert.ToInt32(Math.Floor(Math.Log(DataStorage.jumlahAbsenJuni))))) + DataStorage.jumlahAbsenJuni;

                    DataStorage.daftarNisnAbsensiJuni.Add(nisn);
                    DataStorage.daftarNamaLengkapAbsensiJuni.Add(namaLengkap);
                    DataStorage.daftarAbsensiHadirJuni.Add(hadir);
                    DataStorage.daftarAbsensiSakitJuni.Add(sakit);
                    DataStorage.daftarAbsensiIzinJuni.Add(izin);
                    DataStorage.daftarAbsensiAlfaJuni.Add(alfa);
                    DataStorage.daftarAlamatAbsensiJuni.Add(alamat);

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Data absensi bulan Juni");
                    Console.WriteLine("telah berhasil ditambahkan!\n");
                    isLoop = false;
                    juni();
                }
            }
            else if (method == "read")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n>> Daftar Data Absensi Juni <<");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"+-----+------------+--------------{new string('-', DataStorage.namaLengkapJuniColumn - DataStorage.NAMA_LENGKAP_COLUMN)}+-------+------+-------+------+--------{new string('-', DataStorage.alamatAbsensiJuniColumn - DataStorage.ALAMAT_COLUMN)}+");
                Console.WriteLine($"| No. | Nisn       | Nama Lengkap{new string(' ', DataStorage.namaLengkapJuniColumn - DataStorage.NAMA_LENGKAP_COLUMN)} | Hadir | Izin | Sakit | Alfa | Alamat{new string(' ', DataStorage.alamatAbsensiJuniColumn - DataStorage.ALAMAT_COLUMN)} |");
                Console.WriteLine($"+-----+------------+--------------{new string('-', DataStorage.namaLengkapJuniColumn - DataStorage.NAMA_LENGKAP_COLUMN)}+-------+------+-------+------+--------{new string('-', DataStorage.alamatAbsensiJuniColumn - DataStorage.ALAMAT_COLUMN)}+");

                for (int i = 0; i < DataStorage.jumlahAbsenJuni; i++)
                {
                    // no
                    Console.Write($"| {i + 1}. {new string(' ', 2 - i.ToString().Length)}| ");

                    // nisn
                    Console.Write($"{DataStorage.daftarNisnAbsensiJuni[i]} | ");

                    // nama lengkap
                    Console.Write($"{DataStorage.daftarNamaLengkapAbsensiJuni[i]} {new string(' ', DataStorage.namaLengkapJuniColumn - DataStorage.daftarNamaLengkapAbsensiJuni[i].Length)}| ");

                    // hadir
                    Console.Write($"{DataStorage.daftarAbsensiHadirJuni[i]} {new string(' ', 5 - DataStorage.daftarAbsensiHadirJuni[i].ToString().Length)}| ");

                    // izin
                    Console.Write($"{DataStorage.daftarAbsensiIzinJuni[i]} {new string(' ', 4 - DataStorage.daftarAbsensiIzinJuni[i].ToString().Length)}| ");

                    // sakit
                    Console.Write($"{DataStorage.daftarAbsensiSakitJuni[i]} {new string(' ', 5 - DataStorage.daftarAbsensiSakitJuni[i].ToString().Length)}| ");

                    // alfa
                    Console.Write($"{DataStorage.daftarAbsensiAlfaJuni[i]} {new string(' ', 4 - DataStorage.daftarAbsensiAlfaJuni[i].ToString().Length)}| ");

                    // alamat
                    Console.WriteLine($"{DataStorage.daftarAlamatAbsensiJuni[i]} {new string(' ', DataStorage.alamatAbsensiJuniColumn - DataStorage.daftarAlamatAbsensiJuni[i].Length)}|");
                }

                Console.WriteLine($"+-----+------------+--------------{new string('-', DataStorage.namaLengkapJuniColumn - DataStorage.NAMA_LENGKAP_COLUMN)}+-------+------+-------+------+--------{new string('-', DataStorage.alamatAbsensiJuniColumn - DataStorage.ALAMAT_COLUMN)}+\n");
            }
            else if (method == "update")
            {

            }
            else if (method == "invalid")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nAksi tidak valid!");
                Console.WriteLine("Silakan coba lagi...\n");
                juni();
            }
            else if (method == "in development")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nAksi masih dalam proses pengembangan!");
                Console.WriteLine("Mohon bersabar :)");
                Console.WriteLine("Silakan coba aksi lain...\n");
                juni();
            }
        }

        public static void juli(string method = "")
        {
            if (method == "")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("---------------------------");
                Console.WriteLine("|   Data Absensi - Juli   |");
                Console.WriteLine("---------------------------");

                int opsi;
                List<string> daftarAksi = ["Tambah Absensi Baru", "Lihat Data Absensi", "Impor Data Absensi"];
                if (DataStorage.jumlahAbsenJuli > 0)
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
                            juli("create");
                            break;


                        // lihat data absensi
                        case 2:
                            if (DataStorage.jumlahAbsenJuli > 0)
                            {
                                juli("read");
                                juli();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nData absensi kosong!");
                                Console.WriteLine("Mohon tambahkan terlebih dahulu...\n");
                                juli();
                            }
                            break;


                        // impor data absensi / ubah data absensi
                        case 3:
                            if (DataStorage.jumlahAbsenJuli > 0)
                            {
                                // ubah data absensi
                                juli("in development");
                            }
                            else
                            {
                                // impor data absensi
                                juli("in development");
                            }
                            break;


                        // hapus data absensi
                        case 4:
                            if (DataStorage.jumlahAbsenJuli > 0)
                            {
                                juli("in development");
                            }
                            else
                            {
                                juli("invalid");
                            }
                            break;


                        // reset data absensi
                        case 5:
                            if (DataStorage.jumlahAbsenJuli > 0)
                            {
                                juli("in development");
                            }
                            else
                            {
                                juli("invalid");
                            }
                            break;


                        // impor data absensi
                        case 6:
                            if (DataStorage.jumlahAbsenJuli > 0)
                            {
                                juli("in development");
                            }
                            else
                            {
                                juli("invalid");
                            }
                            break;


                        // ekspor data absensi
                        default:
                            if (DataStorage.jumlahAbsenJuli > 0)
                            {
                                juli("in development");
                            }
                            else
                            {
                                juli("invalid");
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

                    DataStorage.namaLengkapJuliColumn = Math.Max(DataStorage.namaLengkapJuliColumn, namaLengkap.Length);
                    DataStorage.alamatAbsensiJuliColumn = Math.Max(DataStorage.alamatAbsensiJuliColumn, alamat.Length);
                    DataStorage.jumlahAbsenJuli++;
                    nisn = DataStorage.nisnTemplate.Substring(0, (DataStorage.nisnTemplate.Length - Convert.ToInt32(Math.Floor(Math.Log(DataStorage.jumlahAbsenJuli))))) + DataStorage.jumlahAbsenJuli;

                    DataStorage.daftarNisnAbsensiJuli.Add(nisn);
                    DataStorage.daftarNamaLengkapAbsensiJuli.Add(namaLengkap);
                    DataStorage.daftarAbsensiHadirJuli.Add(hadir);
                    DataStorage.daftarAbsensiSakitJuli.Add(sakit);
                    DataStorage.daftarAbsensiIzinJuli.Add(izin);
                    DataStorage.daftarAbsensiAlfaJuli.Add(alfa);
                    DataStorage.daftarAlamatAbsensiJuli.Add(alamat);

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Data absensi bulan Juli");
                    Console.WriteLine("telah berhasil ditambahkan!\n");
                    isLoop = false;
                    juli();
                }
            }
            else if (method == "read")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n>> Daftar Data Absensi Juli <<");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"+-----+------------+--------------{new string('-', DataStorage.namaLengkapJuliColumn - DataStorage.NAMA_LENGKAP_COLUMN)}+-------+------+-------+------+--------{new string('-', DataStorage.alamatAbsensiJuliColumn - DataStorage.ALAMAT_COLUMN)}+");
                Console.WriteLine($"| No. | Nisn       | Nama Lengkap{new string(' ', DataStorage.namaLengkapJuliColumn - DataStorage.NAMA_LENGKAP_COLUMN)} | Hadir | Izin | Sakit | Alfa | Alamat{new string(' ', DataStorage.alamatAbsensiJuliColumn - DataStorage.ALAMAT_COLUMN)} |");
                Console.WriteLine($"+-----+------------+--------------{new string('-', DataStorage.namaLengkapJuliColumn - DataStorage.NAMA_LENGKAP_COLUMN)}+-------+------+-------+------+--------{new string('-', DataStorage.alamatAbsensiJuliColumn - DataStorage.ALAMAT_COLUMN)}+");

                for (int i = 0; i < DataStorage.jumlahAbsenJuli; i++)
                {
                    // no
                    Console.Write($"| {i + 1}. {new string(' ', 2 - i.ToString().Length)}| ");

                    // nisn
                    Console.Write($"{DataStorage.daftarNisnAbsensiJuli[i]} | ");

                    // nama lengkap
                    Console.Write($"{DataStorage.daftarNamaLengkapAbsensiJuli[i]} {new string(' ', DataStorage.namaLengkapJuliColumn - DataStorage.daftarNamaLengkapAbsensiJuli[i].Length)}| ");

                    // hadir
                    Console.Write($"{DataStorage.daftarAbsensiHadirJuli[i]} {new string(' ', 5 - DataStorage.daftarAbsensiHadirJuli[i].ToString().Length)}| ");

                    // izin
                    Console.Write($"{DataStorage.daftarAbsensiIzinJuli[i]} {new string(' ', 4 - DataStorage.daftarAbsensiIzinJuli[i].ToString().Length)}| ");

                    // sakit
                    Console.Write($"{DataStorage.daftarAbsensiSakitJuli[i]} {new string(' ', 5 - DataStorage.daftarAbsensiSakitJuli[i].ToString().Length)}| ");

                    // alfa
                    Console.Write($"{DataStorage.daftarAbsensiAlfaJuli[i]} {new string(' ', 4 - DataStorage.daftarAbsensiAlfaJuli[i].ToString().Length)}| ");

                    // alamat
                    Console.WriteLine($"{DataStorage.daftarAlamatAbsensiJuli[i]} {new string(' ', DataStorage.alamatAbsensiJuliColumn - DataStorage.daftarAlamatAbsensiJuli[i].Length)}|");
                }

                Console.WriteLine($"+-----+------------+--------------{new string('-', DataStorage.namaLengkapJuliColumn - DataStorage.NAMA_LENGKAP_COLUMN)}+-------+------+-------+------+--------{new string('-', DataStorage.alamatAbsensiJuliColumn - DataStorage.ALAMAT_COLUMN)}+\n");
            }
            else if (method == "update")
            {

            }
            else if (method == "invalid")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nAksi tidak valid!");
                Console.WriteLine("Silakan coba lagi...\n");
                juli();
            }
            else if (method == "in development")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nAksi masih dalam proses pengembangan!");
                Console.WriteLine("Mohon bersabar :)");
                Console.WriteLine("Silakan coba aksi lain...\n");
                juli();
            }
        }

        public static void agustus(string method = "")
        {
            if (method == "")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("------------------------------");
                Console.WriteLine("|   Data Absensi - Agustus   |");
                Console.WriteLine("------------------------------");

                int opsi;
                List<string> daftarAksi = ["Tambah Absensi Baru", "Lihat Data Absensi", "Impor Data Absensi"];
                if (DataStorage.jumlahAbsenAgustus > 0)
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
                            agustus("create");
                            break;


                        // lihat data absensi
                        case 2:
                            if (DataStorage.jumlahAbsenAgustus > 0)
                            {
                                agustus("read");
                                agustus();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nData absensi kosong!");
                                Console.WriteLine("Mohon tambahkan terlebih dahulu...\n");
                                agustus();
                            }
                            break;


                        // impor data absensi / ubah data absensi
                        case 3:
                            if (DataStorage.jumlahAbsenAgustus > 0)
                            {
                                // ubah data absensi
                                agustus("in development");
                            }
                            else
                            {
                                // impor data absensi
                                agustus("in development");
                            }
                            break;


                        // hapus data absensi
                        case 4:
                            if (DataStorage.jumlahAbsenAgustus > 0)
                            {
                                agustus("in development");
                            }
                            else
                            {
                                agustus("invalid");
                            }
                            break;


                        // reset data absensi
                        case 5:
                            if (DataStorage.jumlahAbsenAgustus > 0)
                            {
                                agustus("in development");
                            }
                            else
                            {
                                agustus("invalid");
                            }
                            break;


                        // impor data absensi
                        case 6:
                            if (DataStorage.jumlahAbsenAgustus > 0)
                            {
                                agustus("in development");
                            }
                            else
                            {
                                agustus("invalid");
                            }
                            break;


                        // ekspor data absensi
                        default:
                            if (DataStorage.jumlahAbsenAgustus > 0)
                            {
                                agustus("in development");
                            }
                            else
                            {
                                agustus("invalid");
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

                    DataStorage.namaLengkapAgustusColumn = Math.Max(DataStorage.namaLengkapAgustusColumn, namaLengkap.Length);
                    DataStorage.alamatAbsensiAgustusColumn = Math.Max(DataStorage.alamatAbsensiAgustusColumn, alamat.Length);
                    DataStorage.jumlahAbsenAgustus++;
                    nisn = DataStorage.nisnTemplate.Substring(0, (DataStorage.nisnTemplate.Length - Convert.ToInt32(Math.Floor(Math.Log(DataStorage.jumlahAbsenAgustus))))) + DataStorage.jumlahAbsenAgustus;

                    DataStorage.daftarNisnAbsensiAgustus.Add(nisn);
                    DataStorage.daftarNamaLengkapAbsensiAgustus.Add(namaLengkap);
                    DataStorage.daftarAbsensiHadirAgustus.Add(hadir);
                    DataStorage.daftarAbsensiSakitAgustus.Add(sakit);
                    DataStorage.daftarAbsensiIzinAgustus.Add(izin);
                    DataStorage.daftarAbsensiAlfaAgustus.Add(alfa);
                    DataStorage.daftarAlamatAbsensiAgustus.Add(alamat);

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Data absensi bulan Agustus");
                    Console.WriteLine("telah berhasil ditambahkan!\n");
                    isLoop = false;
                    agustus();
                }
            }
            else if (method == "read")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n>> Daftar Data Absensi Agustus <<");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"+-----+------------+--------------{new string('-', DataStorage.namaLengkapAgustusColumn - DataStorage.NAMA_LENGKAP_COLUMN)}+-------+------+-------+------+--------{new string('-', DataStorage.alamatAbsensiAgustusColumn - DataStorage.ALAMAT_COLUMN)}+");
                Console.WriteLine($"| No. | Nisn       | Nama Lengkap{new string(' ', DataStorage.namaLengkapAgustusColumn - DataStorage.NAMA_LENGKAP_COLUMN)} | Hadir | Izin | Sakit | Alfa | Alamat{new string(' ', DataStorage.alamatAbsensiAgustusColumn - DataStorage.ALAMAT_COLUMN)} |");
                Console.WriteLine($"+-----+------------+--------------{new string('-', DataStorage.namaLengkapAgustusColumn - DataStorage.NAMA_LENGKAP_COLUMN)}+-------+------+-------+------+--------{new string('-', DataStorage.alamatAbsensiAgustusColumn - DataStorage.ALAMAT_COLUMN)}+");

                for (int i = 0; i < DataStorage.jumlahAbsenAgustus; i++)
                {
                    // no
                    Console.Write($"| {i + 1}. {new string(' ', 2 - i.ToString().Length)}| ");

                    // nisn
                    Console.Write($"{DataStorage.daftarNisnAbsensiAgustus[i]} | ");

                    // nama lengkap
                    Console.Write($"{DataStorage.daftarNamaLengkapAbsensiAgustus[i]} {new string(' ', DataStorage.namaLengkapAgustusColumn - DataStorage.daftarNamaLengkapAbsensiAgustus[i].Length)}| ");

                    // hadir
                    Console.Write($"{DataStorage.daftarAbsensiHadirAgustus[i]} {new string(' ', 5 - DataStorage.daftarAbsensiHadirAgustus[i].ToString().Length)}| ");

                    // izin
                    Console.Write($"{DataStorage.daftarAbsensiIzinAgustus[i]} {new string(' ', 4 - DataStorage.daftarAbsensiIzinAgustus[i].ToString().Length)}| ");

                    // sakit
                    Console.Write($"{DataStorage.daftarAbsensiSakitAgustus[i]} {new string(' ', 5 - DataStorage.daftarAbsensiSakitAgustus[i].ToString().Length)}| ");

                    // alfa
                    Console.Write($"{DataStorage.daftarAbsensiAlfaAgustus[i]} {new string(' ', 4 - DataStorage.daftarAbsensiAlfaAgustus[i].ToString().Length)}| ");

                    // alamat
                    Console.WriteLine($"{DataStorage.daftarAlamatAbsensiAgustus[i]} {new string(' ', DataStorage.alamatAbsensiAgustusColumn - DataStorage.daftarAlamatAbsensiAgustus[i].Length)}|");
                }

                Console.WriteLine($"+-----+------------+--------------{new string('-', DataStorage.namaLengkapAgustusColumn - DataStorage.NAMA_LENGKAP_COLUMN)}+-------+------+-------+------+--------{new string('-', DataStorage.alamatAbsensiAgustusColumn - DataStorage.ALAMAT_COLUMN)}+\n");
            }
            else if (method == "update")
            {

            }
            else if (method == "invalid")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nAksi tidak valid!");
                Console.WriteLine("Silakan coba lagi...\n");
                agustus();
            }
            else if (method == "in development")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nAksi masih dalam proses pengembangan!");
                Console.WriteLine("Mohon bersabar :)");
                Console.WriteLine("Silakan coba aksi lain...\n");
                agustus();
            }
        }

        public static void september(string method = "")
        {
            if (method == "")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("--------------------------------");
                Console.WriteLine("|   Data Absensi - September   |");
                Console.WriteLine("--------------------------------");

                int opsi;
                List<string> daftarAksi = ["Tambah Absensi Baru", "Lihat Data Absensi", "Impor Data Absensi"];
                if (DataStorage.jumlahAbsenSeptember > 0)
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
                            september("create");
                            break;


                        // lihat data absensi
                        case 2:
                            if (DataStorage.jumlahAbsenSeptember > 0)
                            {
                                september("read");
                                september();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nData absensi kosong!");
                                Console.WriteLine("Mohon tambahkan terlebih dahulu...\n");
                                september();
                            }
                            break;


                        // impor data absensi / ubah data absensi
                        case 3:
                            if (DataStorage.jumlahAbsenSeptember > 0)
                            {
                                // ubah data absensi
                                september("in development");
                            }
                            else
                            {
                                // impor data absensi
                                september("in development");
                            }
                            break;


                        // hapus data absensi
                        case 4:
                            if (DataStorage.jumlahAbsenSeptember > 0)
                            {
                                september("in development");
                            }
                            else
                            {
                                september("invalid");
                            }
                            break;


                        // reset data absensi
                        case 5:
                            if (DataStorage.jumlahAbsenSeptember > 0)
                            {
                                september("in development");
                            }
                            else
                            {
                                september("invalid");
                            }
                            break;


                        // impor data absensi
                        case 6:
                            if (DataStorage.jumlahAbsenSeptember > 0)
                            {
                                september("in development");
                            }
                            else
                            {
                                september("invalid");
                            }
                            break;


                        // ekspor data absensi
                        default:
                            if (DataStorage.jumlahAbsenSeptember > 0)
                            {
                                september("in development");
                            }
                            else
                            {
                                september("invalid");
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

                    DataStorage.namaLengkapSeptemberColumn = Math.Max(DataStorage.namaLengkapSeptemberColumn, namaLengkap.Length);
                    DataStorage.alamatAbsensiSeptemberColumn = Math.Max(DataStorage.alamatAbsensiSeptemberColumn, alamat.Length);
                    DataStorage.jumlahAbsenSeptember++;
                    nisn = DataStorage.nisnTemplate.Substring(0, (DataStorage.nisnTemplate.Length - Convert.ToInt32(Math.Floor(Math.Log(DataStorage.jumlahAbsenSeptember))))) + DataStorage.jumlahAbsenSeptember;

                    DataStorage.daftarNisnAbsensiSeptember.Add(nisn);
                    DataStorage.daftarNamaLengkapAbsensiSeptember.Add(namaLengkap);
                    DataStorage.daftarAbsensiHadirSeptember.Add(hadir);
                    DataStorage.daftarAbsensiSakitSeptember.Add(sakit);
                    DataStorage.daftarAbsensiIzinSeptember.Add(izin);
                    DataStorage.daftarAbsensiAlfaSeptember.Add(alfa);
                    DataStorage.daftarAlamatAbsensiSeptember.Add(alamat);

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Data absensi bulan September");
                    Console.WriteLine("telah berhasil ditambahkan!\n");
                    isLoop = false;
                    september();
                }
            }
            else if (method == "read")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n>> Daftar Data Absensi September <<");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"+-----+------------+--------------{new string('-', DataStorage.namaLengkapSeptemberColumn - DataStorage.NAMA_LENGKAP_COLUMN)}+-------+------+-------+------+--------{new string('-', DataStorage.alamatAbsensiSeptemberColumn - DataStorage.ALAMAT_COLUMN)}+");
                Console.WriteLine($"| No. | Nisn       | Nama Lengkap{new string(' ', DataStorage.namaLengkapSeptemberColumn - DataStorage.NAMA_LENGKAP_COLUMN)} | Hadir | Izin | Sakit | Alfa | Alamat{new string(' ', DataStorage.alamatAbsensiSeptemberColumn - DataStorage.ALAMAT_COLUMN)} |");
                Console.WriteLine($"+-----+------------+--------------{new string('-', DataStorage.namaLengkapSeptemberColumn - DataStorage.NAMA_LENGKAP_COLUMN)}+-------+------+-------+------+--------{new string('-', DataStorage.alamatAbsensiSeptemberColumn - DataStorage.ALAMAT_COLUMN)}+");

                for (int i = 0; i < DataStorage.jumlahAbsenSeptember; i++)
                {
                    // no
                    Console.Write($"| {i + 1}. {new string(' ', 2 - i.ToString().Length)}| ");

                    // nisn
                    Console.Write($"{DataStorage.daftarNisnAbsensiSeptember[i]} | ");

                    // nama lengkap
                    Console.Write($"{DataStorage.daftarNamaLengkapAbsensiSeptember[i]} {new string(' ', DataStorage.namaLengkapSeptemberColumn - DataStorage.daftarNamaLengkapAbsensiSeptember[i].Length)}| ");

                    // hadir
                    Console.Write($"{DataStorage.daftarAbsensiHadirSeptember[i]} {new string(' ', 5 - DataStorage.daftarAbsensiHadirSeptember[i].ToString().Length)}| ");

                    // izin
                    Console.Write($"{DataStorage.daftarAbsensiIzinSeptember[i]} {new string(' ', 4 - DataStorage.daftarAbsensiIzinSeptember[i].ToString().Length)}| ");

                    // sakit
                    Console.Write($"{DataStorage.daftarAbsensiSakitSeptember[i]} {new string(' ', 5 - DataStorage.daftarAbsensiSakitSeptember[i].ToString().Length)}| ");

                    // alfa
                    Console.Write($"{DataStorage.daftarAbsensiAlfaSeptember[i]} {new string(' ', 4 - DataStorage.daftarAbsensiAlfaSeptember[i].ToString().Length)}| ");

                    // alamat
                    Console.WriteLine($"{DataStorage.daftarAlamatAbsensiSeptember[i]} {new string(' ', DataStorage.alamatAbsensiSeptemberColumn - DataStorage.daftarAlamatAbsensiSeptember[i].Length)}|");
                }

                Console.WriteLine($"+-----+------------+--------------{new string('-', DataStorage.namaLengkapSeptemberColumn - DataStorage.NAMA_LENGKAP_COLUMN)}+-------+------+-------+------+--------{new string('-', DataStorage.alamatAbsensiSeptemberColumn - DataStorage.ALAMAT_COLUMN)}+\n");
            }
            else if (method == "update")
            {

            }
            else if (method == "invalid")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nAksi tidak valid!");
                Console.WriteLine("Silakan coba lagi...\n");
                september();
            }
            else if (method == "in development")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nAksi masih dalam proses pengembangan!");
                Console.WriteLine("Mohon bersabar :)");
                Console.WriteLine("Silakan coba aksi lain...\n");
                september();
            }
        }

        public static void oktober(string method = "")
        {
            if (method == "")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("------------------------------");
                Console.WriteLine("|   Data Absensi - Oktober   |");
                Console.WriteLine("------------------------------");

                int opsi;
                List<string> daftarAksi = ["Tambah Absensi Baru", "Lihat Data Absensi", "Impor Data Absensi"];
                if (DataStorage.jumlahAbsenOktober > 0)
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
                            oktober("create");
                            break;


                        // lihat data absensi
                        case 2:
                            if (DataStorage.jumlahAbsenOktober > 0)
                            {
                                oktober("read");
                                oktober();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nData absensi kosong!");
                                Console.WriteLine("Mohon tambahkan terlebih dahulu...\n");
                                oktober();
                            }
                            break;


                        // impor data absensi / ubah data absensi
                        case 3:
                            if (DataStorage.jumlahAbsenOktober > 0)
                            {
                                // ubah data absensi
                                oktober("in development");
                            }
                            else
                            {
                                // impor data absensi
                                oktober("in development");
                            }
                            break;


                        // hapus data absensi
                        case 4:
                            if (DataStorage.jumlahAbsenOktober > 0)
                            {
                                oktober("in development");
                            }
                            else
                            {
                                oktober("invalid");
                            }
                            break;


                        // reset data absensi
                        case 5:
                            if (DataStorage.jumlahAbsenOktober > 0)
                            {
                                oktober("in development");
                            }
                            else
                            {
                                oktober("invalid");
                            }
                            break;


                        // impor data absensi
                        case 6:
                            if (DataStorage.jumlahAbsenOktober > 0)
                            {
                                oktober("in development");
                            }
                            else
                            {
                                oktober("invalid");
                            }
                            break;


                        // ekspor data absensi
                        default:
                            if (DataStorage.jumlahAbsenOktober > 0)
                            {
                                oktober("in development");
                            }
                            else
                            {
                                oktober("invalid");
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

                    DataStorage.namaLengkapOktoberColumn = Math.Max(DataStorage.namaLengkapOktoberColumn, namaLengkap.Length);
                    DataStorage.alamatAbsensiOktoberColumn = Math.Max(DataStorage.alamatAbsensiOktoberColumn, alamat.Length);
                    DataStorage.jumlahAbsenOktober++;
                    nisn = DataStorage.nisnTemplate.Substring(0, (DataStorage.nisnTemplate.Length - Convert.ToInt32(Math.Floor(Math.Log(DataStorage.jumlahAbsenOktober))))) + DataStorage.jumlahAbsenOktober;

                    DataStorage.daftarNisnAbsensiOktober.Add(nisn);
                    DataStorage.daftarNamaLengkapAbsensiOktober.Add(namaLengkap);
                    DataStorage.daftarAbsensiHadirOktober.Add(hadir);
                    DataStorage.daftarAbsensiSakitOktober.Add(sakit);
                    DataStorage.daftarAbsensiIzinOktober.Add(izin);
                    DataStorage.daftarAbsensiAlfaOktober.Add(alfa);
                    DataStorage.daftarAlamatAbsensiOktober.Add(alamat);

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Data absensi bulan Oktober");
                    Console.WriteLine("telah berhasil ditambahkan!\n");
                    isLoop = false;
                    oktober();
                }
            }
            else if (method == "read")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n>> Daftar Data Absensi Oktober <<");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"+-----+------------+--------------{new string('-', DataStorage.namaLengkapOktoberColumn - DataStorage.NAMA_LENGKAP_COLUMN)}+-------+------+-------+------+--------{new string('-', DataStorage.alamatAbsensiOktoberColumn - DataStorage.ALAMAT_COLUMN)}+");
                Console.WriteLine($"| No. | Nisn       | Nama Lengkap{new string(' ', DataStorage.namaLengkapOktoberColumn - DataStorage.NAMA_LENGKAP_COLUMN)} | Hadir | Izin | Sakit | Alfa | Alamat{new string(' ', DataStorage.alamatAbsensiOktoberColumn - DataStorage.ALAMAT_COLUMN)} |");
                Console.WriteLine($"+-----+------------+--------------{new string('-', DataStorage.namaLengkapOktoberColumn - DataStorage.NAMA_LENGKAP_COLUMN)}+-------+------+-------+------+--------{new string('-', DataStorage.alamatAbsensiOktoberColumn - DataStorage.ALAMAT_COLUMN)}+");

                for (int i = 0; i < DataStorage.jumlahAbsenOktober; i++)
                {
                    // no
                    Console.Write($"| {i + 1}. {new string(' ', 2 - i.ToString().Length)}| ");

                    // nisn
                    Console.Write($"{DataStorage.daftarNisnAbsensiOktober[i]} | ");

                    // nama lengkap
                    Console.Write($"{DataStorage.daftarNamaLengkapAbsensiOktober[i]} {new string(' ', DataStorage.namaLengkapOktoberColumn - DataStorage.daftarNamaLengkapAbsensiOktober[i].Length)}| ");

                    // hadir
                    Console.Write($"{DataStorage.daftarAbsensiHadirOktober[i]} {new string(' ', 5 - DataStorage.daftarAbsensiHadirOktober[i].ToString().Length)}| ");

                    // izin
                    Console.Write($"{DataStorage.daftarAbsensiIzinOktober[i]} {new string(' ', 4 - DataStorage.daftarAbsensiIzinOktober[i].ToString().Length)}| ");

                    // sakit
                    Console.Write($"{DataStorage.daftarAbsensiSakitOktober[i]} {new string(' ', 5 - DataStorage.daftarAbsensiSakitOktober[i].ToString().Length)}| ");

                    // alfa
                    Console.Write($"{DataStorage.daftarAbsensiAlfaOktober[i]} {new string(' ', 4 - DataStorage.daftarAbsensiAlfaOktober[i].ToString().Length)}| ");

                    // alamat
                    Console.WriteLine($"{DataStorage.daftarAlamatAbsensiOktober[i]} {new string(' ', DataStorage.alamatAbsensiOktoberColumn - DataStorage.daftarAlamatAbsensiOktober[i].Length)}|");
                }

                Console.WriteLine($"+-----+------------+--------------{new string('-', DataStorage.namaLengkapOktoberColumn - DataStorage.NAMA_LENGKAP_COLUMN)}+-------+------+-------+------+--------{new string('-', DataStorage.alamatAbsensiOktoberColumn - DataStorage.ALAMAT_COLUMN)}+\n");
            }
            else if (method == "update")
            {

            }
            else if (method == "invalid")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nAksi tidak valid!");
                Console.WriteLine("Silakan coba lagi...\n");
                oktober();
            }
            else if (method == "in development")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nAksi masih dalam proses pengembangan!");
                Console.WriteLine("Mohon bersabar :)");
                Console.WriteLine("Silakan coba aksi lain...\n");
                oktober();
            }
        }

        public static void november(string method = "")
        {
            if (method == "")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("-------------------------------");
                Console.WriteLine("|   Data Absensi - November   |");
                Console.WriteLine("-------------------------------");

                int opsi;
                List<string> daftarAksi = ["Tambah Absensi Baru", "Lihat Data Absensi", "Impor Data Absensi"];
                if (DataStorage.jumlahAbsenNovember > 0)
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
                            november("create");
                            break;


                        // lihat data absensi
                        case 2:
                            if (DataStorage.jumlahAbsenNovember > 0)
                            {
                                november("read");
                                november();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nData absensi kosong!");
                                Console.WriteLine("Mohon tambahkan terlebih dahulu...\n");
                                november();
                            }
                            break;


                        // impor data absensi / ubah data absensi
                        case 3:
                            if (DataStorage.jumlahAbsenNovember > 0)
                            {
                                // ubah data absensi
                                november("in development");
                            }
                            else
                            {
                                // impor data absensi
                                november("in development");
                            }
                            break;


                        // hapus data absensi
                        case 4:
                            if (DataStorage.jumlahAbsenNovember > 0)
                            {
                                november("in development");
                            }
                            else
                            {
                                november("invalid");
                            }
                            break;


                        // reset data absensi
                        case 5:
                            if (DataStorage.jumlahAbsenNovember > 0)
                            {
                                november("in development");
                            }
                            else
                            {
                                november("invalid");
                            }
                            break;


                        // impor data absensi
                        case 6:
                            if (DataStorage.jumlahAbsenNovember > 0)
                            {
                                november("in development");
                            }
                            else
                            {
                                november("invalid");
                            }
                            break;


                        // ekspor data absensi
                        default:
                            if (DataStorage.jumlahAbsenNovember > 0)
                            {
                                november("in development");
                            }
                            else
                            {
                                november("invalid");
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

                    DataStorage.namaLengkapNovemberColumn = Math.Max(DataStorage.namaLengkapNovemberColumn, namaLengkap.Length);
                    DataStorage.alamatAbsensiNovemberColumn = Math.Max(DataStorage.alamatAbsensiNovemberColumn, alamat.Length);
                    DataStorage.jumlahAbsenNovember++;
                    nisn = DataStorage.nisnTemplate.Substring(0, (DataStorage.nisnTemplate.Length - Convert.ToInt32(Math.Floor(Math.Log(DataStorage.jumlahAbsenNovember))))) + DataStorage.jumlahAbsenNovember;

                    DataStorage.daftarNisnAbsensiNovember.Add(nisn);
                    DataStorage.daftarNamaLengkapAbsensiNovember.Add(namaLengkap);
                    DataStorage.daftarAbsensiHadirNovember.Add(hadir);
                    DataStorage.daftarAbsensiSakitNovember.Add(sakit);
                    DataStorage.daftarAbsensiIzinNovember.Add(izin);
                    DataStorage.daftarAbsensiAlfaNovember.Add(alfa);
                    DataStorage.daftarAlamatAbsensiNovember.Add(alamat);

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Data absensi bulan November");
                    Console.WriteLine("telah berhasil ditambahkan!\n");
                    isLoop = false;
                    november();
                }
            }
            else if (method == "read")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n>> Daftar Data Absensi November <<");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"+-----+------------+--------------{new string('-', DataStorage.namaLengkapNovemberColumn - DataStorage.NAMA_LENGKAP_COLUMN)}+-------+------+-------+------+--------{new string('-', DataStorage.alamatAbsensiNovemberColumn - DataStorage.ALAMAT_COLUMN)}+");
                Console.WriteLine($"| No. | Nisn       | Nama Lengkap{new string(' ', DataStorage.namaLengkapNovemberColumn - DataStorage.NAMA_LENGKAP_COLUMN)} | Hadir | Izin | Sakit | Alfa | Alamat{new string(' ', DataStorage.alamatAbsensiNovemberColumn - DataStorage.ALAMAT_COLUMN)} |");
                Console.WriteLine($"+-----+------------+--------------{new string('-', DataStorage.namaLengkapNovemberColumn - DataStorage.NAMA_LENGKAP_COLUMN)}+-------+------+-------+------+--------{new string('-', DataStorage.alamatAbsensiNovemberColumn - DataStorage.ALAMAT_COLUMN)}+");

                for (int i = 0; i < DataStorage.jumlahAbsenNovember; i++)
                {
                    // no
                    Console.Write($"| {i + 1}. {new string(' ', 2 - i.ToString().Length)}| ");

                    // nisn
                    Console.Write($"{DataStorage.daftarNisnAbsensiNovember[i]} | ");

                    // nama lengkap
                    Console.Write($"{DataStorage.daftarNamaLengkapAbsensiNovember[i]} {new string(' ', DataStorage.namaLengkapNovemberColumn - DataStorage.daftarNamaLengkapAbsensiNovember[i].Length)}| ");

                    // hadir
                    Console.Write($"{DataStorage.daftarAbsensiHadirNovember[i]} {new string(' ', 5 - DataStorage.daftarAbsensiHadirNovember[i].ToString().Length)}| ");

                    // izin
                    Console.Write($"{DataStorage.daftarAbsensiIzinNovember[i]} {new string(' ', 4 - DataStorage.daftarAbsensiIzinNovember[i].ToString().Length)}| ");

                    // sakit
                    Console.Write($"{DataStorage.daftarAbsensiSakitNovember[i]} {new string(' ', 5 - DataStorage.daftarAbsensiSakitNovember[i].ToString().Length)}| ");

                    // alfa
                    Console.Write($"{DataStorage.daftarAbsensiAlfaNovember[i]} {new string(' ', 4 - DataStorage.daftarAbsensiAlfaNovember[i].ToString().Length)}| ");

                    // alamat
                    Console.WriteLine($"{DataStorage.daftarAlamatAbsensiNovember[i]} {new string(' ', DataStorage.alamatAbsensiNovemberColumn - DataStorage.daftarAlamatAbsensiNovember[i].Length)}|");
                }

                Console.WriteLine($"+-----+------------+--------------{new string('-', DataStorage.namaLengkapNovemberColumn - DataStorage.NAMA_LENGKAP_COLUMN)}+-------+------+-------+------+--------{new string('-', DataStorage.alamatAbsensiNovemberColumn - DataStorage.ALAMAT_COLUMN)}+\n");
            }
            else if (method == "update")
            {

            }
            else if (method == "invalid")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nAksi tidak valid!");
                Console.WriteLine("Silakan coba lagi...\n");
                november();
            }
            else if (method == "in development")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nAksi masih dalam proses pengembangan!");
                Console.WriteLine("Mohon bersabar :)");
                Console.WriteLine("Silakan coba aksi lain...\n");
                november();
            }
        }

        public static void desember(string method = "")
        {
            if (method == "")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("-------------------------------");
                Console.WriteLine("|   Data Absensi - Desember   |");
                Console.WriteLine("-------------------------------");

                int opsi;
                List<string> daftarAksi = ["Tambah Absensi Baru", "Lihat Data Absensi", "Impor Data Absensi"];
                if (DataStorage.jumlahAbsenDesember > 0)
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
                            desember("create");
                            break;


                        // lihat data absensi
                        case 2:
                            if (DataStorage.jumlahAbsenDesember > 0)
                            {
                                desember("read");
                                desember();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nData absensi kosong!");
                                Console.WriteLine("Mohon tambahkan terlebih dahulu...\n");
                                desember();
                            }
                            break;


                        // impor data absensi / ubah data absensi
                        case 3:
                            if (DataStorage.jumlahAbsenDesember > 0)
                            {
                                // ubah data absensi
                                desember("in development");
                            }
                            else
                            {
                                // impor data absensi
                                desember("in development");
                            }
                            break;


                        // hapus data absensi
                        case 4:
                            if (DataStorage.jumlahAbsenDesember > 0)
                            {
                                desember("in development");
                            }
                            else
                            {
                                desember("invalid");
                            }
                            break;


                        // reset data absensi
                        case 5:
                            if (DataStorage.jumlahAbsenDesember > 0)
                            {
                                desember("in development");
                            }
                            else
                            {
                                desember("invalid");
                            }
                            break;


                        // impor data absensi
                        case 6:
                            if (DataStorage.jumlahAbsenDesember > 0)
                            {
                                desember("in development");
                            }
                            else
                            {
                                desember("invalid");
                            }
                            break;


                        // ekspor data absensi
                        default:
                            if (DataStorage.jumlahAbsenDesember > 0)
                            {
                                desember("in development");
                            }
                            else
                            {
                                desember("invalid");
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

                    DataStorage.namaLengkapDesemberColumn = Math.Max(DataStorage.namaLengkapDesemberColumn, namaLengkap.Length);
                    DataStorage.alamatAbsensiDesemberColumn = Math.Max(DataStorage.alamatAbsensiDesemberColumn, alamat.Length);
                    DataStorage.jumlahAbsenDesember++;
                    nisn = DataStorage.nisnTemplate.Substring(0, (DataStorage.nisnTemplate.Length - Convert.ToInt32(Math.Floor(Math.Log(DataStorage.jumlahAbsenDesember))))) + DataStorage.jumlahAbsenDesember;

                    DataStorage.daftarNisnAbsensiDesember.Add(nisn);
                    DataStorage.daftarNamaLengkapAbsensiDesember.Add(namaLengkap);
                    DataStorage.daftarAbsensiHadirDesember.Add(hadir);
                    DataStorage.daftarAbsensiSakitDesember.Add(sakit);
                    DataStorage.daftarAbsensiIzinDesember.Add(izin);
                    DataStorage.daftarAbsensiAlfaDesember.Add(alfa);
                    DataStorage.daftarAlamatAbsensiDesember.Add(alamat);

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Data absensi bulan Desember");
                    Console.WriteLine("telah berhasil ditambahkan!\n");
                    isLoop = false;
                    desember();
                }
            }
            else if (method == "read")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n>> Daftar Data Absensi Desember <<");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"+-----+------------+--------------{new string('-', DataStorage.namaLengkapDesemberColumn - DataStorage.NAMA_LENGKAP_COLUMN)}+-------+------+-------+------+--------{new string('-', DataStorage.alamatAbsensiDesemberColumn - DataStorage.ALAMAT_COLUMN)}+");
                Console.WriteLine($"| No. | Nisn       | Nama Lengkap{new string(' ', DataStorage.namaLengkapDesemberColumn - DataStorage.NAMA_LENGKAP_COLUMN)} | Hadir | Izin | Sakit | Alfa | Alamat{new string(' ', DataStorage.alamatAbsensiDesemberColumn - DataStorage.ALAMAT_COLUMN)} |");
                Console.WriteLine($"+-----+------------+--------------{new string('-', DataStorage.namaLengkapDesemberColumn - DataStorage.NAMA_LENGKAP_COLUMN)}+-------+------+-------+------+--------{new string('-', DataStorage.alamatAbsensiDesemberColumn - DataStorage.ALAMAT_COLUMN)}+");

                for (int i = 0; i < DataStorage.jumlahAbsenDesember; i++)
                {
                    // no
                    Console.Write($"| {i + 1}. {new string(' ', 2 - i.ToString().Length)}| ");

                    // nisn
                    Console.Write($"{DataStorage.daftarNisnAbsensiDesember[i]} | ");

                    // nama lengkap
                    Console.Write($"{DataStorage.daftarNamaLengkapAbsensiDesember[i]} {new string(' ', DataStorage.namaLengkapDesemberColumn - DataStorage.daftarNamaLengkapAbsensiDesember[i].Length)}| ");

                    // hadir
                    Console.Write($"{DataStorage.daftarAbsensiHadirDesember[i]} {new string(' ', 5 - DataStorage.daftarAbsensiHadirDesember[i].ToString().Length)}| ");

                    // izin
                    Console.Write($"{DataStorage.daftarAbsensiIzinDesember[i]} {new string(' ', 4 - DataStorage.daftarAbsensiIzinDesember[i].ToString().Length)}| ");

                    // sakit
                    Console.Write($"{DataStorage.daftarAbsensiSakitDesember[i]} {new string(' ', 5 - DataStorage.daftarAbsensiSakitDesember[i].ToString().Length)}| ");

                    // alfa
                    Console.Write($"{DataStorage.daftarAbsensiAlfaDesember[i]} {new string(' ', 4 - DataStorage.daftarAbsensiAlfaDesember[i].ToString().Length)}| ");

                    // alamat
                    Console.WriteLine($"{DataStorage.daftarAlamatAbsensiDesember[i]} {new string(' ', DataStorage.alamatAbsensiDesemberColumn - DataStorage.daftarAlamatAbsensiDesember[i].Length)}|");
                }

                Console.WriteLine($"+-----+------------+--------------{new string('-', DataStorage.namaLengkapDesemberColumn - DataStorage.NAMA_LENGKAP_COLUMN)}+-------+------+-------+------+--------{new string('-', DataStorage.alamatAbsensiDesemberColumn - DataStorage.ALAMAT_COLUMN)}+\n");
            }
            else if (method == "update")
            {

            }
            else if (method == "invalid")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nAksi tidak valid!");
                Console.WriteLine("Silakan coba lagi...\n");
                desember();
            }
            else if (method == "in development")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nAksi masih dalam proses pengembangan!");
                Console.WriteLine("Mohon bersabar :)");
                Console.WriteLine("Silakan coba aksi lain...\n");
                desember();
            }
        }
    }
}