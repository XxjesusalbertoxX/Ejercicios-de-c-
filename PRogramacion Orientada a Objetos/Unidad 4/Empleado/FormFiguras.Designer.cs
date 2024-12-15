namespace Empleado
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
            this.ComboFig = new System.Windows.Forms.ComboBox();
            this.Areabool = new System.Windows.Forms.RadioButton();
            this.PerimetroBool = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ComboFig
            // 
            this.ComboFig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboFig.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboFig.FormattingEnabled = true;
            this.ComboFig.Items.AddRange(new object[] {
            "Rectangulo",
            "Cuadrado",
            "Circulo",
            "Triangulo"});
            this.ComboFig.Location = new System.Drawing.Point(118, 30);
            this.ComboFig.Name = "ComboFig";
            this.ComboFig.Size = new System.Drawing.Size(179, 41);
            this.ComboFig.TabIndex = 0;
            this.ComboFig.SelectedIndexChanged += new System.EventHandler(this.ComboFig_SelectedIndexChanged);
            // 
            // Areabool
            // 
            this.Areabool.AutoSize = true;
            this.Areabool.Enabled = false;
            this.Areabool.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Areabool.Location = new System.Drawing.Point(118, 86);
            this.Areabool.Name = "Areabool";
            this.Areabool.Size = new System.Drawing.Size(107, 42);
            this.Areabool.TabIndex = 1;
            this.Areabool.Text = "Area";
            this.Areabool.UseVisualStyleBackColor = true;
            this.Areabool.CheckedChanged += new System.EventHandler(this.Areabool_CheckedChanged);
            // 
            // PerimetroBool
            // 
            this.PerimetroBool.AutoSize = true;
            this.PerimetroBool.Enabled = false;
            this.PerimetroBool.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerimetroBool.Location = new System.Drawing.Point(118, 134);
            this.PerimetroBool.Name = "PerimetroBool";
            this.PerimetroBool.Size = new System.Drawing.Size(179, 42);
            this.PerimetroBool.TabIndex = 2;
            this.PerimetroBool.TabStop = true;
            this.PerimetroBool.Text = "Perimetro";
            this.PerimetroBool.UseVisualStyleBackColor = true;
            this.PerimetroBool.CheckedChanged += new System.EventHandler(this.PerimetroBool_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "Figura:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(403, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(215, 244);
            this.listBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Base";
            this.label1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "Altura";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(157, 252);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 9;
            this.textBox2.Visible = false;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(157, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 40);
            this.label4.TabIndex = 12;
            this.label4.Text = "Lado 3";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(157, 303);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 13;
            this.textBox3.Visible = false;
            // 
            // Figuras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 428);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PerimetroBool);
            this.Controls.Add(this.Areabool);
            this.Controls.Add(this.ComboFig);
            this.Name = "Figuras";
            this.Text = "Figuras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboFig;
        private System.Windows.Forms.RadioButton Areabool;
        private System.Windows.Forms.RadioButton PerimetroBool;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
    }
}