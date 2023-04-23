using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HERTZAPP
{
    public partial class FRMMenuGerente : Form
    {
        OracleConnection ConexionOracle;
        public FRMMenuGerente(OracleConnection _ConexionOracle)
        {
            InitializeComponent();
            ConexionOracle = _ConexionOracle;
        }




       

        private void BTNGestionarVehiculos_Click(object sender, EventArgs e)
        {
            FRMVehiculos FormularioVehiculos = new FRMVehiculos(ConexionOracle);
            FormularioVehiculos.Show();
            this.Hide();

        }

        private void FRMMenuGerente_Load(object sender, EventArgs e)
        {

        }
    }
}
