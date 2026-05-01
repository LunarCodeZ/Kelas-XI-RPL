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
        int jumlahWali = 0;
        List<string> daftarNamaWali;
        List<int> daftarUmurWali;
        List<string> daftarAlamatWali;
        List<string> daftarTeleponWali;

        // data sekolah
        int jumlahSekolah = 0;
        List<string> daftarNamaSekolah;
        List<string> daftarAlamatSekolah;
    }
}
