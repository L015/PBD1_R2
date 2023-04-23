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
    public partial class FRMElegirServiciosAdicionales : Form
    {

        public string cantidadRetorno { get; set; }
        public string idServicioRetorno { get; set; }

        public bool botonCancelar2 { get; set; }

        OracleConnection ConexionOracle;

        
        public FRMElegirServiciosAdicionales(OracleConnection _ConexionOracle)
        {
            InitializeComponent();
            ConexionOracle = _ConexionOracle;
        }

        
        private void TXTBusqueda_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TXTCantidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BTNAceptar_Click(object sender, EventArgs e)
        {

            if (dataGridViewVehiculo.SelectedRows.Count == 1)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = dataGridViewVehiculo.SelectedRows[0];

                // Obtener los datos de la fila seleccionada
                if (TXTCantidad.Value > 0)
                {

                    this.Hide();
                    idServicioRetorno = row.Cells["codigo"].Value.ToString();
                    cantidadRetorno = TXTCantidad.Value.ToString();
                    botonCancelar2 = false;

                }

            }





        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            botonCancelar2 = true;
            this.Hide();
        }

        private void TXTBusqueda_TextChanged_1(object sender, EventArgs e)
        {
            ConexionOracle.Open();
            string nombre = "%" + TXTBusqueda.Text + "%";
            OracleCommand comando = new OracleCommand("seleccionarTiposServicioAdicional", ConexionOracle);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
            comando.Parameters.Add("valor", OracleType.VarChar).Value = nombre;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridViewVehiculo.DataSource = tabla;


            ConexionOracle.Close();

        }
    }
}
