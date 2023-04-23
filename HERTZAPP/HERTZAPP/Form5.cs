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
    public partial class FRMIngresarDatos : Form
    {

        public event EventHandler BotonPresionado;
        int _contador;
        string _procedimientoAlmacenado;
        string _parametro1;
        string _parametro2;
        string _parametro3;
        string _nombrep2;
        string _nombrep3;
        public string retorno { get; set; }

        public FRMIngresarDatos(int contador,string procedimientoAlmacenado,string parametro1,string parametro2,string parametro3,string nombrep2,string nombrep3)
        {
            InitializeComponent();
            _contador = contador;
            _procedimientoAlmacenado = procedimientoAlmacenado;
            _parametro1 = parametro1;
            _parametro2 = parametro2;
            _parametro3 = parametro3;
              _nombrep2=nombrep2;
            _nombrep3=nombrep3;

            if (_parametro3 == "NINGUNO")
            {
                label2.Text = _nombrep2;
            }
            else
            {
                label2.Text = _nombrep2;
                label3.Visible = true;
                label3.Text = _nombrep3;
                TXTDato2.Visible = true;
            }
        }

        OracleConnection ConexionOracle = new OracleConnection("DATA SOURCE=localhost:1521/xe;PASSWORD=CHD_111;USER ID=HERTZ_DEV;");

        private void TXTDato_TextChanged(object sender, EventArgs e)
        {

        }

        public void BTNAceptar_Click(object sender, EventArgs e)
        {

            if (_parametro3 == "NINGUNO")
            {
                try
            {
                ConexionOracle.Open();
                  OracleCommand comando = new OracleCommand(_procedimientoAlmacenado, ConexionOracle);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add(_parametro1, OracleType.NChar).Value = _contador.ToString();
                comando.Parameters.Add(_parametro2, OracleType.VarChar).Value = TXTDato.Text;
                comando.ExecuteNonQuery();
                retorno = TXTDato.Text;
                this.Hide();
               


            }
            catch (Exception E) {
                MessageBox.Show(E.ToString());
                this.Hide();
            
            }
            }
            else
            {

                try
                {
                    ConexionOracle.Open();
                    OracleCommand comando = new OracleCommand(_procedimientoAlmacenado, ConexionOracle);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add(_parametro1, OracleType.NChar).Value = _contador.ToString();
                    comando.Parameters.Add(_parametro2, OracleType.VarChar).Value = TXTDato.Text;
                    comando.Parameters.Add(_parametro3, OracleType.NChar).Value = TXTDato2.Text;
                    comando.ExecuteNonQuery();
                    retorno = TXTDato.Text + "  " + TXTDato2.Text;
                    this.Hide();



                }
                catch (Exception E)
                {
                    MessageBox.Show(E.ToString());
                    this.Hide();

                }


            }
        }

        
    }
}
