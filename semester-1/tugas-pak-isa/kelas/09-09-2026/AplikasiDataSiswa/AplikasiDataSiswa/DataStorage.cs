using System;
using System.Collections.Generic;
using System.Text;

namespace AplikasiDataSiswa
{
    class DataStorage
    {
        // ----------------
        // |   Identitas  |
        // ----------------

        // data siswa
        public static string nisnTemplate = "000000000"; // 9 digit
        public static int namaLengkapSiswaColumn = 12;
        public static int alamatSiswaColumn = 6;
        public static int namaSekolahSiswaColumn = 12;

        public static int jumlahSiswa = 0;
        public static List<string> daftarNisnSiswa = new List<string>();
        public static List<string> daftarNamaLengkapSiswa = new List<string>();
        public static List<string> daftarNamaPanggilanSiswa = new List<string>();
        public static List<char> daftarJenisKelaminSiswa = new List<char>();
        public static List<int> daftarUmurSiswa = new List<int>();
        public static List<string> daftarAlamatSiswa = new List<string>();
        public static List<string> daftarSekolahSiswa = new List<string>();


        // data wali
        public const int NAMA_WALI_COLUMN = 9;
        public const int ALAMAT_WALI_COLUMN = 11;
        public const int TELEPON_WALI_COLUMN = 12;
        public const int UMUR_WALI_COLUMN = 4;
        public static int namaWaliColumn = 9;
        public static int alamatWaliColumn = 11;

        public static int jumlahWali = 0;
        public static List<string> daftarNamaWali = new List<string>();
        public static List<int> daftarUmurWali = new List<int>();
        public static List<string> daftarAlamatWali = new List<string>();
        public static List<string> daftarTeleponWali = new List<string>();


        // data sekolah
        public const int NAMA_SEKOLAH_COLUMN = 0;
        public const int ALAMAT_SEKOLAH_COLUMN = 0;
        public static int namaSekolahColumn;
        public static int alamatSekolahColumn;

        public static int jumlahSekolah = 0;
        public static List<string> daftarNamaSekolah = new List<string>();
        public static List<string> daftarAlamatSekolah = new List<string>();
        public static List<char> daftarAkreditasiSekolah = new List<char>();
        public static List<float> daftarIndeksSekolah = new List<float>();
    }
}
