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
    public partial class Form8UbahStatusPenerbangan : Form
    {
        BandaraEntities db = new BandaraEntities();
        private int idStatus;

        public Form8UbahStatusPenerbangan()
        {
            InitializeComponent();
        }


        // Dashboard
        private void label8_Click(object sender, EventArgs e)
        {
            Form3Dashboard dashboard = new Form3Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form3Dashboard dashboard = new Form3Dashboard();
            dashboard.Show();
            this.Hide();
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

        private void LoadStatus()
        {
            statusBox.DataSource = db.StatusPenerbangans.ToList();
            statusBox.ValueMember = "ID";
            statusBox.DisplayMember = "Nama";
            statusBox.SelectedIndex = -1;
        }

        private void LoadData()
        {
            dataGridStatus.DataSource = db.PerubahanStatusJadwalPenerbangans.Select(s => new
            {
                s.ID,
                s.JadwalPenerbanganID,
                kodePenerbangan = s.JadwalPenerbangan.KodePenerbangan,
                bandaraAwal = s.JadwalPenerbangan.Bandara.Nama,
                bandaraTujuan = s.JadwalPenerbangan.Bandara1.Nama,
                maskapai = s.JadwalPenerbangan.Maskapai.Nama,
                tanggalKeberangkatan = s.JadwalPenerbangan.TanggalWaktuKeberangkatan,
                durasiPenerbangan = (s.JadwalPenerbangan.DurasiPenerbangan / 60) + " Jam " + (s.JadwalPenerbangan.DurasiPenerbangan % 60) + " Menit ",
                statusPenerbangan = s.StatusPenerbangan.Nama,
                s.WaktuPerubahanTerjadi
            }).ToList();
        }

        private void dataGridStatus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            idStatus = Convert.ToInt32(dataGridStatus.Rows[e.RowIndex].Cells["ID"].Value);
        }
    }
}
