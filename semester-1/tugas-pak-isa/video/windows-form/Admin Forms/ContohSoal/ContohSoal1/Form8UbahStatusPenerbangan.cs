using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContohSoal1
{
    public partial class Form8UbahStatusPenerbangan : Form
    {
        public Form8UbahStatusPenerbangan()
        {
            // Inisialisasi komponen-komponen yang digunakan pada halaman ini (Form5Maskapai) agar bisa dirender saat dimulai
            InitializeComponent();
        }

        // Apabila label7 (teks "logout") di tekan, maka:
        private void label7_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman login (Form1Login)
            Form1Login login = new Form1Login();

            // Tutup halaman saat ini (Form8UbahStatusPenerbangan)
            this.Close();

            // Tampilkan halaman login (Form1Login)
            login.Show();
        }

        // Apabila pictureBox7 (gambar logout) di tekan, maka:
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman login (Form1Login)
            Form1Login login = new Form1Login();

            // Tutup halaman saat ini (Form8UbahStatusPenerbangan)
            this.Close();

            // Tampilkan halaman login (Form1Login)
            login.Show();
        }

        // Apabila label2 (teks "Master Bandara") pada menu navigasi diklik, maka:
        private void label2_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman bandara (Form4Bandara)
            Form4Bandara bandara = new Form4Bandara();

            // Tutup halaman saat ini (Form8UbahStatusPenerbangan)
            this.Close();

            // Tampilkan halaman bandara (Form4Bandara)
            bandara.Show();
        }

        // Apabila pictureBox2 (gambar peta sebelah teks "Master Bandara") pada menu navigasi diklik, maka:
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman bandara (Form4Bandara)
            Form4Bandara bandara = new Form4Bandara();

            // Tutup halaman saat ini (Form8UbahStatusPenerbangan)
            this.Close();

            // Tampilkan halaman bandara (Form4Bandara)
            bandara.Show();
        }

        // Apabila pictureBox3 (gambar pesawat sebelah teks "Master Maskapai") pada menu navigasi diklik, maka:
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman maskapai (Form5Maskapai)
            Form5Maskapai maskapai = new Form5Maskapai();

            // Tutup halaman saat ini (Form8UbahStatusPenerbangan)
            this.Close();

            // Tampilkan halaman maskapai (Form5Maskapai)
            maskapai.Show();
        }

        // Apabila label3 (teks "Master Maskapai") pada menu navigasi diklik, maka:
        private void label3_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman maskapai (Form5Maskapai)
            Form5Maskapai maskapai = new Form5Maskapai();

            // Tutup halaman saat ini (Form8UbahStatusPenerbangan)
            this.Close();

            // Tampilkan halaman maskapai (Form5Maskapai)
            maskapai.Show();
        }

        // Apabila pictureBox4 (gambar kalender pesawat sebelah teks "Master Jadwal Penerbangan") pada menu navigasi diklik, maka:
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman jadwal (Form6JadwalPenerbangan)
            Form6JadwalPenerbangan jadwal = new Form6JadwalPenerbangan();

            // Tutup halaman saat ini (Form8UbahStatusPenerbangan)
            this.Close();

            // Tampilkan halaman jadwal (Form6JadwalPenerbangan)
            jadwal.Show();
        }

        // Apabila label4 (teks "Master Jadwal Penerbangan") pada menu navigasi diklik, maka:
        private void label4_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman jadwal (Form6JadwalPenerbangan)
            Form6JadwalPenerbangan jadwal = new Form6JadwalPenerbangan();

            // Tutup halaman saat ini (Form8UbahStatusPenerbangan)
            this.Close();

            // Tampilkan halaman jadwal (Form6JadwalPenerbangan)
            jadwal.Show();
        }

        // Apabila label5 (teks "Master Jadwal Penerbangan") pada menu navigasi diklik, maka:
        private void label5_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman promo (Form7KodePromo)
            Form7KodePromo promo = new Form7KodePromo();

            // Tutup halaman saat ini (Form8UbahStatusPenerbangan)
            this.Close();

            // Tampilkan halaman promo (Form7KodePromo)
            promo.Show();
        }

        // Apabila label5 (gambar kupon sebelah teks "Master Jadwal Penerbangan") pada menu navigasi diklik, maka:
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman promo (Form7KodePromo)
            Form7KodePromo promo = new Form7KodePromo();

            // Tutup halaman saat ini (Form8UbahStatusPenerbangan)
            this.Close();

            // Tampilkan halaman promo (Form7KodePromo)
            promo.Show();
        }

        // Apabila pictureBox1 (gambar garis 3 sebelah teks "dashboard") pada menu navigasi bawah diklik, maka:
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman dashboard (Form3Dashboard)
            Form3Dashboard dashboard = new Form3Dashboard();

            // Tutup halaman saat ini (Form8UbahStatusPenerbangan)
            this.Close();

            // Tampilkan halaman dashboard (Form3Dashboard)
            dashboard.Show();
        }

        // Apabila label1 (teks "dashboard") pada menu navigasi bawah diklik, maka:
        private void label1_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman dashboard (Form3Dashboard)
            Form3Dashboard dashboard = new Form3Dashboard();

            // Tutup halaman saat ini (Form8UbahStatusPenerbangan)
            this.Close();

            // Tampilkan halaman dashboard (Form3Dashboard)
            dashboard.Show();
        }
    }
}
