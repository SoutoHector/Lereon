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
            this.coste = new System.Windows.Forms.Label();
            this.nombrePlato = new System.Windows.Forms.Label();
            this.imagenPlato = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPlato)).BeginInit();
            this.SuspendLayout();
            // 
            // anhadir
            // 
            this.anhadir.BackColor = System.Drawing.Color.FloralWhite;
            this.anhadir.Location = new System.Drawing.Point(22, 127);
            this.anhadir.Name = "anhadir";
            this.anhadir.Size = new System.Drawing.Size(75, 23);
            this.anhadir.TabIndex = 2;
            this.anhadir.Text = "+";
            this.anhadir.UseVisualStyleBackColor = false;
            this.anhadir.Click += new System.EventHandler(this.anhadir_Click);
            // 
            // coste
            // 
            this.coste.AutoSize = true;
            this.coste.Location = new System.Drawing.Point(77, 74);
            this.coste.Name = "coste";
            this.coste.Size = new System.Drawing.Size(33, 13);
            this.coste.TabIndex = 3;
            this.coste.Text = "coste";
            // 
            // nombrePlato
            // 
            this.nombrePlato.Location = new System.Drawing.Point(5, 74);
            this.nombrePlato.Name = "nombrePlato";
            this.nombrePlato.Size = new System.Drawing.Size(66, 50);
            this.nombrePlato.TabIndex = 4;
            this.nombrePlato.Text = "nombrePlato";
            // 
            // imagenPlato
            // 
            this.imagenPlato.Location = new System.Drawing.Point(10, 3);
            this.imagenPlato.Name = "imagenPlato";
            this.imagenPlato.Size = new System.Drawing.Size(100, 50);
            this.imagenPlato.TabIndex = 5;
            this.imagenPlato.TabStop = false;
            // 
            // Plato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.imagenPlato);
            this.Controls.Add(this.nombrePlato);
            this.Controls.Add(this.coste);
            this.Controls.Add(this.anhadir);
            this.Name = "Plato";
            this.Size = new System.Drawing.Size(131, 185);
            ((System.ComponentModel.ISupportInitialize)(this.imagenPlato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button anhadir;
        private System.Windows.Forms.Label coste;
        private System.Windows.Forms.Label nombrePlato;
        public System.Windows.Forms.PictureBox imagenPlato;
    }
}
