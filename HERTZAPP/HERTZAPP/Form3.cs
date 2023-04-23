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
    public partial class FRMAgregarTipoVehiculos : Form
    {
        public FRMAgregarTipoVehiculos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int contador;
        OracleConnection ConexionOracle = new OracleConnection("DATA SOURCE=localhost:1521/xe;PASSWORD=CHD_111;USER ID=HERTZ_DEV;");

        private void Form3_Load(object sender, EventArgs e)
        {
            
            ConexionOracle.Open();

            //codigo para llenar transmision
            string consultaTransmision = "select tipo_transmision from TRANSMISION";
            OracleCommand comandoTransmision = new OracleCommand(consultaTransmision, ConexionOracle);
            OracleDataReader lectorTransmision;
            lectorTransmision = comandoTransmision.ExecuteReader();

            if (lectorTransmision.HasRows == true)
            {
                while (lectorTransmision.Read())
                {
                        CMBTransmision.Items.Add(lectorTransmision.GetString(0));
                }
            }

            //llenar marca
            string consultaMarca = "select NOMBRE_MARCA from MARCA";
            OracleCommand comandoMarca = new OracleCommand(consultaMarca, ConexionOracle);
            OracleDataReader lectorMarca;
            lectorMarca = comandoMarca.ExecuteReader();
        


            if (lectorMarca.HasRows == true)
            {
                while (lectorMarca.Read())
                {
           
                    CMBMarca.Items.Add(lectorMarca.GetString(0));
                }
            }


            CMBMarca.Items.Add("Agregar Marca....");

            //lenar version
            string consultaVersion = "select NOMBRE_VERSION,ANIO from VERSION";
            OracleCommand comandoVersion = new OracleCommand(consultaVersion, ConexionOracle);
            OracleDataReader lectorVersion;
            lectorVersion = comandoVersion.ExecuteReader();
      


            if (lectorVersion.HasRows == true)
            {
                while (lectorVersion.Read())
                {
                    CMBVersion.Items.Add(lectorVersion.GetString(0)+ "  " + lectorVersion.GetString(1));
                }
            }

            CMBVersion.Items.Add("Agregar Version....");




            ConexionOracle.Close();

        }

        private void CMBMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CMBMarca.SelectedItem.ToString()== "Agregar Marca....")
            {
                contador = CMBMarca.Items.Count;
                FRMIngresarDatos fRMIngresarDatos = new FRMIngresarDatos(contador, "REGISTRARMARCA", "P_ID", "P_NOMBRE","NINGUNO","MARCA", "NINGUNO");
                fRMIngresarDatos.ShowDialog();
                CMBMarca.Items.Remove("Agregar Marca....");
                CMBMarca.Items.Add(fRMIngresarDatos.retorno);
                CMBMarca.Items.Add("Agregar Marca....");
                CMBMarca.Text = fRMIngresarDatos.retorno;




            }
        }

        private void CMBVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CMBVersion.SelectedItem.ToString() == "Agregar Version....")
            {
                contador = CMBVersion.Items.Count;
                FRMIngresarDatos fRMIngresarDatos = new FRMIngresarDatos(contador, "REGISTRARVERSION", "P_ID", "P_NOMBRE", "P_ANIO", "VERSION", "AÑO");
                fRMIngresarDatos.ShowDialog();
                CMBVersion.Items.Remove("Agregar Version....");
                CMBVersion.Items.Add(fRMIngresarDatos.retorno);
                CMBVersion.Items.Add("Agregar Version....");
                CMBVersion.Text = fRMIngresarDatos.retorno;
            }

        }

        private void BTNAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
