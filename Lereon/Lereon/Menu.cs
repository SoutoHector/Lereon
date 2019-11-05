using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Lereon
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            consulta();
        }

        public List<string> trabajadores = new List<string>();
        public int cont = 0;

        //Prueba base de datos
        public void consulta()
        {
            SQLiteConnection conexion = new SQLiteConnection("Data Source = C:/Users/Lyonx/source/repos/Lereon/Lereon/registro.sqlite");
            conexion.Open();

            string consulta = "select * from trabajadores";
            SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
            SQLiteDataReader datos = comando.ExecuteReader();

            while (datos.Read())
            {
                string id = Convert.ToString(datos[0]);
                string usuario = datos.GetString(1);
                string contraseña = datos.GetString(2);

                Console.WriteLine("id: {0}, usuario: {1}, contraseña: {2}",id,usuario,contraseña);
            }


            conexion.Close();
        }

        private bool flag = false;
        private int tries = 3;
        private bool intento = false;
        //Al cargar este formulario se lanza el form de registro  y si es correcto el usuario y la contraseña se accede al menu
        private void Form1_Load(object sender, EventArgs e)
        {

            Autentificacion f = new Autentificacion();
           // f.infoError.ForeColor = Color.Red;
            f.aceptar.DialogResult = DialogResult.OK;
            do
            {
                try
                {
                    DialogResult res = f.ShowDialog();

                    switch (res)
                    {
                        case DialogResult.OK:

                            if (f.password.Text.Trim() == "carlos")
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

        private void calculadora_Click(object sender, EventArgs e)
        {
            calculadora c = new calculadora();
            c.Show();

        }

        private void plato2_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            cont++;
            avisos.Text = "Aviso("+cont+")";
        }
    }
}
