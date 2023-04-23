using System;
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
    public partial class FRMVehiculos : Form
    {
        public FRMVehiculos()
        {
            InitializeComponent();
        }

        private void BTNVehiculos_Click(object sender, EventArgs e)
        {
            GestionFlota form15 = new GestionFlota();
            form15.Show();
        }

        private void BTNAgregar_Click(object sender, EventArgs e)
        {
            FRMAgregarTipoVehiculos FormularioTipoVehiculos = new FRMAgregarTipoVehiculos();
            FormularioTipoVehiculos.Show();
            this.Hide();
        }

        private void FRMVehiculos_Load(object sender, EventArgs e)
        {

        }
    }
}
