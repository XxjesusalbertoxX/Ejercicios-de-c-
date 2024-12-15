namespace Calculadora
{
    partial class FormCalificaciones
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
            this.DGVListadealumnos = new System.Windows.Forms.DataGridView();
            this.Alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GrupoDatos = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtC4 = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtC3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtC2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtC1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.BtnMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListadealumnos)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.GrupoDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVListadealumnos
            // 
            this.DGVListadealumnos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGVListadealumnos.ColumnHeadersHeight = 30;
            this.DGVListadealumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Alumno,
            this.C1,
            this.C2,
            this.C3,
            this.C4,
            this.P,
            this.Totales});
            this.DGVListadealumnos.ContextMenuStrip = this.contextMenuStrip1;
            this.DGVListadealumnos.Location = new System.Drawing.Point(416, 23);
            this.DGVListadealumnos.Name = "DGVListadealumnos";
            this.DGVListadealumnos.ReadOnly = true;
            this.DGVListadealumnos.RowHeadersWidth = 10;
            this.DGVListadealumnos.RowTemplate.Height = 28;
            this.DGVListadealumnos.Size = new System.Drawing.Size(800, 295);
            this.DGVListadealumnos.TabIndex = 11;
            // 
            // Alumno
            // 
            this.Alumno.HeaderText = "Alumno";
            this.Alumno.MinimumWidth = 8;
            this.Alumno.Name = "Alumno";
            this.Alumno.ReadOnly = true;
            this.Alumno.Width = 108;
            // 
            // C1
            // 
            this.C1.HeaderText = "C1";
            this.C1.MinimumWidth = 8;
            this.C1.Name = "C1";
            this.C1.ReadOnly = true;
            this.C1.Width = 108;
            // 
            // C2
            // 
            this.C2.HeaderText = "C2";
            this.C2.MinimumWidth = 8;
            this.C2.Name = "C2";
            this.C2.ReadOnly = true;
            this.C2.Width = 108;
            // 
            // C3
            // 
            this.C3.HeaderText = "C3";
            this.C3.MinimumWidth = 8;
            this.C3.Name = "C3";
            this.C3.ReadOnly = true;
            this.C3.Width = 108;
            // 
            // C4
            // 
            this.C4.HeaderText = "C4";
            this.C4.MinimumWidth = 8;
            this.C4.Name = "C4";
            this.C4.ReadOnly = true;
            this.C4.Width = 108;
            // 
            // P
            // 
            this.P.HeaderText = "P";
            this.P.MinimumWidth = 8;
            this.P.Name = "P";
            this.P.ReadOnly = true;
            this.P.Width = 108;
            // 
            // Totales
            // 
            this.Totales.HeaderText = "Totales";
            this.Totales.MinimumWidth = 8;
            this.Totales.Name = "Totales";
            this.Totales.ReadOnly = true;
            this.Totales.Width = 150;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 36);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(146, 32);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // GrupoDatos
            // 
            this.GrupoDatos.Controls.Add(this.btnGuardar);
            this.GrupoDatos.Controls.Add(this.txtC4);
            this.GrupoDatos.Controls.Add(this.BtnCalcular);
            this.GrupoDatos.Controls.Add(this.label5);
            this.GrupoDatos.Controls.Add(this.TxtC3);
            this.GrupoDatos.Controls.Add(this.label4);
            this.GrupoDatos.Controls.Add(this.txtC2);
            this.GrupoDatos.Controls.Add(this.label3);
            this.GrupoDatos.Controls.Add(this.txtC1);
            this.GrupoDatos.Controls.Add(this.label2);
            this.GrupoDatos.Controls.Add(this.txtAlumno);
            this.GrupoDatos.Controls.Add(this.label1);
            this.GrupoDatos.Location = new System.Drawing.Point(40, 9);
            this.GrupoDatos.Name = "GrupoDatos";
            this.GrupoDatos.Size = new System.Drawing.Size(327, 345);
            this.GrupoDatos.TabIndex = 1;
            this.GrupoDatos.TabStop = false;
            this.GrupoDatos.Text = "Datos";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(83, 236);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(177, 43);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtC4
            // 
            this.txtC4.Location = new System.Drawing.Point(114, 204);
            this.txtC4.Name = "txtC4";
            this.txtC4.Size = new System.Drawing.Size(163, 26);
            this.txtC4.TabIndex = 5;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(83, 296);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(177, 43);
            this.BtnCalcular.TabIndex = 7;
            this.BtnCalcular.Text = "Calcular Total";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "C4";
            // 
            // TxtC3
            // 
            this.TxtC3.Location = new System.Drawing.Point(114, 166);
            this.TxtC3.Name = "TxtC3";
            this.TxtC3.Size = new System.Drawing.Size(163, 26);
            this.TxtC3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "C3";
            // 
            // txtC2
            // 
            this.txtC2.Location = new System.Drawing.Point(114, 125);
            this.txtC2.Name = "txtC2";
            this.txtC2.Size = new System.Drawing.Size(163, 26);
            this.txtC2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "C2";
            // 
            // txtC1
            // 
            this.txtC1.Location = new System.Drawing.Point(114, 84);
            this.txtC1.Name = "txtC1";
            this.txtC1.Size = new System.Drawing.Size(163, 26);
            this.txtC1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "C1";
            // 
            // txtAlumno
            // 
            this.txtAlumno.Location = new System.Drawing.Point(114, 44);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(163, 26);
            this.txtAlumno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alumno";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cerrar Grupo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(442, 341);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 42);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // BtnMenu
            // 
            this.BtnMenu.Location = new System.Drawing.Point(1107, 341);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(109, 42);
            this.BtnMenu.TabIndex = 10;
            this.BtnMenu.Text = "Menu";
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // FormCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 484);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GrupoDatos);
            this.Controls.Add(this.DGVListadealumnos);
            this.Name = "FormCalificaciones";
            this.Text = "Calificaciones";
            ((System.ComponentModel.ISupportInitialize)(this.DGVListadealumnos)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.GrupoDatos.ResumeLayout(false);
            this.GrupoDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVListadealumnos;
        private System.Windows.Forms.GroupBox GrupoDatos;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtC4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtC3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtC2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtC1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C2;
        private System.Windows.Forms.DataGridViewTextBoxColumn C3;
        private System.Windows.Forms.DataGridViewTextBoxColumn C4;
        private System.Windows.Forms.DataGridViewTextBoxColumn P;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totales;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}