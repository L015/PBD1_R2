namespace HERTZAPP
{
    partial class FRMReserva
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
            this.BTNCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNCliente
            // 
            this.BTNCliente.Location = new System.Drawing.Point(597, 35);
            this.BTNCliente.Name = "BTNCliente";
            this.BTNCliente.Size = new System.Drawing.Size(134, 23);
            this.BTNCliente.TabIndex = 0;
            this.BTNCliente.Text = "Elegir Cliente";
            this.BTNCliente.UseVisualStyleBackColor = true;
            this.BTNCliente.Click += new System.EventHandler(this.BTNCliente_Click);
            // 
            // FRMReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNCliente);
            this.Name = "FRMReserva";
            this.Text = "RESERVA";
            this.Load += new System.EventHandler(this.FRMReserva_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNCliente;
    }
}