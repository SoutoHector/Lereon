using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lereon
{
    /// <summary>
    /// Clase que gestiona el controlador Plato creado
    /// </summary>
    public partial class Plato : UserControl
    {
        public Plato()
        {
            InitializeComponent();
        }


        [Category("Appearance")]
        [Description("Texto asociado a la Label del nombre del plato")]
        public string TextLbln
        {
            set
            {
                nombrePlato.Text = value;
            }
            get
            {
                return nombrePlato.Text;
            }
        }
        [Category("Appearance")]
        [Description("Texto asociado al la label del coste del producto")]
        public string TextLblm
        {
            set
            {
                coste.Text = value;
            }
            get
            {
                return coste.Text;
            }
        }

        [Category("Appearance")]
        [Description("Imagen asociada al plato")]
        public Bitmap imagenMostra
        {
            set
            {
                if (imagenMostra != null)
                {
                    imagenPlato.Image = value;
                }
            }
            get
            {
                return imagenMostra;
            }
        }

        /// <summary>
        /// Aplica el evento click en el botón del componente plato en vez de todo el componente
        /// </summary>
        /// <param name="sender">botón</param>
        /// <param name="e">lanza el evento click del botón</param>
        private void anhadir_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
