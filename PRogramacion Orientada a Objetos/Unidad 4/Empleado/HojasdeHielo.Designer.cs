namespace Empleado
{
    partial class Reporte_de_Ventas
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
            this.TablaVentas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.PrecioBox = new System.Windows.Forms.TextBox();
            this.CantBox = new System.Windows.Forms.TextBox();
            this.NombreBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TipoBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TablaVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // TablaVentas
            // 
            this.TablaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.TablaVentas.Location = new System.Drawing.Point(12, 75);
            this.TablaVentas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TablaVentas.Name = "TablaVentas";
            this.TablaVentas.RowHeadersWidth = 51;
            this.TablaVentas.RowTemplate.Height = 24;
            this.TablaVentas.Size = new System.Drawing.Size(807, 428);
            this.TablaVentas.TabIndex = 0;
            this.TablaVentas.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "NOMBRE";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "SUBTOTAL";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "DESCUENTO";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "NETO A PAGAR";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(310, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 40);
            this.label6.TabIndex = 9;
            this.label6.Text = "\"Reporte de Clientes\"";
            this.label6.Visible = false;
            // 
            // PrecioBox
            // 
            this.PrecioBox.Font = new System.Drawing.Font("Agency FB", 16.2F);
            this.PrecioBox.Location = new System.Drawing.Point(434, 282);
            this.PrecioBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PrecioBox.Name = "PrecioBox";
            this.PrecioBox.Size = new System.Drawing.Size(112, 46);
            this.PrecioBox.TabIndex = 29;
            // 
            // CantBox
            // 
            this.CantBox.Font = new System.Drawing.Font("Agency FB", 16.2F);
            this.CantBox.Location = new System.Drawing.Point(434, 212);
            this.CantBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CantBox.Name = "CantBox";
            this.CantBox.Size = new System.Drawing.Size(112, 46);
            this.CantBox.TabIndex = 28;
            // 
            // NombreBox
            // 
            this.NombreBox.Font = new System.Drawing.Font("Agency FB", 16.2F);
            this.NombreBox.Location = new System.Drawing.Point(434, 91);
            this.NombreBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NombreBox.Name = "NombreBox";
            this.NombreBox.Size = new System.Drawing.Size(112, 46);
            this.NombreBox.TabIndex = 27;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(14, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 56);
            this.button2.TabIndex = 26;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Agency FB", 16.2F);
            this.button1.Location = new System.Drawing.Point(519, 381);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 96);
            this.button1.TabIndex = 25;
            this.button1.Text = "Mostrar Reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TipoBox
            // 
            this.TipoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoBox.Font = new System.Drawing.Font("Agency FB", 16.2F);
            this.TipoBox.FormattingEnabled = true;
            this.TipoBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.TipoBox.Location = new System.Drawing.Point(434, 154);
            this.TipoBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TipoBox.Name = "TipoBox";
            this.TipoBox.Size = new System.Drawing.Size(136, 48);
            this.TipoBox.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 16.2F);
            this.label4.Location = new System.Drawing.Point(248, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 40);
            this.label4.TabIndex = 23;
            this.label4.Text = "Precio x Hoja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 16.2F);
            this.label3.Location = new System.Drawing.Point(248, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 40);
            this.label3.TabIndex = 22;
            this.label3.Text = "Cantidad de Hojas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 16.2F);
            this.label2.Location = new System.Drawing.Point(248, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 40);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tipo Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 16.2F);
            this.label1.Location = new System.Drawing.Point(248, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 40);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nombre Cliente:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(14, 11);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 56);
            this.button3.TabIndex = 30;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Agency FB", 16.2F);
            this.button4.Location = new System.Drawing.Point(254, 381);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 96);
            this.button4.TabIndex = 31;
            this.button4.Text = "Agregar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Agency FB", 16.2F);
            this.textBox1.Location = new System.Drawing.Point(434, 152);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 46);
            this.textBox1.TabIndex = 27;
            // 
            // Reporte_de_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 562);
            this.ControlBox = false;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.PrecioBox);
            this.Controls.Add(this.CantBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NombreBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TipoBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TablaVentas);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Reporte_de_Ventas";
            this.Text = "VENTAS";
            ((System.ComponentModel.ISupportInitialize)(this.TablaVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TablaVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PrecioBox;
        private System.Windows.Forms.TextBox CantBox;
        private System.Windows.Forms.TextBox NombreBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox TipoBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
    }
}