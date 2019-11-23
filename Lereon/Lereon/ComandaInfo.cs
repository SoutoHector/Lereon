using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lereon
{
    public partial class ComandaInfo : UserControl
    {
        public ComandaInfo()
        {
            InitializeComponent();
        }

     

        [Category("Appearance")]
        [Description("Texto asociado a la comanda")]
        public string TextNComanda
        {
            set
            {
                nComanda.Text = value;
            }
            get
            {
                return nComanda.Text;
            }
        }



        [Category("Appearance")]
        [Description("Texto asociado a la comanda")]
        public string TextComanda
        {
            set
            {
                infoComanda.Text = value;
            }
            get
            {
                return infoComanda.Text;
            }
        }


        public void botonPagar_Click(object sender, EventArgs e)
        {
           
        }

        public void botonEliminar_Click(object sender, EventArgs e)
        {
        }
    }
}
