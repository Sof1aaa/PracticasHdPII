using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _300925_appcitas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            
            string usu = txtDoc.Text.ToLower();
            string con = txtContra.Text;
            if (usu == "1025640790" || usu == "999888777")
            {
                
                if (con == "010101")
                {
                    string doc = txtDoc.Text;
                    Cita trae = new Cita(doc);
                    trae.Show();
                    this.Hide();
                }
                if (con == "999888777")
                {
                    Admin trae = new Admin();
                    trae.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta", "ERROR");
                txtDoc.Clear();
                txtContra.Clear();
                txtDoc.Focus();
            }
        }

        private void txtDoc_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
