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
    public partial class firmalar : Form
    {
        public firmalar()
        {
            InitializeComponent();
        }
        Baglan Bg = new Baglan();


        private void firmalar_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from firmalar";

            dataGridView1.DataSource = Bg.Listele(sorgu);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into firmalar(firmaTipi) values ('" + textBox2.Text + "')";
            Bg.Ekle(sorgu);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from firmalar where firmaTipi like '%" + textBox1.Text + "%'";
            dataGridView1.DataSource = Bg.Ara(sorgu);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete From firmalar Where firmaID=" + Int16.Parse(textBox3.Text) + "";
            Bg.Sil(sorgu);
        }


    }
}
