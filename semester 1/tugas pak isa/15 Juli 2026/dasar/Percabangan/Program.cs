// === PERCABANGAN ===
/*
Percabangan ialah dimana komputer dapat menentukan suatu keputusan berdasarkan kondisi yang dimiliki.
Percabangan terdiri dari 3 komponen; IF, ELSE, dan ELSE IF
Tetapi, ada juga percabangan menggunakan SWITCH
*/

// --- Contoh percabangan nilai ujian ---
// IF: Menjalankan kode di dalamnya jika kondisi benar
int nilai = 100;
Console.WriteLine($"Nilai anda: {nilai}");

if (nilai >= 90)
{
    Console.WriteLine("Anda mendapatkan A+");
}

/*
Penjelasan:
--> Jika nilai ialah sama dengan atau lebih dari 90,
    maka komputer akan menampilkan "Anda mendapatkan A+"
*/



// ELSE IF: Menjalankan kode di dalamnya jika kondisi dari IF salah
if (nilai >= 90)
{
    Console.WriteLine("Anda mendapatkan A+");
}
else if (nilai >= 80)
{
    Console.WriteLine("Anda mendapatkan A");
}

/*
Penjelasan:
--> Jika nilai ialah sama dengan atau lebih dari 90,
    maka komputer akan menampilkan "Anda mendapatkan A+"
--> Tetapi, jika nilai ialah sama dengan atau lebih dari 80,
    maka komputer akan menampilkan "Anda mendapatkan A"
*/



// ELSE: Menjalankan kode di dalamnya jika kondisi dari IF dan seluruh ELSE IF berikutnya bernilai salah
if (nilai >= 90)
{
    Console.WriteLine("Anda mendapatkan A+");
}
else if (nilai >= 80)
{
    Console.WriteLine("Anda mendapatkan A");
}
else
{
    Console.WriteLine("Anda mendapatkan B");
}

/*
Penjelasan:
--> Jika nilai ialah sama dengan atau lebih dari 90,
    maka komputer akan menampilkan "Anda mendapatkan A+"
--> Tetapi, jika nilai ialah sama dengan atau lebih dari 80,
    maka komputer akan menampilkan "Anda mendapatkan A"
--> Selain itu,
    maka komputer akan menampilkan "Anda mendapatkan B"
*/





// --- Contoh percabangan deteksi hari ---
int hariSekarang = 1;
string hariSaatIni;

switch (hariSekarang)
{
    case 1:
        hariSaatIni = "Senin";
        break;
    case 2:
        hariSaatIni = "Selasa";
        break;
    case 3:
        hariSaatIni = "Rabu";
        break;
    case 4:
        hariSaatIni = "Kamis";
        break;
    case 5:
        hariSaatIni = "Jumat";
        break;
    case 6:
        hariSaatIni = "Sabtu";
        break;
    default:
        hariSaatIni = "Minggu";
        break;
}
Console.WriteLine($"Hari ini ialah hari: {hariSaatIni}");