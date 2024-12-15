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
    public partial class FormFiguras : Form
    {
        public FormFiguras()
        {
            InitializeComponent();
        }
        float lado1, lado2, lado3;
        private string tipodefigura;
        private void CBTipoFiguras_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipodefigura = CBTipoFiguras.SelectedItem.ToString();
            OcultarInformacion();
            switch (tipodefigura)
            {
                case "Triangulo":
                    Tipodeoperaciontriangulo();

                    break;
                case "Circulo":
                    lbllado1.Visible = true;
                    lbllado1.Text = "Valor del radio";
                    txtlado1.Visible = true;
                    break;
                case "Cuadrado":
                    lbllado1.Visible = true;
                    txtlado1.Visible = true;
                    break;
                case "Rectangulo":
                    lbllado2.Visible = true;
                    txtlado2.Visible = true;
                    lbllado1.Text = "Valor de Base";
                    lbllado2.Text = "Valor de Altura";
                    /*lbllado1.Text = "Valor del lado 1 (b)";
                    lbllado2.Text = "Valor del lado 2 (h)";*///errores extraños
                    lbllado1.Visible = true;
                    txtlado1.Visible = true;
                    /* txtlado1.Location = new Point(222, 290);
                     txtlado2.Location = new System.Drawing.Point(222, 325);*///error extraño
                    break;
                default:
                    break;
            }

        }

        private void FormFiguras_Load(object sender, EventArgs e)
        {
            CBTipoFiguras.SelectedIndex = 0;
            CBTipoOperacion.SelectedIndex = 0;
        }

        private void CBTipoOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBTipoFiguras.SelectedItem == "Triangulo")
            {
 
                Tipodeoperaciontriangulo();
            }
            switch (CBTipoOperacion.SelectedItem.ToString())
            {
                   

                    
                case "Area":
                    if (CBTipoFiguras.SelectedItem == "Circulo"|| CBTipoFiguras.SelectedItem == "Cuadrado")
                    {
                        txtlado1.Visible = true;
                        lbllado1.Visible = true;

                    }
                    else
                    {
                        txtlado1.Visible = true;
                        lbllado1.Visible = true;
                        txtlado2.Visible = true;
                        lbllado2.Visible = true;
                    }



                    break;
                case "Volumen":
                    if (CBTipoFiguras.SelectedItem == "Circulo" || CBTipoFiguras.SelectedItem == "Cuadrado")
                    {
                        txtlado1.Visible = true;
                        lbllado1.Visible = true;
                    }
                    else
                    {
                        txtlado1.Visible = true;
                        lbllado1.Visible = true;
                        txtlado2.Visible = true;
                        txtlado3.Visible = true;
                        lbllado2.Visible = true;
                        lbllado3.Visible = true;
                    }

                  
                    break;
            }


        }


        private void OcultarInformacion()
        {
            txtlado1.Visible = false;
            lbllado1.Visible = false;
            txtlado2.Visible = false;
            lbllado2.Visible = false;
            txtlado3.Visible = false;
            lbllado3.Visible = false;
            CBTipoTriangulo.Visible = false;
            /*txtlado1.Location = new System.Drawing.Point(186, 290);
            txtlado2.Location = new System.Drawing.Point(186, 325);
            txtlado3.Location = new System.Drawing.Point(186, 360);*/

        }
        private void CBTipoTriangulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Tipotriangulo = CBTipoTriangulo.SelectedItem.ToString();
            OcultarInformacion();
            CBTipoTriangulo.Visible = true;
            switch (Tipotriangulo)
            {
                case "Isoceles":
                    Tipodeoperaciontriangulo();
                    break;
                case "Equilatero":
                    Tipodeoperaciontriangulo();
                    break;
                case "Escaleno":
                    Tipodeoperaciontriangulo();
                    break;
            }
        }
        private void Tipodeoperaciontriangulo()
        {

            switch (CBTipoOperacion.SelectedItem.ToString())
            {
                case "Perimetro":

                    txtlado1.Visible = true;
                    lbllado1.Visible = true;
                    CBTipoTriangulo.Visible = true;

                    break;
                case "Area":
                    txtlado1.Visible = true;
                    lbllado1.Visible = true;
                    txtlado2.Visible = true;
                    lbllado2.Visible = true;
                    CBTipoTriangulo.Visible = true;

                    break;
                case "Volumen":
                    txtlado1.Visible = true;
                    lbllado1.Visible = true;
                    txtlado2.Visible = true;
                    txtlado3.Visible = true;
                    lbllado2.Visible = true;
                    lbllado3.Visible = true;
                    CBTipoTriangulo.Visible = true;
                    break;
            }
        }
    }
}
