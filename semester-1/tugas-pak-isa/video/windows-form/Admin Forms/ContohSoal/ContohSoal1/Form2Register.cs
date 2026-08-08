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
    public partial class Form2Register : Form
    {
        public Form2Register()
        {
            // Inisialisasi komponen-komponen pada halaman Form2Register
            InitializeComponent();
        }

        // Apabila button1 (tombol daftar) ditekan, maka:
        private void button1_Click(object sender, EventArgs e)
        {
            // Tampilkan kotak pesan dengan kalimat: "Berhasil Daftar, Silakan Login!"
            MessageBox.Show("Berhasil Daftar, Silakan Login!");
        }

        // Apabila label9 (teks "login") ditekan, maka:
        private void label9_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman login (Form1Login)
            Form1Login login = new Form1Login();

            // Tutup halaman saat ini (Form2Register)
            this.Close();

            // Tampilkan instansi halaman login (Form1Login)
            login.Show();
        }
    }
}
