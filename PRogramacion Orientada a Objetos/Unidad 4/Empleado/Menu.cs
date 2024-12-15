using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleado
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmpleados Practica = new FormEmpleados();
            Practica.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void figurasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFiguras figuras = new FormFiguras();
            figuras.ShowDialog();
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlumno alumno = new FormAlumno();
            alumno.ShowDialog();
        }

        private void bancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoginBanco Banco = new FormLoginBanco();
            this.Hide();
            Banco.ShowDialog();
        }
        private void hojasDeHieloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte_de_Ventas HojasdeHielo = new Reporte_de_Ventas();
            this.Hide();
            HojasdeHielo.ShowDialog();
        }
    }
}
