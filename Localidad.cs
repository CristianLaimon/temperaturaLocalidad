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
        private string nombre;

       public Localidad()
        {
            nombreMunicipio = "";
            nombre = "";
        }
        
        public Localidad(string nM, string nL)
        {
            nombreMunicipio = nM;
            nombre = nL;
        }

        public string NombreMunicipio { get => nombreMunicipio; set => nombreMunicipio = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
