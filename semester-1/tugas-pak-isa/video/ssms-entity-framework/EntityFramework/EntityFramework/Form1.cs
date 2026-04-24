using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework
{
    public partial class Form1 : Form
    {
        SekolahDBEntities db = new SekolahDBEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            LoadData();

            jurusanBox.DataSource = db.Jurusans.ToList();
            jurusanBox.DisplayMember = "NamaJurusan";
            jurusanBox.ValueMember = "Id";
            jurusanBox.SelectedIndex = -1;
        }

        private void LoadData()
        {
            dataGridView1.DataSource = db.Siswas.Select(s => new
            {
                s.Id,
                s.Nama,
                s.Umur,
                s.Alamat,
                Jurusan = s.Jurusan.NamaJurusan
            }).ToList();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (namaText.Text == "" || umurText.Text == "" || alamatText.Text == "" || jurusanBox.SelectedIndex == -1)
            {
                MessageBox.Show("Tolong lengkapi data yang diperlukan terlebih dahulu.");
                return;
            }

            var siswa = new Siswa();

            siswa.Nama = namaText.Text;
            siswa.Umur = Convert.ToInt32(umurText.Text);
            siswa.Alamat = alamatText.Text;
            siswa.JurusanID = Convert.ToInt32(jurusanBox.SelectedValue);

            db.Siswas.Add(siswa);
            db.SaveChanges();

            MessageBox.Show("Data berhasil ditambahkan");
            LoadData();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string key = searchTxt.Text;

            if (key == "") // masukkan error handling jika textbox search kosong
            {
                LoadData(); // data akan terefresh jika textbox kurang
                return;
            }

            // logic untuk search
            dataGridView1.DataSource = db.Siswas.Where(s => s.Nama.Contains(key) || s.Umur.ToString().Contains(key) || s.Alamat.Contains(key) || s.Jurusan.NamaJurusan.Contains(key))
                .Select(s => new
                {
                    s.Id,
                    s.Nama,
                    s.Umur,
                    s.Alamat,
                    Jurusan = s.Jurusan.NamaJurusan
                })
                .ToList();
        }
    }
}
