using System;

namespace AplikasiDataSiswa
{
    class Identitas
    {
        // =========================================================
        // SISWA
        // =========================================================
        public static void siswa()
        {
            while (true)
            {
                Console.Clear();
                Home.Judul("Data Identitas - Siswa");

                Console.WriteLine("[1] Tambah Siswa");
                Console.WriteLine("[2] Lihat Data Siswa");
                Console.WriteLine("[3] Ubah Data Siswa");
                Console.WriteLine("[4] Hapus Data Siswa");
                Console.WriteLine("[5] Reset Data Siswa");
                Console.WriteLine("[0] Kembali");

                int opsi = Home.BacaInt("Pilih aksi: ");

                switch (opsi)
                {
                    case 1: SiswaCreate(); break;
                    case 2: SiswaRead(); break;
                    case 3: SiswaUpdate(); break;
                    case 4: SiswaDelete(); break;
                    case 5: SiswaReset(); break;
                    case 0: return;
                    default: Home.PesanInvalid(); break;
                }
            }
        }

        static void SiswaCreate()
        {
            Console.Clear();
            Home.Judul("Tambah Siswa");

            string nisn;
            while (true)
            {
                nisn = Home.BacaString("NISN (9 digit): ");

                if (nisn.Length == 9 && long.TryParse(nisn, out _))
                {
                    if (!DataStorage.daftarNisnSiswa.Contains(nisn))
                        break;

                    Console.WriteLine("NISN sudah digunakan.");
                }
                else
                {
                    Console.WriteLine("NISN harus tepat 9 digit.");
                }
            }

            string nama = Home.BacaString("Nama lengkap: ");
            string panggilan = Home.BacaString("Nama panggilan: ");

            char jk;
            while (true)
            {
                string input = Home.BacaString("Jenis kelamin (L/P): ").ToUpper();
                if (input.Length == 1 && (input[0] == 'L' || input[0] == 'P'))
                {
                    jk = input[0];
                    break;
                }

                Console.WriteLine("Masukkan L atau P.");
            }

            int umur = Home.BacaInt("Umur: ");
            string alamat = Home.BacaString("Alamat: ");
            string sekolah = Home.BacaString("Nama sekolah: ");

            DataStorage.daftarNisnSiswa.Add(nisn);
            DataStorage.daftarNamaLengkapSiswa.Add(nama);
            DataStorage.daftarNamaPanggilanSiswa.Add(panggilan);
            DataStorage.daftarJenisKelaminSiswa.Add(jk);
            DataStorage.daftarUmurSiswa.Add(umur);
            DataStorage.daftarAlamatSiswa.Add(alamat);
            DataStorage.daftarSekolahSiswa.Add(sekolah);
            DataStorage.jumlahSiswa++;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nData siswa berhasil ditambahkan.");
            Console.ResetColor();
            Home.Tunggu();
        }

        static void SiswaRead()
        {
            Console.Clear();
            Home.Judul("Daftar Data Siswa");

            if (DataStorage.jumlahSiswa == 0)
            {
                Console.WriteLine("Belum ada data siswa.");
                Home.Tunggu();
                return;
            }

            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("| No | NISN      | Nama Lengkap              | Panggilan | JK | Umur | Alamat        | Sekolah |");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");

            for (int i = 0; i < DataStorage.jumlahSiswa; i++)
            {
                Console.WriteLine(
                    $"| {i + 1,2} | " +
                    $"{DataStorage.daftarNisnSiswa[i],-9} | " +
                    $"{Potong(DataStorage.daftarNamaLengkapSiswa[i], 25),-25} | " +
                    $"{Potong(DataStorage.daftarNamaPanggilanSiswa[i], 9),-9} | " +
                    $"{DataStorage.daftarJenisKelaminSiswa[i],2} | " +
                    $"{DataStorage.daftarUmurSiswa[i],4} | " +
                    $"{Potong(DataStorage.daftarAlamatSiswa[i], 13),-13} | " +
                    $"{Potong(DataStorage.daftarSekolahSiswa[i], 7),-7} |");
            }

            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Home.Tunggu();
        }

        static void SiswaUpdate()
        {
            if (DataStorage.jumlahSiswa == 0)
            {
                Console.WriteLine("Belum ada data siswa.");
                Home.Tunggu();
                return;
            }

            SiswaReadTanpaPause();
            int index = PilihIndex(DataStorage.jumlahSiswa, "Nomor siswa yang ingin diubah: ");

            Console.Clear();
            Home.Judul("Ubah Data Siswa");
            Console.WriteLine($"NISN: {DataStorage.daftarNisnSiswa[index]}");

            DataStorage.daftarNamaLengkapSiswa[index] =
                Home.BacaString("Nama lengkap baru: ");
            DataStorage.daftarNamaPanggilanSiswa[index] =
                Home.BacaString("Nama panggilan baru: ");

            while (true)
            {
                string input = Home.BacaString("Jenis kelamin baru (L/P): ").ToUpper();
                if (input.Length == 1 && (input[0] == 'L' || input[0] == 'P'))
                {
                    DataStorage.daftarJenisKelaminSiswa[index] = input[0];
                    break;
                }
                Console.WriteLine("Masukkan L atau P.");
            }

            DataStorage.daftarUmurSiswa[index] = Home.BacaInt("Umur baru: ");
            DataStorage.daftarAlamatSiswa[index] = Home.BacaString("Alamat baru: ");
            DataStorage.daftarSekolahSiswa[index] = Home.BacaString("Nama sekolah baru: ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nData siswa berhasil diubah.");
            Console.ResetColor();
            Home.Tunggu();
        }

        static void SiswaDelete()
        {
            if (DataStorage.jumlahSiswa == 0)
            {
                Console.WriteLine("Belum ada data siswa.");
                Home.Tunggu();
                return;
            }

            SiswaReadTanpaPause();
            int index = PilihIndex(DataStorage.jumlahSiswa, "Nomor siswa yang ingin dihapus: ");

            if (!Home.Konfirmasi($"Hapus siswa {DataStorage.daftarNamaLengkapSiswa[index]}"))
                return;

            string nisn = DataStorage.daftarNisnSiswa[index];

            DataStorage.daftarNisnSiswa.RemoveAt(index);
            DataStorage.daftarNamaLengkapSiswa.RemoveAt(index);
            DataStorage.daftarNamaPanggilanSiswa.RemoveAt(index);
            DataStorage.daftarJenisKelaminSiswa.RemoveAt(index);
            DataStorage.daftarUmurSiswa.RemoveAt(index);
            DataStorage.daftarAlamatSiswa.RemoveAt(index);
            DataStorage.daftarSekolahSiswa.RemoveAt(index);
            DataStorage.jumlahSiswa--;

            // Hapus nilai milik siswa tersebut juga.
            for (int i = DataStorage.jumlahNilai - 1; i >= 0; i--)
            {
                if (DataStorage.daftarNisnNilai[i] == nisn)
                {
                    DataStorage.daftarNisnNilai.RemoveAt(i);
                    DataStorage.daftarIdMataPelajaranNilai.RemoveAt(i);
                    DataStorage.daftarNilai.RemoveAt(i);
                    DataStorage.jumlahNilai--;
                }
            }

            Console.WriteLine("Data siswa berhasil dihapus.");
            Home.Tunggu();
        }

        static void SiswaReset()
        {
            if (DataStorage.jumlahSiswa == 0)
            {
                Console.WriteLine("Belum ada data siswa.");
                Home.Tunggu();
                return;
            }

            if (!Home.Konfirmasi("Reset seluruh data siswa"))
                return;

            DataStorage.daftarNisnSiswa.Clear();
            DataStorage.daftarNamaLengkapSiswa.Clear();
            DataStorage.daftarNamaPanggilanSiswa.Clear();
            DataStorage.daftarJenisKelaminSiswa.Clear();
            DataStorage.daftarUmurSiswa.Clear();
            DataStorage.daftarAlamatSiswa.Clear();
            DataStorage.daftarSekolahSiswa.Clear();
            DataStorage.jumlahSiswa = 0;

            Console.WriteLine("Seluruh data siswa berhasil direset.");
            Home.Tunggu();
        }

        static void SiswaReadTanpaPause()
        {
            if (DataStorage.jumlahSiswa == 0)
            {
                Console.WriteLine("Belum ada data siswa.");
                return;
            }

            Console.WriteLine("\nNo | NISN      | Nama");
            Console.WriteLine("-------------------------------");
            for (int i = 0; i < DataStorage.jumlahSiswa; i++)
                Console.WriteLine($"{i + 1,2} | {DataStorage.daftarNisnSiswa[i]} | {DataStorage.daftarNamaLengkapSiswa[i]}");
        }

        // =========================================================
        // WALI
        // =========================================================
        public static void wali()
        {
            while (true)
            {
                Console.Clear();
                Home.Judul("Data Identitas - Wali");

                Console.WriteLine("[1] Tambah Wali");
                Console.WriteLine("[2] Lihat Data Wali");
                Console.WriteLine("[3] Ubah Data Wali");
                Console.WriteLine("[4] Hapus Data Wali");
                Console.WriteLine("[5] Reset Data Wali");
                Console.WriteLine("[0] Kembali");

                int opsi = Home.BacaInt("Pilih aksi: ");

                switch (opsi)
                {
                    case 1: WaliCreate(); break;
                    case 2: WaliRead(); break;
                    case 3: WaliUpdate(); break;
                    case 4: WaliDelete(); break;
                    case 5: WaliReset(); break;
                    case 0: return;
                    default: Home.PesanInvalid(); break;
                }
            }
        }

        static void WaliCreate()
        {
            Console.Clear();
            Home.Judul("Tambah Wali");

            string nama = Home.BacaString("Nama wali: ");
            int umur = Home.BacaInt("Umur wali: ");

            string telepon;
            while (true)
            {
                telepon = Home.BacaString("Telepon wali (10-12 digit): ");
                if (telepon.Length >= 10 && telepon.Length <= 12 && long.TryParse(telepon, out _))
                    break;
                Console.WriteLine("Nomor telepon harus 10-12 digit.");
            }

            string alamat = Home.BacaString("Alamat wali: ");

            DataStorage.daftarNamaWali.Add(nama);
            DataStorage.daftarUmurWali.Add(umur);
            DataStorage.daftarAlamatWali.Add(alamat);
            DataStorage.daftarTeleponWali.Add(telepon);
            DataStorage.jumlahWali++;

            Console.WriteLine("Data wali berhasil ditambahkan.");
            Home.Tunggu();
        }

        static void WaliRead()
        {
            Console.Clear();
            Home.Judul("Daftar Data Wali");

            if (DataStorage.jumlahWali == 0)
            {
                Console.WriteLine("Belum ada data wali.");
                Home.Tunggu();
                return;
            }

            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("| No | Nama Wali           | Umur | Telepon      | Alamat                    |");
            Console.WriteLine("--------------------------------------------------------------------------------");

            for (int i = 0; i < DataStorage.jumlahWali; i++)
            {
                Console.WriteLine(
                    $"| {i + 1,2} | {Potong(DataStorage.daftarNamaWali[i], 19),-19} | " +
                    $"{DataStorage.daftarUmurWali[i],4} | " +
                    $"{DataStorage.daftarTeleponWali[i],-12} | " +
                    $"{Potong(DataStorage.daftarAlamatWali[i], 25),-25} |");
            }

            Console.WriteLine("--------------------------------------------------------------------------------");
            Home.Tunggu();
        }

        static void WaliUpdate()
        {
            if (DataStorage.jumlahWali == 0)
            {
                Console.WriteLine("Belum ada data wali.");
                Home.Tunggu();
                return;
            }

            WaliReadTanpaPause();
            int index = PilihIndex(DataStorage.jumlahWali, "Nomor wali yang ingin diubah: ");

            DataStorage.daftarNamaWali[index] = Home.BacaString("Nama baru: ");
            DataStorage.daftarUmurWali[index] = Home.BacaInt("Umur baru: ");

            while (true)
            {
                string telepon = Home.BacaString("Telepon baru (10-12 digit): ");
                if (telepon.Length >= 10 && telepon.Length <= 12 && long.TryParse(telepon, out _))
                {
                    DataStorage.daftarTeleponWali[index] = telepon;
                    break;
                }
                Console.WriteLine("Nomor telepon harus 10-12 digit.");
            }

            DataStorage.daftarAlamatWali[index] = Home.BacaString("Alamat baru: ");

            Console.WriteLine("Data wali berhasil diubah.");
            Home.Tunggu();
        }

        static void WaliDelete()
        {
            if (DataStorage.jumlahWali == 0)
            {
                Console.WriteLine("Belum ada data wali.");
                Home.Tunggu();
                return;
            }

            WaliReadTanpaPause();
            int index = PilihIndex(DataStorage.jumlahWali, "Nomor wali yang ingin dihapus: ");

            if (!Home.Konfirmasi("Hapus data wali ini"))
                return;

            DataStorage.daftarNamaWali.RemoveAt(index);
            DataStorage.daftarUmurWali.RemoveAt(index);
            DataStorage.daftarAlamatWali.RemoveAt(index);
            DataStorage.daftarTeleponWali.RemoveAt(index);
            DataStorage.jumlahWali--;

            Console.WriteLine("Data wali berhasil dihapus.");
            Home.Tunggu();
        }

        static void WaliReset()
        {
            if (!Home.Konfirmasi("Reset seluruh data wali"))
                return;

            DataStorage.daftarNamaWali.Clear();
            DataStorage.daftarUmurWali.Clear();
            DataStorage.daftarAlamatWali.Clear();
            DataStorage.daftarTeleponWali.Clear();
            DataStorage.jumlahWali = 0;

            Console.WriteLine("Seluruh data wali berhasil direset.");
            Home.Tunggu();
        }

        static void WaliReadTanpaPause()
        {
            Console.WriteLine("\nNo | Nama Wali | Telepon");
            Console.WriteLine("-------------------------------");
            for (int i = 0; i < DataStorage.jumlahWali; i++)
                Console.WriteLine($"{i + 1,2} | {DataStorage.daftarNamaWali[i]} | {DataStorage.daftarTeleponWali[i]}");
        }

        // =========================================================
        // SEKOLAH
        // =========================================================
        public static void sekolah()
        {
            while (true)
            {
                Console.Clear();
                Home.Judul("Data Identitas - Sekolah");

                Console.WriteLine("[1] Tambah Sekolah");
                Console.WriteLine("[2] Lihat Data Sekolah");
                Console.WriteLine("[3] Ubah Data Sekolah");
                Console.WriteLine("[4] Hapus Data Sekolah");
                Console.WriteLine("[5] Reset Data Sekolah");
                Console.WriteLine("[0] Kembali");

                int opsi = Home.BacaInt("Pilih aksi: ");

                switch (opsi)
                {
                    case 1: SekolahCreate(); break;
                    case 2: SekolahRead(); break;
                    case 3: SekolahUpdate(); break;
                    case 4: SekolahDelete(); break;
                    case 5: SekolahReset(); break;
                    case 0: return;
                    default: Home.PesanInvalid(); break;
                }
            }
        }

        static void SekolahCreate()
        {
            Console.Clear();
            Home.Judul("Tambah Sekolah");

            string nama = Home.BacaString("Nama sekolah: ");
            string alamat = Home.BacaString("Alamat sekolah: ");

            char akreditasi;
            while (true)
            {
                string input = Home.BacaString("Akreditasi (A/B/C): ").ToUpper();
                if (input.Length == 1 && (input[0] == 'A' || input[0] == 'B' || input[0] == 'C'))
                {
                    akreditasi = input[0];
                    break;
                }
                Console.WriteLine("Akreditasi hanya A, B, atau C.");
            }

            int indeks = Home.BacaInt("Indeks sekolah: ");
            string tanggal = DateTime.Today.ToString("dd-MM-yyyy");

            DataStorage.daftarNamaSekolah.Add(nama);
            DataStorage.daftarAlamatSekolah.Add(alamat);
            DataStorage.daftarAkreditasiSekolah.Add(akreditasi);
            DataStorage.daftarIndeksSekolah.Add(indeks);
            DataStorage.daftarTanggalSekolah.Add(tanggal);
            DataStorage.jumlahSekolah++;

            Console.WriteLine("Data sekolah berhasil ditambahkan.");
            Home.Tunggu();
        }

        static void SekolahRead()
        {
            Console.Clear();
            Home.Judul("Daftar Data Sekolah");

            if (DataStorage.jumlahSekolah == 0)
            {
                Console.WriteLine("Belum ada data sekolah.");
                Home.Tunggu();
                return;
            }

            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("| No | Nama Sekolah      | Alamat           | Akred. | Indeks | Tanggal      |");
            Console.WriteLine("--------------------------------------------------------------------------------");

            for (int i = 0; i < DataStorage.jumlahSekolah; i++)
            {
                Console.WriteLine(
                    $"| {i + 1,2} | {Potong(DataStorage.daftarNamaSekolah[i], 17),-17} | " +
                    $"{Potong(DataStorage.daftarAlamatSekolah[i], 16),-16} | " +
                    $"{DataStorage.daftarAkreditasiSekolah[i],-6} | " +
                    $"{DataStorage.daftarIndeksSekolah[i],6} | " +
                    $"{DataStorage.daftarTanggalSekolah[i],-12} |");
            }

            Console.WriteLine("--------------------------------------------------------------------------------");
            Home.Tunggu();
        }

        static void SekolahUpdate()
        {
            if (DataStorage.jumlahSekolah == 0)
            {
                Console.WriteLine("Belum ada data sekolah.");
                Home.Tunggu();
                return;
            }

            SekolahReadTanpaPause();
            int index = PilihIndex(DataStorage.jumlahSekolah, "Nomor sekolah yang ingin diubah: ");

            DataStorage.daftarNamaSekolah[index] = Home.BacaString("Nama baru: ");
            DataStorage.daftarAlamatSekolah[index] = Home.BacaString("Alamat baru: ");

            while (true)
            {
                string input = Home.BacaString("Akreditasi baru (A/B/C): ").ToUpper();
                if (input.Length == 1 && (input[0] == 'A' || input[0] == 'B' || input[0] == 'C'))
                {
                    DataStorage.daftarAkreditasiSekolah[index] = input[0];
                    break;
                }
                Console.WriteLine("Akreditasi hanya A, B, atau C.");
            }

            DataStorage.daftarIndeksSekolah[index] = Home.BacaInt("Indeks baru: ");

            Console.WriteLine("Data sekolah berhasil diubah.");
            Home.Tunggu();
        }

        static void SekolahDelete()
        {
            if (DataStorage.jumlahSekolah == 0)
            {
                Console.WriteLine("Belum ada data sekolah.");
                Home.Tunggu();
                return;
            }

            SekolahReadTanpaPause();
            int index = PilihIndex(DataStorage.jumlahSekolah, "Nomor sekolah yang ingin dihapus: ");

            if (!Home.Konfirmasi("Hapus data sekolah ini"))
                return;

            DataStorage.daftarNamaSekolah.RemoveAt(index);
            DataStorage.daftarAlamatSekolah.RemoveAt(index);
            DataStorage.daftarAkreditasiSekolah.RemoveAt(index);
            DataStorage.daftarIndeksSekolah.RemoveAt(index);
            DataStorage.daftarTanggalSekolah.RemoveAt(index);
            DataStorage.jumlahSekolah--;

            Console.WriteLine("Data sekolah berhasil dihapus.");
            Home.Tunggu();
        }

        static void SekolahReset()
        {
            if (!Home.Konfirmasi("Reset seluruh data sekolah"))
                return;

            DataStorage.daftarNamaSekolah.Clear();
            DataStorage.daftarAlamatSekolah.Clear();
            DataStorage.daftarAkreditasiSekolah.Clear();
            DataStorage.daftarIndeksSekolah.Clear();
            DataStorage.daftarTanggalSekolah.Clear();
            DataStorage.jumlahSekolah = 0;

            Console.WriteLine("Seluruh data sekolah berhasil direset.");
            Home.Tunggu();
        }

        static void SekolahReadTanpaPause()
        {
            Console.WriteLine("\nNo | Nama Sekolah | Alamat");
            Console.WriteLine("----------------------------------------");
            for (int i = 0; i < DataStorage.jumlahSekolah; i++)
                Console.WriteLine($"{i + 1,2} | {DataStorage.daftarNamaSekolah[i]} | {DataStorage.daftarAlamatSekolah[i]}");
        }

        // =========================================================
        // HELPER
        // =========================================================
        static int PilihIndex(int jumlah, string pesan)
        {
            while (true)
            {
                int nomor = Home.BacaInt(pesan);
                if (nomor >= 1 && nomor <= jumlah)
                    return nomor - 1;

                Console.WriteLine("Nomor tidak ditemukan.");
            }
        }

        static string Potong(string teks, int panjang)
        {
            if (teks.Length <= panjang)
                return teks;

            return teks.Substring(0, Math.Max(0, panjang - 3)) + "...";
        }
    }
}
