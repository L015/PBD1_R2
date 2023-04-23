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
            this.SuspendLayout();
            // 
            // BTNGestionarVehiculos
            // 
            this.BTNGestionarVehiculos.Location = new System.Drawing.Point(34, 12);
            this.BTNGestionarVehiculos.Name = "BTNGestionarVehiculos";
            this.BTNGestionarVehiculos.Size = new System.Drawing.Size(98, 44);
            this.BTNGestionarVehiculos.TabIndex = 0;
            this.BTNGestionarVehiculos.Text = "Gestionar Vehiculos";
            this.BTNGestionarVehiculos.UseVisualStyleBackColor = true;
            this.BTNGestionarVehiculos.Click += new System.EventHandler(this.BTNGestionarVehiculos_Click);
            // 
            // FRMMenuGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNGestionarVehiculos);
            this.Name = "FRMMenuGerente";
            this.Text = "Menu del Gerente";
            this.Load += new System.EventHandler(this.FRMMenuGerente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNGestionarVehiculos;
    }
}