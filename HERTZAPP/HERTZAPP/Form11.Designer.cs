namespace HERTZAPP
{
    partial class FRMElegirServiciosAdicionales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.TXTCantidad = new System.Windows.Forms.NumericUpDown();
            this.TXTBusqueda = new System.Windows.Forms.TextBox();
            this.BTNAceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewVehiculo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TXTCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(698, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 32);
            this.button1.TabIndex = 15;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TXTCantidad
            // 
            this.TXTCantidad.Location = new System.Drawing.Point(463, 43);
            this.TXTCantidad.Name = "TXTCantidad";
            this.TXTCantidad.Size = new System.Drawing.Size(120, 20);
            this.TXTCantidad.TabIndex = 14;
            // 
            // TXTBusqueda
            // 
            this.TXTBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTBusqueda.Location = new System.Drawing.Point(26, 42);
            this.TXTBusqueda.Name = "TXTBusqueda";
            this.TXTBusqueda.Size = new System.Drawing.Size(350, 20);
            this.TXTBusqueda.TabIndex = 13;
            this.TXTBusqueda.TextChanged += new System.EventHandler(this.TXTBusqueda_TextChanged_1);
            // 
            // BTNAceptar
            // 
            this.BTNAceptar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BTNAceptar.Location = new System.Drawing.Point(604, 34);
            this.BTNAceptar.Name = "BTNAceptar";
            this.BTNAceptar.Size = new System.Drawing.Size(80, 32);
            this.BTNAceptar.TabIndex = 12;
            this.BTNAceptar.Text = "Aceptar";
            this.BTNAceptar.UseVisualStyleBackColor = false;
            this.BTNAceptar.Click += new System.EventHandler(this.BTNAceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Buscar";
            // 
            // dataGridViewVehiculo
            // 
            this.dataGridViewVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehiculo.Location = new System.Drawing.Point(23, 82);
            this.dataGridViewVehiculo.Name = "dataGridViewVehiculo";
            this.dataGridViewVehiculo.Size = new System.Drawing.Size(755, 349);
            this.dataGridViewVehiculo.TabIndex = 9;
            // 
            // FRMElegirServiciosAdicionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TXTCantidad);
            this.Controls.Add(this.TXTBusqueda);
            this.Controls.Add(this.BTNAceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewVehiculo);
            this.Name = "FRMElegirServiciosAdicionales";
            this.Text = "Form11";
            ((System.ComponentModel.ISupportInitialize)(this.TXTCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown TXTCantidad;
        private System.Windows.Forms.TextBox TXTBusqueda;
        private System.Windows.Forms.Button BTNAceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewVehiculo;
    }
}