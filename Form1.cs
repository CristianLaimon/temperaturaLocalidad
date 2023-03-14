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
            //operaciones.Mostrar(nM, nL, m, d, tM, tm);
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string seleccion = comboBox1.Text;

            comboBox2.Items.Clear();

            if (seleccion == "Comondú")
            {
                Comondu();

            }
            if (seleccion == "La Paz")
            {
                LaPaz();

            }
        }

        public void Comondu()
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
            comboBox2.Items.Add("Parque");
        }
    }
}
