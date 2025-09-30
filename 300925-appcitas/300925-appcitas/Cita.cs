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
    public partial class Cita : Form
    {
        public Cita(string a)
        {
            InitializeComponent();
            txtDoc.Text = a;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            string txtdoc = txtDoc.Text;
            string 
        }
    }
}
