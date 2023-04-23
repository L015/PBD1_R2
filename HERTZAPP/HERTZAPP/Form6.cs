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
    public partial class FRMElegirCliente : Form
    {


        OracleConnection ConexionOracle;


        public FRMElegirCliente(OracleConnection _ConexionOracle)
        {
            InitializeComponent();
            ConexionOracle = _ConexionOracle;
        }

        private void BTNNuevoCliente_Click(object sender, EventArgs e)
        {
            FRMIngresarCliente fRMIngresarCliente = new FRMIngresarCliente(ConexionOracle);
            fRMIngresarCliente.Show();
        }

        private void FRMElegirCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
