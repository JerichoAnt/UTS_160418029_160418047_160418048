﻿using System;
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
    public partial class FormMenu : Form
    {
        public User userLogin;
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            this.IsMdiContainer = true;
            FormLogin formLogin = new FormLogin();
            formLogin.MdiParent = this;
            formLogin.Show();
        }
    }
}
