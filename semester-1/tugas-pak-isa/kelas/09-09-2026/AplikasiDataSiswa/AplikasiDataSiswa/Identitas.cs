using System;

namespace AplikasiDataSiswa
{
    class Identitas
    {
        public static void siswa()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------------------------------");
            Console.WriteLine("|   Data Identitas - Siswa   |");
            Console.WriteLine("------------------------------");

            int opsi;
            List<string> daftarAksi = ["Kembali", "Tambah Siswa Baru", "Lihat Data Siswa", "Impor Data"];
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

            if (opsi >= 0 && opsi <= 4)
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
                                Console.WriteLine("Jenis kelamin tidak valid,");
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
                                Console.WriteLine("Jenis kelamin tidak valid,");
                                Console.WriteLine("harap ketikkan 'l' ataupun 'p'!");
                                Console.WriteLine("Coba lagi...");
                            }
                        }
                        break;

                    // lihat data siswa
                    case 2:
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

                    // impor data
                    case 3:
                        break;
                    
                    // ekspor data
                    default:
                        if (DataStorage.jumlahSiswa > 0)
                        {
                            // allow
                        }
                        else
                        {
                            // error
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

        public static void wali(string mode = "")
        {
            if (mode == "")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("-----------------------------");
                Console.WriteLine("|   Data Identitas - Wali   |");
                Console.WriteLine("-----------------------------");

                int opsi;
                List<string> daftarAksi = ["Kembali", "Tambah Wali Baru", "Lihat Data Wali", "Impor Data"];
                if (DataStorage.jumlahWali > 0)
                {
                    daftarAksi.Insert(3, "Ubah Data Wali");
                    daftarAksi.Insert(4, "Hapus Data Wali");
                    daftarAksi.Insert(5, "Reset Data Wali");
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

                if (opsi >= 0 && opsi <= 7)
                {
                    switch (opsi)
                    {
                        // kembali ke home
                        case 0:
                            Console.Clear();
                            Home.identitas();
                            break;

                        // tambah wali baru
                        case 1:
                            string nama;
                            int umur;
                            string alamat;
                            string telepon;

                            bool isLoop = true;
                            while (isLoop)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\n>> Tambah Wali Baru <<");

                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("Nama wali: ");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                nama = Console.ReadLine();

                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("Umur wali: ");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                umur = Convert.ToInt32(Console.ReadLine());

                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("Telepon wali: ");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                telepon = Console.ReadLine();

                                // validasi telepon
                                if (telepon.Length >= 10 && telepon.Length <= 12)
                                {
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.Write("Alamat wali: ");
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    alamat = Console.ReadLine();

                                    DataStorage.namaWaliColumn = Math.Max(DataStorage.namaWaliColumn, nama.Length);
                                    DataStorage.alamatWaliColumn = Math.Max(DataStorage.alamatWaliColumn, alamat.Length);

                                    // simpan data
                                    DataStorage.jumlahWali++;
                                    DataStorage.daftarNamaWali.Add(nama);
                                    DataStorage.daftarUmurWali.Add(umur);
                                    DataStorage.daftarAlamatWali.Add(alamat);
                                    DataStorage.daftarTeleponWali.Add(telepon);

                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Data wali berhasil ditambahkan!\n");
                                    isLoop = false;
                                    wali();
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("No. telepon harus diantara 10 - 12 karakter!");
                                    Console.WriteLine("Silahkan coba lagi...\n");
                                }
                            }
                            break;

                        // lihat data wali
                        case 2:
                            wali("read");
                            break;

                        // impor data / ubah data wali
                        case 3:
                            if (DataStorage.jumlahWali > 0)
                            {
                                // ubah data
                            }
                            else
                            {
                                // impor data
                            }
                            break;

                        // hapus data wali
                        case 4:
                            if (DataStorage.jumlahWali > 0)
                            {
                                
                            }
                            else
                            {
                                wali("invalid");
                            }
                            break;

                        // reset data wali
                        case 5:
                            if (DataStorage.jumlahWali > 0)
                            {
                                
                            }
                            else
                            {
                                wali("invalid");
                            }
                            break;

                        // impor data wali
                        case 6:
                            if (DataStorage.jumlahWali > 0)
                            {
                                
                            }
                            else
                            {
                                wali("invalid");
                            }
                            break;

                        // ekspor data
                        default:
                            if (DataStorage.jumlahWali > 0)
                            {

                            }
                            else
                            {
                                wali("invalid");
                            }
                            break;
                    }
                }
                else
                {
                    wali("invalid");
                }
            }
            else if (mode == "read")
            {
                if (DataStorage.jumlahWali > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n>> Daftar Data Wali <<\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("+-----+");
                    Console.Write($"-----------{new string('-', DataStorage.namaWaliColumn - DataStorage.NAMA_WALI_COLUMN)}+------+--------------+-------------");
                    Console.Write($"{new string('-', DataStorage.alamatWaliColumn - DataStorage.ALAMAT_WALI_COLUMN)}+\n");
                    Console.Write("| No. | Nama Wali");
                    Console.Write($"{new string(' ', DataStorage.namaWaliColumn - DataStorage.NAMA_WALI_COLUMN)} | ");
                    Console.Write($"Umur | Telepon Wali | Alamat Wali");
                    Console.Write($"{new string(' ', DataStorage.alamatWaliColumn - DataStorage.ALAMAT_WALI_COLUMN)} |\n");
                    Console.Write("+-----+");
                    Console.Write($"-----------{new string('-', DataStorage.namaWaliColumn - DataStorage.NAMA_WALI_COLUMN)}+------+--------------+-------------");
                    Console.Write($"{new string('-', DataStorage.alamatWaliColumn - DataStorage.ALAMAT_WALI_COLUMN)}+\n");

                    for (int i = 0; i < DataStorage.jumlahWali; i++)
                    {
                        // no
                        if (i >= 0 && i < 9)
                        {
                            Console.Write($"| {i + 1}.  | ");
                        }
                        else
                        {
                            Console.Write($"| {i + 1}. | ");
                        }

                        // nama wali
                        Console.Write($"{DataStorage.daftarNamaWali[i]}{new string(' ', DataStorage.namaWaliColumn - DataStorage.daftarNamaWali[i].Length)} | ");

                        // umur wali
                        Console.Write($"{DataStorage.daftarUmurWali[i]}{new string(' ', DataStorage.UMUR_WALI_COLUMN - DataStorage.daftarUmurWali[i].ToString().Length)} | ");

                        // telepon wali
                        Console.Write($"{DataStorage.daftarTeleponWali[i]}{new string(' ', DataStorage.TELEPON_WALI_COLUMN - DataStorage.daftarTeleponWali[i].Length)} | ");

                        // alamat wali
                        Console.Write($"{DataStorage.daftarAlamatWali[i]}{new string(' ', DataStorage.alamatWaliColumn - DataStorage.daftarAlamatWali[i].Length)} |\n");
                    }

                    Console.Write("+-----+");
                    Console.Write($"-----------{new string('-', DataStorage.namaWaliColumn - DataStorage.NAMA_WALI_COLUMN)}+------+--------------+-------------");
                    Console.Write($"{new string('-', DataStorage.alamatWaliColumn - DataStorage.ALAMAT_WALI_COLUMN)}+\n\n");
                    wali();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nTidak ada data wali satupun!");
                    Console.WriteLine("Mohon tambahkan wali terlebih dahulu...\n");
                    wali();
                }
            }
            else if (mode == "invalid")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nAksi tidak valid!");
                Console.WriteLine("Silahkan coba lagi...\n");
                wali();
            }
        }

        public static void sekolah()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------------------------");
            Console.WriteLine("|   Data Identitas - Sekolah   |");
            Console.WriteLine("-------------------------------");

            int opsi;
            List<string> daftarAksi = ["Kembali", "Tambah Sekolah Baru", "Lihat Data Sekolah", "Impor Data"];
            if (DataStorage.jumlahSekolah > 0)
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

            if (opsi >= 0 && opsi <= 4)
            {
                switch (opsi)
                {
                    // kembali ke home
                    case 0:
                        Console.Clear();
                        Home.identitas();
                        break;

                    // tambah sekolah baru
                    case 1:
                        break;

                    // lihat data sekolah
                    case 2:
                        break;

                    // impor data
                    case 3:
                        break;

                    // ekspor data
                    default:
                        break;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nAksi tidak valid!");
                Console.WriteLine("Silahkan coba lagi...\n");
                sekolah();
            }
        }
    }
}