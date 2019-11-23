namespace Lereon
{
    partial class Registro
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
            this.label2 = new System.Windows.Forms.Label();
            this.rusuario = new System.Windows.Forms.TextBox();
            this.rcontrasenha = new System.Windows.Forms.TextBox();
            this.aceptar_r = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.infoRegistro = new System.Windows.Forms.Label();
            this.cancelarRegistro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // rusuario
            // 
            this.rusuario.Location = new System.Drawing.Point(101, 113);
            this.rusuario.MaxLength = 20;
            this.rusuario.Name = "rusuario";
            this.rusuario.Size = new System.Drawing.Size(100, 20);
            this.rusuario.TabIndex = 1;
            // 
            // rcontrasenha
            // 
            this.rcontrasenha.Location = new System.Drawing.Point(101, 172);
            this.rcontrasenha.MaxLength = 20;
            this.rcontrasenha.Name = "rcontrasenha";
            this.rcontrasenha.Size = new System.Drawing.Size(100, 20);
            this.rcontrasenha.TabIndex = 2;
            // 
            // aceptar_r
            // 
            this.aceptar_r.BackColor = System.Drawing.Color.FloralWhite;
            this.aceptar_r.Location = new System.Drawing.Point(30, 223);
            this.aceptar_r.Name = "aceptar_r";
            this.aceptar_r.Size = new System.Drawing.Size(75, 23);
            this.aceptar_r.TabIndex = 3;
            this.aceptar_r.Text = "Aceptar";
            this.aceptar_r.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(96, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Registro";
            // 
            // infoRegistro
            // 
            this.infoRegistro.AutoSize = true;
            this.infoRegistro.BackColor = System.Drawing.Color.Transparent;
            this.infoRegistro.ForeColor = System.Drawing.Color.White;
            this.infoRegistro.Location = new System.Drawing.Point(12, 71);
            this.infoRegistro.Name = "infoRegistro";
            this.infoRegistro.Size = new System.Drawing.Size(270, 13);
            this.infoRegistro.TabIndex = 6;
            this.infoRegistro.Text = "Introduzca un nombre y una contraseña para registrarse";
            // 
            // cancelarRegistro
            // 
            this.cancelarRegistro.BackColor = System.Drawing.Color.FloralWhite;
            this.cancelarRegistro.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelarRegistro.Location = new System.Drawing.Point(163, 223);
            this.cancelarRegistro.Name = "cancelarRegistro";
            this.cancelarRegistro.Size = new System.Drawing.Size(75, 23);
            this.cancelarRegistro.TabIndex = 7;
            this.cancelarRegistro.Text = "Cancelar";
            this.cancelarRegistro.UseVisualStyleBackColor = false;
            // 
            // Registro
            // 
            this.AcceptButton = this.aceptar_r;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelarRegistro;
            this.ClientSize = new System.Drawing.Size(303, 283);
            this.Controls.Add(this.cancelarRegistro);
            this.Controls.Add(this.infoRegistro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aceptar_r);
            this.Controls.Add(this.rcontrasenha);
            this.Controls.Add(this.rusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button aceptar_r;
        public System.Windows.Forms.TextBox rusuario;
        public System.Windows.Forms.TextBox rcontrasenha;
        public System.Windows.Forms.Label infoRegistro;
        public System.Windows.Forms.Button cancelarRegistro;
    }
}