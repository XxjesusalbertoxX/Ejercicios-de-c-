using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void sueldoEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmpleado form1 = new FormEmpleado();
            form1.ShowDialog();
        }

        private void calificacionesAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCalificaciones form1 = new FormCalificaciones();
            form1.ShowDialog();
        }

        private void FigurasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FormFiguras();
            form.ShowDialog();
        }
    }
}
