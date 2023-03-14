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

        Operaciones operaciones = new Operaciones();

        int i;

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int d, tM, tm;
            string m, nM, nL;
            nM = comboBox1.Text;
            nL = comboBox2.Text;
            m = comboBox3.Text;
            d = (int)numericUpDown2.Value;
            tM = (int)numericUpDown3.Value;
            tm = (int)numericUpDown4.Value;
            operaciones.Agregar(m, d, tM, tm, nM, nL);
            operaciones.Mostrar(dataGridView1);
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string seleccion = comboBox1.Text;

            comboBox2.Items.Clear();

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
            comboBox2.Items.Add("Ciudad Constitución");
            comboBox2.Items.Add("Ciudad Insurgentes");
            comboBox2.Items.Add("Puerto San Carlos");
            comboBox2.Items.Add("Ciudad Insurgentes");
            comboBox2.Items.Add("Puerto Adolfo López Mateos");
            comboBox2.Items.Add("Villa Ignacio Zaragoza");
            comboBox2.Items.Add("Villa Morelos");

        }
        public void Mulege()
        {
            comboBox2.Items.Add("Santa Rosalía");
            comboBox2.Items.Add("Guerrero Negro");
            comboBox2.Items.Add("Villa Alberto Andrés Alvarado Arámburo");
            comboBox2.Items.Add("Heroica Mulegé");
            comboBox2.Items.Add("Bahía Tortugas");
            comboBox2.Items.Add("San Francisco");
            comboBox2.Items.Add("Bahía Asunción");
            comboBox2.Items.Add("Las Margaritas");
            comboBox2.Items.Add("Estero de la Bocana");
        }

        public void LaPaz()
        {
            comboBox2.Items.Add("La Paz");
            comboBox2.Items.Add("Todos Santos");
            comboBox2.Items.Add("El Centenario");
            comboBox2.Items.Add("Chametla");
            comboBox2.Items.Add("Melitón Albáñez Domínguez");
            comboBox2.Items.Add("Los Barriles");
            comboBox2.Items.Add("El sargento");
            comboBox2.Items.Add("General Juan Domínguez Cota");
        }
        public void LosCabos()
        {
            comboBox2.Items.Add("Cabo San Lucas");
            comboBox2.Items.Add("San José del Cabo");
            comboBox2.Items.Add("El Centenario");
            comboBox2.Items.Add("Miraflores");

        }

        public void Loreto()
        {
            comboBox2.Items.Add("Loreto");

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
