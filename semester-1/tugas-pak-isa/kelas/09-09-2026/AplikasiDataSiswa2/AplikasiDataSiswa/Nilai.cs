using System;

namespace AplikasiDataSiswa
{
    class Nilai
    {
        public static void Menu()
        {
            while (true)
            {
                Console.Clear();
                Home.Judul("Data Nilai");

                Console.WriteLine("[1] Tambah Nilai");
                Console.WriteLine("[2] Lihat Data Nilai");
                Console.WriteLine("[3] Ubah Nilai");
                Console.WriteLine("[4] Hapus Nilai");
                Console.WriteLine("[5] Reset Nilai");
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
            Home.Judul("Tambah Nilai");

            if (DataStorage.jumlahSiswa == 0)
            {
                Console.WriteLine("Tambahkan siswa terlebih dahulu.");
                Home.Tunggu();
                return;
            }

            if (DataStorage.jumlahMataPelajaran == 0)
            {
                Console.WriteLine("Tambahkan mata pelajaran terlebih dahulu.");
                Home.Tunggu();
                return;
            }

            string nisn = PilihSiswa();
            int idMapel = PilihMataPelajaran();

            // Satu siswa tidak boleh memiliki dua nilai untuk mapel yang sama.
            for (int i = 0; i < DataStorage.jumlahNilai; i++)
            {
                if (DataStorage.daftarNisnNilai[i] == nisn &&
                    DataStorage.daftarIdMataPelajaranNilai[i] == idMapel)
                {
                    Console.WriteLine("Nilai untuk siswa dan mata pelajaran tersebut sudah ada.");
                    Home.Tunggu();
                    return;
                }
            }

            double nilai;
            while (true)
            {
                nilai = Home.BacaDouble("Nilai (0-100): ");
                if (nilai >= 0 && nilai <= 100)
                    break;

                Console.WriteLine("Nilai harus berada di antara 0 sampai 100.");
            }

            DataStorage.daftarNisnNilai.Add(nisn);
            DataStorage.daftarIdMataPelajaranNilai.Add(idMapel);
            DataStorage.daftarNilai.Add(nilai);
            DataStorage.jumlahNilai++;

            Console.WriteLine("Nilai berhasil ditambahkan.");
            Home.Tunggu();
        }

        static void Read()
        {
            Console.Clear();
            Home.Judul("Daftar Nilai");

            if (DataStorage.jumlahNilai == 0)
            {
                Console.WriteLine("Belum ada data nilai.");
                Home.Tunggu();
                return;
            }

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("| No | NISN      | Siswa                 | Mata Pelajaran | Nilai |");
            Console.WriteLine("----------------------------------------------------------------");

            for (int i = 0; i < DataStorage.jumlahNilai; i++)
            {
                int siswaIndex = DataStorage.daftarNisnSiswa.IndexOf(DataStorage.daftarNisnNilai[i]);
                int mapelIndex = DataStorage.daftarIdMataPelajaran.IndexOf(DataStorage.daftarIdMataPelajaranNilai[i]);

                string namaSiswa = siswaIndex >= 0
                    ? DataStorage.daftarNamaLengkapSiswa[siswaIndex]
                    : "(siswa terhapus)";

                string namaMapel = mapelIndex >= 0
                    ? DataStorage.daftarNamaMataPelajaran[mapelIndex]
                    : "(mapel terhapus)";

                Console.WriteLine(
                    $"| {i + 1,2} | {DataStorage.daftarNisnNilai[i],-9} | " +
                    $"{Potong(namaSiswa, 21),-21} | " +
                    $"{Potong(namaMapel, 14),-14} | " +
                    $"{DataStorage.daftarNilai[i],5:0.##} |");
            }

            Console.WriteLine("----------------------------------------------------------------");
            Home.Tunggu();
        }

        static void Update()
        {
            if (DataStorage.jumlahNilai == 0)
            {
                Console.WriteLine("Belum ada data nilai.");
                Home.Tunggu();
                return;
            }

            ReadShort();
            int index = PilihIndexNilai();

            double nilai;
            while (true)
            {
                nilai = Home.BacaDouble("Nilai baru (0-100): ");
                if (nilai >= 0 && nilai <= 100)
                    break;

                Console.WriteLine("Nilai harus berada di antara 0 sampai 100.");
            }

            DataStorage.daftarNilai[index] = nilai;

            Console.WriteLine("Nilai berhasil diubah.");
            Home.Tunggu();
        }

        static void Delete()
        {
            if (DataStorage.jumlahNilai == 0)
            {
                Console.WriteLine("Belum ada data nilai.");
                Home.Tunggu();
                return;
            }

            ReadShort();
            int index = PilihIndexNilai();

            if (!Home.Konfirmasi("Hapus nilai ini"))
                return;

            DataStorage.daftarNisnNilai.RemoveAt(index);
            DataStorage.daftarIdMataPelajaranNilai.RemoveAt(index);
            DataStorage.daftarNilai.RemoveAt(index);
            DataStorage.jumlahNilai--;

            Console.WriteLine("Nilai berhasil dihapus.");
            Home.Tunggu();
        }

        static void Reset()
        {
            if (!Home.Konfirmasi("Reset seluruh data nilai"))
                return;

            DataStorage.daftarNisnNilai.Clear();
            DataStorage.daftarIdMataPelajaranNilai.Clear();
            DataStorage.daftarNilai.Clear();
            DataStorage.jumlahNilai = 0;

            Console.WriteLine("Seluruh data nilai berhasil direset.");
            Home.Tunggu();
        }

        static void ReadShort()
        {
            Console.WriteLine("\nNo | NISN | ID Mapel | Nilai");
            Console.WriteLine("-----------------------------");

            for (int i = 0; i < DataStorage.jumlahNilai; i++)
            {
                Console.WriteLine(
                    $"{i + 1,2} | " +
                    $"{DataStorage.daftarNisnNilai[i]} | " +
                    $"{DataStorage.daftarIdMataPelajaranNilai[i],8} | " +
                    $"{DataStorage.daftarNilai[i]:0.##}");
            }
        }

        static int PilihIndexNilai()
        {
            while (true)
            {
                int nomor = Home.BacaInt("Nomor data nilai: ");

                if (nomor >= 1 && nomor <= DataStorage.jumlahNilai)
                    return nomor - 1;

                Console.WriteLine("Nomor data tidak ditemukan.");
            }
        }

        static string PilihSiswa()
        {
            Console.WriteLine("\nDaftar siswa:");
            for (int i = 0; i < DataStorage.jumlahSiswa; i++)
                Console.WriteLine($"[{DataStorage.daftarNisnSiswa[i]}] {DataStorage.daftarNamaLengkapSiswa[i]}");

            while (true)
            {
                string nisn = Home.BacaString("NISN siswa: ");

                if (DataStorage.daftarNisnSiswa.Contains(nisn))
                    return nisn;

                Console.WriteLine("NISN tidak ditemukan.");
            }
        }

        static int PilihMataPelajaran()
        {
            Console.WriteLine("\nDaftar mata pelajaran:");
            for (int i = 0; i < DataStorage.jumlahMataPelajaran; i++)
                Console.WriteLine($"[{DataStorage.daftarIdMataPelajaran[i]}] {DataStorage.daftarNamaMataPelajaran[i]}");

            while (true)
            {
                int id = Home.BacaInt("ID mata pelajaran: ");

                if (DataStorage.daftarIdMataPelajaran.Contains(id))
                    return id;

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
