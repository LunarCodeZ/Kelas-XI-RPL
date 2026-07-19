// === Method / Fungsi Sederhana ===
/*
Materi yang akan dipelajari:
1.) Method / Fungsi
2.) Parameter
3.) Return Value
*/

// 1. Method / Fungsi
/*
Blok kode yang dapat dijalankan dengan cara memanggil nama
function atau method tersebut
*/
static void Salam()
{
    Console.WriteLine("Halo !");
}

// Memanggil method / function
Salam();



// 2. Parameter
/*
Variabel yang dapat digunakan dalam function
atau method tersebut
*/
static void Sapa(string nama)
{
    Console.WriteLine($"Halo, nama saya {nama}");
}

// Memanggil method / function dengan parameter
Sapa("Lunar");



// 3. Return Value
/*
Nilai yang akan dikembalikan oleh suatu function atau method
*/
static char DapatkanNilai()
{
    return 'A';
}

// Mendapatkan return value
char nilaiSaya = DapatkanNilai();
Console.WriteLine(nilaiSaya);

// Kode diatas akan menampilkan 'A' karena function DapatkanNilai() mengembalikan karakter 'A'!