using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperaturaLocalidad
{
    internal class Localidad
    {
        private string nomMunicipio;
        private string nombre;
        

        public Localidad()
        {
            nomMunicipio = string.Empty;
            nombre = string.Empty;
        }

        public Localidad(string nomMunicipio, string nombre)
        {
            this.nomMunicipio = nomMunicipio;
            this.nombre = nombre;
        }
    }
}
