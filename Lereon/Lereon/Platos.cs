using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lereon
{
    class Platos
    {
        private string nombre_plato;
        private double precio;
        private string nombre_imagen;
        
        public string Nombre_plato { get => nombre_plato; set => nombre_plato = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Nombre_imagen { get => nombre_imagen; set => nombre_imagen = value; }
    }
}
