using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void button1_Click(object sender, EventArgs e)
        {
            int d;
            double tM, tm, p;
            string m, nM, nL;
            nM = comboBox1.Text;
            nL = comboBox2.Text;
            m = comboBox3.Text;
            d = (int)numericUpDown2.Value;
            tM = (double)numericUpDown3.Value;
            tm = (double)numericUpDown4.Value;
            p = (tM + tm) / 2;
            operaciones.Agregar(m, d, tM, tm, nM, nL, p);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            label14.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double promedios = 0;

            if (radioButton1.Checked == true)
            {
                for(int k = 0; k < dataGridView1.Rows.Count-1; k++)
                {
                    promedios += (double)dataGridView1.Rows[k].Cells[4].Value;
                }
                promedios/= dataGridView1.Rows.Count-1;
                
                label7.Text = promedios.ToString();
            }
            radioButton1.Checked = false;

            if (radioButton2.Checked == true)
            {
                for (int k = 0; k < dataGridView1.Rows.Count - 1; k++)
                {
                    promedios += (double)dataGridView1.Rows[k].Cells[5].Value;
                }
                promedios/= dataGridView1.Rows.Count-1;
                label8.Text = promedios.ToString();
            }
            radioButton2.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                double menor = (double)dataGridView1.Rows[0].Cells[6].Value;
                double mayor = (double)dataGridView1.Rows[0].Cells[6].Value;

                for (int d = 0; d < dataGridView1.Rows.Count - 1; d++)
                {
                    if ((double)(dataGridView1.Rows[d].Cells[6].Value) > mayor)
                    {
                        mayor = (double)(dataGridView1.Rows[d].Cells[6].Value);
                    }
                    if ((double)(dataGridView1.Rows[d].Cells[6].Value) < menor)
                    {
                        menor = (double)(dataGridView1.Rows[d].Cells[6].Value);
                    }
                }
                for (int d = 0; d < dataGridView1.Rows.Count - 1; d++)
                {
                    if ((double)(dataGridView1.Rows[d].Cells[6].Value) == mayor)
                    {
                        label9.Text = dataGridView1.Rows[d].Cells[1].Value.ToString();
                    }
                }
            }
            radioButton3.Checked = false;

            if (radioButton4.Checked == true)
            {
                double menor = (double)dataGridView1.Rows[0].Cells[6].Value;
                double mayor = (double)dataGridView1.Rows[0].Cells[6].Value;

                for (int d = 0; d < dataGridView1.Rows.Count - 1; d++)
                {
                    if ((double)(dataGridView1.Rows[d].Cells[6].Value) > mayor)
                    {
                        mayor = (double)(dataGridView1.Rows[d].Cells[6].Value);
                    }
                    if ((double)(dataGridView1.Rows[d].Cells[6].Value) < menor)
                    {
                        menor = (double)(dataGridView1.Rows[d].Cells[6].Value);
                    }
                }
                for (int d = 0; d < dataGridView1.Rows.Count - 1; d++)
                {
                    if ((double)(dataGridView1.Rows[d].Cells[6].Value) == menor)
                    {
                        label10.Text = dataGridView1.Rows[d].Cells[1].Value.ToString();
                    }
                }
            }
            radioButton4.Checked = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string mes = comboBox4.Text;
            int dia = (int)numericUpDown1.Value;
            if (dia > 0)
            {
                for (int d = 0; d < dataGridView1.Rows.Count - 1; d++)
                {
                    if (mes == (string)dataGridView1.Rows[d].Cells[2].Value && dia == (int)dataGridView1.Rows[d].Cells[3].Value)
                    {
                        label14.Text = dataGridView1.Rows[d].Cells[6].Value.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("Fecha no registrada");
            }
            comboBox4.Text = "";
            numericUpDown1.Value = 0;
        }
    }
}
