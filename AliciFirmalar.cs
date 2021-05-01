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
    public partial class AliciFirmalar : Form
    {
        public AliciFirmalar()
        {
            InitializeComponent();
        }
        Baglan Bg = new Baglan();

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into alicifirmalar(AFirmalarAdi,AFirmalarAdres,AFirmalarTelno,firma_ID) values ('" + adText.Text + "','" + adresText.Text + "'," + telText.Text + "," + 6 + ")"; // alici firma id 6 da
            Bg.Ekle(sorgu);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select *from alicifirmalar";
            dataGridView1.DataSource = Bg.Listele(sorgu);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from alicifirmalar where AFirmalarAdi like '%" + textBox1.Text + "%'";
            dataGridView1.DataSource = Bg.Ara(sorgu);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete From alicifirmalar Where AFirmalarID=" + Int32.Parse(silText.Text) + "";
            Bg.Sil(sorgu);
        }

        private void AliciFirmalar_Load(object sender, EventArgs e)
        {

        }
    }
}
