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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool flag = false;
        private int tries = 3;
        private bool intento = false;
        //Al cargar este formulario se lanza el form de contraseña y si es correcta crea los botones para el ejercicio
        private void Form1_Load(object sender, EventArgs e)
        {

            Form2 f = new Form2();
            f.infoError.ForeColor = Color.Red;
            f.aceptar.DialogResult = DialogResult.OK;
            do
            {
                try
                {
                    DialogResult res = f.ShowDialog();

                    switch (res)
                    {
                        case DialogResult.OK:

                            if (f.password.Text.Trim() == "0000")
                            {
                                intento = true;
                                MessageBox.Show("Password correcto", "Bien", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                            {
                                tries--;
                                f.infoError.Text = "Error al introducir el password, \nte quedan: " + tries + " intentos";
                                if (tries == 0)
                                {
                                    MessageBox.Show("El telefono se apagara", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    Environment.Exit(0); //Cierra bien no usar ni application.exit ni this.close()
                                }
                            }

                            break;
                        case DialogResult.Cancel: // El boton x del form ya es el cancel per se
                            Environment.Exit(0);
                            break;
                    }
                }
                catch (ObjectDisposedException) { };
            } while (!intento);

        }
    }
}
