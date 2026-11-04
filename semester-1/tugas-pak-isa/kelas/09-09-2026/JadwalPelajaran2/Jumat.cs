using System;
using System.Collections.Generic;
using System.Text;

namespace JadwalPelajaran
{
    internal class Jumat
    {
        public static void sesi1()
        {
            Console.WriteLine(">>> Pelajaran Hari Jum'at: Sesi 1 <<<");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Jam ke-  | Waktu         | Mata Pelajaran");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("0        | 06.30 - 08.00 | Senam / Istighosah / Kebersihan");
            Console.WriteLine("1        | 08.00 - 08.30 | B. Inggris");
            Console.WriteLine("2        | 08.30 - 09.00 | B. Inggris");
            Console.WriteLine("3        | 09.00 - 09.30 | Seni Budaya");
            Console.WriteLine("-        | 09.30 - 09.45 | Istirahat");
            Console.WriteLine("----------------------------------------------------------");
        }

        public static void sesi2()
        {
            Console.WriteLine(">>> Pelajaran Hari Jum'at: Sesi 2 <<<");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Jam ke-  | Waktu         | Mata Pelajaran");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("4        | 09.45 - 10.15 | Seni Budaya");
            Console.WriteLine("5        | 10.15 - 10.45 | Pendidikan Pancasila");
            Console.WriteLine("6        | 10.45 - 11.15 | Pendidikan Pancasila");
            Console.WriteLine("-----------------------------------------------");
        }
    }
}
