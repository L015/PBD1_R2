﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HERTZAPP
{
    public partial class FRMElegirCliente : Form
    {
        public FRMElegirCliente()
        {
            InitializeComponent();
        }

        private void BTNNuevoCliente_Click(object sender, EventArgs e)
        {
            FRMIngresarCliente fRMIngresarCliente = new FRMIngresarCliente();
            fRMIngresarCliente.Show();
        }
    }
}
