using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wform09092025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txt1.Text);
            Operaciones operaciones = new Operaciones();

            if (rbdsum.Checked == true)
            {
                int n2 = int.Parse(txt2.Text);
                txt3.Text = Convert.ToString(operaciones.Suma(n1, n2));
            }
            else if (rbdres.Checked == true)
            {
                int n2 = int.Parse(txt2.Text);
                txt3.Text = Convert.ToString(operaciones.Resta(n1, n2));
            }
            else if (rbdmul.Checked == true)
            {
                int n2 = int.Parse(txt2.Text);
                txt3.Text = Convert.ToString(operaciones.Multiplicar(n1, n2));
            }
            else if (rbddiv.Checked == true)
            {
                double a = double.Parse(txt1.Text);
                double b = double.Parse(txt2.Text);
                txt3.Text = Convert.ToString(operaciones.Division(a, b));
            }
            else if (rbdFac.Checked == true) {
                int fac = 1, res;
                if (n1 < 0)
                {
                    MessageBox.Show("No se puede obtener factorial de numeros negativos", "Error");
                }
                else if (n1 == 0)
                {
                    res = 1;
                    txt3.Text = Convert.ToString(res);
                }
                txt3.Text = Convert.ToString(operaciones.Factorial(n1, fac));
            } 
            else if (rbdSumatoria.Checked == true)
            {
                    int sum = 0;
                    Operaciones operaciones1 = new Operaciones();
                    txt3.Text = Convert.ToString(operaciones1.Sumatoria(n1, sum));
            }
            else if (rbdFibo.Checked == true)
            {
                txt3.Text = Convert.ToString(operaciones.Fibonacci(n1));

            }

        }


    }
}
