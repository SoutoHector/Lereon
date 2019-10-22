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
    public partial class Autentificacion : Form
    {
        public Autentificacion()
        {
            InitializeComponent();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        //Al presionar el boton de registrarse sale una ventana en la cual se introduce los datos de un nuevo usuario de la aplicacion para poder usarla
        private void button1_Click(object sender, EventArgs e)
        {
            Registro r = new Registro();
            r.aceptar_r.DialogResult = DialogResult.OK;
            DialogResult res = r.ShowDialog();
            switch (res)
            {
                //Datos de usuario y contraseña que se introducen a la tabla de la base de datos
            }
        }
    }
}
