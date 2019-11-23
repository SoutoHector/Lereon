namespace Lereon
{
    partial class AñadirPlato
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
            this.label3 = new System.Windows.Forms.Label();
            this.nombrePlato = new System.Windows.Forms.TextBox();
            this.precioPlato = new System.Windows.Forms.TextBox();
            this.btnAceptarPlato = new System.Windows.Forms.Button();
            this.btnCancelarPlato = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imagen_seleccionada = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del plato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio del plato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Imagen del plato";
            // 
            // nombrePlato
            // 
            this.nombrePlato.Location = new System.Drawing.Point(176, 101);
            this.nombrePlato.Name = "nombrePlato";
            this.nombrePlato.Size = new System.Drawing.Size(100, 20);
            this.nombrePlato.TabIndex = 0;
            // 
            // precioPlato
            // 
            this.precioPlato.Location = new System.Drawing.Point(176, 145);
            this.precioPlato.Name = "precioPlato";
            this.precioPlato.Size = new System.Drawing.Size(100, 20);
            this.precioPlato.TabIndex = 1;
            // 
            // btnAceptarPlato
            // 
            this.btnAceptarPlato.BackColor = System.Drawing.Color.FloralWhite;
            this.btnAceptarPlato.Location = new System.Drawing.Point(30, 344);
            this.btnAceptarPlato.Name = "btnAceptarPlato";
            this.btnAceptarPlato.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarPlato.TabIndex = 4;
            this.btnAceptarPlato.Text = "Aceptar";
            this.btnAceptarPlato.UseVisualStyleBackColor = false;
            // 
            // btnCancelarPlato
            // 
            this.btnCancelarPlato.BackColor = System.Drawing.Color.FloralWhite;
            this.btnCancelarPlato.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarPlato.Location = new System.Drawing.Point(176, 344);
            this.btnCancelarPlato.Name = "btnCancelarPlato";
            this.btnCancelarPlato.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarPlato.TabIndex = 5;
            this.btnCancelarPlato.Text = "Cancelar";
            this.btnCancelarPlato.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(66, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Añade un plato";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(176, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // imagen_seleccionada
            // 
            this.imagen_seleccionada.Location = new System.Drawing.Point(185, 249);
            this.imagen_seleccionada.Name = "imagen_seleccionada";
            this.imagen_seleccionada.Size = new System.Drawing.Size(75, 23);
            this.imagen_seleccionada.TabIndex = 3;
            this.imagen_seleccionada.Text = "Imagen";
            this.imagen_seleccionada.UseVisualStyleBackColor = true;
            this.imagen_seleccionada.Click += new System.EventHandler(this.imagen_seleccionada_Click);
            // 
            // AñadirPlato
            // 
            this.AcceptButton = this.btnAceptarPlato;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelarPlato;
            this.ClientSize = new System.Drawing.Size(289, 390);
            this.Controls.Add(this.imagen_seleccionada);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelarPlato);
            this.Controls.Add(this.btnAceptarPlato);
            this.Controls.Add(this.precioPlato);
            this.Controls.Add(this.nombrePlato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AñadirPlato";
            this.Text = "AñadirPlato";
            this.Load += new System.EventHandler(this.AñadirPlato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button imagen_seleccionada;
        public System.Windows.Forms.TextBox nombrePlato;
        public System.Windows.Forms.TextBox precioPlato;
        public System.Windows.Forms.Button btnAceptarPlato;
        public System.Windows.Forms.Button btnCancelarPlato;
    }
}