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
    public partial class AñadirPlato : Form
    {
        public AñadirPlato()
        {
            InitializeComponent();
        }

        public string rutaIcon = Environment.GetEnvironmentVariable("homepath") + "/source/repos/Lereon/Lereon/Imagenes_interfaz/letter_l.ico";
        public string rutaImagen = Environment.GetEnvironmentVariable("homepath") + "/source/repos/Lereon/Lereon/Imagenes_interfaz/registro.png";
        public string filepath;
        public Bitmap image;
        private void AñadirPlato_Load(object sender, EventArgs e)
        {
            Icon ico = Icon.ExtractAssociatedIcon(rutaIcon);
            this.Icon = ico;
            this.BackgroundImage = new Bitmap(rutaImagen);
            pictureBox1.Tag = "";
        }

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
                                pictureBox1.Tag =filepath;
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
