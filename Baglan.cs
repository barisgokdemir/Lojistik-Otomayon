using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Lojistik
{
    class Baglan
    {
        public MySqlConnection con;
        public MySqlCommand cmd;


        public Baglan()
        {
            con = new MySqlConnection("Server=localhost;Database=lojistik;user=root;Pwd='1234';SslMode=none");
        }
        public DataTable Listele(string sorgu)
        {
            con.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(sorgu, con);

            ///Yeni bir DataTable oluşturuyorum. İçindekileri DataAdapter içine atıyorum.
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();


            //  dataGridView1.DataSource = dt;
            return dt;

        }
        public void Ekle(string sorgu)
        {
            con.Open();
            cmd = new MySqlCommand(sorgu, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Giriş Başarılı.");
            con.Close();
        }
        public DataTable Ara(string sorgu)
        {
            con.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(sorgu, con);

            ///Yeni bir DataTable oluşturuyorum. İçindekileri DataAdapter içine atıyorum.
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();


            //  dataGridView1.DataSource = dt;
            return dt;

        }
        public void Sil(string sorgu)
        {
            con.Open();
            cmd = new MySqlCommand(sorgu, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("silme Başarılı.");
            con.Close();
        }


    }
}
