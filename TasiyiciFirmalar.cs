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
    public partial class TasiyiciFirmalar : Form
    {
        public TasiyiciFirmalar()
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
            string sorgu = "insert into tasiyicifirmalar(TFirmalarAdi,TFirmalarAdres,TasimaSekli,TFirmalarTelno,firma_ID) values ('" + firmaAdText.Text + "','" + adresText.Text + "','" + comboTasimaSekli.Text + "','" + firmaTelText.Text + "'," + 1 + ")"; // alici firma id 6 da
            Bg.Ekle(sorgu);

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from tasiyicifirmalar where TFirmalarAdi like '%" + textBox1.Text + "%'";
            dataGridView1.DataSource = Bg.Ara(sorgu);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {

            string sorgu = "select *from tasiyicifirmalar";
            dataGridView1.DataSource = Bg.Listele(sorgu);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete From tasiyicifirmalar Where TFirmalarID=" + Int32.Parse(silText.Text) + "";
            Bg.Sil(sorgu);
        }
    }
}
