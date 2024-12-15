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
    public partial class FormCalificaciones : Form
    {
        public FormCalificaciones()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Alumnos alumno = new Alumnos(txtAlumno.Text,txtC1.Text,txtC2.Text,TxtC3.Text,txtC4.Text);

            
            TextBox[] textBoxes = { txtC1, txtC2, TxtC3, txtC4 };
            float[] calificiaciones = new float[textBoxes.Length];
            for (int i = 0; i < calificiaciones.Length; i++)
            {
                float.TryParse(textBoxes[i].Text, out calificiaciones[i]);
            }
            
            Alumnos alumno = new Alumnos(txtAlumno.Text, calificiaciones);
           /* 
            Alumnos alumno = new Alumnos();
            alumno.nombre = txtAlumno.Text;
            alumno.calificacion[0] = float.Parse(txtC1.Text);
            alumno.calificacion[1] = float.Parse(txtC2.Text);
            alumno.calificacion[2] = float.Parse(TxtC3.Text);
            alumno.calificacion[3] = float.Parse(txtC4.Text);
           */
            DGVListadealumnos.Rows.Add(alumno.nombre, alumno.calificacion[0], alumno.calificacion[1], alumno.calificacion[2], alumno.calificacion[3],alumno.Promedio());
            txtAlumno.Clear();
            txtC1.Clear();
            txtC2.Clear();
            TxtC3.Clear();
            txtC4.Clear();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            float promedioC1 = CalcularPromedioColumna("C1");
            float promedioC2 = CalcularPromedioColumna("C2");
            float promedioC3 = CalcularPromedioColumna("C3");
            float promedioC4 = CalcularPromedioColumna("C4");
            float promedioTotal = CalcularPromedioColumna("P");
            DGVListadealumnos.Rows.Add(DGVListadealumnos.Rows.Count-1, promedioC1, promedioC2, promedioC3, promedioC4, $"Total = {promedioTotal}");

            
        }
        private float CalcularPromedioColumna(string nombredelacolumna)
        {
            // Si tiene filas
            if (DGVListadealumnos.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos en el DataGridView.");
                return 0;
            }

            float suma = 0;
            int conteo = 0;


            // de fila en fila
            foreach (DataGridViewRow fila in DGVListadealumnos.Rows)
            {
                // que la fila no este vacia
                if (!fila.IsNewRow)
                {
                    // saca el valor de la fila
                    var valorCelda = fila.Cells[nombredelacolumna].Value;

                    // Verificar que el valor no sea nulo y se pueda convertir a float
                    if (valorCelda != null && float.TryParse(valorCelda.ToString(), out float valorNumerico))
                    {
                        suma += valorNumerico;
                        conteo++;
                    }
                }
            }

            // Calcular el promedio
            return conteo > 0 ? suma / conteo : 0;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            DGVListadealumnos.Rows.Clear();
        }
        
        private void BtnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
