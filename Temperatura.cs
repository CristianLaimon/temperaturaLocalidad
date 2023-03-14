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
        private double temperaturaMaxima;
        private double temperaturaMinima;
        private int dia;
        private string mes;
        private double promedio;

        public Temperatura()
        {
            localidad = null;
            temperaturaMaxima = 0;
            temperaturaMinima = 0;
            dia = 0;
            mes = "";
            Promedio = 0;
        }

        public Temperatura(string m, int d, double tM, double tm, Localidad loc)
        {
            localidad = loc;
            temperaturaMaxima = tM;
            temperaturaMinima = tm;
            dia = d;
            mes = m;
            Promedio = 0;
        }

        internal Localidad Localidad { get => localidad; set => localidad = value; }
        public double TemperaturaMaxima { get => temperaturaMaxima; set => temperaturaMaxima = value; }
        public double TemperaturaMinima { get => temperaturaMinima; set => temperaturaMinima = value; }
        public int Dia { get => dia; set => dia = value; }
        public string Mes { get => mes; set => mes = value; }
        public double Promedio { get => promedio; set => promedio = value; }
    }
}
