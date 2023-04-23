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
    public partial class Form16 : Form
    {
        
        public Form16()
        {
            InitializeComponent();
        }

        OracleConnection ConexionOracle = new OracleConnection("DATA SOURCE=localhost:1521/xe;PASSWORD=CHD_111;USER ID=HERTZ_DEV;");
        string[] idSucursal1;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

  


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form16_Load(object sender, EventArgs e)
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

                    SucursalCombo.Items.Add(lectorMarca.GetString(1) + "," + lectorMarca.GetString(0));

                }
            }

            ConexionOracle.Close();

        }

        private void IDVehiculoTXT_TextChanged(object sender, EventArgs e)
        {
            ConexionOracle.Open();
            string nombre = "%" + IDVehiculoTXT.Text + "%";
            OracleCommand comando = new OracleCommand("seleccionarTiposVehiculos", ConexionOracle);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
            comando.Parameters.Add("valor", OracleType.VarChar).Value = nombre;
            comando.ExecuteNonQuery();

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;

            ConexionOracle.Close();
        }

        private void BTNAgregar_Click(object sender, EventArgs e)
        {
            idSucursal1 = SucursalCombo.Text.Split(',');

            ConexionOracle.Open();
            OracleCommand comando = new OracleCommand("REGISTRARVEHICULOFLOTA", ConexionOracle);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.Add("P_Matricula",OracleType.NChar).Value = MatriculaTXT.Text;
            comando.Parameters.Add("P_Disponibilidad", OracleType.Char).Value = '1';
            comando.Parameters.Add("P_GPS",OracleType.VarChar).Value=GPSTXT.Text;
            comando.Parameters.Add("P_ID_Sucursal", OracleType.NChar).Value = idSucursal1[0];
            comando.Parameters.Add("P_Dirrecion_Almacen", OracleType.VarChar).Value = textBox4.Text;
            comando.Parameters.Add("P_ID_Vehiculo",OracleType.NChar).Value=textBox1.Text;
            comando.Parameters.Add("P_Color",OracleType.VarChar).Value=ColorTXT.Text;
            comando.Parameters.Add("P_Fecha_Ingreso", OracleType.DateTime).Value = dateTimePicker1.Value;
            comando.ExecuteNonQuery();
            
            ConexionOracle.Close();
            this.Hide();
        }
    }
}
