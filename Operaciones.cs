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
                datagridview.Rows.Add(temp.Localidad ,temp.Mes, temp.Dia, temp.TemperaturaMaxima, temp.TemperaturaMinima);
            
        }
        
        public void Agregar(string m, int d, int tM, int tm, string nM, string nL)
        {
            lista.Add(new Temperatura(m, d, tM, tm, new Localidad(nM, nL)));
        }

        public void Eliminar(int indice)
        {
            lista.RemoveAt(indice);
        }
    }
}
