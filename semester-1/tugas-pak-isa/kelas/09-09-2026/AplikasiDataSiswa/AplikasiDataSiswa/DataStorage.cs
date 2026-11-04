using System;
using System.Collections.Generic;
using System.Text;

namespace AplikasiDataSiswa
{
    class DataStorage
    {
        /*
        --------------
        |   Public   |
        --------------
        */
        public const int NAMA_LENGKAP_COLUMN = 12;
        public const int ALAMAT_COLUMN = 6;

        /*
        -----------------
        |   Identitas   |
        -----------------
        */

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
        public const int NAMA_SEKOLAH_COLUMN = 12;
        public const int ALAMAT_SEKOLAH_COLUMN = 14;
        public const int AKREDITASI_SEKOLAH_COLUMN = 10;
        public const int INDEKS_SEKOLAH_COLUMN = 6;
        public const int TANGGAL_SEKOLAH_COLUMN = 14;
        public static int namaSekolahColumn = NAMA_SEKOLAH_COLUMN;
        public static int alamatSekolahColumn = ALAMAT_SEKOLAH_COLUMN;

        public static int jumlahSekolah = 0;
        public static List<string> daftarNamaSekolah = new List<string>();
        public static List<string> daftarAlamatSekolah = new List<string>();
        public static List<char> daftarAkreditasiSekolah = new List<char>();
        public static List<int> daftarIndeksSekolah = new List<int>();
        public static List<string> daftarTanggalSekolah = new List<string>();



        /*
        ---------------
        |   Absensi   |
        ---------------
        */
        // januari
        public static int namaLengkapJanuariColumn = NAMA_LENGKAP_COLUMN;
        public static int alamatAbsensiJanuariColumn = ALAMAT_COLUMN;
        public static int jumlahAbsenJanuari = 0;

        public static List<string> daftarNisnAbsensiJanuari = new List<string>();
        public static List<string> daftarNamaLengkapAbsensiJanuari = new List<string>();
        public static List<int> daftarAbsensiHadirJanuari = new List<int>();
        public static List<int> daftarAbsensiSakitJanuari = new List<int>();
        public static List<int> daftarAbsensiIzinJanuari = new List<int>();
        public static List<int> daftarAbsensiAlfaJanuari = new List<int>();
        public static List<string> daftarAlamatAbsensiJanuari = new List<string>();

        // februari
        public static int jumlahAbsenFebruari = 0;

        // maret
        public static int jumlahAbsenMaret = 0;

        // april
        public static int jumlahAbsenApril = 0;

        // mei
        public static int jumlahAbsenMei = 0;

        // juni
        public static int jumlahAbsenJuni = 0;

        // juli
        public static int jumlahAbsenJuli = 0;

        // agustus
        public static int jumlahAbsenAgustus = 0;

        // september
        public static int jumlahAbsenSeptember = 0;

        // oktober
        public static int jumlahAbsenOktober = 0;

        // november
        public static int jumlahAbsenNovember = 0;

        // desember
        public static int jumlahAbsenDesember = 0;
    }
}
