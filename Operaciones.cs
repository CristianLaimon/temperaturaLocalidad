using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDeTemperaturas
{
    internal class Operaciones
    {
        List<Temperatura> lista = new List<Temperatura>(); 

        public void Mostrar(DataGridView datagridview)
        {
            datagridview.RowCount = 0;
            foreach (Temperatura temp in lista)
                datagridview.Rows.Add(temp.Localidad.NombreMunicipio, temp.Localidad.Nombre, temp.Mes, temp.Dia, temp.TemperaturaMaxima, temp.TemperaturaMinima, temp.Promedio);
        }
        
        public void Agregar(string mes, int dia, double tMax, double tMin, string nMunicipio, string nLocalidad)
        {
            lista.Add(new Temperatura(mes, dia, tMax, tMin, new Localidad(nMunicipio, nLocalidad)));
        }

        public void Eliminar(int indice, DataGridView datagridview)
        {
            lista.RemoveAt(indice);
            datagridview.Rows.RemoveAt(indice);
        }

        public double Promedio(double tM, double tm)
        {
            return (tM + tm) / 2;
        }
    }
}
