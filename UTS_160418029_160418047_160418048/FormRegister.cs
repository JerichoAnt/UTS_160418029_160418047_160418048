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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }
        FormLogin formLogin;
        private void FormRegister_Load(object sender, EventArgs e)
        {
            formLogin = (FormLogin)this.Owner;
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.SelectedIndex = 0;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Koneksi koneksi = new Koneksi("localhost", "isa_uts", "root", "");
            
            Koneksi koneksi2 = new Koneksi();
            if (User.cekUser(textBoxUsername.Text) == true)
            {
                MessageBox.Show("Username telah terdaftar, anda gagal mendaftar", "Informasi");
            }
            else
            {
                User userRegis = new User(1,textBoxUsername.Text, textBoxPassword.Text,comboBoxRole.Text,textBoxName.Text);
                Register.TambahUser(textBoxUsername.Text, textBoxPassword.Text, comboBoxRole.Text, textBoxName.Text);
                User.ManajemenUser(userRegis);
                MessageBox.Show("Selamat anda berhasil terdaftar", "Informasi");
            }

        }
    }
}
