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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        List<User> listUser = new List<User>();

        private void FormUser_Load(object sender, EventArgs e)
        {
            this.Height = 50 + panelLogin.Height;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxUsername.Text != "")
                {
                    Koneksi koneksi = new Koneksi("localhost", "isa_uts", textBoxUsername.Text, textBoxPassword.Text);

                    Koneksi koneksi2 = new Koneksi();

                    listUser = User.BacaData("username", textBoxUsername.Text);

                    if (listUser.Count > 0)
                    {
                        FormMenu formMenu = (FormMenu)this.MdiParent;
                        formMenu.labelUsername.Text = listUser[0].Username;
                        formMenu.labelRole.Text = listUser[0].Role;

                        formMenu.userLogin = listUser[0];

                        FormPilihan formPilihan = new FormPilihan(formMenu);
                        formPilihan.MdiParent = this.MdiParent;
                        formPilihan.PengaturanHakAksesMenu(listUser[0].Role);
                        formPilihan.Show();
                        this.Close();

                        MessageBox.Show("Koneksi berhasil. Selamat Menggunakan Aplikasi", "Informasi");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Username tidak ditemukan");
                    }
                    
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Koneksi gagal. Pesan kesalahan: " + exception.Message, "Kesalahan");
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            formRegister.Owner = this;
            formRegister.Show();
        }
    }
}
