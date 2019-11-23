namespace Lereon
{
    partial class ComandaInfo
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
            this.infoComanda = new System.Windows.Forms.TextBox();
            this.botonPagar = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.nComanda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // infoComanda
            // 
            this.infoComanda.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.infoComanda.Location = new System.Drawing.Point(21, 44);
            this.infoComanda.Multiline = true;
            this.infoComanda.Name = "infoComanda";
            this.infoComanda.ReadOnly = true;
            this.infoComanda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.infoComanda.Size = new System.Drawing.Size(122, 114);
            this.infoComanda.TabIndex = 0;
            // 
            // botonPagar
            // 
            this.botonPagar.BackColor = System.Drawing.Color.FloralWhite;
            this.botonPagar.Location = new System.Drawing.Point(21, 164);
            this.botonPagar.Name = "botonPagar";
            this.botonPagar.Size = new System.Drawing.Size(75, 23);
            this.botonPagar.TabIndex = 1;
            this.botonPagar.Text = "Pagar";
            this.botonPagar.UseVisualStyleBackColor = false;
            this.botonPagar.Click += new System.EventHandler(this.botonPagar_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.BackColor = System.Drawing.Color.FloralWhite;
            this.botonEliminar.Location = new System.Drawing.Point(115, 164);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(28, 23);
            this.botonEliminar.TabIndex = 2;
            this.botonEliminar.Text = "X";
            this.botonEliminar.UseVisualStyleBackColor = false;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // nComanda
            // 
            this.nComanda.AutoSize = true;
            this.nComanda.Location = new System.Drawing.Point(61, 17);
            this.nComanda.Name = "nComanda";
            this.nComanda.Size = new System.Drawing.Size(35, 13);
            this.nComanda.TabIndex = 3;
            this.nComanda.Text = "label1";
            // 
            // ComandaInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.nComanda);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonPagar);
            this.Controls.Add(this.infoComanda);
            this.Name = "ComandaInfo";
            this.Size = new System.Drawing.Size(163, 201);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox infoComanda;
        private System.Windows.Forms.Label nComanda;
        public System.Windows.Forms.Button botonPagar;
        public System.Windows.Forms.Button botonEliminar;
    }
}
