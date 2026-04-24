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
    public partial class Form7KodePromo : Form
    {
        public Form7KodePromo()
        {
            // Inisialisasi komponen-komponen yang digunakan pada halaman ini (Form5Maskapai) agar bisa dirender saat dimulai
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman dashboard (Form3Dashboard)
            Form3Dashboard dashboard = new Form3Dashboard();

            // Tutup halaman saat ini (Form7KodePromo)
            this.Close();

            // Tampilkan halaman dashboard (Form3Dashboard)
            dashboard.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman dashboard (Form3Dashboard)
            Form3Dashboard dashboard = new Form3Dashboard();

            // Tutup halaman saat ini (Form7KodePromo)
            this.Close();

            // Tampilkan halaman dashboard (Form3Dashboard)
            dashboard.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman bandara (Form4Bandara)
            Form4Bandara bandara = new Form4Bandara();

            // Tutup halaman saat ini (Form7KodePromo)
            this.Close();

            // Tampilkan halaman bandara (Form4Bandara)
            bandara.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman bandara (Form4Bandara)
            Form4Bandara bandara = new Form4Bandara();

            // Tutup halaman saat ini (Form7KodePromo)
            this.Close();

            // Tampilkan halaman bandara (Form4Bandara)
            bandara.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman maskapai (Form5Maskapai)
            Form5Maskapai maskapai = new Form5Maskapai();

            // Tutup halaman saat ini (Form7KodePromo)
            this.Close();

            // Tampilkan halaman maskapai (Form5Maskapai)
            maskapai.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman maskapai (Form5Maskapai)
            Form5Maskapai maskapai = new Form5Maskapai();

            // Tutup halaman saat ini (Form7KodePromo)
            this.Close();

            // Tampilkan halaman maskapai (Form5Maskapai)
            maskapai.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman jadwal penerbangan (Form6JadwalPenerbangan)
            Form6JadwalPenerbangan jadwal = new Form6JadwalPenerbangan();

            // Tutup halaman saat ini (Form7KodePromo)
            this.Close();

            // Tampilkan halaman jadwal penerbangan (Form6JadwalPenerbangan)
            jadwal.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman jadwal penerbangan (Form6JadwalPenerbangan)
            Form6JadwalPenerbangan jadwal = new Form6JadwalPenerbangan();

            // Tutup halaman saat ini (Form7KodePromo)
            this.Close();

            // Tampilkan halaman jadwal penerbangan (Form6JadwalPenerbangan)
            jadwal.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman status penerbangan (Form8UbahStatusPenerbangan)
            Form8UbahStatusPenerbangan status = new Form8UbahStatusPenerbangan();

            // Tutup halaman saat ini (Form7KodePromo)
            this.Close();

            // Tampilkan halaman status penerbangan (Form8UbahStatusPenerbangan)
            status.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman status penerbangan (Form8UbahStatusPenerbangan)
            Form8UbahStatusPenerbangan status = new Form8UbahStatusPenerbangan();

            // Tutup halaman saat ini (Form7KodePromo)
            this.Close();

            // Tampilkan halaman status penerbangan (Form8UbahStatusPenerbangan)
            status.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman login (Form1Login)
            Form1Login login = new Form1Login();

            // Tutup halaman saat ini (Form7KodePromo)
            this.Close();

            // Tampilkan halaman login (Form1Login)
            login.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman login (Form1Login)
            Form1Login login = new Form1Login();

            // Tutup halaman saat ini (Form7KodePromo)
            this.Close();

            // Tampilkan halaman login (Form1Login)
            login.Show();
        }
    }
}
