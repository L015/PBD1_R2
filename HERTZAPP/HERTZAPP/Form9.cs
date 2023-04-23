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
    public partial class FRMMenuVendedor : Form
    {
        public FRMMenuVendedor()
        {
            InitializeComponent();
        }
        OracleConnection ConexionOracle = new OracleConnection("DATA SOURCE=localhost:1521/xe;PASSWORD=CHD_111;USER ID=HERTZ_DEV;");

        string[] idSucursal1;
        string[] idSucursal2;
        DataTable tabla = new DataTable();
        DataTable tabla2 = new DataTable();


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           //aplicar retorno en boton cancelar

            FRMElegirAutomovil fRMElegirAutomovil = new FRMElegirAutomovil();
            fRMElegirAutomovil.ShowDialog();
            ConexionOracle.Open();

            if (fRMElegirAutomovil.botonCancelar == false)
            {

                OracleCommand comando = new OracleCommand("seleccionarFlota", ConexionOracle);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                OracleDataAdapter adaptador = new OracleDataAdapter();

                comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("vehiculo", OracleType.VarChar).Value = fRMElegirAutomovil.idVehiculoRetorno;
                comando.Parameters.Add("cantidad", OracleType.Int16).Value = Int16.Parse(fRMElegirAutomovil.cantidadRetorno);


                adaptador.SelectCommand = comando;
                adaptador.Fill(tabla);
                dataGridViewFlota.DataSource = tabla;

            }

           

            
            ConexionOracle.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void FRMMenuVendedor_Load(object sender, EventArgs e)
        {
            ConexionOracle.Open();


            string consultaMarca = "select nombre_sucursal,id_sucursal_pk from sucursal";
            OracleCommand comandoMarca = new OracleCommand(consultaMarca, ConexionOracle);
            OracleDataReader lectorMarca;
            lectorMarca = comandoMarca.ExecuteReader();



            if (lectorMarca.HasRows == true)
            {
                while (lectorMarca.Read())
                {

                    comboBox1.Items.Add(lectorMarca.GetString(1) +"," +lectorMarca.GetString(0));
                    comboBox2.Items.Add(lectorMarca.GetString(1) + "," + lectorMarca.GetString(0));
                }
            }

            ConexionOracle.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            idSucursal1 = comboBox2.Text.Split(',');
            idSucursal2 = comboBox1.Text.Split(',');

            ConexionOracle.Open();
            //OracleCommand comando = new OracleCommand("hacerReservacion", ConexionOracle);
            //comando.CommandType = System.Data.CommandType.StoredProcedure;
            //comando.Parameters.Add("Pidreservacion", OracleType.NChar).Value = textBox6.Text;
            //comando.Parameters.Add("Pcliente", OracleType.NChar).Value = textBox1.Text;
            //comando.Parameters.Add("Pdeposito", OracleType.Float).Value = textBox5.Text;
            //comando.Parameters.Add("Pdevolucion", OracleType.NChar).Value = idSucursal1[0];
            //comando.Parameters.Add("Pretiro", OracleType.NChar).Value = idSucursal2[0];
            //comando.Parameters.Add("Pfecharetiro", OracleType.DateTime).Value = dateTimePicker1.Value;
            //comando.Parameters.Add("Pfechadevolucion", OracleType.DateTime).Value = dateTimePicker2.Value;
            //comando.Parameters.Add("Pestado", OracleType.NChar).Value ="1";
            //comando.ExecuteNonQuery();


            List<string> elementosSeleccionados = new List<string>();
            if (dataGridViewFlota.RowCount > 0)
            {
               
                DataGridViewColumn columna = dataGridViewFlota.Columns[0];

                foreach (DataGridViewRow fila in dataGridViewFlota.Rows)
                {
                    fila.Cells[columna.Index].Selected = true;
                }

                foreach (DataGridViewRow fila in dataGridViewFlota.Rows)
                {
                    if (fila.Cells[columna.Index].Selected)
                    {
                        if (fila.Cells[columna.Index].Value != null)
                        {
                            string valorCelda = (fila.Cells[columna.Index].Value).ToString();
                            elementosSeleccionados.Add(valorCelda);
                        }
                        
                    }
                }    // El DataGridView contiene elementos
            }
            else
            {
                MessageBox.Show("por favor eliga primero los vehiculos");
            }


            //codigo para detalles de factura
            foreach (string element in elementosSeleccionados)
            {
                OracleCommand comando = new OracleCommand("ingresarDetallesReservacion", ConexionOracle);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("Pidreservacion", OracleType.NChar).Value = textBox6.Text;
                comando.Parameters.Add("Pmatricula", OracleType.NChar).Value = element;
                comando.Parameters.Add("Pidconductor", OracleType.NChar).Value = "1";
                comando.Parameters.Add("Pestado", OracleType.NChar).Value = "1";
                comando.ExecuteNonQuery();
            }









            ConexionOracle.Close();
         
        }

        private void button3_Click(object sender, EventArgs e)
        {

            FRMElegirServiciosAdicionales fRMElegirServiciosAdicionales = new FRMElegirServiciosAdicionales();
            fRMElegirServiciosAdicionales.ShowDialog();
            ConexionOracle.Open();

            if (fRMElegirServiciosAdicionales.botonCancelar2 == false)
            {

                OracleCommand comando = new OracleCommand("seleccionarTiposServicioAdicionales", ConexionOracle);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                OracleDataAdapter adaptador = new OracleDataAdapter();

                comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("valor", OracleType.VarChar).Value = fRMElegirServiciosAdicionales.idServicioRetorno;
                comando.Parameters.Add("cant", OracleType.NChar).Value = fRMElegirServiciosAdicionales.cantidadRetorno;


                adaptador.SelectCommand = comando;
                adaptador.Fill(tabla2);
                dataGridViewServicios.DataSource = tabla2;

            }




            ConexionOracle.Close();
        }
    }
}
