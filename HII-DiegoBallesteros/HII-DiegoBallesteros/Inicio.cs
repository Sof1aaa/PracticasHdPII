using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HII_DiegoBallesteros
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Freelancers());
        }

        private void AbrirFormEnPanel(Form formHijo)
        {
            if (this.pnlVentanas.Controls.Count > 0)
                this.pnlVentanas.Controls.RemoveAt(0);

            formHijo.TopLevel = false;  // Para que sea un control hijo
            formHijo.FormBorderStyle = FormBorderStyle.None; // Quita bordes y barra de título
            formHijo.Dock = DockStyle.Fill; // Que ocupe todo el espacio del panel

            this.pnlVentanas.Controls.Add(formHijo);
            this.pnlVentanas.Tag = formHijo;

            formHijo.Show();
        } 
    }
}
