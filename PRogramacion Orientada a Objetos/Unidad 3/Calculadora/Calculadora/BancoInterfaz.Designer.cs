namespace Empleado
{
    partial class BancoInterfaz
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaldoBox = new System.Windows.Forms.TextBox();
            this.NombreBox = new System.Windows.Forms.TextBox();
            this.CuentaBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TablaMovimientos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CantidadBox = new System.Windows.Forms.TextBox();
            this.ComboMov = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SaldoBox);
            this.groupBox1.Controls.Add(this.NombreBox);
            this.groupBox1.Controls.Add(this.CuentaBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS";
            // 
            // SaldoBox
            // 
            this.SaldoBox.Location = new System.Drawing.Point(127, 173);
            this.SaldoBox.Name = "SaldoBox";
            this.SaldoBox.ReadOnly = true;
            this.SaldoBox.Size = new System.Drawing.Size(121, 22);
            this.SaldoBox.TabIndex = 9;
            this.SaldoBox.Text = "0";
            this.SaldoBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NombreBox
            // 
            this.NombreBox.Location = new System.Drawing.Point(127, 47);
            this.NombreBox.Name = "NombreBox";
            this.NombreBox.ReadOnly = true;
            this.NombreBox.Size = new System.Drawing.Size(121, 22);
            this.NombreBox.TabIndex = 8;
            // 
            // CuentaBox
            // 
            this.CuentaBox.Location = new System.Drawing.Point(127, 107);
            this.CuentaBox.Name = "CuentaBox";
            this.CuentaBox.ReadOnly = true;
            this.CuentaBox.Size = new System.Drawing.Size(121, 22);
            this.CuentaBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 40);
            this.label3.TabIndex = 3;
            this.label3.Text = "Saldo: $";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cuenta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // TablaMovimientos
            // 
            this.TablaMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaMovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.TablaMovimientos.Location = new System.Drawing.Point(354, 46);
            this.TablaMovimientos.Name = "TablaMovimientos";
            this.TablaMovimientos.RowHeadersWidth = 51;
            this.TablaMovimientos.RowTemplate.Height = 24;
            this.TablaMovimientos.Size = new System.Drawing.Size(455, 207);
            this.TablaMovimientos.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No.";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Abono";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Retiro";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Saldo";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(689, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 69);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.button2.Location = new System.Drawing.Point(49, 448);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 57);
            this.button2.TabIndex = 3;
            this.button2.Text = "Procesar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 40);
            this.label4.TabIndex = 4;
            this.label4.Text = "Movimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 40);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cantidad:";
            // 
            // CantidadBox
            // 
            this.CantidadBox.Location = new System.Drawing.Point(191, 363);
            this.CantidadBox.Name = "CantidadBox";
            this.CantidadBox.Size = new System.Drawing.Size(121, 22);
            this.CantidadBox.TabIndex = 6;
            this.CantidadBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ComboMov
            // 
            this.ComboMov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboMov.FormattingEnabled = true;
            this.ComboMov.Items.AddRange(new object[] {
            "Abonar",
            "Retirar"});
            this.ComboMov.Location = new System.Drawing.Point(191, 312);
            this.ComboMov.Name = "ComboMov";
            this.ComboMov.Size = new System.Drawing.Size(121, 24);
            this.ComboMov.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(486, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 34);
            this.label6.TabIndex = 8;
            this.label6.Text = "\"Movimientos\"";
            // 
            // BancoInterfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 529);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ComboMov);
            this.Controls.Add(this.CantidadBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TablaMovimientos);
            this.Controls.Add(this.groupBox1);
            this.Name = "BancoInterfaz";
            this.Text = "BancoInterfaz";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaMovimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView TablaMovimientos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CantidadBox;
        private System.Windows.Forms.ComboBox ComboMov;
        private System.Windows.Forms.TextBox SaldoBox;
        private System.Windows.Forms.TextBox NombreBox;
        private System.Windows.Forms.TextBox CuentaBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}