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
    public partial class FormLoginBanco : Form
    {
        public FormLoginBanco()
        {
            InitializeComponent();
        }
        Banco Banco = new Banco();
        
        private void Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Banco.Nombre = NombreLogin.Text;
                Banco.Cuenta = Convert.ToInt32(CuentaLogin.Text);
                FormBancoInicio BancoInt = new FormBancoInicio(Banco.Nombre, Banco.Cuenta);
                this.Hide();
                BancoInt.ShowDialog();
               
            }
            catch (System.FormatException) 
            {
                MessageBox.Show("Porfavor ingrese sus datos correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
            this.Hide();
            Menu.ShowDialog();
        }
    }
}
