// === MATERI ARRAY DAN KOLEKSI DASAR ===
/*
Dalam pemrograman, array dan koleksi dasar keduanya digunakan
untuk menyimpan banyak data. Berbeda dengan variabel yang dimana
hanya dapat digunakan untuk menyimpan satu data saja.
*/

// --- Array ---
/*
Array ialah tipe data komposit yang dapat digunakan untuk
menyimpan banyak elemen dimana setiap elemen memiliki tipe
yang sama. Pada tipe data ini, kita tidak dapat menambahkan
maupun mengurangi elemen di dalamnya.
*/
string[] buahBuahan = { "Apel", "Pisang", "Jeruk", "Mangga" };

// > Menampilkan elemen
/*
Setiap elemen pada array memiliki indeks 0
yang dimulai dari elemen paling kiri yang dimana akan
bertambah sebanyak 1 untuk setiap elemen ke kanan.
*/
Console.WriteLine(buahBuahan[0]); // --> menampilkan elemen pertama (indeks 0)
Console.WriteLine(buahBuahan[1]); // --> menampilkan elemen kedua (indeks 1)
Console.WriteLine(buahBuahan[3]); // --> menampilkan elemen terakhir (indeks 3)

// > Mengubah elemen
// Mengubah elemen pertama dari "Apel" menjadi "Kiwi"
buahBuahan[0] = "Kiwi";
Console.WriteLine(buahBuahan[0]);

// Mengubah elemen terakhir dari "Mangga" menjadi "Kurma"
buahBuahan[3] = "Kurma";
Console.WriteLine(buahBuahan[3]);

// > Menampilkan semua elemen list
foreach (string buah in buahBuahan)
{
    Console.WriteLine(buah);
}



// --- List ---
/*
List ialah tipe data yang sama seperti array, tetapi kita
juga dapat menambah dan mengurangi elemen di dalamnya.
*/
List<string> namaSiswa = new List<string>();

// > Menambahkan elemen baru
namaSiswa.Add("Agus");
namaSiswa.Add("Budi");
namaSiswa.Add("Lunar");

// > Menampilkan semua elemen list
foreach (string nama in namaSiswa)
{
    Console.WriteLine(nama);
}