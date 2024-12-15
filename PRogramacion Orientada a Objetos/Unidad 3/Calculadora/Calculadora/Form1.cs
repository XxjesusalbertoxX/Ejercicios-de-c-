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
    public partial class FormEmpleado : Form
    {
        public FormEmpleado()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Empleado employe = new Empleado();
            employe.nombre = txtnombre.Text;
            if (txtcuota.Text == "" || txthoras.Text =="")
            {
                employe.cuota = 0;
                listempleados.Items.Add($"El empleado: {employe.nombre}");
                listempleados.Items.Add($"salario {employe.salario}");
                BorrarCajasDeTexto();
            }
            else
            {     
               
                employe.cuota = double.Parse(txtcuota.Text);
                employe.horas = int.Parse(txthoras.Text);
                BorrarCajasDeTexto();
                listempleados.Items.Add($"El empleado: {employe.nombre}");
                listempleados.Items.Add($"salario {employe.salario}");
            }


        }
        private void BorrarCajasDeTexto()
        {
            txtcuota.Clear();
            txtnombre.Clear();
            txthoras.Clear();
        }
    }
}
