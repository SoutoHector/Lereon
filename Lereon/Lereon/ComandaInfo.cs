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
    /// Clase encargada del controlador creado ComandaInfo
    /// </summary>
    public partial class ComandaInfo : UserControl
    {
        public ComandaInfo()
        {
            InitializeComponent();
        }

     

        [Category("Appearance")]
        [Description("Texto asociado a la comanda")]
        public string TextNComanda
        {
            set
            {
                nComanda.Text = value;
            }
            get
            {
                return nComanda.Text;
            }
        }



        [Category("Appearance")]
        [Description("Texto asociado a la comanda")]
        public string TextComanda
        {
            set
            {
                infoComanda.Text = value;
            }
            get
            {
                return infoComanda.Text;
            }
        }

        /// <summary>
        /// Permite acceder al evento click del botón pagar
        /// </summary>
        /// <param name="sender">botón</param>
        /// <param name="e">evento click</param>
        public void botonPagar_Click(object sender, EventArgs e)
        {
           
        }
        /// <summary>
        /// Permite acceder al evento click del botón eliminar
        /// </summary>
        /// <param name="sender">botón</param>
        /// <param name="e">evento click</param>
        public void botonEliminar_Click(object sender, EventArgs e)
        {
        }
    }
}
