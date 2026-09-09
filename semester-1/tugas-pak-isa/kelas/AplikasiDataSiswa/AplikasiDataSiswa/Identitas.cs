namespace AplikasiDataSiswa
{
    class Identitas()
    {
        public int nisn;
        String nama;
        char jenisKelamin;
        int umur;
        String alamat;
        String namaSekolahTK;
        String namaSekolahSD;
        String namaSekolahSMP;
        String namaSekolahSMA;

        //public Identitas(string nama, int umur, string alamat, int nisn, char jenisKelamin = '?')
        //{
        //    this.nama = nama;
        //    this.umur = umur;
        //    this.jenisKelamin = jenisKelamin;
        //    this.alamat = alamat;
        //    //this.namaSekolah = namaSekolah;
        //    this.nisn = nisn;
        //}

        public void daftarkanSiswa(string nama, int nisn, char jenisKelamin, int umur, string alamat)
        {
            this.nama = nama;
            this.nisn = nisn;
            this.jenisKelamin = jenisKelamin;
            this.umur = umur;
            this.alamat = alamat;
        }

        public void siswa()
        {
            string namaSiswa;
            int nisnSiswa;
            string jenisKelaminSiswa;
            int umurSiswa;
            string alamatSiswa;

            Console.Write($"Masukkan nama siswa: ");
            namaSiswa = Console.ReadLine();

            Console.Write($"Masukkan nisn siswa: ");
            nisnSiswa = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Masukkan jenis kelamin siswa: ");
            jenisKelaminSiswa = Console.ReadLine();

            Console.Write($"Masukkan umur siswa: ");
            umurSiswa = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Masukkan alamat siswa: ");
            alamatSiswa = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine($"Nama siswa: {namaSiswa}");
            Console.WriteLine($"Nisn siswa: {nisnSiswa}");
            Console.WriteLine($"Jenis kelamin siswa: {jenisKelaminSiswa}");
            Console.WriteLine($"Umur siswa: {umurSiswa}");
            Console.WriteLine($"Alamat siswa: {alamatSiswa}");
        }

        public void wali()
        {
            string namaWali;
            int umurWali;
            string teleponWali;
            string alamatWali;

            Console.Write($"Masukkan nama wali: ");
            namaWali = Console.ReadLine();

            Console.Write($"Masukkan umur wali: ");
            umurWali = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Masukkan telepon wali: ");
            teleponWali = Console.ReadLine();

            Console.Write($"Masukkan alamat wali: ");
            alamatWali = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine($"Nama wali: {namaWali}");
            Console.WriteLine($"Nisn wali: {umurWali}");
            Console.WriteLine($"Telepon wali: {teleponWali}");
            Console.WriteLine($"Alamat wali: {alamatWali}");
        }

        public void sekolah()
        {
            string sekolahTk;
            string sekolahSd;
            string sekolahSmp;
            string sekolahSma;

            Console.Write($"Masukkan nama sekolah TK: ");
            sekolahTk = Console.ReadLine();

            Console.Write($"Masukkan nama sekolah SD: ");
            sekolahSd = Console.ReadLine();

            Console.Write($"Masukkan nama sekolah SMP: ");
            sekolahSmp = Console.ReadLine();

            Console.Write($"Masukkan nama sekolah SMA: ");
            sekolahSma = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine($"Nama sekolah TK: {sekolahTk}");
            Console.WriteLine($"Nama sekolah SD: {sekolahSd}");
            Console.WriteLine($"Nama sekolah SMP: {sekolahSmp}");
            Console.WriteLine($"Nama sekolah SMA: {sekolahSma}");
        }
    }
}