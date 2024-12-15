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
    public partial class BancoInterfaz : Form
    {
        Banco Banco = new Banco();
        public BancoInterfaz(string Nombre ,Int32 Cuenta)
        {
            InitializeComponent();
            NombreBox.Text = Nombre;
            CuentaBox.Text = Convert.ToString(Cuenta);
            Banco.Abono = 0;
            Banco.Retiro = 0;
            Banco.Saldo = 0;
        }
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            BancoLogin BancoLogin = new BancoLogin();
            this.Hide();
            BancoLogin.ShowDialog();
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            i++;
            try
            {
                if (ComboMov.SelectedItem.ToString() == "Abonar")
                {
                    Banco.Abono = Convert.ToDouble(CantidadBox.Text);
                    Banco.Saldo = Convert.ToDouble(SaldoBox.Text);
                    Banco.Abonar();
                    TablaMovimientos.Rows.Add($"{i}", $"{Banco.Abono}", $"{Banco.Retiro}", $"{Banco.Saldo}");
                    SaldoBox.Text = Convert.ToString(Banco.Saldo);
                }
                if (ComboMov.SelectedItem.ToString() == "Retirar")
                {
                    Banco.Retiro = Convert.ToDouble(CantidadBox.Text);
                    Banco.Saldo = Convert.ToDouble(SaldoBox.Text);
                    Banco.Retirar();
                    TablaMovimientos.Rows.Add($"{i}", $"{Banco.Abono}", $"{Banco.Retiro}", $"{Banco.Saldo}");
                    SaldoBox.Text = Convert.ToString(Banco.Saldo);
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("No ingresaste datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No ingresaste datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            CantidadBox.Clear();
        }
    }
}
