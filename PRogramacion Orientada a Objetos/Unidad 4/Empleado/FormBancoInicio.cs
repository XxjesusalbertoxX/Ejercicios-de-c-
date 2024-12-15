using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Empleado
{
    public partial class FormBancoInicio : Form
    {
        private Banco banco;
        private int i = 0;

        public FormBancoInicio(string nombre, int cuenta)
        {
            InitializeComponent();
            nombre = nombre;
            cuenta = cuenta;
            txtnombre.Text = nombre;
            txtcuenta.Text = cuenta.ToString();
            banco = new Banco();
        }

        private void btnAbonarRetirar_Click(object sender, EventArgs e)
        {
            double cantidad;
            double saldoActual;

            try
            {
                cantidad = Convert.ToDouble(txtcantidad.Text);
                saldoActual = Convert.ToDouble(txtsldo.Text);

                if (CBmovimiento.SelectedItem.ToString() == "Abonar")
                {
                    double nuevoSaldo = banco.Abonar(saldoActual, cantidad);
                    DGVmovimientos.Rows.Add($"{++i}", $"{cantidad}", $"0", $"{nuevoSaldo}");
                    txtsldo.Text = nuevoSaldo.ToString();
                }
                else if (CBmovimiento.SelectedItem.ToString() == "Retirar")
                {
                    double nuevoSaldo = banco.Retirar(saldoActual, cantidad);
                    DGVmovimientos.Rows.Add($"{++i}", $"0", $"{cantidad}", $"{nuevoSaldo}");
                    txtsldo.Text = nuevoSaldo.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingrese datos válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Seleccione un movimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            txtcantidad.Clear();
        }
    }
}
