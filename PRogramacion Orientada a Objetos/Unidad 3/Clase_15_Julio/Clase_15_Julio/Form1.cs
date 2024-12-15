using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_15_Julio
{
    public partial class FormCarros : Form
    {
        public FormCarros()
        {
            InitializeComponent();
        }
        private List<Importacion> importe = new List<Importacion>();
        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtcosto.Text) || string.IsNullOrEmpty(txtmarca.Text) || comboBox1.SelectedItem == null)
                {
                    throw new System.NullReferenceException();
                }

                Importacion nuevoCarro = new Importacion()
                {
                    origen = comboBox1.SelectedItem.ToString(),
                    costo = double.Parse(txtcosto.Text),
                    nombrecarro = txtmarca.Text
                };

                nuevoCarro.Impuesto();
                nuevoCarro.PrecioVenta();

                importe.Add(nuevoCarro);
                DGVimportes.Rows.Add(nuevoCarro.nombrecarro, nuevoCarro.origen, nuevoCarro.costo, nuevoCarro.ImpuestosCalculados, nuevoCarro.PrecioVentaCalculado);

                txtcosto.Clear();
                txtmarca.Clear();
                comboBox1.SelectedItem = null;
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Faltan Datos", "Warning", MessageBoxButtons.OK);
                txtcosto.Clear();
                txtmarca.Clear();
                comboBox1.SelectedItem = null;
            }
            catch (FormatException)
            {
                MessageBox.Show("Costo debe ser un número válido.", "Error", MessageBoxButtons.OK);
                txtcosto.Clear();
            }



        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            double Impuestotal = importe.Sum(a => a.Impuesto());
            double PrecioVentaTotal = importe.Sum(a => a.PrecioVenta());
            double Costotal = importe.Sum(a => a.costo);
            double CarrosTotal = importe.Count();
            var paisMasImportador = importe
                            .GroupBy(a => a.origen)
                            .OrderByDescending(g => g.Count())
                            .FirstOrDefault()?.Key;
            DGVimportes.Rows.Add(CarrosTotal, paisMasImportador, Costotal, Impuestotal, PrecioVentaTotal);
            // Calcular y guardar valores en las propiedades de la clase
            


        }


    }
}
