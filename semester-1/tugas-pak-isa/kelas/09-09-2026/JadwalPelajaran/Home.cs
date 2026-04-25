using System;
using System.Collections.Generic;
using System.Text;

namespace JadwalPelajaran
{
    class Home
    {
        public static void Main(String[] args) {
            String[] daftarHari = { "Senin", "Selasa", "Rabu", "Kamis", "Jum'at" };
            String hari = "";


            while (true) {
                Console.WriteLine("=========================");
                Console.WriteLine("   Jadwal Kelas XI-RPL");
                Console.WriteLine("   oleh: LunarCodeZ");
                Console.WriteLine("=========================\n");

                Console.WriteLine("> Daftar Hari");
                for (int i = 0; i < daftarHari.Length; i++)
                {
                    Console.WriteLine($"[{i + 1}] {daftarHari[i]}");
                }
                Console.Write("Masukkan angka: ");
                int opsi = Convert.ToInt32(Console.ReadLine());

                if (opsi >= 1 && opsi <= 5)
                {
                    if (opsi != 5)
                    {
                        hari = daftarHari[opsi - 1];
                    }
                    else
                    {
                        hari = "Jumat";
                    }

                    Console.Clear();
                    Console.WriteLine($"Hari: {hari}");
                    Console.WriteLine("\n> Daftar Sesi");

                    if (hari != "Jumat")
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            if (i == 0)
                            {
                                Console.WriteLine("[0] Kembali");
                            }
                            else
                            {
                                Console.WriteLine($"[{i}] Sesi {i + 1}");
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            if (i == 0)
                            {
                                Console.WriteLine("[0] Kembali");
                            }
                            else
                            {
                                Console.WriteLine($"[{i}] Sesi {i + 1}");
                            }
                        }
                    }

                    Console.Write("Pilih sesi: ");
                    opsi = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    switch (opsi)
                    {
                        case 0:
                            break;

                        case 1:
                            dapatkanJadwal(hari, opsi);
                            break;

                        case 2:
                            dapatkanJadwal(hari, opsi);
                            break;

                        case 3:
                            if (hari == "Jumat")
                            {
                                Console.WriteLine("Angka tidak valid!");
                                Console.WriteLine("Mohon masukkan angka antara 1-2...");
                                Console.WriteLine("Mohon coba lagi :)\n\n");
                            }
                            else
                            {
                                dapatkanJadwal(hari, opsi);
                            }
                            break;

                        default:
                            Console.WriteLine("Angka tidak valid!");
                            if (hari == "Jumat")
                            {
                                Console.WriteLine("Mohon masukkan angka antara 1-2...");
                            }
                            else 
                            {
                                Console.WriteLine("Mohon masukkan angka antara 1-3...");
                            }
                            Console.WriteLine("Mohon coba lagi :)\n\n");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Angka tidak valid!");
                    Console.WriteLine("Mohon masukkan angka antara 1-5...");
                    Console.WriteLine("Mohon coba lagi :)\n\n");
                }
            }
        }

        static void mulai() { }

        static void pilihHari() { }

        static void pilihSesi() { }

        static void dapatkanJadwal(String hari, int sesi)
        {
            switch (hari) 
            {
                case "Senin":
                    Senin senin = new Senin();
                    if (sesi == 1)
                    {
                        senin.sesi1();
                    }
                    else if (sesi == 2)
                    {
                        senin.sesi2();
                    }
                    else
                    {
                        senin.sesi3();
                    }
                    break;

                case "Selasa":
                    Selasa selasa = new Selasa();
                    if (sesi == 1)
                    {
                        selasa.sesi1();
                    }
                    else if (sesi == 2)
                    {
                        selasa.sesi2();
                    }
                    else
                    {
                        selasa.sesi3();
                    }
                    break;

                case "Rabu":
                    Rabu rabu = new Rabu();
                    if (sesi == 1)
                    {
                        rabu.sesi1();
                    }
                    else if (sesi == 2)
                    {
                        rabu.sesi2();
                    }
                    else
                    {
                        rabu.sesi3();
                    }
                    break;

                case "Kamis":
                    if (sesi == 1)
                    {
                        Kamis.sesi1();
                    }
                    else if (sesi == 2)
                    {
                        Kamis.sesi2();
                    }
                    else
                    {
                        Kamis.sesi3();
                    }
                    break;

                default:
                    if (sesi == 1)
                    {
                        Jumat.sesi1();
                    }
                    else
                    {
                        Jumat.sesi2();
                    }
                    break;
            }
        }
    }
}