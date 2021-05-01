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
    public partial class UreticiFirmalar : Form
    {
        public UreticiFirmalar()
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
            string sorgu = "insert into ureticifirmalar(UFirmalarAdi,UFirmalarAdres,UFirmalarTelno,firma_ID) values ('" + firmaAdText.Text + "','" + adresText.Text + "','" + firmaTelText.Text + "'," + 7 + ")"; // alici firma id 6 da
            Bg.Ekle(sorgu);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select *from ureticifirmalar";
            dataGridView1.DataSource = Bg.Listele(sorgu);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from ureticifirmalar where UFirmalarAdi like '%" + textBox1.Text + "%'";
            dataGridView1.DataSource = Bg.Ara(sorgu);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete From ureticifirmalar Where UFirmalarID=" + Int32.Parse(silText.Text) + "";
            Bg.Sil(sorgu);
        }
    }
}
