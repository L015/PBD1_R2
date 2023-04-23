using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HERTZAPP
{
    public partial class FRMInicioSesion : Form
    {

        public FRMInicioSesion()
        {
            InitializeComponent();
        }

        public string cadenaConexion;


        private void BTNIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {

             
                cadenaConexion = "DATA SOURCE=localhost:1521/xe;PASSWORD=" + TXTPassword.Text + ";USER ID=" + TXTUsuario.Text + ";";
                OracleConnection ConexionOracle = new OracleConnection(cadenaConexion);

                ConexionOracle.Open();
                string consulta = "SELECT granted_role FROM dba_role_privs WHERE grantee = '" + TXTUsuario.Text + "'";
                OracleCommand comando = new OracleCommand(consulta, ConexionOracle);
                OracleDataReader lector;
                lector = comando.ExecuteReader();

                FRMMenuGerente fRMMenuGerente = new FRMMenuGerente(ConexionOracle);
            FRMMenuVendedor fRMMenuVendedor = new FRMMenuVendedor(ConexionOracle);


            if (lector.HasRows == true)
                {
                    while (lector.Read())
                    {
                        if (lector.GetString(0) == "CAJERO")
                        {
                            MessageBox.Show("sesion iniciada correctamente");
                        ConexionOracle.Close();
                        fRMMenuVendedor.Show();
                        this.Hide();
                        break;

                        }
                        else if (lector.GetString(0) == "ALMACEN")
                        {
                            MessageBox.Show("le corresponde menu Almacen");
                        }
                        else if (lector.GetString(0) == "GERENTE")
                        {
                            MessageBox.Show("Sesion iniciada correctamente");
                            ConexionOracle.Close();
                            fRMMenuGerente.Show();
                            this.Hide();
                            break;
                        }
                        else
                        {
                            MessageBox.Show(lector.GetString(0));
                        }

                    }


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo iniciar sesion Nombre o contrasenia incorrecto");
            }

        }
    }

}
