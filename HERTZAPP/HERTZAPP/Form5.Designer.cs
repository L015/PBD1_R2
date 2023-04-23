namespace HERTZAPP
{
    partial class FRMIngresarDatos
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
            this.label1 = new System.Windows.Forms.Label();
            this.TXTDato = new System.Windows.Forms.TextBox();
            this.BTNAceptar = new System.Windows.Forms.Button();
            this.TXTDato2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese aqui el dato correspondiente por favor";
            // 
            // TXTDato
            // 
            this.TXTDato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTDato.Location = new System.Drawing.Point(63, 135);
            this.TXTDato.Name = "TXTDato";
            this.TXTDato.Size = new System.Drawing.Size(199, 20);
            this.TXTDato.TabIndex = 1;
            this.TXTDato.TextChanged += new System.EventHandler(this.TXTDato_TextChanged);
            // 
            // BTNAceptar
            // 
            this.BTNAceptar.Location = new System.Drawing.Point(115, 255);
            this.BTNAceptar.Name = "BTNAceptar";
            this.BTNAceptar.Size = new System.Drawing.Size(75, 23);
            this.BTNAceptar.TabIndex = 2;
            this.BTNAceptar.Text = "Aceptar";
            this.BTNAceptar.UseVisualStyleBackColor = true;
            this.BTNAceptar.Click += new System.EventHandler(this.BTNAceptar_Click);
            // 
            // TXTDato2
            // 
            this.TXTDato2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTDato2.Location = new System.Drawing.Point(63, 193);
            this.TXTDato2.Name = "TXTDato2";
            this.TXTDato2.Size = new System.Drawing.Size(199, 20);
            this.TXTDato2.TabIndex = 3;
            this.TXTDato2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // FRMIngresarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 303);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTDato2);
            this.Controls.Add(this.BTNAceptar);
            this.Controls.Add(this.TXTDato);
            this.Controls.Add(this.label1);
            this.Name = "FRMIngresarDatos";
            this.Text = "INGRESAR DATOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTDato;
        private System.Windows.Forms.Button BTNAceptar;
        private System.Windows.Forms.TextBox TXTDato2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}