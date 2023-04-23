namespace HERTZAPP
{
    partial class FRMElegirCliente
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
            this.BTNNuevoCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNNuevoCliente
            // 
            this.BTNNuevoCliente.Location = new System.Drawing.Point(507, 61);
            this.BTNNuevoCliente.Name = "BTNNuevoCliente";
            this.BTNNuevoCliente.Size = new System.Drawing.Size(103, 23);
            this.BTNNuevoCliente.TabIndex = 0;
            this.BTNNuevoCliente.Text = "Nuevo Cliente";
            this.BTNNuevoCliente.UseVisualStyleBackColor = true;
            this.BTNNuevoCliente.Click += new System.EventHandler(this.BTNNuevoCliente_Click);
            // 
            // FRMElegirCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNNuevoCliente);
            this.Name = "FRMElegirCliente";
            this.Text = "ELEGIR CLIENTE";
            this.Load += new System.EventHandler(this.FRMElegirCliente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNNuevoCliente;
    }
}