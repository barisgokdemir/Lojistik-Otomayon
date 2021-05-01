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
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
        }
        Baglan Bg = new Baglan();
        private void btnEkle_Click(object sender, EventArgs e)
        {

            string sorgu = "insert into urunler(UrunAdi,UrunTipi,StokMiktari) values ('" + urunAdText.Text + "','" + urunTipiText.Text + "'," + Int32.Parse(stokText.Text) + ")"; // alici firma id 6 da
            Bg.Ekle(sorgu);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {

            string sorgu = "select *from urunler";
            dataGridView1.DataSource = Bg.Listele(sorgu);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {

            string sorgu = "select * from urunler where UrunAdi like '%" + textBox1.Text + "%'";
            dataGridView1.DataSource = Bg.Ara(sorgu);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete From urunler Where UrunID=" + Int32.Parse(silText.Text) + "";
            Bg.Sil(sorgu);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

