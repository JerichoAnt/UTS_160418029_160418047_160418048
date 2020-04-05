using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTS_160418029_160418047_160418048
{
    public partial class FormListBarang : Form
    {
        public FormListBarang()
        {
            InitializeComponent();
        }
       
        private void ListBarang_Load(object sender, EventArgs e)
        {
            buttonTambahKeranjang.Hide();
            buttonTambahBarang.Hide();
            buttonUbah.Hide();
            buttonHapus.Hide();
            string transaki = this.Tag.ToString();
            if(transaki=="beli")
            {
                buttonTambahKeranjang.Show();
                buttonTambahKeranjang.Location = buttonHapus.Location;
            }
            else
            {
                buttonTambahBarang.Show();
                buttonUbah.Show();
                buttonHapus.Show();
               
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
