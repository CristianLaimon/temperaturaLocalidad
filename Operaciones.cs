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
            datagridview.RowCount = 1;
            foreach (Temperatura temp in lista)
                datagridview.Rows.Add(temp.Localidad.NombreMunicipio, temp.Localidad.NombreLocalidad, temp.Mes, temp.Dia, temp.TemperaturaMaxima, temp.TemperaturaMinima, temp.Promedio);
        }
        
        public void Agregar(string m, int d, double tM, double tm, string nM, string nL)
        {
            lista.Add(new Temperatura(m, d, tM, tm, new Localidad(nM, nL)));
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
