namespace Calculadora
{
    partial class FormEmpleado
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.listempleados = new System.Windows.Forms.ListBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txthoras = new System.Windows.Forms.TextBox();
            this.txtcuota = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Horas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cuota";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(171, 305);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(136, 59);
            this.btncalcular.TabIndex = 3;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // listempleados
            // 
            this.listempleados.FormattingEnabled = true;
            this.listempleados.ItemHeight = 20;
            this.listempleados.Location = new System.Drawing.Point(479, 64);
            this.listempleados.Name = "listempleados";
            this.listempleados.Size = new System.Drawing.Size(231, 244);
            this.listempleados.TabIndex = 4;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(207, 95);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 26);
            this.txtnombre.TabIndex = 5;
            // 
            // txthoras
            // 
            this.txthoras.Location = new System.Drawing.Point(189, 135);
            this.txthoras.Name = "txthoras";
            this.txthoras.Size = new System.Drawing.Size(118, 26);
            this.txthoras.TabIndex = 6;
            // 
            // txtcuota
            // 
            this.txtcuota.Location = new System.Drawing.Point(189, 181);
            this.txtcuota.Name = "txtcuota";
            this.txtcuota.Size = new System.Drawing.Size(118, 26);
            this.txtcuota.TabIndex = 7;
            // 
            // FormEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtcuota);
            this.Controls.Add(this.txthoras);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.listempleados);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEmpleado";
            this.Text = "Empleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.ListBox listempleados;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txthoras;
        private System.Windows.Forms.TextBox txtcuota;
    }
}

