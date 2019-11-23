using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lereon
{
    /// <summary>
    /// Clase encarga de permitir el acceso 
    /// <marker>
    /// si cumplimenta los datos correctamente , es decir, que existen en la base de datos
    /// </marker>
    /// </summary>
    public partial class Autentificacion : Form
    {
        public Autentificacion()
        {
            InitializeComponent();
            consultaT();
        }

        //Clases
        Registro r;

        //Path
        private string directory = Environment.GetEnvironmentVariable("homepath");
        public string rutaIcon = Environment.GetEnvironmentVariable("homepath") + "/source/repos/Lereon/Lereon/Imagenes_interfaz/letter_l.ico";
        public string rutaImagen = Environment.GetEnvironmentVariable("homepath") + "/source/repos/Lereon/Lereon/Imagenes_interfaz/registro.png";

        //Variables
        private List<Trabajador> trabajadores = new List<Trabajador>();
        public bool flag = false;

        /// <summary>
        /// Función encargada de realizar una consulta a la tabla de los trabajadores para añadirla a una list
        /// </summary>
        public void consultaT()
        {
            SQLiteConnection conexion = new SQLiteConnection("Data Source = " + directory + "/source/repos/Lereon/Lereon/registro.sqlite");
            conexion.Open();

            string consulta = "select * from trabajadores";
            SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
            SQLiteDataReader datos = comando.ExecuteReader();

            while (datos.Read())
            {
                string id = Convert.ToString(datos[0]);
                string usuario = datos.GetString(1);
                string contraseña = datos.GetString(2);
                trabajadores.Add(new Trabajador() { Nombre = usuario, Password = contraseña });
            }
            conexion.Close();
        }
        public void insertarTrabajador()
        {
            SQLiteConnection conexion = new SQLiteConnection("Data Source = " + directory + "/source/repos/Lereon/Lereon/registro.sqlite");
            conexion.Open();

            SQLiteCommand comando = new SQLiteCommand();
            using (comando = new SQLiteCommand(conexion))
            {
                using (var transaction = conexion.BeginTransaction())
                {

                    comando.CommandText = "insert into trabajadores(Usuario,Contrasenha) values ('" + r.rusuario.Text.Trim().ToUpper() + "','" + r.rcontrasenha.Text.Trim().ToUpper() + "')";
                    comando.ExecuteNonQuery();

                    transaction.Commit();
                }
            }
            conexion.Close();
        }

        /// <summary>
        /// Lanza el formulario de registro 
        /// </summary>
        /// <param name="sender">botón</param>
        /// <param name="e">se encarga de lanzar el formulario de registro y de gestionar los datos que se hagan en el formulario </param>
        private void button1_Click(object sender, EventArgs e)
        {
            r = new Registro();
            r.aceptar_r.DialogResult = DialogResult.OK;
            r.cancelarRegistro.DialogResult = DialogResult.Cancel;

            do
            {
                flag = true;
                trabajadores.Clear();
                consultaT();
                DialogResult res = r.ShowDialog();
                switch (res)
                {
                    case DialogResult.OK:
                        foreach (Trabajador t in trabajadores)
                        {
                            if (t.Nombre.Trim().ToUpper() == r.rusuario.Text.Trim().ToUpper())
                            {
                                MessageBox.Show("El usuario ya existe, intente con otro diferente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                flag = false;
                            }
                        }

                        if (string.IsNullOrEmpty(r.rusuario.Text) || string.IsNullOrEmpty(r.rcontrasenha.Text))
                        {
                            MessageBox.Show("Ambos campos no pueden estar vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            flag = false;
                            break;
                        }

                        break;
                    case DialogResult.Cancel:
                        flag = false;
                        r.Close();
                        break;
                }
            } while (!flag);
            if (flag)
            {
                insertarTrabajador();
            }

        }

        /// <summary>
        /// Carga el formulario
        /// </summary>
        /// <param name="sender">formulario</param>
        /// <param name="e">carga el formulario</param>
        private void Autentificacion_Load(object sender, EventArgs e)
        {
            Icon ico = Icon.ExtractAssociatedIcon(rutaIcon);
            this.Icon = ico;
            this.BackgroundImage = new Bitmap(rutaImagen);
        }
    }
}
