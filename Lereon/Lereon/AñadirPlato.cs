using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lereon
{
    /// <summary>
    /// Formulario para añadir un plato
    /// </summary>
    public partial class AñadirPlato : Form
    {
        public AñadirPlato(Menu m)
        {
            InitializeComponent();
            ms = m;
        }

        private Menu ms;
        //Paths
        public string rutaIcon = Environment.GetEnvironmentVariable("homepath") + "/source/repos/Lereon/Lereon/Imagenes_interfaz/letter_l.ico";
        public string rutaImagen = Environment.GetEnvironmentVariable("homepath") + "/source/repos/Lereon/Lereon/Imagenes_interfaz/registro.png";

        //Componentes
        public Bitmap image;

        //Variables
        public string filepath;

        /// <summary>
        /// Carga el formulario y coloca un icono e imagen en él
        /// </summary>
        /// <param name="sender">formulario</param>
        /// <param name="e">carga el formulario</param>
        private void AñadirPlato_Load(object sender, EventArgs e)
        {
            Icon ico = Icon.ExtractAssociatedIcon(rutaIcon);
            this.Icon = ico;
            this.BackgroundImage = new Bitmap(rutaImagen);
            pictureBox1.Tag = "";
        }

        /// <summary>
        /// Función encargada de que elija una foto para la imagen del plato
        /// </summary>
        /// <param name="sender">botón</param>
        /// <param name="e">lanza un openFileDialog para coger una foto</param>
        private void imagen_seleccionada_Click(object sender, EventArgs e)
        {
            
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = Environment.GetEnvironmentVariable("hometpath")+"/desktop";
                    openFileDialog.Filter = "png files(*.png)|*.png"; 
                    openFileDialog.FilterIndex = 3;
                    openFileDialog.RestoreDirectory = true;
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        filepath = openFileDialog.FileName;
                            if (filepath.EndsWith(".png"))
                            {
                                image = new Bitmap(filepath);
                                ms.Path = filepath;
                                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                pictureBox1.Image = (Image)image;
                                GC.Collect();
                            }
                    }
                }
            }
            catch (ArgumentException es)
            {
                MessageBox.Show("Elemento corrupto", "Corrupcion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
