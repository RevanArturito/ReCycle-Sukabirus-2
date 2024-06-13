using Admin.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class Form1 : Form
    {
        private Panel panelContainer;  // Deklarasikan panelContainer
        public Form1()
        {
            InitializeComponent();
                UC_TambahProduk uc = new UC_TambahProduk();
            addUserConntrol(uc);
        }

            private void addUserConntrol(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            PanelKanan.Controls.Clear();
            PanelKanan.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UC_TambahProduk uc = new UC_TambahProduk();
            addUserConntrol(uc);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_ListProduk uc = new UC_ListProduk();
            addUserConntrol(uc);

        }

        private void PanelKanan_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
