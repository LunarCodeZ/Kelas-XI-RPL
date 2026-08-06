using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorSederhana2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            // mengubah input menjadi integer agar bisa dijumlahkan
            int angka1 = Convert.ToInt32(txtAngka1.Text);
            int angka2 = Convert.ToInt32(txtAngka2.Text);

            // menghitung penjumlahan dari kedua bilangan
            int hasil = angka1 + angka2;

            // mengubah hasil penjumlahan menjadi string dan menampilkannya di label hasil
            lblHasil.Text = hasil.ToString();
        }

        private void btnKurang_Click(object sender, EventArgs e)
        {
            // mengubah input menjadi integer agar bisa dikurangkan
            int angka1 = Convert.ToInt32(txtAngka1.Text);
            int angka2 = Convert.ToInt32(txtAngka2.Text);

            // menghitung pengurangan dari kedua bilangan
            int hasil = angka1 - angka2;

            // mengubah hasil pengurangan menjadi string dan menampilkannya di label hasil
            lblHasil.Text = hasil.ToString();
        }

        private void btnKali_Click(object sender, EventArgs e)
        {
            // mengubah input menjadi integer agar bisa dikalikan
            int angka1 = Convert.ToInt32(txtAngka1.Text);
            int angka2 = Convert.ToInt32(txtAngka2.Text);

            // menghitung perkalian dari kedua bilangan
            int hasil = angka1 * angka2;

            // mengubah hasil perkalian menjadi string dan menampilkannya di label hasil
            lblHasil.Text = hasil.ToString();
        }

        private void btnBagi_Click(object sender, EventArgs e)
        {
            // mengubah input menjadi integer agar bisa dibagikan
            int angka1 = Convert.ToInt32(txtAngka1.Text);
            int angka2 = Convert.ToInt32(txtAngka2.Text);

            // menghitung pembagian dari kedua bilangan
            double hasil = Math.Round((double)angka1 / angka2, 2);

            // mengubah hasil pembagian menjadi string dan menampilkannya di label hasil
            lblHasil.Text = hasil.ToString();
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            // membersihkan bilangan pada kedua input
            txtAngka1.Text = "";
            txtAngka2.Text = "";
            lblHasil.Text = "0";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
