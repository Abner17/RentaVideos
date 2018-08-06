﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaVideos
{
    public partial class frmPrivilegios : Form
    {
        string user = "";
        public frmPrivilegios()
        {
            InitializeComponent();
        }
        public frmPrivilegios(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuPrincipal menu = new menuPrincipal(user);
            menu.Show();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuPrincipal menu = new menuPrincipal(user);
            menu.Show();
        }

        private void frmPrivilegios_Load(object sender, EventArgs e)
        {

        }
    }
}
