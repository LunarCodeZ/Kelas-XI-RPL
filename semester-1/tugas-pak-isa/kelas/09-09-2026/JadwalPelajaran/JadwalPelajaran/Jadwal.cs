using System;
using System.Collections.Generic;
using System.Text;

namespace JadwalPelajaran
{
    class Jadwal
    {
        public static List<Jadwal> objekJadwalPelajaranSenin = new List<Jadwal>();

        public static int[,,] banyakJadwalPelajaran = {
            // Senin
            {
                // Kelas 10
                { 1, 1, 1, 1, 1, 1 },

                // Kelas 11
                { 2, 1, 1, 1, 1, 1 },

                // Kelas 12
                { 1, 1, 1, 1, 1, 1 }
            }

            // Selasa
            // Rabu
            // Kamis
            // Jumat
        };

        public static string[,,,] jadwalPelajaranSenin = {
            // Kelas 10

            // Kelas 11
            {
                {
                    { "0", "1"},
                    { "07.00 - 07.35", "07.35 - 08.10" },
                    { "Upacara Bendera", "Gak tau" },
                    { "-", "-" }
                },
                {
                    { "0", "1"},
                    { "07.00 - 07.35", "07.35 - 08.10" },
                    { "Upacara Bendera", "Gak tau" },
                    { "-", "-" }
                },
                {
                    { "0", "1"},
                    { "07.00 - 07.35", "07.35 - 08.10" },
                    { "Upacara Bendera", "Gak tau" },
                    { "-", "-" }
                },
                {
                    { "0", "1"},
                    { "07.00 - 07.35", "07.35 - 08.10" },
                    { "Upacara Bendera", "Gak tau" },
                    { "-", "-" }
                },
                {
                    { "0", "1"},
                    { "07.00 - 07.35", "07.35 - 08.10" },
                    { "Upacara Bendera", "Gak tau" },
                    { "-", "-" }
                },
                {
                    { "0", "1"},
                    { "07.00 - 07.35", "07.35 - 08.10" },
                    { "Upacara Bendera", "Gak tau" },
                    { "-", "-" }
                }
            },

            // Kelas 12
        };

        public int JamKe { get; set; }
        public string Jam { get; set; }
        public string MataPelajaran { get; set; }
        public string NamaPengajar { get; set; }

        // >>> Methods <<<
        public static void Create(int kelasId, int jurusanId)
        {

        }

        public static void Read(int kelasId, int jurusanId)
        {

        }

        public static void Update(int kelasId, int jurusanId)
        {

        }
        public static void Delete(int kelasId, int jurusanId)
        {

        }

        public static void Reset(int kelasId, int jurusanId)
        {

        }

        public static void Export(int kelasId, int jurusanId)
        {

        }

        public static void Import(int kelasId, int jurusanId)
        {

        }

        public static void Load(int kelasId, int jurusanId)
        {
            //objekJadwalPelajaranSenin.Add(new List<List<Jadwal>>());

            for (int i = 0; i < banyakJadwalPelajaran[0, 1, 0]; i++)
            {
                objekJadwalPelajaranSenin.Add(new Jadwal
                {
                    JamKe = Convert.ToInt32(jadwalPelajaranSenin[kelasId, jurusanId, 0, i]),
                    Jam = jadwalPelajaranSenin[kelasId, jurusanId, 1, i],
                    MataPelajaran = jadwalPelajaranSenin[kelasId, jurusanId, 2, i],
                    NamaPengajar = jadwalPelajaranSenin[kelasId, jurusanId, 3, i]
                });

                Console.WriteLine($"Jam ke: {objekJadwalPelajaranSenin[i].JamKe}");
                Console.WriteLine($"Jam: {objekJadwalPelajaranSenin[i].Jam}");
                Console.WriteLine($"Mata pelajaran: {objekJadwalPelajaranSenin[i].MataPelajaran}");
                Console.WriteLine($"Nama pengajar: {objekJadwalPelajaranSenin[i].NamaPengajar}");
            }
        }

        public static void Save(int kelasId, int jurusanId)
        {

        }


        // --------------------------
        // | Jadwal Pelajaran Senin |
        // --------------------------
        // --- Kelas 10 ---
        // RPL
        // DKV
        // AK
        // BD
        // MP
        // LPB

        // --- Kelas 11 ---
        // RPL
        // DKV
        // AK
        // BD
        // MP
        // LPB

        // --- Kelas 12 ---
        // RPL
        // DKV
        // AK
        // BD
        // MP
        // LPB

        

        
    }
}
