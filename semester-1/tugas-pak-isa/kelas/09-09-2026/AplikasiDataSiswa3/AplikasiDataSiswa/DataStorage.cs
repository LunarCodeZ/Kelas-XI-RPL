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
        public const int MATA_PELAJARAN_COLUMN = 14;
        public const int NAMA_GURU_PENGAJAR_COLUMN = 18;

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
        public static int namaLengkapFebruariColumn = NAMA_LENGKAP_COLUMN;
        public static int alamatAbsensiFebruariColumn = ALAMAT_COLUMN;
        public static int jumlahAbsenFebruari = 0;

        public static List<string> daftarNisnAbsensiFebruari = new List<string>();
        public static List<string> daftarNamaLengkapAbsensiFebruari = new List<string>();
        public static List<int> daftarAbsensiHadirFebruari = new List<int>();
        public static List<int> daftarAbsensiSakitFebruari = new List<int>();
        public static List<int> daftarAbsensiIzinFebruari = new List<int>();
        public static List<int> daftarAbsensiAlfaFebruari = new List<int>();
        public static List<string> daftarAlamatAbsensiFebruari = new List<string>();

        // maret
        public static int namaLengkapMaretColumn = NAMA_LENGKAP_COLUMN;
        public static int alamatAbsensiMaretColumn = ALAMAT_COLUMN;
        public static int jumlahAbsenMaret = 0;

        public static List<string> daftarNisnAbsensiMaret = new List<string>();
        public static List<string> daftarNamaLengkapAbsensiMaret = new List<string>();
        public static List<int> daftarAbsensiHadirMaret = new List<int>();
        public static List<int> daftarAbsensiSakitMaret = new List<int>();
        public static List<int> daftarAbsensiIzinMaret = new List<int>();
        public static List<int> daftarAbsensiAlfaMaret = new List<int>();
        public static List<string> daftarAlamatAbsensiMaret = new List<string>();

        // april
        public static int namaLengkapAprilColumn = NAMA_LENGKAP_COLUMN;
        public static int alamatAbsensiAprilColumn = ALAMAT_COLUMN;
        public static int jumlahAbsenApril = 0;

        public static List<string> daftarNisnAbsensiApril = new List<string>();
        public static List<string> daftarNamaLengkapAbsensiApril = new List<string>();
        public static List<int> daftarAbsensiHadirApril = new List<int>();
        public static List<int> daftarAbsensiSakitApril = new List<int>();
        public static List<int> daftarAbsensiIzinApril = new List<int>();
        public static List<int> daftarAbsensiAlfaApril = new List<int>();
        public static List<string> daftarAlamatAbsensiApril = new List<string>();

        // mei
        public static int namaLengkapMeiColumn = NAMA_LENGKAP_COLUMN;
        public static int alamatAbsensiMeiColumn = ALAMAT_COLUMN;
        public static int jumlahAbsenMei = 0;

        public static List<string> daftarNisnAbsensiMei = new List<string>();
        public static List<string> daftarNamaLengkapAbsensiMei = new List<string>();
        public static List<int> daftarAbsensiHadirMei = new List<int>();
        public static List<int> daftarAbsensiSakitMei = new List<int>();
        public static List<int> daftarAbsensiIzinMei = new List<int>();
        public static List<int> daftarAbsensiAlfaMei = new List<int>();
        public static List<string> daftarAlamatAbsensiMei = new List<string>();

        // juni
        public static int namaLengkapJuniColumn = NAMA_LENGKAP_COLUMN;
        public static int alamatAbsensiJuniColumn = ALAMAT_COLUMN;
        public static int jumlahAbsenJuni = 0;

        public static List<string> daftarNisnAbsensiJuni = new List<string>();
        public static List<string> daftarNamaLengkapAbsensiJuni = new List<string>();
        public static List<int> daftarAbsensiHadirJuni = new List<int>();
        public static List<int> daftarAbsensiSakitJuni = new List<int>();
        public static List<int> daftarAbsensiIzinJuni = new List<int>();
        public static List<int> daftarAbsensiAlfaJuni = new List<int>();
        public static List<string> daftarAlamatAbsensiJuni = new List<string>();

        // juli
        public static int namaLengkapJuliColumn = NAMA_LENGKAP_COLUMN;
        public static int alamatAbsensiJuliColumn = ALAMAT_COLUMN;
        public static int jumlahAbsenJuli = 0;

        public static List<string> daftarNisnAbsensiJuli = new List<string>();
        public static List<string> daftarNamaLengkapAbsensiJuli = new List<string>();
        public static List<int> daftarAbsensiHadirJuli = new List<int>();
        public static List<int> daftarAbsensiSakitJuli = new List<int>();
        public static List<int> daftarAbsensiIzinJuli = new List<int>();
        public static List<int> daftarAbsensiAlfaJuli = new List<int>();
        public static List<string> daftarAlamatAbsensiJuli = new List<string>();

        // agustus
        public static int namaLengkapAgustusColumn = NAMA_LENGKAP_COLUMN;
        public static int alamatAbsensiAgustusColumn = ALAMAT_COLUMN;
        public static int jumlahAbsenAgustus = 0;

        public static List<string> daftarNisnAbsensiAgustus = new List<string>();
        public static List<string> daftarNamaLengkapAbsensiAgustus = new List<string>();
        public static List<int> daftarAbsensiHadirAgustus = new List<int>();
        public static List<int> daftarAbsensiSakitAgustus = new List<int>();
        public static List<int> daftarAbsensiIzinAgustus = new List<int>();
        public static List<int> daftarAbsensiAlfaAgustus = new List<int>();
        public static List<string> daftarAlamatAbsensiAgustus = new List<string>();

        // september
        public static int namaLengkapSeptemberColumn = NAMA_LENGKAP_COLUMN;
        public static int alamatAbsensiSeptemberColumn = ALAMAT_COLUMN;
        public static int jumlahAbsenSeptember = 0;

        public static List<string> daftarNisnAbsensiSeptember = new List<string>();
        public static List<string> daftarNamaLengkapAbsensiSeptember = new List<string>();
        public static List<int> daftarAbsensiHadirSeptember = new List<int>();
        public static List<int> daftarAbsensiSakitSeptember = new List<int>();
        public static List<int> daftarAbsensiIzinSeptember = new List<int>();
        public static List<int> daftarAbsensiAlfaSeptember = new List<int>();
        public static List<string> daftarAlamatAbsensiSeptember = new List<string>();

        // oktober
        public static int namaLengkapOktoberColumn = NAMA_LENGKAP_COLUMN;
        public static int alamatAbsensiOktoberColumn = ALAMAT_COLUMN;
        public static int jumlahAbsenOktober = 0;

        public static List<string> daftarNisnAbsensiOktober = new List<string>();
        public static List<string> daftarNamaLengkapAbsensiOktober = new List<string>();
        public static List<int> daftarAbsensiHadirOktober = new List<int>();
        public static List<int> daftarAbsensiSakitOktober = new List<int>();
        public static List<int> daftarAbsensiIzinOktober = new List<int>();
        public static List<int> daftarAbsensiAlfaOktober = new List<int>();
        public static List<string> daftarAlamatAbsensiOktober = new List<string>();

        // november
        public static int namaLengkapNovemberColumn = NAMA_LENGKAP_COLUMN;
        public static int alamatAbsensiNovemberColumn = ALAMAT_COLUMN;
        public static int jumlahAbsenNovember = 0;

        public static List<string> daftarNisnAbsensiNovember = new List<string>();
        public static List<string> daftarNamaLengkapAbsensiNovember = new List<string>();
        public static List<int> daftarAbsensiHadirNovember = new List<int>();
        public static List<int> daftarAbsensiSakitNovember = new List<int>();
        public static List<int> daftarAbsensiIzinNovember = new List<int>();
        public static List<int> daftarAbsensiAlfaNovember = new List<int>();
        public static List<string> daftarAlamatAbsensiNovember = new List<string>();

        // desember
        public static int namaLengkapDesemberColumn = NAMA_LENGKAP_COLUMN;
        public static int alamatAbsensiDesemberColumn = ALAMAT_COLUMN;
        public static int jumlahAbsenDesember = 0;

        public static List<string> daftarNisnAbsensiDesember = new List<string>();
        public static List<string> daftarNamaLengkapAbsensiDesember = new List<string>();
        public static List<int> daftarAbsensiHadirDesember = new List<int>();
        public static List<int> daftarAbsensiSakitDesember = new List<int>();
        public static List<int> daftarAbsensiIzinDesember = new List<int>();
        public static List<int> daftarAbsensiAlfaDesember = new List<int>();
        public static List<string> daftarAlamatAbsensiDesember = new List<string>();



        /*
        -------------
        |   Nilai   |
        -------------
        */
        public static int mataPelajaranColumn = MATA_PELAJARAN_COLUMN;
        public static int banyakDataNilai = 0;

        public static List<string> daftarNamaLengkapNilai = new List<string>();
        public static List<string> daftarMataPelajaranNilai = new List<string>(); 
        public static List<int> daftarNilai = new List<int>();
        public static List<char> daftarKeteranganNilai = new List<char>();



        /*
        ----------------------
        |   Mata Pelajaran   |
        ----------------------
        */
        public static int namaGuruPengajarColumn = NAMA_GURU_PENGAJAR_COLUMN;
        public static int jumlahMataPelajaran = 0;

        public static List<string> daftarDataMataPelajaran = new List<string>();
        public static List<string> daftarJenisMataPelajaran = new List<string>();
        public static List<string> daftarNamaGuruPengajar = new List<string>();
    }
}
