using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _250925
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("Prueba.txt");

            foreach (string line in lines)
            {
                string[] values = line.Split(',');
                dataGridView1.Rows.Add(values);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string dato1 = txtNom.Text;
            string dato2 = txtAp.Text;
            string dato3 = txtDoc.Text;
            string dato4 = txtDi.Text;
            string dato5 = txtTe.Text;

            if (!string.IsNullOrEmpty(dato1) & !string.IsNullOrEmpty(dato2) & !string.IsNullOrEmpty(dato3) & !string.IsNullOrEmpty(dato4) & !string.IsNullOrEmpty(dato5))
                {
                dataGridView1.Rows.Add(dato1, dato2, dato3, dato4, dato5);

                using (StreamWriter sw = new StreamWriter("Prueba.txt", true))
                {
                    sw.WriteLine($"{dato1},{dato2},{dato3},{dato4},{dato5}");
                }
                txtNom.Text = dato1;
                txtAp.Text = dato2;
                txtDoc.Text = dato3;
                txtDi.Text = dato4;
                txtTe.Text = dato5;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
