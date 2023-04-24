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
    public partial class Form17 : Form
    {


        OracleConnection ConexionOracle;
       
        public Form17(OracleConnection _ConexionOracle)
        {
            InitializeComponent();
            ConexionOracle = _ConexionOracle;
        }

        private void mostrarDataGrid()
        {

            string fecha1=dateTimePicker1.Value.Date.ToShortDateString();
            string fecha2=dateTimePicker2.Value.Date.ToShortDateString();


            ConexionOracle.Open();
            if (checkBox1.Checked == true)
            {
                OracleCommand comando = new OracleCommand(" select factura.id_factura_pk as Numero_Factura,factura.dias_retraso,factura.fecha_emision,factura.id_reservacion_fk as Numero_Reservacion\r\n,factura.total,factura.devolucion_deposito,factura.cargo_combustible,estado_reservacion.tipo_estado\r\nfrom Factura inner join reservacion on factura.id_reservacion_fk=reservacion.id_reservacion_pk inner join estado_reservacion \r\non estado_reservacion.id_estado_reservacion_pk=reservacion.id_estado_reservacion_fk \r\nwhere factura.fecha_emision>='" + fecha1 + "' AND factura.fecha_emision<='" + fecha2 + "' AND estado_reservacion.tipo_estado='CANCELADA'\r\norder by factura.id_factura_pk desc ", ConexionOracle);

                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla3 = new DataTable();
                adaptador.Fill(tabla3);
                dataGridView1.DataSource = tabla3;
            }
            if (checkBox2.Checked == true)
            {
                OracleCommand comando = new OracleCommand(" select factura.id_factura_pk as Numero_Factura,factura.dias_retraso,factura.fecha_emision,factura.id_reservacion_fk as Numero_Reservacion\r\n,factura.total,factura.devolucion_deposito,factura.cargo_combustible,estado_reservacion.tipo_estado\r\nfrom Factura inner join reservacion on factura.id_reservacion_fk=reservacion.id_reservacion_pk inner join estado_reservacion \r\non estado_reservacion.id_estado_reservacion_pk=reservacion.id_estado_reservacion_fk \r\nwhere factura.fecha_emision>='" + fecha1 + "' AND factura.fecha_emision<='" + fecha2 + "' AND estado_reservacion.tipo_estado='COMPLETADA'\r\norder by factura.id_factura_pk desc ", ConexionOracle);

                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla3 = new DataTable();
                adaptador.Fill(tabla3);
                dataGridView1.DataSource = tabla3;
            }
            ConexionOracle.Close();

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
                checkBox2.Checked = false;
            if (checkBox1.Checked == false)
                checkBox2.Checked = true;
            mostrarDataGrid();

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                checkBox1.Checked = false;
            if (checkBox2.Checked == false)
                checkBox1.Checked = true;
            mostrarDataGrid();

        }

        private void Form17_Load(object sender, EventArgs e)
        {
            mostrarDataGrid();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            mostrarDataGrid();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            mostrarDataGrid();
        }
    }
}
