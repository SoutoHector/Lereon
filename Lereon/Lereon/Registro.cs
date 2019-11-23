using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lereon
{
    /// <summary>
    /// Clase que se encarga del registro de trabajadores
    /// </summary>
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();

        }
        //Paths
        public string rutaIcon = Environment.GetEnvironmentVariable("homepath") + "/source/repos/Lereon/Lereon/Imagenes_interfaz/letter_l.ico";
        public string rutaImagen = Environment.GetEnvironmentVariable("homepath") + "/source/repos/Lereon/Lereon/Imagenes_interfaz/registro.png";

        /// <summary>
        /// Carga el formulario con un icono e imagen 
        /// </summary>
        /// <param name="sender">formulario</param>
        /// <param name="e">carga el formulario</param>
        private void Registro_Load(object sender, EventArgs e)
        {
            Icon ico = Icon.ExtractAssociatedIcon(rutaIcon);
            this.Icon = ico;
            this.BackgroundImage = new Bitmap(rutaImagen);
        }
    }
}
