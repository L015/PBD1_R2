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
    public partial class FRMMenuGerente : Form
    {
        public FRMMenuGerente()
        {
            InitializeComponent();
        }

        FRMVehiculos FormularioVehiculos = new FRMVehiculos();

        private void BTNGestionarVehiculos_Click(object sender, EventArgs e)
        {

            FormularioVehiculos.Show();
            this.Hide();

        }
    }
}
