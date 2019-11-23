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
    public partial class Autentificacion : Form
    {
        public Autentificacion()
        {
            InitializeComponent();

        }

        private string directory = Environment.GetEnvironmentVariable("homepath");
        private List<Trabajador> trabajadores = new List<Trabajador>();
        Registro r;
        public string rutaIcon = Environment.GetEnvironmentVariable("homepath") + "/source/repos/Lereon/Lereon/Imagenes_interfaz/letter_l.ico";
        public string rutaImagen = Environment.GetEnvironmentVariable("homepath") + "/source/repos/Lereon/Lereon/Imagenes_interfaz/registro.png";
        public bool flag = false;
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




        //Al presionar el boton de registrarse sale una ventana en la cual se introduce los datos de un nuevo usuario de la aplicacion para poder usarla
        private void button1_Click(object sender, EventArgs e)
        {
            r = new Registro();
            r.aceptar_r.DialogResult = DialogResult.OK;
            DialogResult res = r.ShowDialog();

            do
            {

                if (res == DialogResult.OK)
                {

                    foreach (Trabajador t in trabajadores)
                    {
                        if (t.Nombre.Trim().ToUpper() == r.rusuario.Text.Trim().ToUpper())
                        {
                            r.infoRegistro.Text = "Ya existe un usuario con ese nombre";
                            flag = false;
                        }
                        else
                        {
                            flag = true;
                        }
                    }

                    if(string.IsNullOrEmpty(r.rusuario.Text) || string.IsNullOrEmpty(r.rcontrasenha.Text))
                    {
                        r.infoRegistro.Text = "Los campos usuario y contraseña deben ser rellenados";
                        flag = false;
                        break;
                    }
                    
                    if (flag)
                    {
                    insertarTrabajador();
                    }
                }
            } while (!flag);
        }

        private void Autentificacion_Load(object sender, EventArgs e)
        {
            Icon ico = Icon.ExtractAssociatedIcon(rutaIcon);
            this.Icon = ico;
            this.BackgroundImage = new Bitmap(rutaImagen);
        }
    }
}
