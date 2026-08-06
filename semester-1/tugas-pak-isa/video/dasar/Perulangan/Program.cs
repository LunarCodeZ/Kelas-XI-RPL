// === MATERI PERULANGAN ===
/*
Perulangan ialah dimana blok kode diulang secara beberapa kali
selama kondisi masih memenuhi.
Perulangan dibagi menjadi 3, yakni:
1.) For Loop
2.) While Loop
3.) Foreach Loop
*/

// --- For Loop ---
/*
Perulangan yang dilakukan dengan menggunakan variabel lokal
*/
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Perulangan for ke-{i}");
}



// --- While Loop ---
/*
Perulangan yang dilakukan dengan menggunakan variabel global
*/
int angka = 1;
while (angka <= 5)
{
    Console.WriteLine($"Perulangan while ke-{angka}");
    angka++;
}



// --- Foreach Loop ---
/*
Perulangan yang dilakukan selama masih ada elemen
saat ini pada suatu array
*/
string[] buahBuahan = { "Apel", "Pisang", "Jeruk", "Nanas" };
foreach (string buah in buahBuahan)
{
    Console.WriteLine($"Buah saat ini: {buah}");
}