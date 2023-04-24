namespace HERTZAPP
{
    partial class FRMMenuGerente
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
            this.BTNGestionarVehiculos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNGestionarVehiculos
            // 
            this.BTNGestionarVehiculos.Location = new System.Drawing.Point(44, 62);
            this.BTNGestionarVehiculos.Name = "BTNGestionarVehiculos";
            this.BTNGestionarVehiculos.Size = new System.Drawing.Size(118, 55);
            this.BTNGestionarVehiculos.TabIndex = 0;
            this.BTNGestionarVehiculos.Text = "Gestionar Vehiculos";
            this.BTNGestionarVehiculos.UseVisualStyleBackColor = true;
            this.BTNGestionarVehiculos.Click += new System.EventHandler(this.BTNGestionarVehiculos_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ver Reporte De Reservaciones";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRMMenuGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 190);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTNGestionarVehiculos);
            this.Name = "FRMMenuGerente";
            this.Text = "Menu del Gerente";
            this.Load += new System.EventHandler(this.FRMMenuGerente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNGestionarVehiculos;
        private System.Windows.Forms.Button button1;
    }
}