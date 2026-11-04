using System;

namespace AplikasiDataSiswa
{
    class Nilai
    {
        public static void nilai()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------------------");
            Console.WriteLine("|   Data Nilai   |");
            Console.WriteLine("------------------");

            int opsi;
            List<string> daftarAksi = ["Tambah Nilai Baru", "Lihat Data Nilai", "Impor Data Nilai"];
            if (DataStorage.jumlahSekolah > 0)
            {
                daftarAksi.Insert(2, "Ubah Data Nilai");
                daftarAksi.Insert(3, "Hapus Data Nilai");
                daftarAksi.Insert(4, "Reset Data Nilai");
                daftarAksi.Add("Ekspor Data Nilai");
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
                        Home.identitas();
                        break;

                    // tambah mata pelajaran baru
                    case 1:
                        Console.Clear();
                        string nama;
                        string alamat;
                        string akreditasi;
                        int indeks;
                        DateTime tanggal;

                        bool isLoop = true;
                        while (isLoop)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n>> Tambah Sekolah Baru <<");

                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("Nama sekolah: ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            nama = Console.ReadLine();

                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("Alamat sekolah: ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            alamat = Console.ReadLine();

                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("Akreditasi sekolah: ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            akreditasi = Console.ReadLine();

                            // validasi akreditasi
                            if (akreditasi.Length > 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nAkreditasi sekolah harus karakter tunggal!");
                                Console.WriteLine("Contoh: A, B, C");
                                Console.WriteLine("Silakan coba lagi...\n");
                            }
                            else if (akreditasi.Length == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nAkreditasi sekolah tidak boleh kosong!");
                                Console.WriteLine("Harap isi dengan karakter tunggal.");
                                Console.WriteLine("Contoh: A, B, C");
                                Console.WriteLine("Silakan coba lagi...\n");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("Indeks sekolah: ");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                indeks = Convert.ToInt32(Console.ReadLine());

                                tanggal = DateTime.Today;
                                DataStorage.namaSekolahColumn = Math.Max(DataStorage.namaSekolahColumn, nama.Length);
                                DataStorage.alamatSekolahColumn = Math.Max(DataStorage.alamatSekolahColumn, alamat.Length);

                                DataStorage.jumlahSekolah++;
                                DataStorage.daftarNamaSekolah.Add(nama);
                                DataStorage.daftarAlamatSekolah.Add(alamat);
                                DataStorage.daftarAkreditasiSekolah.Add(akreditasi[0]);
                                DataStorage.daftarIndeksSekolah.Add(indeks);
                                DataStorage.daftarTanggalSekolah.Add(tanggal.ToString("dd-MM-yyyy"));

                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Data sekolah berhasil ditambahkan!\n");
                                isLoop = false;
                                sekolah();
                            }
                        }
                        break;

                    // lihat data sekolah
                    case 2:
                        sekolah("read");
                        break;

                    // impor data / ubah data sekolah
                    case 3:
                        if (DataStorage.jumlahSekolah > 0)
                        {
                            sekolah("in development");
                        }
                        else
                        {
                            sekolah("in development");
                        }
                        break;


                    // hapus data sekolah
                    case 4:
                        if (DataStorage.jumlahSekolah > 0)
                        {
                            sekolah("in development");
                        }
                        else
                        {
                            sekolah("invalid");
                        }
                        break;


                    // reset data sekolah
                    case 5:
                        if (DataStorage.jumlahSekolah > 0)
                        {
                            sekolah("in development");
                        }
                        else
                        {
                            sekolah("invalid");
                        }
                        break;


                    // impor data sekolah
                    case 6:
                        if (DataStorage.jumlahSekolah > 0)
                        {
                            sekolah("in development");
                        }
                        else
                        {
                            sekolah("invalid");
                        }
                        break;


                    // ekspor data sekolah
                    default:
                        if (DataStorage.jumlahSekolah > 0)
                        {
                            sekolah("in development");
                        }
                        else
                        {
                            sekolah("invalid");
                        }
                        break;
                }
            }
            else
            {
                sekolah("invalid");
            }
        }

        public static void tambahkanData()
        {

        }

        public static void tampilkanData()
        {

        }

        public static void ubahData()
        {

        }

        public static void hapusData()
        {

        }

        public static void imporData()
        { 

        }

        public static void eksporData()
        {

        }

        public static void resetData()
        {

        }

        public static void invalid()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nAksi tidak valid!");
            Console.WriteLine("Silakan coba lagi...\n");
        }

        public static void inDevelopment()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nAksi masih dalam proses pengembangan!");
            Console.WriteLine("Mohon bersabar :)");
            Console.WriteLine("Silakan coba aksi lain...\n");
        }
    }
}