using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04092025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            txtRes.Text = Convert.ToString(Suma(num1, num2));

        }

        static int Suma (int num1, int num2)
        {
            return num1 + num2;
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            txtRes.Text = Convert.ToString(Resta(num1,num2));
        }

        static int Resta (int num1, int num2)
        {
            return num1 - num2;
        }


        private void btnMul_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            txtRes.Text = Convert.ToString(Multiplicacion(num1, num2));
        }

        static int Multiplicacion(int num1, int num2)
        { 
            return num1 * num2; 
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            if (num2 == 0)
            {
                MessageBox.Show("No se puede dividir por 0", "Error");
                txtNum2.Clear();
            }
            else
            {
                int res = num1 / num2;
                txtRes.Text = Convert.ToString(res);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFac_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int fac = 1, res;
            if (num1 < 0)
            {
                MessageBox.Show("No se puede obtener factorial de numeros negativos", "Error");
            }
            else if (num1 == 0)
            {
                res = 1;
                txtOp.Text = Convert.ToString(res);
            }
                txtOp.Text = Convert.ToString(Factorial(num1, fac));
        }

        static int Factorial (int num1, int fac)
        {
            for (int i = 1; i <= num1; i++)
            {
                fac *= i;
            }
            return fac;
        }

        private void btnSumatoria_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int sum=0;
            txtOp.Text = Convert.ToString(Sumatoria(num1, sum));
        }

        static int Sumatoria(int num1, int sum)
        {
            for (int i = 1; i <= num1; i++)
            { 
            sum += i;
            }
            return sum;
        }


    }
}
