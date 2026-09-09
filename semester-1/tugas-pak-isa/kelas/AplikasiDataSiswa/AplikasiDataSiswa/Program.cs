namespace AplikasiDataSiswa
{
    class Program
    {
        public static void Main(string[] args)
        {
            mulai();
        }

        public static void mulai()
        {
            string[] daftarAksi = { "Identitas", "MataPelajaran", "Absensi", "Nilai" };
            Console.WriteLine("-------------------------");
            Console.WriteLine("   Aplikasi Data Siswa");
            Console.WriteLine("   oleh: LunarCodeZ");
            Console.WriteLine("-------------------------");

            Console.WriteLine("> Daftar Aksi");
            for (int i = 0; i < daftarAksi.Length; i++)
            {
                Console.WriteLine($"[{i + 1}] {daftarAksi[i]}");
            }
            Console.Write("Pilih aksi: ");
            int opsi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            switch (opsi)
            {
                case 1:
                    Console.WriteLine("> Identitas");
                    string[] daftarAksiIdentitas = { "Siswa", "Wali", "Sekolah" };
                    for (int i = 0; i < daftarAksiIdentitas.Length; i++)
                    {
                        Console.WriteLine($"[{i + 1}] {daftarAksiIdentitas[i]}");
                    }
                    Console.WriteLine("Pilih aksi: ");
                    opsi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    Identitas identitas = new Identitas();

                    if (opsi == 1)
                    {
                        identitas.siswa();
                    }
                    else if (opsi == 2)
                    {
                        identitas.wali();
                    }
                    else if (opsi == 3)
                    {
                        identitas.sekolah();
                    }
                    break;

                case 2:
                    Console.WriteLine("> Mata Pelajaran");
                    string[] daftarMataPelajaran = { "Produktif", "Non-produktif" };
                    for (int i = 0; i < daftarMataPelajaran.Length; i++)
                    {
                        Console.WriteLine($"[{i + 1}] {daftarMataPelajaran[i]}");
                    }

                    Console.Write("Pilih aksi: ");
                    opsi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");

                    if (opsi == 1)
                    {
                        MataPelajaran.mataPelajaranProduktif();
                    }
                    else if (opsi == 2)
                    {
                        MataPelajaran.mataPelajaranNonProduktif();
                    }
                    break;

                case 3:
                    char[] daftarHadir = { '-', 'a', '-', '-', '-', '-', 'a', '-', '-', '-', '-', '-', '-', '-', 'i', '-', '-', '-', 'i', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-' };
                    Console.WriteLine("> Absensi");
                    string[] daftarBulan = { "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember" };
                    for (int i = 0; i < daftarBulan.Length; i++)
                    {
                        Console.WriteLine($"[{i + 1}] {daftarBulan[i]}");
                    }
                    Console.Write("Pilih bulan: ");
                    opsi = Convert.ToInt32(Console.ReadLine());

                    if (opsi == 1)
                    {
                        Absensi.januari(daftarHadir);
                    }
                    else if (opsi == 2)
                    {
                        Absensi.februari(daftarHadir);
                    }
                    else if (opsi == 3)
                    {
                        Absensi.maret(daftarHadir);
                    }
                    else if (opsi == 4)
                    {
                        Absensi.april(daftarHadir);
                    }
                    else if (opsi == 5)
                    {
                        Absensi.mei(daftarHadir);
                    }
                    else if (opsi == 6)
                    {
                        Absensi.juni(daftarHadir);
                    }
                    else if (opsi == 7)
                    {
                        Absensi.juli(daftarHadir);
                    }
                    else if (opsi == 8)
                    {
                        Absensi.agustus(daftarHadir);
                    }
                    else if (opsi == 9)
                    {
                        Absensi.september(daftarHadir);
                    }
                    else if (opsi == 10)
                    {
                        Absensi.oktober(daftarHadir);
                    }
                    else if (opsi == 11)
                    {
                        Absensi.november(daftarHadir);
                    }
                    else if (opsi == 12)
                    {
                        Absensi.desember(daftarHadir);
                    }
                    break;

                case 4:
                    Console.WriteLine("> Nilai");
                    int[] daftarNilai = { 100, 95, 98, 70, 76, 24 };
                    Nilai.tampilkanNilai(daftarNilai);
                    break;

                default:
                    Console.WriteLine("Aksi tidak valid!");
                    Console.WriteLine("Harap coba lagi...");
                    break;
            }

            mulai();
        }
    }
}