using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDeTemperaturas
{
    internal class Localidad
    {
        private string nombreMunicipio;
        private string nombreLocalidad;

       public Localidad()
        {
            nombreMunicipio = "";
            nombreLocalidad = "";
        }
        
        public Localidad(string nM, string nL)
        {
            nombreMunicipio = nM;
            nombreLocalidad = nL;
        }

        public string NombreMunicipio { get => nombreMunicipio; set => nombreMunicipio = value; }
        public string NombreLocalidad { get => nombreLocalidad; set => nombreLocalidad = value; }
    }
}
