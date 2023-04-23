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
    public partial class FRMIngresarCliente : Form
    {



        OracleConnection ConexionOracle;

      

        public FRMIngresarCliente(OracleConnection _ConexionOracle)
        {
            InitializeComponent();
            ConexionOracle = _ConexionOracle;
        }

        private void FRMIngresarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
