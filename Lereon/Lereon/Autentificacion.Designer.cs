namespace Lereon
{
    partial class Autentificacion
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
            this.usuarior = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.infoError = new System.Windows.Forms.Label();
            this.aceptar = new System.Windows.Forms.Button();
            this.registrarse = new System.Windows.Forms.Button();
            this.passwordr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usuarior
            // 
            this.usuarior.Location = new System.Drawing.Point(103, 107);
            this.usuarior.MaxLength = 20;
            this.usuarior.Name = "usuarior";
            this.usuarior.Size = new System.Drawing.Size(100, 20);
            this.usuarior.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lereon";
            // 
            // infoError
            // 
            this.infoError.AutoSize = true;
            this.infoError.BackColor = System.Drawing.Color.Transparent;
            this.infoError.ForeColor = System.Drawing.Color.White;
            this.infoError.Location = new System.Drawing.Point(23, 61);
            this.infoError.Name = "infoError";
            this.infoError.Size = new System.Drawing.Size(180, 13);
            this.infoError.TabIndex = 2;
            this.infoError.Text = "Introduzca el usuario y la contraseña";
            // 
            // aceptar
            // 
            this.aceptar.BackColor = System.Drawing.Color.FloralWhite;
            this.aceptar.Location = new System.Drawing.Point(128, 238);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 3;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = false;
            // 
            // registrarse
            // 
            this.registrarse.BackColor = System.Drawing.Color.FloralWhite;
            this.registrarse.ForeColor = System.Drawing.Color.Black;
            this.registrarse.Location = new System.Drawing.Point(26, 238);
            this.registrarse.Name = "registrarse";
            this.registrarse.Size = new System.Drawing.Size(75, 23);
            this.registrarse.TabIndex = 2;
            this.registrarse.Text = "Registrarse";
            this.registrarse.UseVisualStyleBackColor = false;
            this.registrarse.Click += new System.EventHandler(this.button1_Click);
            // 
            // passwordr
            // 
            this.passwordr.Location = new System.Drawing.Point(103, 170);
            this.passwordr.MaxLength = 20;
            this.passwordr.Name = "passwordr";
            this.passwordr.Size = new System.Drawing.Size(100, 20);
            this.passwordr.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contraseña:";
            // 
            // Autentificacion
            // 
            this.AcceptButton = this.aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 273);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordr);
            this.Controls.Add(this.registrarse);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.infoError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usuarior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Autentificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autentificación";
            this.Load += new System.EventHandler(this.Autentificacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox usuarior;
        public System.Windows.Forms.Button aceptar;
        public System.Windows.Forms.Label infoError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button registrarse;
        public System.Windows.Forms.TextBox passwordr;
    }
}