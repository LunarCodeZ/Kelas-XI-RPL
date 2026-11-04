using System;

namespace AplikasiDataSiswa
{
    class MataPelajaran
    {
        public static void Menu()
        {
            while (true)
            {
                Console.Clear();
                Home.Judul("Data Mata Pelajaran");

                Console.WriteLine("[1] Tambah Mata Pelajaran");
                Console.WriteLine("[2] Lihat Mata Pelajaran");
                Console.WriteLine("[3] Ubah Mata Pelajaran");
                Console.WriteLine("[4] Hapus Mata Pelajaran");
                Console.WriteLine("[5] Reset Mata Pelajaran");
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
            Home.Judul("Tambah Mata Pelajaran");

            int id = DataStorage.jumlahMataPelajaran == 0
                ? 1
                : DataStorage.daftarIdMataPelajaran[^1] + 1;

            string nama = Home.BacaString("Nama mata pelajaran: ");
            string guru = Home.BacaString("Nama guru: ");

            DataStorage.daftarIdMataPelajaran.Add(id);
            DataStorage.daftarNamaMataPelajaran.Add(nama);
            DataStorage.daftarGuruMataPelajaran.Add(guru);
            DataStorage.jumlahMataPelajaran++;

            Console.WriteLine($"Mata pelajaran berhasil ditambahkan. ID = {id}");
            Home.Tunggu();
        }

        static void Read()
        {
            Console.Clear();
            Home.Judul("Daftar Mata Pelajaran");

            if (DataStorage.jumlahMataPelajaran == 0)
            {
                Console.WriteLine("Belum ada mata pelajaran.");
                Home.Tunggu();
                return;
            }

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("| ID | Mata Pelajaran          | Guru         |");
            Console.WriteLine("----------------------------------------------");

            for (int i = 0; i < DataStorage.jumlahMataPelajaran; i++)
            {
                Console.WriteLine(
                    $"| {DataStorage.daftarIdMataPelajaran[i],2} | " +
                    $"{Potong(DataStorage.daftarNamaMataPelajaran[i], 23),-23} | " +
                    $"{Potong(DataStorage.daftarGuruMataPelajaran[i], 12),-12} |");
            }

            Console.WriteLine("----------------------------------------------");
            Home.Tunggu();
        }

        static void Update()
        {
            if (DataStorage.jumlahMataPelajaran == 0)
            {
                Console.WriteLine("Belum ada mata pelajaran.");
                Home.Tunggu();
                return;
            }

            ReadShort();
            int index = PilihIndex();

            DataStorage.daftarNamaMataPelajaran[index] =
                Home.BacaString("Nama mata pelajaran baru: ");
            DataStorage.daftarGuruMataPelajaran[index] =
                Home.BacaString("Nama guru baru: ");

            Console.WriteLine("Data mata pelajaran berhasil diubah.");
            Home.Tunggu();
        }

        static void Delete()
        {
            if (DataStorage.jumlahMataPelajaran == 0)
            {
                Console.WriteLine("Belum ada mata pelajaran.");
                Home.Tunggu();
                return;
            }

            ReadShort();
            int index = PilihIndex();

            if (!Home.Konfirmasi("Hapus mata pelajaran ini"))
                return;

            int id = DataStorage.daftarIdMataPelajaran[index];

            DataStorage.daftarIdMataPelajaran.RemoveAt(index);
            DataStorage.daftarNamaMataPelajaran.RemoveAt(index);
            DataStorage.daftarGuruMataPelajaran.RemoveAt(index);
            DataStorage.jumlahMataPelajaran--;

            // Hapus nilai yang memakai mata pelajaran tersebut.
            for (int i = DataStorage.jumlahNilai - 1; i >= 0; i--)
            {
                if (DataStorage.daftarIdMataPelajaranNilai[i] == id)
                {
                    DataStorage.daftarNisnNilai.RemoveAt(i);
                    DataStorage.daftarIdMataPelajaranNilai.RemoveAt(i);
                    DataStorage.daftarNilai.RemoveAt(i);
                    DataStorage.jumlahNilai--;
                }
            }

            Console.WriteLine("Mata pelajaran berhasil dihapus.");
            Home.Tunggu();
        }

        static void Reset()
        {
            if (!Home.Konfirmasi("Reset seluruh mata pelajaran"))
                return;

            DataStorage.daftarIdMataPelajaran.Clear();
            DataStorage.daftarNamaMataPelajaran.Clear();
            DataStorage.daftarGuruMataPelajaran.Clear();
            DataStorage.jumlahMataPelajaran = 0;

            DataStorage.daftarNisnNilai.Clear();
            DataStorage.daftarIdMataPelajaranNilai.Clear();
            DataStorage.daftarNilai.Clear();
            DataStorage.jumlahNilai = 0;

            Console.WriteLine("Seluruh mata pelajaran berhasil direset.");
            Console.WriteLine("Nilai yang terkait juga dihapus.");
            Home.Tunggu();
        }

        static void ReadShort()
        {
            Console.WriteLine("\nID | Mata Pelajaran");
            Console.WriteLine("---------------------------");
            for (int i = 0; i < DataStorage.jumlahMataPelajaran; i++)
                Console.WriteLine($"{DataStorage.daftarIdMataPelajaran[i],2} | {DataStorage.daftarNamaMataPelajaran[i]}");
        }

        static int PilihIndex()
        {
            while (true)
            {
                int id = Home.BacaInt("Masukkan ID mata pelajaran: ");
                int index = DataStorage.daftarIdMataPelajaran.IndexOf(id);

                if (index >= 0)
                    return index;

                Console.WriteLine("ID mata pelajaran tidak ditemukan.");
            }
        }

        static string Potong(string teks, int panjang)
        {
            return teks.Length <= panjang
                ? teks
                : teks.Substring(0, Math.Max(0, panjang - 3)) + "...";
        }
    }
}
