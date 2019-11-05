namespace Lereon
{
    partial class Plato
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.anhadir = new System.Windows.Forms.Button();
            this.moneda = new System.Windows.Forms.Label();
            this.nombrePlato = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // anhadir
            // 
            this.anhadir.Location = new System.Drawing.Point(8, 101);
            this.anhadir.Name = "anhadir";
            this.anhadir.Size = new System.Drawing.Size(75, 23);
            this.anhadir.TabIndex = 2;
            this.anhadir.Text = "+";
            this.anhadir.UseVisualStyleBackColor = true;
            // 
            // moneda
            // 
            this.moneda.AutoSize = true;
            this.moneda.Location = new System.Drawing.Point(77, 74);
            this.moneda.Name = "moneda";
            this.moneda.Size = new System.Drawing.Size(45, 13);
            this.moneda.TabIndex = 3;
            this.moneda.Text = "moneda";
            // 
            // nombrePlato
            // 
            this.nombrePlato.AutoSize = true;
            this.nombrePlato.Location = new System.Drawing.Point(5, 74);
            this.nombrePlato.Name = "nombrePlato";
            this.nombrePlato.Size = new System.Drawing.Size(66, 13);
            this.nombrePlato.TabIndex = 4;
            this.nombrePlato.Text = "nombrePlato";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(8, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Plato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nombrePlato);
            this.Controls.Add(this.moneda);
            this.Controls.Add(this.anhadir);
            this.Name = "Plato";
            this.Size = new System.Drawing.Size(132, 133);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button anhadir;
        private System.Windows.Forms.Label moneda;
        private System.Windows.Forms.Label nombrePlato;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
