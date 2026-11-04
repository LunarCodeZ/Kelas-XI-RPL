using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContohSoal
{
    public partial class Form3Dashboard : Form
    {
        public Form3Dashboard()
        {
            InitializeComponent();
        }


        // Bandara
        private void label2_Click(object sender, EventArgs e)
        {
            Form4Bandara about = new Form4Bandara();
            this.Hide();
            about.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form4Bandara about = new Form4Bandara();
            this.Hide();
            about.Show();
        }


        // Maskapai
        private void label3_Click(object sender, EventArgs e)
        {
            Form5Maskapai maskapai = new Form5Maskapai();
            this.Hide();
            maskapai.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form5Maskapai maskapai = new Form5Maskapai();
            this.Hide();
            maskapai.Show();
        }


        // Jadwal Penerbangan
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form6JadwalPenerbangan jadwalPenerbangan = new Form6JadwalPenerbangan();
            this.Hide();
            jadwalPenerbangan.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form6JadwalPenerbangan jadwalPenerbangan = new Form6JadwalPenerbangan();
            this.Hide();
            jadwalPenerbangan.Show();
        }


        // Kode Promo
        private void label5_Click(object sender, EventArgs e)
        {
            Form7KodePromo kodePromo = new Form7KodePromo();
            this.Hide();
            kodePromo.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form7KodePromo kodePromo = new Form7KodePromo();
            this.Hide();
            kodePromo.Show();
        }


        // Ubah Status Penerbangan
        private void label6_Click(object sender, EventArgs e)
        {
            Form8UbahStatusPenerbangan ubahStatusPenerbangan = new Form8UbahStatusPenerbangan();
            this.Hide();
            ubahStatusPenerbangan.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form8UbahStatusPenerbangan ubahStatusPenerbangan = new Form8UbahStatusPenerbangan();
            this.Hide();
            ubahStatusPenerbangan.Show();
        }


        // Logout
        private void label7_Click(object sender, EventArgs e)
        {
            Form1Login login = new Form1Login();
            this.Hide();
            login.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1Login login = new Form1Login();
            this.Hide();
            login.Show();
        }
    }
}
