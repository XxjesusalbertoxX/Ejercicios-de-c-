namespace Calculadora
{
    partial class FormFiguras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CBTipoFiguras = new System.Windows.Forms.ComboBox();
            this.txtlado1 = new System.Windows.Forms.TextBox();
            this.lbllado1 = new System.Windows.Forms.Label();
            this.CBTipoTriangulo = new System.Windows.Forms.ComboBox();
            this.lbllado2 = new System.Windows.Forms.Label();
            this.txtlado2 = new System.Windows.Forms.TextBox();
            this.lbllado3 = new System.Windows.Forms.Label();
            this.txtlado3 = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.TimerActualizador = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LVListaFiguras = new System.Windows.Forms.ListView();
            this.CBTipoOperacion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CBTipoFiguras
            // 
            this.CBTipoFiguras.AutoCompleteCustomSource.AddRange(new string[] {
            "Ninguno"});
            this.CBTipoFiguras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTipoFiguras.FormattingEnabled = true;
            this.CBTipoFiguras.Items.AddRange(new object[] {
            "Circulo",
            "Rectangulo",
            "Triangulo",
            "Cuadrado"});
            this.CBTipoFiguras.Location = new System.Drawing.Point(79, 86);
            this.CBTipoFiguras.Name = "CBTipoFiguras";
            this.CBTipoFiguras.Size = new System.Drawing.Size(121, 28);
            this.CBTipoFiguras.TabIndex = 0;
            this.CBTipoFiguras.SelectedIndexChanged += new System.EventHandler(this.CBTipoFiguras_SelectedIndexChanged);
            // 
            // txtlado1
            // 
            this.txtlado1.Location = new System.Drawing.Point(191, 287);
            this.txtlado1.Name = "txtlado1";
            this.txtlado1.Size = new System.Drawing.Size(100, 26);
            this.txtlado1.TabIndex = 1;
            this.txtlado1.Visible = false;
            // 
            // lbllado1
            // 
            this.lbllado1.AutoSize = true;
            this.lbllado1.Location = new System.Drawing.Point(75, 293);
            this.lbllado1.Name = "lbllado1";
            this.lbllado1.Size = new System.Drawing.Size(110, 20);
            this.lbllado1.TabIndex = 2;
            this.lbllado1.Text = "Valor del largo";
            this.lbllado1.Visible = false;
            // 
            // CBTipoTriangulo
            // 
            this.CBTipoTriangulo.DisplayMember = "Equilatero";
            this.CBTipoTriangulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTipoTriangulo.FormattingEnabled = true;
            this.CBTipoTriangulo.Items.AddRange(new object[] {
            "Equilatero",
            "Isoceles",
            "Escaleno"});
            this.CBTipoTriangulo.Location = new System.Drawing.Point(272, 86);
            this.CBTipoTriangulo.Name = "CBTipoTriangulo";
            this.CBTipoTriangulo.Size = new System.Drawing.Size(121, 28);
            this.CBTipoTriangulo.TabIndex = 3;
            this.CBTipoTriangulo.ValueMember = "Equilatero";
            this.CBTipoTriangulo.Visible = false;
            this.CBTipoTriangulo.SelectedIndexChanged += new System.EventHandler(this.CBTipoTriangulo_SelectedIndexChanged);
            // 
            // lbllado2
            // 
            this.lbllado2.AutoSize = true;
            this.lbllado2.Location = new System.Drawing.Point(75, 328);
            this.lbllado2.Name = "lbllado2";
            this.lbllado2.Size = new System.Drawing.Size(119, 20);
            this.lbllado2.TabIndex = 4;
            this.lbllado2.Text = "Valor del ancho";
            this.lbllado2.Visible = false;
            // 
            // txtlado2
            // 
            this.txtlado2.Location = new System.Drawing.Point(200, 319);
            this.txtlado2.Name = "txtlado2";
            this.txtlado2.Size = new System.Drawing.Size(100, 26);
            this.txtlado2.TabIndex = 5;
            this.txtlado2.Visible = false;
            // 
            // lbllado3
            // 
            this.lbllado3.AutoSize = true;
            this.lbllado3.Location = new System.Drawing.Point(75, 363);
            this.lbllado3.Name = "lbllado3";
            this.lbllado3.Size = new System.Drawing.Size(115, 20);
            this.lbllado3.TabIndex = 6;
            this.lbllado3.Text = "Valor del altura";
            this.lbllado3.Visible = false;
            // 
            // txtlado3
            // 
            this.txtlado3.Location = new System.Drawing.Point(196, 357);
            this.txtlado3.Name = "txtlado3";
            this.txtlado3.Size = new System.Drawing.Size(100, 26);
            this.txtlado3.TabIndex = 7;
            this.txtlado3.Visible = false;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(173, 432);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(198, 60);
            this.btncalcular.TabIndex = 8;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(855, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 394);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // LVListaFiguras
            // 
            this.LVListaFiguras.HideSelection = false;
            this.LVListaFiguras.Location = new System.Drawing.Point(618, 220);
            this.LVListaFiguras.Name = "LVListaFiguras";
            this.LVListaFiguras.Size = new System.Drawing.Size(205, 214);
            this.LVListaFiguras.TabIndex = 10;
            this.LVListaFiguras.UseCompatibleStateImageBehavior = false;
            // 
            // CBTipoOperacion
            // 
            this.CBTipoOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTipoOperacion.FormattingEnabled = true;
            this.CBTipoOperacion.Items.AddRange(new object[] {
            "Perimetro",
            "Area",
            "Volumen"});
            this.CBTipoOperacion.Location = new System.Drawing.Point(450, 86);
            this.CBTipoOperacion.Name = "CBTipoOperacion";
            this.CBTipoOperacion.Size = new System.Drawing.Size(121, 28);
            this.CBTipoOperacion.TabIndex = 11;
            this.CBTipoOperacion.SelectedIndexChanged += new System.EventHandler(this.CBTipoOperacion_SelectedIndexChanged);
            // 
            // FormFiguras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 557);
            this.Controls.Add(this.CBTipoOperacion);
            this.Controls.Add(this.LVListaFiguras);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtlado3);
            this.Controls.Add(this.lbllado3);
            this.Controls.Add(this.txtlado2);
            this.Controls.Add(this.lbllado2);
            this.Controls.Add(this.CBTipoTriangulo);
            this.Controls.Add(this.lbllado1);
            this.Controls.Add(this.txtlado1);
            this.Controls.Add(this.CBTipoFiguras);
            this.Name = "FormFiguras";
            this.Text = "FormFiguras";
            this.Load += new System.EventHandler(this.FormFiguras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBTipoFiguras;
        private System.Windows.Forms.TextBox txtlado1;
        private System.Windows.Forms.Label lbllado1;
        private System.Windows.Forms.Label lbllado2;
        private System.Windows.Forms.TextBox txtlado2;
        private System.Windows.Forms.Label lbllado3;
        private System.Windows.Forms.TextBox txtlado3;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Timer TimerActualizador;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CBTipoTriangulo;
        private System.Windows.Forms.ListView LVListaFiguras;
        private System.Windows.Forms.ComboBox CBTipoOperacion;
    }
}