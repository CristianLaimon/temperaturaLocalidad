using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDeTemperaturas
{
    internal class Operaciones
    {
        private List<Temperatura> lista;

        public Operaciones()
        {
            lista = new List<Temperatura>();
        }

        public List<Temperatura> Lista { get => lista; set => lista = value; }

        public void Mostrar(DataGridView datagridview)
        {
            datagridview.RowCount = 1;
            foreach (Temperatura temp in Lista)
                datagridview.Rows.Add(temp.Localidad.NombreMunicipio, temp.Localidad.NombreLocalidad, temp.Mes, temp.Dia, temp.TemperaturaMaxima, temp.TemperaturaMinima, temp.Promedio);
        }
        
        public void Agregar(string m, int d, double tM, double tm, string nM, string nL, double p)
        {
            Lista.Add(new Temperatura(m, d, tM, tm, new Localidad(nM, nL), p));
        }

        public void Eliminar(int indice, DataGridView datagridview)
        {
            Lista.RemoveAt(indice);
            datagridview.Rows.RemoveAt(indice);
        }

        public void PromedioMayor()
        {
            
        }

        public void PromedioMenor()
        {

        }
        public void RellenarTablaTesting()
        {
            lista.Add(new Temperatura("Enero", 2, 35, 10, new Localidad("Loreto", "Loreto"), 22.5));
            lista.Add(new Temperatura("Febrero", 10, 20, 1, new Localidad("La Paz", "El Centenario"), 10.5));
            lista.Add(new Temperatura("Marzo", 12, 10, -10, new Localidad("Comondú", "Ciudad Constitución"), 0));
            lista.Add(new Temperatura("Diciembre", 15, 15, 3, new Localidad("Loreto", "Loreto"), 9));
        }
    }
}
