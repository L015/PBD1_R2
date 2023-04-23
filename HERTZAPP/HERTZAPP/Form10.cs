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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HERTZAPP
{
    public partial class FRMElegirAutomovil : Form
    {

        public string cantidadRetorno { get; set; }
        public string idVehiculoRetorno { get; set; }

        public bool botonCancelar { get; set; }



        OracleConnection ConexionOracle;


        public FRMElegirAutomovil(OracleConnection _ConexionOracle)
        {
            InitializeComponent();
            ConexionOracle = _ConexionOracle;
        }
      
       

        private void TXTBusqueda_TextChanged(object sender, EventArgs e)
        {
            ConexionOracle.Open();
            string nombre = "%" + TXTBusqueda.Text + "%";
            OracleCommand comando = new OracleCommand("seleccionarTiposVehiculos", ConexionOracle);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
            comando.Parameters.Add("valor", OracleType.VarChar).Value = nombre;
            comando.ExecuteNonQuery();

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridViewVehiculo.DataSource = tabla;


            ConexionOracle.Close();
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
                string cantidad = row.Cells["cantidad"].Value.ToString();
                idVehiculoRetorno = row.Cells["id_vehiculo"].Value.ToString();
                if (Int16.Parse(TXTCantidad.Text) > Int16.Parse(cantidad))
                {
                    MessageBox.Show("eliga una cantidad igual o menor a la disponible");
                    TXTCantidad.Value = Int16.Parse(cantidad);
                    
                }
                else
                {
                    this.Hide();
                }
                cantidadRetorno = TXTCantidad.Value.ToString();
                botonCancelar = false;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            botonCancelar = true;
            this.Hide();
        }
    }
}
