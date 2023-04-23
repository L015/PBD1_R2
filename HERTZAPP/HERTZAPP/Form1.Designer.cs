namespace HERTZAPP
{
    partial class FRMInicioSesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TXTUsuario = new System.Windows.Forms.TextBox();
            this.TXTPassword = new System.Windows.Forms.TextBox();
            this.BTNIniciarSesion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXTUsuario
            // 
            this.TXTUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTUsuario.Location = new System.Drawing.Point(117, 87);
            this.TXTUsuario.Name = "TXTUsuario";
            this.TXTUsuario.Size = new System.Drawing.Size(161, 20);
            this.TXTUsuario.TabIndex = 0;
            // 
            // TXTPassword
            // 
            this.TXTPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTPassword.Location = new System.Drawing.Point(117, 155);
            this.TXTPassword.Name = "TXTPassword";
            this.TXTPassword.PasswordChar = '♣';
            this.TXTPassword.Size = new System.Drawing.Size(161, 20);
            this.TXTPassword.TabIndex = 1;
            // 
            // BTNIniciarSesion
            // 
            this.BTNIniciarSesion.AccessibleName = "";
            this.BTNIniciarSesion.Location = new System.Drawing.Point(147, 216);
            this.BTNIniciarSesion.Name = "BTNIniciarSesion";
            this.BTNIniciarSesion.Size = new System.Drawing.Size(105, 23);
            this.BTNIniciarSesion.TabIndex = 2;
            this.BTNIniciarSesion.Text = "Iniciar Sesion";
            this.BTNIniciarSesion.UseVisualStyleBackColor = true;
            this.BTNIniciarSesion.Click += new System.EventHandler(this.BTNIniciarSesion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hertz Developer Rentadora de Vehiculos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre de Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña";
            // 
            // FRMInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 279);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNIniciarSesion);
            this.Controls.Add(this.TXTPassword);
            this.Controls.Add(this.TXTUsuario);
            this.Name = "FRMInicioSesion";
            this.Text = "INICIAR SESION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTUsuario;
        private System.Windows.Forms.TextBox TXTPassword;
        private System.Windows.Forms.Button BTNIniciarSesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

