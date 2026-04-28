using System;

namespace AplikasiDataSiswa
{
    class Identitas
    {
        // data siswa
        string nisnTemplate = "000000000"; // 9 digit
        int jumlahSiswa = 0;
        List<string> daftarNisnSiswa;
        List<string> daftarNamaLengkapSiswa;
        List<string> daftarNamaPanggilanSiswa;
        List<char> daftarJenisKelaminSiswa;
        List<int> daftarUmurSiswa;
        List<string> daftarAlamatSiswa;
        List<string> daftarSekolahSiswa;

        int namaLengkapSiswaColumn = 12;
        int alamatSiswaColumn = 6;
        int namaSekolahSiswaColumn = 12;

        // data wali
        int jumlahWali = 0;
        List<string> daftarNamaWali;
        List<int> daftarUmurWali;
        List<string> daftarAlamatWali;
        List<string> daftarTeleponWali;

        // data sekolah
        int jumlahSekolah = 0;
        List<string> daftarNamaSekolah;
        List<string> daftarAlamatSekolah;

        public void siswa(int opsi)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("|   Data Identitas - Siswa   |");
            Console.WriteLine("------------------------------");
            string[] daftarAksi = { "Kembali", "Tambah Siswa Baru", "Lihat Data Siswa" };

            Console.WriteLine("\n>> Daftar Aksi <<");
            for (int i = 0; i < daftarAksi.Length; i++)
            {
                Console.WriteLine($"[{i}] {daftarAksi[i]}");
            }
            Console.Write("Pilih aksi: ");
            opsi = Convert.ToInt32(Console.ReadLine());

            if (opsi >= 0 && opsi <= 2)
            {
                switch (opsi)
                {
                    // kembali ke home
                    case 0:
                        Console.Clear();
                        Home.identitas(opsi);
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
                            Console.WriteLine("\n>> Tambah Siswa Baru <<");

                            Console.Write("Nama lengkap: ");
                            namaLengkap = Console.ReadLine();
                            Console.Write("Nama panggilan: ");
                            namaPanggilan = Console.ReadLine();
                            Console.Write("Jenis kelamin (l/p): ");
                            jenisKelamin = Console.ReadLine().ToUpper();

                            if (jenisKelamin.Length > 1)
                            {
                                Console.Clear();
                                Console.WriteLine("\nJenis kelamin tidak valid,");
                                Console.WriteLine("harap ketikkan 'l' ataupun 'p'!");
                                Console.WriteLine("Coba lagi...");
                            }
                            else if (jenisKelamin[0] == 'L' || jenisKelamin[0] == 'P')
                            {
                                Console.Write("Umur: ");
                                umur = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Alamat: ");
                                alamat = Console.ReadLine();
                                Console.Write("Nama Sekolah: ");
                                namaSekolah = Console.ReadLine();

                                namaSekolahSiswaColumn = Math.Max(namaSekolahSiswaColumn, namaSekolah.Length);
                                if (jumlahSiswa == 0)
                                {
                                    daftarNisnSiswa = new List<string>();
                                    daftarNamaLengkapSiswa = new List<string>();
                                    daftarNamaPanggilanSiswa = new List<string>();
                                    daftarJenisKelaminSiswa = new List<char>();
                                    daftarUmurSiswa = new List<int>();
                                    daftarAlamatSiswa = new List<string>();
                                    daftarSekolahSiswa = new List<string>();
                                }

                                jumlahSiswa++;
                                nisn = nisnTemplate.Substring(0, (nisnTemplate.Length - Convert.ToInt32(Math.Floor(Math.Log(jumlahSiswa))))) + jumlahSiswa;
                                daftarNisnSiswa.Add(nisn);
                                daftarNamaLengkapSiswa.Add(namaLengkap);
                                daftarNamaPanggilanSiswa.Add(namaPanggilan);
                                daftarJenisKelaminSiswa.Add(jenisKelamin[0]);
                                daftarUmurSiswa.Add(umur);
                                daftarAlamatSiswa.Add(alamat);
                                daftarSekolahSiswa.Add(namaSekolah);
                                Console.Clear();
                                Console.WriteLine("Data siswa berhasil ditambahkan!\n");
                                isLoop = false;
                                siswa(opsi);
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("\nJenis kelamin tidak valid,");
                                Console.WriteLine("harap ketikkan 'l' ataupun 'p'!");
                                Console.WriteLine("Coba lagi...");
                            }
                        }
                        break;

                    // lihat data siswa
                    default:
                        if (jumlahSiswa > 0)
                        {
                            Console.WriteLine("\n>> Daftar Data Siswa <<\n");
                            Console.Write("-------------------------------------------------------------------------------------------------------------------------------------------");
                            for (int i = 0; i <= namaSekolahSiswaColumn - 12; i++)
                            {
                                Console.Write("-");
                            }
                            Console.Write("\n");
                            Console.WriteLine("No.   | NISN       | Nama Lengkap                             | Nama Panggilan | Jenis Kelamin | Umur | Alamat               | Nama Sekolah");
                            Console.Write("-------------------------------------------------------------------------------------------------------------------------------------------");
                            for (int i = 0; i <= namaSekolahSiswaColumn - 12; i++)
                            {
                                Console.Write("-");
                            }
                            Console.Write("\n");

                            for (int i = 0; i < jumlahSiswa; i++)
                            {
                                // no
                                if (i >= 0 && i < 9)
                                {
                                    Console.Write($"{i + 1}.    | ");
                                }
                                else
                                {
                                    Console.Write($"{i + 1}.   | ");
                                }

                                // nisn
                                Console.Write($"{daftarNisnSiswa[i]} | ");

                                // nama lengkap
                                Console.Write($"{daftarNamaLengkapSiswa[i]} ");
                                for (int j = 1; j <= 39 - daftarNamaLengkapSiswa[i].Length; j++)
                                {
                                    Console.Write(" ");
                                }
                                Console.Write(" | ");

                                // nama panggilan
                                Console.Write($"{daftarNamaPanggilanSiswa[i]} ");
                                for (int j = 1; j <= 13 - daftarNamaPanggilanSiswa[i].Length; j++)
                                {
                                    Console.Write(" ");
                                }
                                Console.Write(" | ");

                                // jenis kelamin
                                Console.Write($"{daftarJenisKelaminSiswa[i]}             | ");

                                // umur
                                if (daftarUmurSiswa[i] >= 10)
                                {
                                    Console.Write($"{daftarUmurSiswa[i]}   | ");
                                }
                                else
                                {
                                    Console.Write($"{daftarUmurSiswa[i]}    | ");
                                }

                                // alamat
                                Console.Write($"{daftarAlamatSiswa[i]} ");
                                for (int j = 1; j <= 19 - daftarAlamatSiswa[i].Length; j++)
                                {
                                    Console.Write(" ");
                                }
                                Console.Write(" | ");

                                // nama sekolah
                                Console.Write($"{daftarSekolahSiswa[i]}\n");
                            }

                            Console.Write("-------------------------------------------------------------------------------------------------------------------------------------------");
                            for (int i = 0; i <= namaSekolahSiswaColumn - 12; i++)
                            {
                                Console.Write("-");
                            }
                            Console.WriteLine("\n");

                            siswa(opsi);
                        }
                        else
                        {
                            Console.WriteLine("\nTidak ada data siswa satupun!");
                            Console.WriteLine("Mohon tambahkan siswa terlebih dahulu...");
                            siswa(opsi);
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nAksi tidak valid!");
                Console.WriteLine("Silahkan coba lagi...");
                siswa(opsi);
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