using System;

namespace AplikasiDataSiswa
{
    class Absensi
    {
        // Untuk sekarang mengikuti struktur file awal:
        // CRUD dibuat untuk absensi bulan Januari.
        public static void januari(string method = "")
        {
            while (true)
            {
                Console.Clear();
                Home.Judul("Data Absensi - Januari");

                Console.WriteLine("[1] Tambah Absensi");
                Console.WriteLine("[2] Lihat Data Absensi");
                Console.WriteLine("[3] Ubah Absensi");
                Console.WriteLine("[4] Hapus Absensi");
                Console.WriteLine("[5] Reset Absensi");
                Console.WriteLine("[0] Kembali");

                int opsi = Home.BacaInt("Pilih aksi: ");

                switch (opsi)
                {
                    case 1: Create(); break;
                    case 2: Read(); break;
                    case 3: Update(); break;
                    case 4: Delete(); break;
                    case 5: Reset(); break;
                    case 0: return;
                    default: Home.PesanInvalid(); break;
                }
            }
        }

        static void Create()
        {
            Console.Clear();
            Home.Judul("Tambah Absensi Januari");

            if (DataStorage.jumlahSiswa == 0)
            {
                Console.WriteLine("Tambahkan siswa terlebih dahulu.");
                Home.Tunggu();
                return;
            }

            string nisn = PilihSiswa();

            // satu siswa cukup memiliki satu record absensi januari
            if (CariIndex(nisn) >= 0)
            {
                Console.WriteLine("Data absensi siswa tersebut sudah ada.");
                Home.Tunggu();
                return;
            }

            int hadir = Home.BacaInt("Jumlah hadir: ");
            int sakit = Home.BacaInt("Jumlah sakit: ");
            int izin = Home.BacaInt("Jumlah izin: ");
            int alpha = Home.BacaInt("Jumlah alpha: ");

            if (hadir < 0 || sakit < 0 || izin < 0 || alpha < 0)
            {
                Console.WriteLine("Jumlah absensi tidak boleh negatif.");
                Home.Tunggu();
                return;
            }

            int siswaIndex = DataStorage.daftarNisnSiswa.IndexOf(nisn);

            DataStorage.daftarNisnAbsensiJanuari.Add(nisn);
            DataStorage.daftarNamaAbsensiJanuari.Add(
                DataStorage.daftarNamaLengkapSiswa[siswaIndex]);
            DataStorage.daftarAbsensiHadirJanuari.Add(hadir);
            DataStorage.daftarAbsensiSakitJanuari.Add(sakit);
            DataStorage.daftarAbsensiIzinJanuari.Add(izin);
            DataStorage.daftarAbsensiAlphaJanuari.Add(alpha);
            DataStorage.daftarAlamatAbsensiJanuari.Add(
                DataStorage.daftarAlamatSiswa[siswaIndex]);

            DataStorage.jumlahAbsenJanuari++;

            Console.WriteLine("Data absensi berhasil ditambahkan.");
            Home.Tunggu();
        }

        static void Read()
        {
            Console.Clear();
            Home.Judul("Daftar Absensi Januari");

            if (DataStorage.jumlahAbsenJanuari == 0)
            {
                Console.WriteLine("Belum ada data absensi.");
                Home.Tunggu();
                return;
            }

            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("| No | NISN      | Nama Siswa             | Hadir | Sakit | Izin | Alpha |");
            Console.WriteLine("----------------------------------------------------------------------------");

            for (int i = 0; i < DataStorage.jumlahAbsenJanuari; i++)
            {
                Console.WriteLine(
                    $"| {i + 1,2} | {DataStorage.daftarNisnAbsensiJanuari[i],-9} | " +
                    $"{Potong(DataStorage.daftarNamaAbsensiJanuari[i], 22),-22} | " +
                    $"{DataStorage.daftarAbsensiHadirJanuari[i],5} | " +
                    $"{DataStorage.daftarAbsensiSakitJanuari[i],5} | " +
                    $"{DataStorage.daftarAbsensiIzinJanuari[i],4} | " +
                    $"{DataStorage.daftarAbsensiAlphaJanuari[i],5} |");
            }

            Console.WriteLine("----------------------------------------------------------------------------");
            Home.Tunggu();
        }

        static void Update()
        {
            if (DataStorage.jumlahAbsenJanuari == 0)
            {
                Console.WriteLine("Belum ada data absensi.");
                Home.Tunggu();
                return;
            }

            ReadShort();
            int index = PilihIndex();

            DataStorage.daftarAbsensiHadirJanuari[index] =
                Home.BacaInt("Jumlah hadir baru: ");
            DataStorage.daftarAbsensiSakitJanuari[index] =
                Home.BacaInt("Jumlah sakit baru: ");
            DataStorage.daftarAbsensiIzinJanuari[index] =
                Home.BacaInt("Jumlah izin baru: ");
            DataStorage.daftarAbsensiAlphaJanuari[index] =
                Home.BacaInt("Jumlah alpha baru: ");

            Console.WriteLine("Data absensi berhasil diubah.");
            Home.Tunggu();
        }

        static void Delete()
        {
            if (DataStorage.jumlahAbsenJanuari == 0)
            {
                Console.WriteLine("Belum ada data absensi.");
                Home.Tunggu();
                return;
            }

            ReadShort();
            int index = PilihIndex();

            if (!Home.Konfirmasi("Hapus data absensi ini"))
                return;

            DataStorage.daftarNisnAbsensiJanuari.RemoveAt(index);
            DataStorage.daftarNamaAbsensiJanuari.RemoveAt(index);
            DataStorage.daftarAbsensiHadirJanuari.RemoveAt(index);
            DataStorage.daftarAbsensiSakitJanuari.RemoveAt(index);
            DataStorage.daftarAbsensiIzinJanuari.RemoveAt(index);
            DataStorage.daftarAbsensiAlphaJanuari.RemoveAt(index);
            DataStorage.daftarAlamatAbsensiJanuari.RemoveAt(index);
            DataStorage.jumlahAbsenJanuari--;

            Console.WriteLine("Data absensi berhasil dihapus.");
            Home.Tunggu();
        }

        static void Reset()
        {
            if (!Home.Konfirmasi("Reset seluruh absensi Januari"))
                return;

            DataStorage.daftarNisnAbsensiJanuari.Clear();
            DataStorage.daftarNamaAbsensiJanuari.Clear();
            DataStorage.daftarAbsensiHadirJanuari.Clear();
            DataStorage.daftarAbsensiSakitJanuari.Clear();
            DataStorage.daftarAbsensiIzinJanuari.Clear();
            DataStorage.daftarAbsensiAlphaJanuari.Clear();
            DataStorage.daftarAlamatAbsensiJanuari.Clear();
            DataStorage.jumlahAbsenJanuari = 0;

            Console.WriteLine("Seluruh absensi Januari berhasil direset.");
            Home.Tunggu();
        }

        static void ReadShort()
        {
            Console.WriteLine("\nNo | NISN | Nama Siswa");
            Console.WriteLine("--------------------------------");
            for (int i = 0; i < DataStorage.jumlahAbsenJanuari; i++)
                Console.WriteLine(
                    $"{i + 1,2} | {DataStorage.daftarNisnAbsensiJanuari[i]} | " +
                    $"{DataStorage.daftarNamaAbsensiJanuari[i]}");
        }

        static int PilihIndex()
        {
            while (true)
            {
                int nomor = Home.BacaInt("Nomor data absensi: ");

                if (nomor >= 1 && nomor <= DataStorage.jumlahAbsenJanuari)
                    return nomor - 1;

                Console.WriteLine("Nomor data tidak ditemukan.");
            }
        }

        static string PilihSiswa()
        {
            Console.WriteLine("\nDaftar siswa:");
            for (int i = 0; i < DataStorage.jumlahSiswa; i++)
                Console.WriteLine(
                    $"[{DataStorage.daftarNisnSiswa[i]}] {DataStorage.daftarNamaLengkapSiswa[i]}");

            while (true)
            {
                string nisn = Home.BacaString("NISN siswa: ");

                if (DataStorage.daftarNisnSiswa.Contains(nisn))
                    return nisn;

                Console.WriteLine("NISN tidak ditemukan.");
            }
        }

        static int CariIndex(string nisn)
        {
            return DataStorage.daftarNisnAbsensiJanuari.IndexOf(nisn);
        }

        static string Potong(string teks, int panjang)
        {
            return teks.Length <= panjang
                ? teks
                : teks.Substring(0, Math.Max(0, panjang - 3)) + "...";
        }
    }
}
