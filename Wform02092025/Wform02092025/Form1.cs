using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wform02092025
{
    public partial class Hola : Form
    {
        public Hola()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string nom=txt_nombre.Text;
            //MessageBox.Show("Bienvenido a POO " + nom + ", Este es tu primer formulario", "Mensaje para el usuario");
            lb_nombre.Text = "Bienvenido/a a Ecomoda " + nom;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
