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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();

        }

        public string rutaIcon = Environment.GetEnvironmentVariable("homepath") + "/source/repos/Lereon/Lereon/Imagenes_interfaz/letter_l.ico";
        public string rutaImagen = Environment.GetEnvironmentVariable("homepath") + "/source/repos/Lereon/Lereon/Imagenes_interfaz/registro.png";

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {
            Icon ico = Icon.ExtractAssociatedIcon(rutaIcon);
            this.Icon = ico;
            this.BackgroundImage = new Bitmap(rutaImagen);
        }
    }
}
