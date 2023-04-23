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
    public partial class FRMVehiculos : Form
    {

        OracleConnection ConexionOracle;
        public FRMVehiculos(OracleConnection _ConexionOracle)
        {
            InitializeComponent();
            ConexionOracle = _ConexionOracle;
        }



      

       



        private void BTNVehiculos_Click(object sender, EventArgs e)
        {

        }

        private void BTNAgregar_Click(object sender, EventArgs e)
        {
            FRMAgregarTipoVehiculos FormularioTipoVehiculos = new FRMAgregarTipoVehiculos(ConexionOracle);
            FormularioTipoVehiculos.Show();
            this.Hide();
        }
    }
}
