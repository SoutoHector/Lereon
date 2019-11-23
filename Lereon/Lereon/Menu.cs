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
using System.IO;
using System.Drawing.Imaging;

namespace Lereon
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            consultaT();
            consultaP();
        }

        private string directory = Environment.GetEnvironmentVariable("homepath");
        Registro r;
        AñadirPlato pl;
        List<List<Platos>> multiComandas = new List<List<Platos>>();
        private List<Trabajador> trabajadores = new List<Trabajador>();
        private List<Platos> platos = new List<Platos>();
        private List<Platos> platosComanda = new List<Platos>();
        ListBox listT;
        ListBox listP;
        private TextBox mostrarMenu = new TextBox();
        private TextBox mostrarCalculadora = new TextBox();
        private TextBox caja = new TextBox();
        Label lbCalc = new Label();
        Label lbMen = new Label();
        Label lbCaj = new Label();
        Label lbOpc = new Label();
        Label lbComan = new Label();
        Label lbp = new Label();
        Panel panelMenu = new Panel(), panelCalculadora = new Panel(), panelComandas = new Panel(), panelCaja = new Panel(), panelOpciones = new Panel();
        ComandaInfo datosComanda;
        public int cont = 0;
        private Button boton;
        Button botonEnviarComanda;
        private Plato platoNuevo;
        public int xb, yb, yz, xp, yp, xt = 83, yt = 69;
        public int sizetx = 166, sizety = 20, sizelbx = 100, sizelby = 32;
        public int conta;
        public bool fmenu = false, fcalculadora = false, fComandas = false, fCaja = false, fOpciones = false;
        public string rutaImagen = Environment.GetEnvironmentVariable("homepath") + "/source/repos/Lereon/Lereon/imagenes_platos/";
        public string rutaIcon = Environment.GetEnvironmentVariable("homepath") + "/source/repos/Lereon/Lereon/Imagenes_interfaz/letter_l.ico";
        public string rutaSplit1 = Environment.GetEnvironmentVariable("homepath") + "/source/repos/Lereon/Lereon/Imagenes_interfaz/wood_split1.png";
        public string rutaSplit2 = Environment.GetEnvironmentVariable("homepath") + "/source/repos/Lereon/Lereon/Imagenes_interfaz/wood_split2.png";
        public double total = 0;
        public string input = "";
        public char operador = ' ';
        public double resultado = 0;
        public double totalPagadoComanda = 0;
        public bool flagresultado = false, flagpuntos = true;
        public string filePath;


        /**
         * Realiza una consulta a la base de datos de los trabajadores
         * */
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
                Console.WriteLine("id: {0}, usuario: {1}, contraseña: {2}", id, usuario, contraseña);
            }


            conexion.Close();
        }

        /**
        * Realiza una consulta a la base de datos de los platos
        * */
        public void consultaP()
        {
            SQLiteConnection conexion = new SQLiteConnection("Data Source = " + directory + "/source/repos/Lereon/Lereon/menu_platos.sqlite");
            conexion.Open();

            string consulta = "select * from menu";
            SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
            SQLiteDataReader datos = comando.ExecuteReader();

            while (datos.Read())
            {
                string nombre_plato = datos.GetString(0);
                double precio_plato = datos.GetDouble(datos.GetOrdinal("precio"));
                string nombre_imagen = datos.GetString(datos.GetOrdinal("nombreImagen"));
                platos.Add(new Platos() { Nombre_plato = nombre_plato, Precio = precio_plato, Nombre_imagen = nombre_imagen });
                Console.WriteLine("nombre_plato: {0}, precio_plato: {1}, nombre_imagen: {2}", nombre_plato, precio_plato, nombre_imagen);
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
                    tries--;
                    switch (res)
                    {
                        case DialogResult.OK:

                            foreach (Trabajador trabajadorr in trabajadores)
                            {

                                if (f.usuarior.Text.Trim().ToUpper() == trabajadorr.Nombre.ToUpper() && f.passwordr.Text.Trim().ToUpper() == trabajadorr.Password.ToUpper())
                                {
                                    intento = true;
                                    MessageBox.Show("Password correcto", "Bien", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    if (f.usuarior.Text.Trim().ToUpper() == "ADMIN" && f.passwordr.Text.Trim() == "1981")
                                    {
                                        opciones.Enabled = true;
                                    }

                                    lbCalc.Location = new Point(sizelbx, sizelby);
                                    lbCaj.Location = new Point(sizelbx, sizelby);
                                    lbComan.Location = new Point(sizelbx, sizelby);
                                    lbMen.Location = new Point(sizelbx, sizelby);
                                    lbOpc.Location = new Point(sizelbx, sizelby);
                                    mostrarMenu.Location = new Point(xt, yt);
                                    mostrarMenu.Size = new Size(sizetx, sizety);
                                    mostrarMenu.Enabled = false;
                                    mostrarCalculadora.Location = new Point(xt, yt);
                                    mostrarCalculadora.Size = new Size(sizetx, sizety);
                                    mostrarCalculadora.Enabled = false;
                                    Icon ico = Icon.ExtractAssociatedIcon(rutaIcon);
                                    this.Icon = ico;
                                    splitContainer1.Panel1.BackgroundImage = new Bitmap(rutaSplit1);
                                    lbp = new Label();
                                    
                                    lbp.Font = new Font("", 16, FontStyle.Bold);
                                    lbp.Text = "Bienvenido, por favor escoja una de las opciones disposibles que se encuentran en el otro panel";
                                    lbp.Location = new Point(37, 114);
                                    lbp.ForeColor = Color.Black;
                                    lbp.BackColor = Color.Transparent;
                                    lbp.Width = 250;
                                    lbp.Height = 300;
                                    splitContainer1.Panel2.Controls.Add(lbp);


                                    //Comentado por el alto gasto de memoria y ralentización de la aplicación
                                    //splitContainer1.Panel2.BackgroundImage = new Bitmap(rutaSplit2);
                                    //panelCaja.BackgroundImage = new Bitmap(rutaSplit2);
                                    //panelCalculadora.BackgroundImage = new Bitmap(rutaSplit2);
                                    //panelComandas.BackgroundImage = new Bitmap(rutaSplit2);
                                    //panelMenu.BackgroundImage = new Bitmap(rutaSplit2);
                                    //panelOpciones.BackgroundImage = new Bitmap(rutaSplit2);
                                    break;
                                }
                                else
                                {


                                    f.infoError.Text = "Error al introducir el password, \nte quedan: " + tries + " intentos";
                                    if (tries == 0)
                                    {
                                        MessageBox.Show("El telefono se apagara", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        Environment.Exit(0); //Cierra bien no usar ni application.exit ni this.close()
                                    }
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
            lbp.Visible = false;
            if (fcalculadora == false)
            {
                panelMenu.Visible = false;
                this.splitContainer1.Panel2.Controls.Add(panelCalculadora);
                panelCalculadora.Dock = DockStyle.Fill;
                fcalculadora = true;
                panelCalculadora.Controls.Add(lbCalc);
                lbCalc.Text = "Calculadora";
                lbCalc.AutoSize = true;
                lbCalc.ForeColor = Color.Black;
                lbCalc.BackColor = Color.Transparent;
                lbCalc.Font = new Font("", 16, FontStyle.Bold);
                xb = 65;
                yb = 150;
                yz = 150;
                conta = 0;
                for (int i = 1; i <= 17; i++)
                {
                    boton = new Button();
                    if (i < 10) boton.Text = i.ToString();
                    if (i == 10) boton.Text = "0";
                    if (i == 11) boton.Text = ",";
                    if (i == 12) boton.Text = "C";
                    if (i == 13) boton.Text = "=";
                    if (i == 14) boton.Text = "+";
                    if (i == 15) boton.Text = "-";
                    if (i == 16) boton.Text = "*";
                    if (i == 17) boton.Text = "/";
                    boton.Tag = boton.Text;
                    boton.Enabled = true;
                    if (i != 12)
                    {
                        this.boton.Click += new EventHandler(calcular);
                    }
                    else
                    {
                        this.boton.Click += new EventHandler(reset);
                    }
                    if (i < 13)
                    {
                        boton.Location = new Point(xb, yb);
                        boton.Size = new Size(40, 20);
                        if (i % 3 == 0)
                        {
                            xb = 65;
                            yb += 60;
                        }
                        else
                        {
                            xb += 50;
                        }
                    }
                    else
                    {
                        if (i == 13)
                        {
                            boton.Location = new Point(xb, yb);
                            boton.Size = new Size(200, 20);
                        }

                        if (i > 13)
                        {
                            boton.Location = new Point(220, yz);
                            boton.Size = new Size(40, 20);
                            yz += 60;
                        }
                    }
                    panelCalculadora.Controls.Add(boton);
                }


                panelCalculadora.Controls.Add(mostrarCalculadora);
            }

            panelMenu.Visible = false;
            panelCaja.Visible = false;
            panelComandas.Visible = false;
            panelOpciones.Visible = false;
            panelCalculadora.Visible = true;



        }

        //Al hacer click en uno de los botones se pasa el valor de los botones 
        private void calcular(Object sender, EventArgs e)
        {


            try
            {
                switch (((Button)sender).Text)
                {



                    case "+":
                        mostrarCalculadora.Text = resultado.ToString();
                        if (flagresultado)
                        {

                        }
                        else
                        {
                            resultado = Convert.ToDouble(input);

                        }
                        input = string.Empty;
                        operador = '+';
                        flagpuntos = true;
                        break;
                    case "-":
                        mostrarCalculadora.Text = resultado.ToString();
                        if (flagresultado)
                        {

                        }
                        else
                        {
                            resultado = Convert.ToDouble(input);

                        }
                        input = string.Empty;
                        operador = '-';
                        flagpuntos = true;
                        break;
                    case "*":
                        mostrarCalculadora.Text = resultado.ToString();
                        if (flagresultado)
                        {

                        }
                        else
                        {
                            resultado = Convert.ToDouble(input);

                        }
                        input = string.Empty;
                        operador = '*';
                        flagpuntos = true;
                        break;
                    case "/":
                        mostrarCalculadora.Text = resultado.ToString();
                        if (flagresultado)
                        {

                        }
                        else
                        {
                            resultado = Convert.ToDouble(input);

                        }
                        input = string.Empty;
                        operador = '/';
                        flagpuntos = true;
                        break;
                    case "=":
                        if (operador != ' ')
                        {
                            switch (operador)
                            {
                                case '+':
                                    resultado = resultado + Convert.ToDouble(input);
                                    break;
                                case '-':
                                    resultado = resultado - Convert.ToDouble(input);
                                    break;
                                case '*':
                                    resultado = resultado * Convert.ToDouble(input);
                                    break;
                                case '/':
                                    if (Convert.ToDouble(input) == 0.00 || Convert.ToDouble(input) == 0)
                                    {
                                        mostrarCalculadora.Text = "Error";
                                        resultado = 0;
                                        input = " ";
                                    }
                                    else
                                    {
                                        resultado = resultado / Convert.ToDouble(input);

                                    }
                                    break;
                            }
                        }
                        mostrarCalculadora.Text = resultado.ToString();
                        flagresultado = true;
                        flagpuntos = true;
                        break;
                    default:
                        if (((Button)sender).Text == ",")
                        {
                            if (flagpuntos)
                            {
                                mostrarCalculadora.Text = "";
                                input += ((Button)sender).Text;
                                mostrarCalculadora.Text += input;
                                flagpuntos = false;
                            }
                        }
                        else
                        {
                            mostrarCalculadora.Text = "";
                            input += ((Button)sender).Text;
                            mostrarCalculadora.Text += input;
                        }
                        break;
                }
            }
            catch (FormatException)
            {
                mostrarCalculadora.Text = "No utilice dos operadores segudidos";
                resultado = 0;
            }
        }

        public void reset(Object sender, EventArgs e)
        {
            mostrarCalculadora.Clear();
            flagresultado = false;
            input = " ";
            resultado = 0;
            operador = ' ';
        }

        private void totalCaja_Click(object sender, EventArgs e)
        {
            if (fCaja == false)
            {
                lbp.Visible = false;
                panelMenu.Visible = false;
                panelCalculadora.Visible = false;
                this.splitContainer1.Panel2.Controls.Add(panelCaja);
                panelCaja.Dock = DockStyle.Fill;
                fCaja = true;
                lbCaj.Text = "Caja del día";
                lbCaj.ForeColor = Color.Black;
                lbCaj.BackColor = Color.Transparent;
                lbCaj.Font = new Font("", 16, FontStyle.Bold);
                lbCaj.AutoSize = true;
                panelCaja.Controls.Add(lbCaj);
                caja = new TextBox();
                caja.Enabled = false;
                panelCaja.Controls.Add(caja);
                caja.Location = new Point(53, 134);
                caja.Size = new Size(190, 20);
                boton = new Button();
                panelCaja.Controls.Add(boton);
                boton.Click += new EventHandler(reinicio);
                boton.Location = new Point(125, 196);
                boton.Text = "Reiniciar";
                Label euro = new Label();
                panelCaja.Controls.Add(euro);
                euro.Text = "€";
                euro.ForeColor = Color.Black;
                euro.BackColor = Color.Transparent;
                euro.Location = new Point(258, 136);

            }
            caja.Text = totalPagadoComanda.ToString();
            panelCaja.Visible = true;
            panelCalculadora.Visible = false;
            panelMenu.Visible = false;
            panelComandas.Visible = false;
            panelOpciones.Visible = false;
        }

        public void reinicio(Object sender, EventArgs e)
        {
            totalPagadoComanda = 0;
            caja.Text = totalPagadoComanda.ToString();
        }

        private void comandas_Click(object sender, EventArgs e)
        {
            lbp.Visible = false;
            panelComandas.Visible = true;
            panelComandas.AutoScroll = true;
            panelComandas.Controls.Clear();
            int xdc = 26;
            int ydc = 100;
            int contcomandas = 1;
            double precioTotall;
            panelCaja.Visible = false;
            panelCalculadora.Visible = false;
            panelMenu.Visible = false;
            panelOpciones.Visible = false;
            splitContainer1.Panel2.Controls.Add(panelComandas);
            panelComandas.Dock = DockStyle.Fill;
            for (int i = 0; i < cont; i++)
            {
                precioTotall = 0;
                datosComanda = new ComandaInfo();
                datosComanda.Location = new Point(xdc, ydc);
                datosComanda.Tag = i;
                datosComanda.botonPagar.Tag = i;
                datosComanda.botonEliminar.Tag = i;
                panelComandas.Controls.Add(datosComanda);
                datosComanda.botonPagar.Click += new EventHandler(pagoComanda);
                datosComanda.botonEliminar.Click += new EventHandler(eliminarComanda);
                datosComanda.TextComanda += "Pedido";
                datosComanda.TextComanda += "\r\n";
                datosComanda.TextComanda += "------";
                datosComanda.TextComanda += "\r\n";
                foreach (Platos p in multiComandas.ElementAt(i))
                {
                    datosComanda.TextComanda += String.Format("{0} {1} €", p.Nombre_plato, p.Precio);
                    datosComanda.TextComanda += "\r\n";
                    precioTotall += p.Precio;
                }
                datosComanda.TextComanda += String.Format("Precio total: {0} €", precioTotall);
                datosComanda.TextNComanda = "Comanda " + (i + 1);
                xdc += 150;

                if (contcomandas % 2 == 0)
                {
                    xdc = 26;
                    ydc += 200;
                }
                contcomandas++;
            }

        }

        public void pagoComanda(Object sender, EventArgs e)
        {
            foreach (Control c in panelComandas.Controls)
            {
                if (c.Tag.ToString() == ((Button)sender).Tag.ToString())
                {
                    foreach (Platos p in multiComandas.ElementAt(Convert.ToInt32(c.Tag)))
                    {
                        totalPagadoComanda += p.Precio;
                    }
                    cont--;
                    comandas.Text = "Comandas" + "(" + cont + ")";
                    multiComandas.RemoveAt(Convert.ToInt32(c.Tag));
                    panelComandas.Controls.Remove(c);
                }
            }
            comandas.PerformClick();
            if (cont == 0)
            {
                comandas.Enabled = false;
            }
        }


        public void eliminarComanda(Object sender, EventArgs e)
        {
            foreach (Control c in panelComandas.Controls)
            {
                if (c.Tag.ToString() == ((Button)sender).Tag.ToString())
                {
                    cont--;
                    comandas.Text = "Comandas" + "(" + cont + ")";
                    multiComandas.RemoveAt(Convert.ToInt32(c.Tag));
                    panelComandas.Controls.Remove(c);

                }
            }
            comandas.PerformClick();
            if (cont == 0)
            {
                comandas.Enabled = false;
            }
        }


        //Importante añadir primerl el elemento al group box y luego aplicarle el tamaño y la localizacion
        private void menus_Click(object sender, EventArgs e)
        {
            panelMenu.Controls.Clear();
            lbp.Visible = false;
            platos.Clear();
            consultaP();
            panelCalculadora.Visible = false;
            panelCaja.Visible = false;
            panelComandas.Visible = false;
            panelOpciones.Visible = false;
            panelMenu.Visible = true;
            panelCalculadora.Visible = false;
            this.splitContainer1.Panel2.Controls.Add(panelMenu);
            panelMenu.Dock = DockStyle.Fill;
            fmenu = true;
            Bitmap imagen;
            lbMen.Text = "Precio total";
            lbMen.ForeColor = Color.Black;
            lbMen.BackColor = Color.Transparent;
            lbMen.Font = new Font("", 16, FontStyle.Bold);
            lbMen.AutoSize = true;
            panelMenu.Controls.Add(lbMen);
            GroupBox muestraMenu = new GroupBox();
            muestraMenu.BackColor = Color.Transparent;
            muestraMenu.Location = new Point(14, 123);
            muestraMenu.Size = new Size(294, 289);
            muestraMenu.Text = "Platos";
            panelMenu.Controls.Add(muestraMenu);
            Panel panel_menus = new Panel();
            muestraMenu.Controls.Add(panel_menus);
            panel_menus.Location = new Point(3, 16);
            panel_menus.Size = new Size(288, 270);
            panel_menus.Dock = DockStyle.Fill;
            panel_menus.AutoScroll = true;
            xp = 10;
            yp = 10;
            foreach (Platos platoss in platos)
            {
                conta++;
                platoNuevo = new Plato();
                panel_menus.Controls.Add(platoNuevo);
                platoNuevo.TextLbln = platoss.Nombre_plato;
                platoNuevo.TextLblm = platoss.Precio.ToString() + " €";
                try
                {
                    imagen = new Bitmap(rutaImagen + platoss.Nombre_imagen);

                }
                catch (ArgumentException)
                {
                    imagen = new Bitmap(rutaImagen + "noimagen.png");
                }
                platoNuevo.imagenPlato.SizeMode = PictureBoxSizeMode.StretchImage;
                platoNuevo.imagenPlato.Image = (Image)imagen;
                platoNuevo.Location = new Point(xp, yp);
                platoNuevo.Click += new EventHandler(sumaComanda);
                platoNuevo.Tag = platoss;
                xp += 140;
                if (conta % 2 == 0)
                {
                    xp = 10;
                    yp += 250;
                }
            }

            botonEnviarComanda = new Button();
            botonEnviarComanda.Location = new Point(111, 418);
            botonEnviarComanda.Size = new Size(75, 23);
            botonEnviarComanda.Text = "Enviar comanda";
            botonEnviarComanda.Click += new EventHandler(enviarComanda);
            if (comandas.Enabled == false)
            {
                botonEnviarComanda.Enabled = false;
            }
            panelMenu.Controls.Add(botonEnviarComanda);
            panelMenu.Controls.Add(mostrarMenu);






        }

        private void sumaComanda(Object sender, EventArgs e)
        {
            botonEnviarComanda.Enabled = true;

            Platos p = new Platos();
            p = (Platos)((Plato)sender).Tag;

            total += Convert.ToDouble(p.Precio);
            mostrarMenu.Text = total.ToString();
            platosComanda.Add(p);


        }

        public void enviarComanda(Object sender, EventArgs e)
        {
            botonEnviarComanda.Enabled = false;
            cont++;
            multiComandas.Add(platosComanda);
            platosComanda = new List<Platos>();
            comandas.Text = "Comandas" + "(" + cont + ")";
            total = 0;
            mostrarMenu.Text = "0";
            comandas.Enabled = true;


        }

        private void Opciones_Click(object sender, EventArgs e)
        {
            lbp.Visible = false;
            panelOpciones.Controls.Clear();
            panelMenu.Visible = false;
            panelComandas.Visible = false;
            panelCaja.Visible = false;
            panelCalculadora.Visible = false;
            panelOpciones.Visible = true;
            panelOpciones.Controls.Add(lbOpc);
            trabajadores.Clear();
            consultaT();
            platos.Clear();
            consultaP();
            lbOpc.Text = "Opciones";
            lbOpc.AutoSize = true;
            lbOpc.Font = new Font("", 16, FontStyle.Bold);
            lbOpc.ForeColor = Color.Black;
            panelOpciones.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(panelOpciones);
            Label lb1 = new Label();
            Label lb2 = new Label();
            lb1.AutoSize = true;
            lb1.Text = "Lista de trabajadores:";
            lb1.Location = new Point(22, 103);
            lb2.AutoSize = true;
            lb2.Location = new Point(22, 285);
            lb2.Text = "Lista de platos:";
            panelOpciones.Controls.Add(lb1);
            panelOpciones.Controls.Add(lb2);
            listT = new ListBox();
            listP = new ListBox();
            listT.Size = new Size(261, 97);
            listP.Size = new Size(261, 97);
            listT.Location = new Point(25, 131);
            listP.Location = new Point(25, 323);
            panelOpciones.Controls.Add(listT);
            panelOpciones.Controls.Add(listP);
            listT.SelectionMode = SelectionMode.One;
            listP.SelectionMode = SelectionMode.One;
            Button btnat = new Button();
            Button btnet = new Button();
            Button btnap = new Button();
            Button btnep = new Button();
            btnat.Location = new Point(39, 234);
            btnet.Location = new Point(157, 234);
            btnap.Location = new Point(39, 427);
            btnep.Location = new Point(157, 427);
            btnat.Text = "Añadir";
            btnat.Tag = "at";
            btnap.Text = "Añadir";
            btnap.Tag = "ap";
            btnet.Text = "Eliminar";
            btnet.Tag = "et";
            btnep.Text = "Eliminar";
            btnep.Tag = "ep";
            panelOpciones.Controls.Add(btnat);
            panelOpciones.Controls.Add(btnet);
            panelOpciones.Controls.Add(btnap);
            panelOpciones.Controls.Add(btnep);
            btnat.Click += new EventHandler(añadirTrabajador);
            btnet.Click += new EventHandler(quitarTrabajador);
            btnap.Click += new EventHandler(añadirPlato);
            btnep.Click += new EventHandler(quitarPlato);
            string filaTrabajador = "";
            string filaPlato = "";
            foreach (Trabajador t in trabajadores)
            {
                if (t.Nombre.Trim().ToUpper() == "ADMIN")
                {

                }
                else
                {
                    filaTrabajador = String.Format("\r\n Usuario: {0}, Contraseña {1}", t.Nombre, t.Password);
                    listT.Items.Add(filaTrabajador);
                }
            }
            foreach (Platos p in platos)
            {
                filaPlato = String.Format("\r\n Nombre del plato: {0}, precio: {1}", p.Nombre_plato, p.Precio);
                listP.Items.Add(filaPlato);
            }

        }

        public void añadirTrabajador(Object sender, EventArgs e)
        {
            r = new Registro();
            r.aceptar_r.DialogResult = DialogResult.OK;
            DialogResult res = r.ShowDialog();

            if (res == DialogResult.OK)
            {
                insertarTrabajador();
            }
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

                    comando.CommandText = "insert into trabajadores(Usuario,Contrasenha) values ('" + r.rusuario.Text.Trim() + "','" + r.rcontrasenha.Text.Trim() + "')";
                    comando.ExecuteNonQuery();


                    transaction.Commit();
                }
            }
            conexion.Close();
        }



        public void quitarTrabajador(Object sender, EventArgs e)
        {
            if (listT.Items.Count > 0 && listT.SelectedItem != null)
            {
                eliminarTrabajador();
                listT.Items.Remove(listT.SelectedItem);
            }
        }

        public void eliminarTrabajador()
        {
            string text = listT.GetItemText(listT.SelectedItem);
            Console.WriteLine(text);
            int iend = text.IndexOf(",");
            string unombreTrabajador = text.Substring(12, iend - 12);
            Console.WriteLine(unombreTrabajador);

            SQLiteConnection conexion = new SQLiteConnection("Data Source = " + directory + "/source/repos/Lereon/Lereon/registro.sqlite");
            conexion.Open();
            SQLiteCommand comando = new SQLiteCommand();
            using (comando = new SQLiteCommand(conexion))
            {
                using (var transaction = conexion.BeginTransaction())
                {

                    comando.CommandText = "delete from trabajadores where Usuario like '" + unombreTrabajador + "'";
                    comando.ExecuteNonQuery();


                    transaction.Commit();
                }
            }
            conexion.Close();
        }


        public void añadirPlato(Object sender, EventArgs e)
        {


            pl = new AñadirPlato();
            pl.btnAceptarPlato.DialogResult = DialogResult.OK;
            DialogResult res = pl.ShowDialog();


            if (res == DialogResult.OK)
            {
                if (pl.precioPlato.Text.Contains(","))
                {
                    pl.precioPlato.Text = pl.precioPlato.Text.Replace(',', '.');
                }
                insertarPlato();
            }

        }

        public void insertarPlato()
        {
            SQLiteConnection conexion = new SQLiteConnection("Data Source = " + directory + "/source/repos/Lereon/Lereon/menu_platos.sqlite");
            conexion.Open();
            SQLiteCommand comando = new SQLiteCommand();
            var result = "";
            if (pl.pictureBox1.Tag.ToString() == "")
            {
                result = "noimagen.png";

            }
            else
            {
                filePath = pl.pictureBox1.Tag.ToString();
                result = filePath.Substring(filePath.LastIndexOf('\\') + 1);
            }


            using (comando = new SQLiteCommand(conexion))
            {
                using (var transaction = conexion.BeginTransaction())
                {

                    comando.CommandText = "insert into menu(nombre,precio,nombreImagen) values ('" + pl.nombrePlato.Text.Trim() + "'," + pl.precioPlato.Text.Trim() + ",'" + result + "')";
                    comando.ExecuteNonQuery();


                    transaction.Commit();
                }
            }
            conexion.Close();

            if (result != "noimagen.png" && !File.Exists(rutaImagen+result))
            {
            try
            {
                
                File.Copy(filePath, rutaImagen + result);
            }
            catch (NullReferenceException e)
            {
            }
            }


        }


        public void quitarPlato(Object sender, EventArgs e)
        {
            if (listP.Items.Count > 0 && listP.SelectedItem != null)
            {
                retirarPlato();
                listP.Items.Remove(listP.SelectedItem);
            }
        }

        public void retirarPlato()
        {
            string text = listP.GetItemText(listP.SelectedItem);
            Console.WriteLine(text);
            int iend = text.IndexOf(",");
            string nombrePlato = text.Substring(21, iend - 21);
            Console.WriteLine(nombrePlato);
            SQLiteConnection conexion = new SQLiteConnection("Data Source = " + directory + "/source/repos/Lereon/Lereon/menu_platos.sqlite");
            conexion.Open();
            SQLiteCommand comando = new SQLiteCommand();
            using (comando = new SQLiteCommand(conexion))
            {
                using (var transaction = conexion.BeginTransaction())
                {

                    comando.CommandText = "delete from menu where nombre like '" + nombrePlato + "'";
                    comando.ExecuteNonQuery();


                    transaction.Commit();
                }
            }
            conexion.Close();
            var filePath = rutaImagen + nombrePlato + ".png";
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    }
}
