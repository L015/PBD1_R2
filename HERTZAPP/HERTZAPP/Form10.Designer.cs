namespace HERTZAPP
{
    partial class FRMElegirAutomovil
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
            this.dataGridViewVehiculo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNAceptar = new System.Windows.Forms.Button();
            this.TXTBusqueda = new System.Windows.Forms.TextBox();
            this.TXTCantidad = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVehiculo
            // 
            this.dataGridViewVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehiculo.Location = new System.Drawing.Point(21, 75);
            this.dataGridViewVehiculo.Name = "dataGridViewVehiculo";
            this.dataGridViewVehiculo.Size = new System.Drawing.Size(755, 349);
            this.dataGridViewVehiculo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad";
            // 
            // BTNAceptar
            // 
            this.BTNAceptar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BTNAceptar.Location = new System.Drawing.Point(602, 27);
            this.BTNAceptar.Name = "BTNAceptar";
            this.BTNAceptar.Size = new System.Drawing.Size(80, 32);
            this.BTNAceptar.TabIndex = 5;
            this.BTNAceptar.Text = "Aceptar";
            this.BTNAceptar.UseVisualStyleBackColor = false;
            this.BTNAceptar.Click += new System.EventHandler(this.BTNAceptar_Click);
            // 
            // TXTBusqueda
            // 
            this.TXTBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTBusqueda.Location = new System.Drawing.Point(24, 35);
            this.TXTBusqueda.Name = "TXTBusqueda";
            this.TXTBusqueda.Size = new System.Drawing.Size(350, 20);
            this.TXTBusqueda.TabIndex = 6;
            this.TXTBusqueda.TextChanged += new System.EventHandler(this.TXTBusqueda_TextChanged);
            // 
            // TXTCantidad
            // 
            this.TXTCantidad.Location = new System.Drawing.Point(461, 36);
            this.TXTCantidad.Name = "TXTCantidad";
            this.TXTCantidad.Size = new System.Drawing.Size(120, 20);
            this.TXTCantidad.TabIndex = 7;
            this.TXTCantidad.ValueChanged += new System.EventHandler(this.TXTCantidad_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(696, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRMElegirAutomovil
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
            this.Name = "FRMElegirAutomovil";
            this.Text = "FORMULARIO DE BUSQUEDA";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVehiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNAceptar;
        private System.Windows.Forms.TextBox TXTBusqueda;
        private System.Windows.Forms.NumericUpDown TXTCantidad;
        private System.Windows.Forms.Button button1;
    }
}