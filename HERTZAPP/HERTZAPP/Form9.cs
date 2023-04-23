using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HERTZAPP
{
    public partial class FRMMenuVendedor : Form
    {
        private static string cadenaConexion;


        OracleConnection ConexionOracle;

        public FRMMenuVendedor(OracleConnection _ConexionOracle)
        {
            InitializeComponent();
            ConexionOracle = _ConexionOracle;
        }


        


        DataTable tabla = new DataTable();
        DataTable tabla2 = new DataTable();
        float costoTotal = 0;
        string diferenciaDias = (0).ToString();
        string deposito;
        Boolean pagooCancelacion;
        
      


        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void LlenarCostoTotal()
        {
            costoTotal = 0;
            if (dataGridViewFlota.RowCount > 0)
            {

                DataGridViewColumn columna = dataGridViewFlota.Columns[8];

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
                            costoTotal += float.Parse(valorCelda);
                        }

                    }
                }    // El DataGridView contiene elementos
            }

            
            //codigo para llenar de servicios adicionales

            if (dataGridViewServicios.RowCount > 0)
            {

                DataGridViewColumn columna1 = dataGridViewServicios.Columns[2];
                DataGridViewColumn columna2 = dataGridViewServicios.Columns[4];

                foreach (DataGridViewRow fila in dataGridViewServicios.Rows)
                {
                    fila.Cells[columna1.Index].Selected = true;
                    fila.Cells[columna2.Index].Selected = true;
                }

                foreach (DataGridViewRow fila in dataGridViewServicios.Rows)
                {
                    if (fila.Cells[columna1.Index].Selected && fila.Cells[columna2.Index].Selected)
                    {
                        if (fila.Cells[columna1.Index].Value != null && fila.Cells[columna2.Index].Value != null)
                        {
                            string valorCelda = (fila.Cells[columna1.Index].Value).ToString();
                            string valorCelda2 = (fila.Cells[columna2.Index].Value).ToString();
                            costoTotal += (float.Parse(valorCelda) * float.Parse(valorCelda2));
                        }

                    }
                }    // El DataGridView contiene elementos
            }

            textBox5.Text = (costoTotal * 0.2 * (Int16.Parse(diferenciaDias)+1)).ToString();
            LabelTotal.Text = (costoTotal * (Int16.Parse(diferenciaDias) + 1)).ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            //aplicar retorno en boton cancelar

            FRMElegirAutomovil fRMElegirAutomovil = new FRMElegirAutomovil(ConexionOracle);
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




                //codigo para obtener los costos totales de la reserva




                LlenarCostoTotal();
                
            }




            ConexionOracle.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        public class Valor
        {
            public string Value { get; set; }
            public string Index { get; set; }
        }


        private void FRMMenuVendedor_Load(object sender, EventArgs e)
        {


            ConexionOracle.Open();

            string consultaMarca = "select nombre_sucursal,id_sucursal_pk from sucursal";
            OracleCommand comandoMarca = new OracleCommand(consultaMarca, ConexionOracle);
            OracleDataReader lectorMarca;
            lectorMarca = comandoMarca.ExecuteReader();



            var Valores1 = new List<Valor>();
            var Valores2 = new List<Valor>();



            if (lectorMarca.HasRows == true)
            {
                while (lectorMarca.Read())
                {

                    Valores1.Add(new Valor() { Index = lectorMarca.GetString(1), Value = lectorMarca.GetString(0) });
                    Valores2.Add(new Valor() { Index = lectorMarca.GetString(1), Value = lectorMarca.GetString(0) });
                }
            }

            comboBox1.DataSource = Valores1;
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Index";

            comboBox2.DataSource = Valores2;
            comboBox2.DisplayMember = "Value";
            comboBox2.ValueMember = "Index";



            string consulta = "select count(ID_RESERVACION_PK) from RESERVACION";
            OracleCommand comando = new OracleCommand(consulta, ConexionOracle);
            OracleDataReader lector;
            lector = comando.ExecuteReader();


            if (lector.HasRows == true)
            {
                while (lector.Read())
                {

                    textBox6.Text = (Int16.Parse((lector.GetValue(0).ToString())) + 1).ToString();



                }


            }


            string consultaFactura = "select count(id_factura_pk) from factura";
            OracleCommand comandoFactura = new OracleCommand(consultaFactura, ConexionOracle);
            OracleDataReader lectorFactura;
            lectorFactura = comandoFactura.ExecuteReader();


            if (lectorFactura.HasRows == true)
            {
                while (lectorFactura.Read())
                {

                    textBox7.Text = (Int16.Parse((lectorFactura.GetValue(0).ToString())) + 1).ToString();



                }


            }

            button11.Enabled = false;



            ConexionOracle.Close();


           


        }

        private void button5_Click(object sender, EventArgs e)
        {
           

            try
            {

           

            ConexionOracle.Open();



                

                OracleCommand comando = new OracleCommand("hacerReservacion", ConexionOracle);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("Pidreservacion", OracleType.NChar).Value = textBox6.Text;
            comando.Parameters.Add("Pcliente", OracleType.NChar).Value = textBox1.Text;
            comando.Parameters.Add("Pdeposito", OracleType.Float).Value = textBox5.Text;
            comando.Parameters.Add("Pdevolucion", OracleType.NChar).Value = comboBox2.SelectedValue.ToString();
                comando.Parameters.Add("Pretiro", OracleType.NChar).Value = comboBox1.SelectedValue.ToString();
                comando.Parameters.Add("Pfecharetiro", OracleType.DateTime).Value = dateTimePicker1.Value;
            comando.Parameters.Add("Pfechadevolucion", OracleType.DateTime).Value = dateTimePicker2.Value;
            comando.Parameters.Add("Pestado", OracleType.NChar).Value = "1";
            comando.ExecuteNonQuery();


            List<string> elementosSeleccionados1 = new List<string>();
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
                            elementosSeleccionados1.Add(valorCelda);
                        }

                    }
                }    // El DataGridView contiene elementos
            }
            else
            {
                MessageBox.Show("por favor eliga primero los vehiculos");
            }




            //codigo para detalles de reservacion
            foreach (string element in elementosSeleccionados1)
            {
                OracleCommand comandodetalleReserva = new OracleCommand("ingresarDetallesReservacion", ConexionOracle);
                comandodetalleReserva.CommandType = System.Data.CommandType.StoredProcedure;
                    comandodetalleReserva.Parameters.Add("Pidreservacion", OracleType.NChar).Value = textBox6.Text;
                    comandodetalleReserva.Parameters.Add("Pmatricula", OracleType.NChar).Value = element;
                    comandodetalleReserva.Parameters.Add("Pidconductor", OracleType.NChar).Value = "1";
                    comandodetalleReserva.Parameters.Add("Pestado", OracleType.NChar).Value = "1";
                    comandodetalleReserva.ExecuteNonQuery();


                    OracleCommand comandoDisponibilidad = new OracleCommand("actualizarDisponibilidadFlota", ConexionOracle);
                    comandoDisponibilidad.CommandType = System.Data.CommandType.StoredProcedure;
                    comandoDisponibilidad.Parameters.Add("Pmatricula", OracleType.NChar).Value = element;
                    comandoDisponibilidad.Parameters.Add("Pdisponiblidad", OracleType.NChar).Value = "0";

                    comandoDisponibilidad.ExecuteNonQuery();
                }

            //codigo para detalle servicios adicionales


            List<string> elementosSeleccionados2 = new List<string>();
            List<string> elementosSeleccionados3 = new List<string>();
            if (dataGridViewServicios.RowCount > 0)
            {

                DataGridViewColumn columna = dataGridViewServicios.Columns[0];
                DataGridViewColumn columna2 = dataGridViewServicios.Columns[4];

                foreach (DataGridViewRow fila in dataGridViewServicios.Rows)
                {
                    fila.Cells[columna.Index].Selected = true;
                    fila.Cells[columna2.Index].Selected = true;
                }

                foreach (DataGridViewRow fila in dataGridViewServicios.Rows)
                {
                    if (fila.Cells[columna.Index].Selected && fila.Cells[columna2.Index].Selected)
                    {
                        if (fila.Cells[columna.Index].Value != null && fila.Cells[columna2.Index].Value != null)
                        {
                            string valorCelda = (fila.Cells[columna.Index].Value).ToString();
                            string valorCelda2 = (fila.Cells[columna2.Index].Value).ToString();
                            elementosSeleccionados2.Add(valorCelda);
                            elementosSeleccionados3.Add(valorCelda2);
                        }

                    }
                }




            }





            for (int i = 0; i < elementosSeleccionados2.Count; i++)
            {


                OracleCommand comandoServicios = new OracleCommand("IngresarServiciosAdicionalesReserva", ConexionOracle);
                    comandoServicios.CommandType = System.Data.CommandType.StoredProcedure;
                    comandoServicios.Parameters.Add("Pidreservacion", OracleType.NChar).Value = textBox6.Text;
                    comandoServicios.Parameters.Add("Pservicio", OracleType.NChar).Value = elementosSeleccionados2[i];
                    comandoServicios.Parameters.Add("cantidad", OracleType.Int16).Value = Int16.Parse(elementosSeleccionados3[i]);

                    comandoServicios.ExecuteNonQuery();

            }





            ConexionOracle.Close();

                MessageBox.Show("Reservacion Creada Exitosamente");
                this.Hide();
                FRMMenuVendedor fRMMenu = new FRMMenuVendedor(ConexionOracle);
                fRMMenu.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
               
                    ConexionOracle.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            FRMElegirServiciosAdicionales fRMElegirServiciosAdicionales = new FRMElegirServiciosAdicionales(ConexionOracle);
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


                LlenarCostoTotal();
                LabelTotal.Text = costoTotal.ToString();

            }




            ConexionOracle.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha1 = dateTimePicker1.Value;
            DateTime fecha2 = dateTimePicker2.Value;
            TimeSpan diferencia = fecha2 - fecha1;
            diferenciaDias = diferencia.Days.ToString();
            textBox5.Text = (costoTotal * 0.2 * (Int16.Parse(diferenciaDias) + 1)).ToString();
            LabelTotal.Text = (costoTotal * (Int16.Parse(diferenciaDias) + 1)).ToString();

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker2.Value;
            DateTime fecha2 = fecha.AddSeconds(5);
            
            DateTime fecha1 = dateTimePicker1.Value;
            
            TimeSpan diferencia = fecha2 - fecha1;
            diferenciaDias = diferencia.Days.ToString();

            textBox5.Text = (costoTotal * 0.2 * (Int16.Parse(diferenciaDias) + 1)).ToString();
            LabelTotal.Text = (costoTotal * (Int16.Parse(diferenciaDias) + 1)).ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            ConexionOracle.Open();
            string nombre = "%" + textBox3.Text + "%";
            OracleCommand comando = new OracleCommand("seleccionarReservacion", ConexionOracle);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
            comando.Parameters.Add("valor", OracleType.VarChar).Value = nombre;
            comando.ExecuteNonQuery();

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tablaReservaciones = new DataTable();
            adaptador.Fill(tablaReservaciones);
            dataGridView1.DataSource = tablaReservaciones;


            ConexionOracle.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                // Obtener los datos de la fila seleccionada
                textBox4.Text = row.Cells["ID_RESERVACION_PK"].Value.ToString();
                deposito= row.Cells["DEPOSITO"].Value.ToString();

                dateTimePicker4.Value= DateTime.Parse(row.Cells["FECHA_RETIRO"].Value.ToString()) ;
               
                dateTimePicker3.MinDate = DateTime.Parse(row.Cells["FECHA_DEVOLUCION"].Value.ToString());
                dateTimePicker3.Value = DateTime.Parse(row.Cells["FECHA_DEVOLUCION"].Value.ToString());



            }

            ConexionOracle.Open();
            OracleCommand comando = new OracleCommand(" select detalle_reservacion.id_matricula_flota_fk AS MATRICULA,marca.nombre_marca AS MARCA,modelo.nombre_modelo AS MODELO,vehiculo.costo_diario,  flota.color, vehiculo.numero_puertas  from detalle_reservacion \r\nINNER JOIN FLOTA ON detalle_reservacion.id_matricula_flota_fk=flota.matricula_pk INNER JOIN VEHICULO ON flota.id_vehiculo_fk=vehiculo.id_vehiculo_pk\r\nINNER JOIN MARCA ON marca.id_marca_pk=vehiculo.id_marca_fk INNER JOIN MODELO ON modelo.id_modelo_pk=vehiculo.modelo_fk WHERE detalle_reservacion.id_reservacion_fk='" + textBox4.Text+"' ", ConexionOracle);

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla3 = new DataTable();
            adaptador.Fill(tabla3);
            dataGridView2.DataSource = tabla3;


            //para el otro datagrid

            OracleCommand comando2 = new OracleCommand(" select servicios_adicionales.id_tipo_servicio_adicional_fk,servicios_adicionales.id_reservacion_fk,\r\ntipo_servicio_adicional.nombre_tipo_servicio,tipo_servicio_adicional.costo, servicios_adicionales.cantidad from servicios_adicionales \r\nINNER JOIN tipo_servicio_adicional on servicios_adicionales.id_tipo_servicio_adicional_fk=tipo_servicio_adicional.id_tipo_servicio_adicional_pk \r\nwhere servicios_adicionales.id_reservacion_fk='" + textBox4.Text+"' ", ConexionOracle);

            OracleDataAdapter adaptador2 = new OracleDataAdapter();
            adaptador2.SelectCommand = comando2;
            DataTable tabla4 = new DataTable();
            adaptador2.Fill(tabla4);
            dataGridView3.DataSource = tabla4;


            ConexionOracle.Close();


        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (DateTime.Now >= dateTimePicker4.Value)
            {
                MessageBox.Show("no puede cancelar esta reserva debido a que ya se activo el periodo de renta");

            }
            else
            {
                tabControl1.SelectedTab = tabControl1.TabPages["tabPage3"];
                textBox8.Text = "0";
                textBox9.Text = (Convert.ToSingle(deposito) / 2).ToString();
                textBox10.Text=(Convert.ToSingle(deposito) / 2).ToString();
                textBox11.Text = "0";
                textBox11.Enabled = false;
                button11.Enabled = true;
                textBox12.Text = "0";

                pagooCancelacion = false;
                
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
           

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                try
                {
                    ConexionOracle.Open();

                    OracleCommand comando = new OracleCommand("actualizarFechaReservacion", ConexionOracle);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("Preservacion", OracleType.NChar).Value = textBox4.Text;
                    comando.Parameters.Add("FDevolucion", OracleType.DateTime).Value = dateTimePicker3.Value;

                    comando.ExecuteNonQuery();
                    ConexionOracle.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }



                MessageBox.Show("Actualizacion de reserva exitosa");
            }
            else
            {
                MessageBox.Show("debe elegir una reserva");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            float total=0;
            if (textBox4.Text != "")
            {



                if (dataGridView2.RowCount > 0)
                {

                    DataGridViewColumn columna = dataGridView2.Columns[3];
                    

                    foreach (DataGridViewRow fila in dataGridView2.Rows)
                    {
                        fila.Cells[columna.Index].Selected = true;
                    }

                    foreach (DataGridViewRow fila in dataGridView2.Rows)
                    {
                        if (fila.Cells[columna.Index].Selected)
                        {
                            if (fila.Cells[columna.Index].Value != null)
                            {
                                string valorCelda = (fila.Cells[columna.Index].Value).ToString();
                                total += Convert.ToSingle(valorCelda);
                            }

                        }
                    }    // El DataGridView contiene elementos
                }


                //codigo para llenar de servicios adicionales

                if (dataGridView3.RowCount > 0)
                {

                    DataGridViewColumn columna1 = dataGridView3.Columns[3];
                    DataGridViewColumn columna2 = dataGridView3.Columns[4];

                    foreach (DataGridViewRow fila in dataGridView3.Rows)
                    {
                        fila.Cells[columna1.Index].Selected = true;
                        fila.Cells[columna2.Index].Selected = true;
                    }

                    foreach (DataGridViewRow fila in dataGridView3.Rows)
                    {
                        if (fila.Cells[columna1.Index].Selected && fila.Cells[columna2.Index].Selected)
                        {
                            if (fila.Cells[columna1.Index].Value != null && fila.Cells[columna2.Index].Value != null)
                            {
                                string valorCelda = (fila.Cells[columna1.Index].Value).ToString();
                                string valorCelda2 = (fila.Cells[columna2.Index].Value).ToString();
                                total += (Convert.ToSingle(valorCelda) * Convert.ToSingle(valorCelda2));
                            }

                        }
                    }    // El DataGridView contiene elementos
                }







                tabControl1.SelectedTab = tabControl1.TabPages["tabPage3"];

                
                textBox11.Text = "0";
                textBox11.Enabled = true;
               

                DateTime fechaInicio = dateTimePicker4.Value.Date;
                DateTime fechaFin = dateTimePicker3.Value.Date;
                TimeSpan diferencia1 = fechaFin.Subtract(fechaInicio);
             
                int diferenciaEnDias = diferencia1.Days + 1;


                if (DateTime.Now <= dateTimePicker3.Value)
                {

                    textBox8.Text = (diferenciaEnDias).ToString();
                    textBox12.Text = "0";
                    textBox9.Text = ((Convert.ToSingle(deposito) / 2) + total*diferenciaEnDias).ToString();
                    textBox10.Text = (Convert.ToSingle(deposito) / 2).ToString();
                }
                else
                {

                  
                 

                    DateTime fechaSeleccionada = dateTimePicker3.Value.Date;
                    TimeSpan diferencia2 = DateTime.Now.Subtract(fechaSeleccionada);
                    diferenciaEnDias+= diferencia2.Days;
                   textBox8.Text= (diferenciaEnDias).ToString();
                    textBox9.Text = ((Convert.ToSingle(deposito)) + total * diferenciaEnDias).ToString();
                    textBox10.Text = "0";
                    textBox12.Text = (diferencia2.Days).ToString();
                }

                button11.Enabled = true;
                pagooCancelacion = true;

              

                //aqui terminar el if
            }
            else
            {
                MessageBox.Show("debe elegir una reserva");
            }


            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage2"];
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            try
            {
                ConexionOracle.Open();
                List<string> elementosSeleccionados1 = new List<string>();
                if (dataGridView2.RowCount > 0)
                {

                    DataGridViewColumn columna = dataGridView2.Columns[0];

                    foreach (DataGridViewRow fila in dataGridView2.Rows)
                    {
                        fila.Cells[columna.Index].Selected = true;
                    }

                    foreach (DataGridViewRow fila in dataGridView2.Rows)
                    {
                        if (fila.Cells[columna.Index].Selected)
                        {
                            if (fila.Cells[columna.Index].Value != null)
                            {
                                string valorCelda = (fila.Cells[columna.Index].Value).ToString();
                                elementosSeleccionados1.Add(valorCelda);
                            }

                        }
                    }    // El DataGridView contiene elementos
                }

                //codigo para detalles de reservacion
                foreach (string element in elementosSeleccionados1)
                {
                    OracleCommand comandoDisponibilidad = new OracleCommand("actualizarDisponibilidadFlota", ConexionOracle);
                    comandoDisponibilidad.CommandType = System.Data.CommandType.StoredProcedure;
                    comandoDisponibilidad.Parameters.Add("Pmatricula", OracleType.NChar).Value = element;
                    comandoDisponibilidad.Parameters.Add("Pdisponiblidad", OracleType.NChar).Value = "1";
                    comandoDisponibilidad.ExecuteNonQuery();
                }


                OracleCommand comandoFactura = new OracleCommand("HacerFactura", ConexionOracle);
                comandoFactura.CommandType = System.Data.CommandType.StoredProcedure;
                comandoFactura.Parameters.Add("Preservacion", OracleType.NChar).Value = textBox4.Text;

                if (pagooCancelacion == false)
                {

                    comandoFactura.Parameters.Add("Estado", OracleType.NChar).Value = "2";







                }
                else
                {
                    comandoFactura.Parameters.Add("Estado", OracleType.NChar).Value = "3";
                }

                comandoFactura.Parameters.Add("IDFactura", OracleType.NChar).Value = textBox7.Text;
                comandoFactura.Parameters.Add("Retraso", OracleType.Int16).Value = Int16.Parse(textBox12.Text);
                comandoFactura.Parameters.Add("Fecha", OracleType.DateTime).Value = DateTime.Now.Date;
                comandoFactura.Parameters.Add("Ptotal", OracleType.Float).Value = float.Parse(textBox9.Text);
                comandoFactura.Parameters.Add("Pdevolucion", OracleType.Float).Value = float.Parse(textBox10.Text);
                comandoFactura.Parameters.Add("Pcargo", OracleType.Float).Value = float.Parse(textBox11.Text);
                comandoFactura.ExecuteNonQuery();









                MessageBox.Show("factura realizada con exito");
                ConexionOracle.Close();
                this.Hide();
                FRMMenuVendedor fRMMenu = new FRMMenuVendedor(ConexionOracle);
                fRMMenu.Show();
            }
            catch (Exception ex){
                MessageBox.Show(ex.ToString());
                ConexionOracle.Close();
            }
           
        }
    }
}

