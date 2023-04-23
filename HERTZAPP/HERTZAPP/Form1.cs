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
    public partial class FRMInicioSesion : Form
    {
        public FRMInicioSesion()
        {
            InitializeComponent();
        }

        OracleConnection ConexionOracle = new OracleConnection("DATA SOURCE=localhost:1521/xe;PASSWORD=CHD_111;USER ID=HERTZ_DEV;");


        private void BTNIniciarSesion_Click(object sender, EventArgs e)
        {


            ConexionOracle.Open();
            string consulta = "select NOMBRECARGO from EMPLEADO INNER JOIN CARGO ON empleado.id_cargo_fk=cargo.id_cargo_pk WHERE (id_empleado_pk='" + TXTUsuario.Text + "' AND CONTRASENIA='"+ TXTPassword.Text+"')";
            OracleCommand comando = new OracleCommand(consulta, ConexionOracle);
            OracleDataReader lector;
            lector = comando.ExecuteReader();

           FRMMenuGerente fRMMenuGerente = new FRMMenuGerente();
            FRMMenuVendedor fRMMenuVendedor = new FRMMenuVendedor();


            if (lector.HasRows == true)
            {
                while (lector.Read())
                {
                    if (lector.GetString(0)=="VENDEDOR")
                    {
                        MessageBox.Show("Sesion iniciada correctamente");
                        fRMMenuVendedor.Show();
                        this.Hide();

                    }
                    else if(lector.GetString(0) == "ALMACEN")
                    {
                        MessageBox.Show("le corresponde menu Almacen");
                    }
                    else if (lector.GetString(0) == "GERENTE")
                    {
                        MessageBox.Show("Sesion iniciada correctamente");
                        fRMMenuGerente.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show(lector.GetString(0));
                    }

                }


            }
            else
            {
                MessageBox.Show("contrasenia o usuario incorrecto");
            }
            ConexionOracle.Close();



        }
    }
}
