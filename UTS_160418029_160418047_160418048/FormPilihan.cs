using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTS_160418029_160418047_160418048Lib;

namespace UTS_160418029_160418047_160418048
{
    public partial class FormPilihan : Form
    {
        public FormPilihan()
        {
            InitializeComponent();
            
        }
        public FormMenu formMenu;
        public User userLogin;

        private void buttonPembeli_Click(object sender, EventArgs e)
        {

        }
        public FormPilihan(FormMenu formMenu)
        {
            InitializeComponent();
            this.formMenu = formMenu;
            PengaturanHakAksesMenu(formMenu.userLogin.Role);
        }

        public void PengaturanHakAksesMenu(string u)
        {
            if (u == "admin")
            {
                buttonPembeli.Visible = true;
                buttonPenjual.Visible = true;
            }

            else if (u == "penjual")
            {
                buttonPembeli.Visible = false;
                buttonPenjual.Visible = true;
            }

            else if (u == "pembeli")
            {
                buttonPembeli.Visible = true;
                buttonPenjual.Visible = false;
            }
        }

        private void FormPilihan_Load(object sender, EventArgs e)
        {

        }
    }
}
