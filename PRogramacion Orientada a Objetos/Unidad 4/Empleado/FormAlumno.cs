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
    public partial class FormAlumno : Form
{
    private List<Alumno> alumnos = new List<Alumno>();

    public FormAlumno()
    {
        InitializeComponent();
    }

    private void CerrarButton_Click(object sender, EventArgs e)
    {
        txtname.Enabled = false;
        txtc1.Enabled = false;
        txtc2.Enabled = false;
        txtc3.Enabled = false;
        txtc4.Enabled = false;

        double promedioCal1 = alumnos.Average(a => a.Cal1);
        double promedioCal2 = alumnos.Average(a => a.Cal2);
        double promedioCal3 = alumnos.Average(a => a.Cal3);
        double promedioCal4 = alumnos.Average(a => a.Cal4);
        double promedioTotal = alumnos.Average(a => a.Promediar());

        DGVAlumnospromedio.Rows.Add("TOTAL PROMEDIOS", promedioCal1.ToString("N2"), promedioCal2.ToString("N2"), promedioCal3.ToString("N2"), promedioCal4.ToString("N2"), promedioTotal.ToString("N2"));
    }

    private void CerrarTodo_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void LimpiarButton_Click(object sender, EventArgs e)
    {
        txtname.Enabled = true;
        txtc1.Enabled = true;
        txtc2.Enabled = true;
        txtc3.Enabled = true;
        txtc4.Enabled = true;
        CerrarButton.Enabled = false;
        DGVAlumnospromedio.Rows.Clear();
        alumnos.Clear();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
        try
        {
            Alumno alumno = new Alumno
            {
                Nombre = txtname.Text,
                Cal1 = Convert.ToDouble(txtc1.Text),
                Cal2 = Convert.ToDouble(txtc2.Text),
                Cal3 = Convert.ToDouble(txtc3.Text),
                Cal4 = Convert.ToDouble(txtc4.Text)
            };

            alumnos.Add(alumno);
            double promedio = alumno.Promediar();
            DGVAlumnospromedio.Rows.Add(alumno.Nombre, alumno.Cal1, alumno.Cal2, alumno.Cal3, alumno.Cal4, promedio.ToString("N2"));

            txtname.Clear();
            txtc1.Clear();
            txtc2.Clear();
            txtc3.Clear();
            txtc4.Clear();
            CerrarButton.Enabled = true;
        }
        catch (System.FormatException)
        {
            MessageBox.Show("Por favor ingrese datos válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}

}
