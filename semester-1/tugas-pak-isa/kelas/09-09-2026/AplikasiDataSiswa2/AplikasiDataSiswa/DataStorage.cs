using System;
using System.Collections.Generic;

namespace AplikasiDataSiswa
{
    class DataStorage
    {
        // =========================
        // DATA SISWA
        // =========================
        public const int NISN_LENGTH = 9;

        public static int jumlahSiswa = 0;
        public static List<string> daftarNisnSiswa = new();
        public static List<string> daftarNamaLengkapSiswa = new();
        public static List<string> daftarNamaPanggilanSiswa = new();
        public static List<char> daftarJenisKelaminSiswa = new();
        public static List<int> daftarUmurSiswa = new();
        public static List<string> daftarAlamatSiswa = new();
        public static List<string> daftarSekolahSiswa = new();

        // =========================
        // DATA WALI
        // =========================
        public const int NAMA_WALI_COLUMN = 9;
        public const int ALAMAT_WALI_COLUMN = 11;
        public const int TELEPON_WALI_COLUMN = 12;
        public const int UMUR_WALI_COLUMN = 4;

        public static int jumlahWali = 0;
        public static List<string> daftarNamaWali = new();
        public static List<int> daftarUmurWali = new();
        public static List<string> daftarAlamatWali = new();
        public static List<string> daftarTeleponWali = new();

        // =========================
        // DATA SEKOLAH
        // =========================
        public const int NAMA_SEKOLAH_COLUMN = 12;
        public const int ALAMAT_SEKOLAH_COLUMN = 14;
        public const int AKREDITASI_SEKOLAH_COLUMN = 10;
        public const int INDEKS_SEKOLAH_COLUMN = 6;
        public const int TANGGAL_SEKOLAH_COLUMN = 14;

        public static int jumlahSekolah = 0;
        public static List<string> daftarNamaSekolah = new();
        public static List<string> daftarAlamatSekolah = new();
        public static List<char> daftarAkreditasiSekolah = new();
        public static List<int> daftarIndeksSekolah = new();
        public static List<string> daftarTanggalSekolah = new();

        // =========================
        // DATA MATA PELAJARAN
        // =========================
        public static int jumlahMataPelajaran = 0;
        public static List<int> daftarIdMataPelajaran = new();
        public static List<string> daftarNamaMataPelajaran = new();
        public static List<string> daftarGuruMataPelajaran = new();

        // =========================
        // DATA NILAI
        // =========================
        public static int jumlahNilai = 0;
        public static List<string> daftarNisnNilai = new();
        public static List<int> daftarIdMataPelajaranNilai = new();
        public static List<double> daftarNilai = new();

        // =========================
        // DATA ABSENSI JANUARI
        // =========================
        public static int jumlahAbsenJanuari = 0;
        public static List<string> daftarNisnAbsensiJanuari = new();
        public static List<string> daftarNamaAbsensiJanuari = new();
        public static List<int> daftarAbsensiHadirJanuari = new();
        public static List<int> daftarAbsensiSakitJanuari = new();
        public static List<int> daftarAbsensiIzinJanuari = new();
        public static List<int> daftarAbsensiAlphaJanuari = new();
        public static List<string> daftarAlamatAbsensiJanuari = new();
    }
}
