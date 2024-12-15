using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleado
{
    public partial class FormEmpleados : Form
    {
        public FormEmpleados()
        {
            InitializeComponent();
        }
        Empleado Empleado= new Empleado();

        private void Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado.NombreEmp = txtNombre.Text;
                Empleado.HorasT = Convert.ToDouble(txtHoras.Text);
                Empleado.CuotaHora = Convert.ToDouble(txtCuota.Text);
                Empleado.SumarSueldo();
                LVEmpleados.Items.Add($"Nombre: {Empleado.NombreEmp}");
                LVEmpleados.Items.Add($"Sueldo: {Empleado.Sueldo}");
                txtNombre.Clear();
                txtCuota.Clear();
                txtHoras.Clear();
                txtNombre.Focus();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Dato Incorrecto","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtNombre.Clear();
                txtCuota.Clear();
                txtHoras.Clear();
                txtNombre.Focus();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LVEmpleados.Items.Clear();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
