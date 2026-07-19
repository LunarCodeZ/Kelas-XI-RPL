// === Variabel, Tipe Data, dan Operator Sederhana

// Variabel: Tempat untuk menyimpan suatu nilai
// Tipe Data: Jenis nilai yang disimpan pada variabel
// Operator: Simbol untuk menjalankan suatu operasi



// --- Variabel ---
int umur = 17;
string nama = "Budi";
// Contoh diatas, umur dan nama ialah variabel, sedangkan 17 dan "Budi" ialah nilainya



// --- Tipe Data ---
// Integer (int): Untuk menyimpan bilangan bulat utuh
int tahun = 2026;

// Long (long): Untuk menyimpan bilangan bulat utuh, dengan digit lebih banyak daripada integer
long angkaLong = 250000000;

// Float (float): Untuk menyimpan bilangan desimal 6-7 digit
float angkaFloat = 10.5f;

// Double (double): Untuk menyimpan bilangan desimal hingga 15 digit
double tinggi = 175.5d;

// Character (char): Untuk menyimpan karakter tunggal
char nilai = 'A';

// String (string): Untuk menyimpan kata atau kalimat
string alamat = "Sidoarjo";

// Boolean (bool): Untuk menyimpan pernyataan antara benar atau salah (true or false)
bool gemarMembaca = true;
bool sukaGame = false;



// --- Operator ---
int a = 10;
int b = 6;

/* Cara 1: Melakukan operator dan menyimpan hasil ke variabel, kemudian menampilkan hasilnya ke dalam console
Contoh:
int hasil = a + b;
Console.WriteLine(hasil);
*/

/* Cara 2: Melakukan operasi langsung di dalam console
Contoh:
Console.WriteLine(a + b);
*/

// Penjumlahan (+): Menjumlahkan kedua nilai, atau lebih
int hasilPenjumlahan = a + b;
Console.WriteLine(hasilPenjumlahan);

// Pengurangan (-): Mengurangi kedua nilai, atau lebih
int hasilPengurangan = a - b;
Console.WriteLine(hasilPengurangan);

// Perkalian (*): Mengalikan kedua nilai, atau lebih
int hasilPerkalian = a * b;
Console.WriteLine(hasilPerkalian);

// Pembagian (/): Membagikan kedua nilai, atau lebih. Hasil bisa saja desimal, sehingga perlu menggunakan tipe data float ataupun double.
double hasilPembagian = a / b;
Console.WriteLine(hasilPembagian);