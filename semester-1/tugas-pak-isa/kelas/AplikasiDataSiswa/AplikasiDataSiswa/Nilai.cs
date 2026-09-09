using System.Collections.Generic;

namespace AplikasiDataSiswa
{
    class Nilai
    {
        public static void tampilkanNilai(int[] daftarNilai)
        {
            string[] daftarMataPelajaran = { "Pendidikan Pancasila", "Matematika", "B. Indonesia", "B. Inggris", "B. Jepang", "B. Jawa" };
            Console.WriteLine("> Nilai:");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("No.    | Mata Pelajaran: Nilai");
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < daftarNilai.Length; i++)
            {
                Console.WriteLine($"{i+1}.     | {daftarMataPelajaran[i]}: {daftarNilai[i]}");
            }
            Console.WriteLine("------------------------------------");
        }
    }
}