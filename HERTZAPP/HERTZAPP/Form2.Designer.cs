namespace HERTZAPP
{
    partial class FRMVehiculos
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
            this.DataGridVehiculos = new System.Windows.Forms.DataGridView();
            this.TXTBusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNActualizar = new System.Windows.Forms.Button();
            this.BTNAgregar = new System.Windows.Forms.Button();
            this.BTNEliminar = new System.Windows.Forms.Button();
            this.BTNVehiculos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridVehiculos
            // 
            this.DataGridVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridVehiculos.Location = new System.Drawing.Point(43, 135);
            this.DataGridVehiculos.Name = "DataGridVehiculos";
            this.DataGridVehiculos.Size = new System.Drawing.Size(674, 274);
            this.DataGridVehiculos.TabIndex = 0;
            // 
            // TXTBusqueda
            // 
            this.TXTBusqueda.Location = new System.Drawing.Point(43, 84);
            this.TXTBusqueda.Name = "TXTBusqueda";
            this.TXTBusqueda.Size = new System.Drawing.Size(254, 20);
            this.TXTBusqueda.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar por marca, modelo, tipo de vehiculo";
            // 
            // BTNActualizar
            // 
            this.BTNActualizar.Location = new System.Drawing.Point(635, 80);
            this.BTNActualizar.Name = "BTNActualizar";
            this.BTNActualizar.Size = new System.Drawing.Size(82, 23);
            this.BTNActualizar.TabIndex = 3;
            this.BTNActualizar.Text = "Actualizar";
            this.BTNActualizar.UseVisualStyleBackColor = true;
            // 
            // BTNAgregar
            // 
            this.BTNAgregar.Location = new System.Drawing.Point(554, 80);
            this.BTNAgregar.Name = "BTNAgregar";
            this.BTNAgregar.Size = new System.Drawing.Size(75, 23);
            this.BTNAgregar.TabIndex = 4;
            this.BTNAgregar.Text = "Agregar";
            this.BTNAgregar.UseVisualStyleBackColor = true;
            this.BTNAgregar.Click += new System.EventHandler(this.BTNAgregar_Click);
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.Location = new System.Drawing.Point(473, 80);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(75, 23);
            this.BTNEliminar.TabIndex = 5;
            this.BTNEliminar.Text = "Eliminar";
            this.BTNEliminar.UseVisualStyleBackColor = true;
            // 
            // BTNVehiculos
            // 
            this.BTNVehiculos.Location = new System.Drawing.Point(602, 23);
            this.BTNVehiculos.Name = "BTNVehiculos";
            this.BTNVehiculos.Size = new System.Drawing.Size(115, 37);
            this.BTNVehiculos.TabIndex = 6;
            this.BTNVehiculos.Text = "Ver Vehiculos De Empresa";
            this.BTNVehiculos.UseVisualStyleBackColor = true;
            this.BTNVehiculos.Click += new System.EventHandler(this.BTNVehiculos_Click);
            // 
            // FRMVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 450);
            this.Controls.Add(this.BTNVehiculos);
            this.Controls.Add(this.BTNEliminar);
            this.Controls.Add(this.BTNAgregar);
            this.Controls.Add(this.BTNActualizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTBusqueda);
            this.Controls.Add(this.DataGridVehiculos);
            this.Name = "FRMVehiculos";
            this.Text = "Administrar Tipos de Vehiculos";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridVehiculos;
        private System.Windows.Forms.TextBox TXTBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNActualizar;
        private System.Windows.Forms.Button BTNAgregar;
        private System.Windows.Forms.Button BTNEliminar;
        private System.Windows.Forms.Button BTNVehiculos;
    }
}