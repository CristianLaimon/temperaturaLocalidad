using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeTemperaturas
{
    internal class Temperatura
    {
        private Localidad localidad;
        private int temperaturaMaxima;
        private int temperaturaMinima;
        private int dia;
        private string mes;

        public Temperatura()
        {
            localidad = null;
            temperaturaMaxima = 0;
            temperaturaMinima = 0;
            dia = 0;
            mes = "";
        }

        public Temperatura(string m, int d, int tM, int tm, Localidad loc)
        {
            localidad = loc;
            temperaturaMaxima = tM;
            temperaturaMinima = tm;
            dia = d;
            mes = m;
        }

        internal Localidad Localidad { get => localidad; set => localidad = value; }
        public int TemperaturaMaxima { get => temperaturaMaxima; set => temperaturaMaxima = value; }
        public int TemperaturaMinima { get => temperaturaMinima; set => temperaturaMinima = value; }
        public int Dia { get => dia; set => dia = value; }
        public string Mes { get => mes; set => mes = value; }
    }
}
