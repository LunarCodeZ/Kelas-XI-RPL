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
    public partial class Form1Login : Form
    {
        public Form1Login()
        {
            // Inisialisasi komponen-komponen yang digunakan, agar bisa dirender saat dimulai
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Saat button1 (tombol login) ditekan, maka:
        private void button1_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman Form3Dashboard
            Form3Dashboard dashboard = new Form3Dashboard();

            // Sembunyikan halaman saat ini (Form1)
            this.Hide();

            // Tampilkan instansi halaman Form3Dashboard
            dashboard.Show();
        }

        // Saat label4 (teks "Daftar Sekarang") ditekan, maka:
        private void label4_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman register (Form2Register)
            Form2Register register = new Form2Register();

            // Sembunyikan halaman saat ini (Form1)
            this.Hide();

            // Tampilkan instansi halaman Form2Register
            register.Show();
        }

        private void Form1Login_Load(object sender, EventArgs e)
        {

        }
    }
}
