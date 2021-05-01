using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lojistik
{
    public partial class Sevkiyat : Form
    {
        public Sevkiyat()
        {
            InitializeComponent();
        }
        Baglan Bg = new Baglan();

        private void Sevkiyat_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into sevkiyat(SevkiyatAdi,Ulke,urun_ID,firma_ID) values ('" + adText.Text + "','" + ulkeText.Text + "'," + Int32.Parse(urunIDText.Text) + "," + Int32.Parse(firmaIDText.Text) + ")"; // alici firma id 6 da
            Bg.Ekle(sorgu);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select *from sevkiyat";
            dataGridView1.DataSource = Bg.Listele(sorgu);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from sevkiyat where SevkiyatAdi like '%" + textBox1.Text + "%'";
            dataGridView1.DataSource = Bg.Ara(sorgu);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete From sevkiyat Where SevkiyatID=" + Int32.Parse(silText.Text) + "";
            Bg.Sil(sorgu);
        }
    }
}
