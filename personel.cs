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
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }
        Baglan Bg = new Baglan();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into personel(personelAdSoyad,personelTelNo,bolum_ID) values ('" + adiSoyAdiText.Text + "','" + telText.Text + "'," + Int32.Parse(bolumIDText.Text) + ")"; // alici firma id 6 da
            Bg.Ekle(sorgu);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {

            string sorgu = "select *from personel";
            dataGridView1.DataSource = Bg.Listele(sorgu);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {

            string sorgu = "select * from personel where personelAdSoyad like '%" + textBox1.Text + "%'";
            dataGridView1.DataSource = Bg.Ara(sorgu);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete From personel Where personelID=" + Int32.Parse(silText.Text) + "";
            Bg.Sil(sorgu);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
