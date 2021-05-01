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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hideSubMenu();

        }
        private void hideSubMenu()
        {
            panelSubMenuFirma.Visible = false;

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }




        private void btnfirmalar_Click(object sender, EventArgs e)
        {
            openChildForm(new firmalar());

            hideSubMenu();
        }

        private void btnAlici_Click(object sender, EventArgs e)
        {
            openChildForm(new AliciFirmalar());

            hideSubMenu();
        }

        private void btnTasiyici_Click(object sender, EventArgs e)
        {
            openChildForm(new TasiyiciFirmalar());

            hideSubMenu();
        }

        private void btnUretici_Click(object sender, EventArgs e)
        {
            openChildForm(new UreticiFirmalar());

            hideSubMenu();
        }

        private void btnBolum_Click(object sender, EventArgs e)
        {
            openChildForm(new Bolum());

        }



        private void btnSevkiyat_Click(object sender, EventArgs e)
        {
            openChildForm(new Sevkiyat());
        }



        private void btnPersonel_Click(object sender, EventArgs e)
        {
            openChildForm(new Personel());

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            Text = "";
            Text += childForm.Text;
            childForm.Show();
        }

        private void btnFirma_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuFirma);

        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            openChildForm(new Urunler());
        }
    }
}
