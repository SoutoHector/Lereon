namespace Lereon
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menus = new System.Windows.Forms.Button();
            this.comandas = new System.Windows.Forms.Button();
            this.totalCaja = new System.Windows.Forms.Button();
            this.opciones = new System.Windows.Forms.Button();
            this.calculadora = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menus
            // 
            this.menus.Location = new System.Drawing.Point(34, 51);
            this.menus.Name = "menus";
            this.menus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menus.Size = new System.Drawing.Size(94, 23);
            this.menus.TabIndex = 1;
            this.menus.Text = "Menú";
            this.menus.UseVisualStyleBackColor = true;
            this.menus.Click += new System.EventHandler(this.menus_Click);
            // 
            // comandas
            // 
            this.comandas.Enabled = false;
            this.comandas.Location = new System.Drawing.Point(34, 131);
            this.comandas.Name = "comandas";
            this.comandas.Size = new System.Drawing.Size(94, 23);
            this.comandas.TabIndex = 2;
            this.comandas.Text = "Comandas";
            this.comandas.UseVisualStyleBackColor = true;
            this.comandas.Click += new System.EventHandler(this.comandas_Click);
            // 
            // totalCaja
            // 
            this.totalCaja.Location = new System.Drawing.Point(34, 196);
            this.totalCaja.Name = "totalCaja";
            this.totalCaja.Size = new System.Drawing.Size(94, 23);
            this.totalCaja.TabIndex = 3;
            this.totalCaja.Text = "Caja";
            this.totalCaja.UseVisualStyleBackColor = true;
            this.totalCaja.Click += new System.EventHandler(this.totalCaja_Click);
            // 
            // opciones
            // 
            this.opciones.Enabled = false;
            this.opciones.Location = new System.Drawing.Point(34, 353);
            this.opciones.Name = "opciones";
            this.opciones.Size = new System.Drawing.Size(94, 23);
            this.opciones.TabIndex = 5;
            this.opciones.Text = "Opciones";
            this.opciones.UseVisualStyleBackColor = true;
            this.opciones.Click += new System.EventHandler(this.Opciones_Click);
            // 
            // calculadora
            // 
            this.calculadora.Location = new System.Drawing.Point(34, 275);
            this.calculadora.Name = "calculadora";
            this.calculadora.Size = new System.Drawing.Size(94, 23);
            this.calculadora.TabIndex = 4;
            this.calculadora.Text = "Calculadora";
            this.calculadora.UseVisualStyleBackColor = true;
            this.calculadora.Click += new System.EventHandler(this.calculadora_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vScrollBar1);
            this.groupBox1.Location = new System.Drawing.Point(80, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 224);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Platos";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(0, 16);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 80);
            this.vScrollBar1.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.menus);
            this.splitContainer1.Panel1.Controls.Add(this.calculadora);
            this.splitContainer1.Panel1.Controls.Add(this.comandas);
            this.splitContainer1.Panel1.Controls.Add(this.totalCaja);
            this.splitContainer1.Panel1.Controls.Add(this.opciones);
            this.splitContainer1.Size = new System.Drawing.Size(486, 468);
            this.splitContainer1.SplitterDistance = 162;
            this.splitContainer1.TabIndex = 10;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 468);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lereon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button menus;
        private System.Windows.Forms.Button comandas;
        private System.Windows.Forms.Button totalCaja;
        private System.Windows.Forms.Button calculadora;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button opciones;
    }
}

