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
    public partial class GestionFlota : Form    {


        OracleConnection ConexionOracle;


        public GestionFlota(OracleConnection _ConexionOracle)
        {
            InitializeComponent();
            ConexionOracle = _ConexionOracle;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form16 form16 = new Form16(ConexionOracle);
            form16.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ConexionOracle.Open();
            OracleCommand comando = new OracleCommand("select  Flota.Matricula_PK as Matricula , VEHICULO.ID_VEHICULO_PK AS Vehiculo_ID , MARCA.NOMBRE_MARCA as Marca from FLOTA inner join VEHICULO ON flota.id_vehiculo_fk = vehiculo.id_vehiculo_pk inner join MARCA on vehiculo.ID_Marca_FK = Marca.ID_MARCA_PK  where  MARCA.NOMBRE_MARCA like '%" + textBox1.Text + "%'", ConexionOracle);

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla3 = new DataTable();
            adaptador.Fill(tabla3);
            dataGridView1.DataSource = tabla3;
            ConexionOracle.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            this.Hide();

        }
    }
}
