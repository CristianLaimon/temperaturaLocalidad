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
            if (m == "" || d == 0 || tM == 0 || tm == 0 || nM == "" || nL == "" || p == 0)
            {
                MessageBox.Show("Faltan campos por completar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (tM > tm)
                {
                    Lista.Add(new Temperatura(m, d, tM, tm, new Localidad(nM, nL), p));
                }
                if (tm > tM)
                {
                    MessageBox.Show("Temperatura minima incorrecta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void Eliminar(int indice, DataGridView datagridview)
        {
            if (indice < 0)
            {
                MessageBox.Show("No hay elementos para borrar");
            }
            else
            {
                Lista.RemoveAt(indice);
                datagridview.Rows.RemoveAt(indice);
            }
        }
    }
}
