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
    public partial class Reporte_de_Ventas : Form
    {
        public Reporte_de_Ventas()
        {
            InitializeComponent();
        }
        HojasHielo Hojas = new HojasHielo();
        HojasHielo SubtotalSum = new HojasHielo();
        HojasHielo DescuentoSum = new HojasHielo();
        HojasHielo TotalSum = new HojasHielo();
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false; NombreBox.Visible = false;
            label2.Visible = false; TipoBox.Visible = false;
            label3.Visible = false; CantBox.Visible = false;
            label4.Visible = false; PrecioBox.Visible = false;
            TablaVentas.Visible = true;
            button1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            this.Text = "REPORTE DE VENTAS";
            TablaVentas.Rows.Add($"TOTAL DE ClIENTES: {i} ", $"{SubtotalSum.SumaColumna}", $"{DescuentoSum.SumaColumna}", $"{TotalSum.SumaColumna}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true; NombreBox.Visible = true;
            label2.Visible = true; TipoBox.Visible = true;
            label3.Visible = true; CantBox.Visible = true;
            label4.Visible = true; PrecioBox.Visible = true;
            TablaVentas.Visible = false; TablaVentas.Rows.Clear();
            button1.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            SubtotalSum.SumaColumna = 0;
            DescuentoSum.SumaColumna = 0;
            TotalSum.SumaColumna = 0;
            i = 0;
            this.Text = "VENTAS";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
            this.Hide();
            Menu.ShowDialog();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (TipoBox.SelectedItem.ToString() == "1")
                {
                    Hojas.Nombre = NombreBox.Text;
                    Hojas.Tipo = Convert.ToInt32(TipoBox.SelectedItem.ToString());
                    Hojas.Cantidad = Convert.ToInt32(CantBox.Text);
                    Hojas.Precio = Convert.ToDouble(PrecioBox.Text);
                    Hojas.Subtotales();
                    Hojas.Descontar();
                    TablaVentas.Rows.Add($"{Hojas.Nombre}", $"{Hojas.Subtotal}", $"{Hojas.Descuento}", $"{Hojas.Total}");
                    SubtotalSum.SumaColumna += Hojas.Subtotal;
                    DescuentoSum.SumaColumna += Hojas.Descuento;
                    TotalSum.SumaColumna += Hojas.Total;
                    i++;
                }
                if (TipoBox.SelectedItem.ToString() == "2")
                {
                    Hojas.Nombre = NombreBox.Text;
                    Hojas.Tipo = Convert.ToInt32(TipoBox.SelectedItem.ToString());
                    Hojas.Cantidad = Convert.ToInt32(CantBox.Text);
                    Hojas.Precio = Convert.ToDouble(PrecioBox.Text);
                    Hojas.Subtotales();
                    Hojas.Descontar();
                    TablaVentas.Rows.Add($"{Hojas.Nombre}", $"{Hojas.Subtotal}", $"{Hojas.Descuento}", $"{Hojas.Total}");
                    SubtotalSum.SumaColumna += Hojas.Subtotal;
                    DescuentoSum.SumaColumna += Hojas.Descuento;
                    TotalSum.SumaColumna += Hojas.Total;
                    i++;
                }
                if (TipoBox.SelectedItem.ToString() == "3")
                {
                    Hojas.Nombre = NombreBox.Text;
                    Hojas.Tipo = Convert.ToInt32(TipoBox.SelectedItem.ToString());
                    Hojas.Cantidad = Convert.ToInt32(CantBox.Text);
                    Hojas.Precio = Convert.ToDouble(PrecioBox.Text);
                    Hojas.Subtotales();
                    Hojas.Descontar();
                    TablaVentas.Rows.Add($"{Hojas.Nombre}", $"{Hojas.Subtotal}", $"{Hojas.Descuento}", $"{Hojas.Total}");
                    SubtotalSum.SumaColumna += Hojas.Subtotal;
                    DescuentoSum.SumaColumna += Hojas.Descuento;
                    TotalSum.SumaColumna += Hojas.Total;
                    i++;
                }
                if (TipoBox.SelectedItem.ToString() == "4")
                {
                    Hojas.Nombre = NombreBox.Text;
                    Hojas.Tipo = Convert.ToInt32(TipoBox.SelectedItem.ToString());
                    Hojas.Cantidad = Convert.ToInt32(CantBox.Text);
                    Hojas.Precio = Convert.ToDouble(PrecioBox.Text);
                    Hojas.Subtotales();
                    Hojas.Descontar();
                    TablaVentas.Rows.Add($"{Hojas.Nombre}", $"{Hojas.Subtotal}", $"{Hojas.Descuento}", $"{Hojas.Total}");
                    SubtotalSum.SumaColumna += Hojas.Subtotal;
                    DescuentoSum.SumaColumna += Hojas.Descuento;
                    TotalSum.SumaColumna += Hojas.Total;
                    i++;
                }
                NombreBox.Clear();
                TipoBox.SelectedIndex = -1;
                CantBox.Clear();
                PrecioBox.Clear();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Porfavor ingrese sus datos correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }
    }
}
