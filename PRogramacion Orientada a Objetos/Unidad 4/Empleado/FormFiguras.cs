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
    public partial class FormFiguras : Form
    {
        public FormFiguras()
        {
            InitializeComponent();
        }
        Operaciones Operaciones = new Operaciones();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ComboFig.SelectedItem.ToString() == "Triangulo" && Areabool.Checked)
                {
                    Operaciones.Base = Convert.ToDouble(textBox1.Text);
                    Operaciones.Altura = Convert.ToDouble(textBox2.Text);
                    Operaciones.TrianguloAr();
                    listBox1.Items.Add($"Area del Triangulo: {Operaciones.Area}");
                }
                if (ComboFig.SelectedItem.ToString() == "Triangulo" && PerimetroBool.Checked)
                {
                    Operaciones.Lado1 = Convert.ToDouble(textBox1.Text);
                    Operaciones.Lado2 = Convert.ToDouble(textBox2.Text);
                    Operaciones.Lado3 = Convert.ToDouble(textBox3.Text);
                    Operaciones.TrianguloPer();
                    listBox1.Items.Add($"Perimetro del Triangulo: {Operaciones.Perimetro}");
                }
                if (ComboFig.SelectedItem.ToString() == "Cuadrado" && Areabool.Checked)
                {
                    Operaciones.Base = Convert.ToDouble(textBox1.Text);
                    Operaciones.Altura = Convert.ToDouble(textBox2.Text);
                    Operaciones.CuadradoAr();
                    listBox1.Items.Add($"Area del Cuadrado: {Operaciones.Area}");
                }
                if (ComboFig.SelectedItem.ToString() == "Cuadrado" && PerimetroBool.Checked)
                {
                    Operaciones.Lado1 = Convert.ToDouble(textBox1.Text);
                    Operaciones.CuadradoPer();
                    listBox1.Items.Add($"Perimetro del Cuadrado: {Operaciones.Perimetro}");
                }
                if (ComboFig.SelectedItem.ToString() == "Rectangulo" && Areabool.Checked)
                {
                    Operaciones.Base = Convert.ToDouble(textBox1.Text);
                    Operaciones.Altura = Convert.ToDouble(textBox2.Text);
                    Operaciones.RectanguloAr();
                    listBox1.Items.Add($"Area del Rectangulo: {Operaciones.Area}");
                }
                if (ComboFig.SelectedItem.ToString() == "Rectangulo" && PerimetroBool.Checked)
                {
                    Operaciones.Base = Convert.ToDouble(textBox1.Text);
                    Operaciones.Altura = Convert.ToDouble(textBox2.Text);
                    Operaciones.RectanguloPer();
                    listBox1.Items.Add($"Perimetro del Rectangulo: {Operaciones.Perimetro}");
                }
                if (ComboFig.SelectedItem.ToString() == "Circulo" && Areabool.Checked)
                {
                    Operaciones.Radio = Convert.ToDouble(textBox1.Text);
                    Operaciones.CirculoAr();
                    listBox1.Items.Add($"Area del Circulo: {Operaciones.Area}");
                }
                if (ComboFig.SelectedItem.ToString() == "Circulo" && PerimetroBool.Checked)
                {
                    Operaciones.Radio = Convert.ToDouble(textBox1.Text);
                    Operaciones.CirculoPer();
                    listBox1.Items.Add($"Perimetro del Circulo: {Operaciones.Perimetro}");
                }
                Areabool.Checked = false;
                PerimetroBool.Checked = false;
                Areabool.Enabled = false;
                PerimetroBool.Enabled = false;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                ComboFig.SelectedIndex = -1;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Dato Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                ComboFig.SelectedIndex = -1;
                label1.Visible = false; textBox1.Visible = false;
                label3.Visible = false; textBox2.Visible = false;
                label4.Visible = false; textBox3.Visible = false;
                button1.Enabled = false;
                Areabool.Enabled = false; Areabool.Checked = false;
                PerimetroBool.Enabled = false; PerimetroBool.Checked = false;
            }
        }
        private void Areabool_CheckedChanged(object sender, EventArgs e)
        {

            button1.Enabled = true;
            switch (ComboFig.SelectedItem.ToString())
            {
                case "Triangulo":
                    Areabool.Enabled = false;
                    PerimetroBool.Enabled = true;
                    label1.Visible = true; textBox1.Visible = true; label1.Text = "Base";
                    label3.Visible = true; textBox2.Visible = true; label3.Text = "Altura";
                    label4.Visible = false; textBox3.Visible = false;
                    break;
                case "Cuadrado":
                    Areabool.Enabled = false;
                    PerimetroBool.Enabled = true;
                    label1.Visible = true; textBox1.Visible = true; label1.Text = "Base";
                    label3.Visible = true; textBox2.Visible = true; label3.Text = "Altura";
                    label4.Visible = false; textBox3.Visible = false;
                    break;
                case "Rectangulo":
                    Areabool.Enabled = false;
                    PerimetroBool.Enabled = true;
                    label1.Visible = true; textBox1.Visible = true; label1.Text = "Base";
                    label3.Visible = true; textBox2.Visible = true; label3.Text = "Altura";
                    label4.Visible = false; textBox3.Visible = false;
                    break;
                case "Circulo":
                    Areabool.Enabled = false;
                    PerimetroBool.Enabled = true;
                    label1.Visible = true; textBox1.Visible = true; label1.Text = "Radio";
                    label3.Visible = false; textBox2.Visible = false;
                    label4.Visible = false; textBox3.Visible = false;
                    break;
            }
        }
        private void PerimetroBool_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            switch (ComboFig.SelectedItem.ToString())
            {
                case "Triangulo":
                    Areabool.Enabled = true;
                    PerimetroBool.Enabled = false;
                    label1.Visible = true; textBox1.Visible = true; label1.Text = "Lado 1";
                    label3.Visible = true; textBox2.Visible = true; label3.Text = "Lado 2";
                    label4.Visible = true; textBox3.Visible = true; label4.Text = "Lado 3";
                    break;
                case "Cuadrado":
                    Areabool.Enabled = true;
                    PerimetroBool.Enabled = false;
                    label1.Visible = true; textBox1.Visible = true; label1.Text = "Lado 1";
                    label3.Visible = false; textBox2.Visible = false;
                    label4.Visible = false; textBox3.Visible = false;
                    break;
                case "Rectangulo":
                    Areabool.Enabled = true;
                    PerimetroBool.Enabled = false;
                    label1.Visible = true; textBox1.Visible = true; label1.Text = "Base";
                    label3.Visible = true; textBox2.Visible = true; label3.Text = "Altura";
                    label4.Visible = false; textBox3.Visible = false;
                    break;
                case "Circulo":
                    Areabool.Enabled = true;
                    PerimetroBool.Enabled = false;
                    label1.Visible = true; textBox1.Visible = true; label1.Text = "Radio";
                    label3.Visible = false; textBox2.Visible = false;
                    label4.Visible = false; textBox3.Visible = false;
                    break;
            }
        }
        private void ComboFig_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ComboFig.SelectedIndex > -1)
            {
                Areabool.Checked = true;
                PerimetroBool.Checked = true;
                Areabool.Enabled = true;
                PerimetroBool.Enabled = true;
            }
        }
    }
}
