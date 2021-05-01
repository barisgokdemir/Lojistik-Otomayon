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
    public partial class Bolum : Form
    {
        public Bolum()
        {
            InitializeComponent();
        }
        Baglan Bg = new Baglan();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into bolum(bolumAdi,firma_ID) values ('" + adText.Text + "'," + Int32.Parse(firmaText.Text) + ")"; // alici firma id 6 da
            Bg.Ekle(sorgu);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select *from bolum";
            dataGridView1.DataSource = Bg.Listele(sorgu);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete From bolum Where bolumID=" + Int32.Parse(silText.Text) + "";
            Bg.Sil(sorgu);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from bolum where bolumAdi like '%" + textBox1.Text + "%'";
            dataGridView1.DataSource = Bg.Ara(sorgu);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
