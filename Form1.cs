using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDeTemperaturas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Operaciones operaciones = new Operaciones(); //Se creo un objeto para poder realizar sus funciones. No se utilizó propiedades y valores estáticos

        int i;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operaciones.Agregar(comboMes.Text, (int)numDia.Value, (double)numTMax.Value, (double)numTMin.Value, comboMunicipio.Text, comboLocalidad.Text);
            operaciones.Mostrar(dataGridView1);
            RestablecerFormulario();

        }

        private void RestablecerFormulario()
        {
            comboMunicipio.Text = "";
            comboLocalidad.Text = "";
            comboMes.Text = "";
            numDia.Value = 0;
            numTMax.Value = 0;
            numTMin.Value = 0;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string seleccion = comboMunicipio.Text;

            comboLocalidad.Items.Clear();

            if (seleccion == "Comondú")
            {
                Comondu();

            }
            if (seleccion == "Mulegé")
            {
                Mulege();

            }
            if (seleccion == "La Paz")
            {
                LaPaz();

            }
            if (seleccion == "Los Cabos")
            {
                LosCabos();

            }
            if (seleccion == "Loreto")
            {
                Loreto();

            }
        }

        public void Comondu()
        {
            comboLocalidad.Items.Add("Ciudad Constitución");
            comboLocalidad.Items.Add("Ciudad Insurgentes");
            comboLocalidad.Items.Add("Puerto San Carlos");
            comboLocalidad.Items.Add("Ciudad Insurgentes");
            comboLocalidad.Items.Add("Puerto Adolfo López Mateos");
            comboLocalidad.Items.Add("Villa Ignacio Zaragoza");
            comboLocalidad.Items.Add("Villa Morelos");

        }
        public void Mulege()
        {
            comboLocalidad.Items.Add("Santa Rosalía");
            comboLocalidad.Items.Add("Guerrero Negro");
            comboLocalidad.Items.Add("Villa Alberto Andrés Alvarado Arámburo");
            comboLocalidad.Items.Add("Heroica Mulegé");
            comboLocalidad.Items.Add("Bahía Tortugas");
            comboLocalidad.Items.Add("San Francisco");
            comboLocalidad.Items.Add("Bahía Asunción");
            comboLocalidad.Items.Add("Las Margaritas");
            comboLocalidad.Items.Add("Estero de la Bocana");
        }

        public void LaPaz()
        {
            comboLocalidad.Items.Add("La Paz");
            comboLocalidad.Items.Add("Todos Santos");
            comboLocalidad.Items.Add("El Centenario");
            comboLocalidad.Items.Add("Chametla");
            comboLocalidad.Items.Add("Melitón Albáñez Domínguez");
            comboLocalidad.Items.Add("Los Barriles");
            comboLocalidad.Items.Add("El sargento");
            comboLocalidad.Items.Add("General Juan Domínguez Cota");
        }
        public void LosCabos()
        {
            comboLocalidad.Items.Add("Cabo San Lucas");
            comboLocalidad.Items.Add("San José del Cabo");
            comboLocalidad.Items.Add("El Centenario");
            comboLocalidad.Items.Add("Miraflores");

        }

        public void Loreto()
        {
            comboLocalidad.Items.Add("Loreto");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            operaciones.Eliminar(i, dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
        }
    }
}
