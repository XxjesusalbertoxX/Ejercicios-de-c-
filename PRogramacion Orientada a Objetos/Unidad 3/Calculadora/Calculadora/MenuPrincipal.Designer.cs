﻿namespace Calculadora
{
    partial class MenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.proyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sueldoEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FigurasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calificacionesAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proyectosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // proyectosToolStripMenuItem
            // 
            this.proyectosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sueldoEmpleadoToolStripMenuItem,
            this.FigurasToolStripMenuItem,
            this.calificacionesAlumnoToolStripMenuItem});
            this.proyectosToolStripMenuItem.Name = "proyectosToolStripMenuItem";
            this.proyectosToolStripMenuItem.Size = new System.Drawing.Size(106, 29);
            this.proyectosToolStripMenuItem.Text = "Proyectos";
            // 
            // sueldoEmpleadoToolStripMenuItem
            // 
            this.sueldoEmpleadoToolStripMenuItem.Name = "sueldoEmpleadoToolStripMenuItem";
            this.sueldoEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.sueldoEmpleadoToolStripMenuItem.Text = "SueldoEmpleado";
            this.sueldoEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.sueldoEmpleadoToolStripMenuItem_Click);
            // 
            // FigurasToolStripMenuItem
            // 
            this.FigurasToolStripMenuItem.Name = "FigurasToolStripMenuItem";
            this.FigurasToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.FigurasToolStripMenuItem.Text = "Figuras";
            this.FigurasToolStripMenuItem.Click += new System.EventHandler(this.FigurasToolStripMenuItem_Click);
            // 
            // calificacionesAlumnoToolStripMenuItem
            // 
            this.calificacionesAlumnoToolStripMenuItem.Name = "calificacionesAlumnoToolStripMenuItem";
            this.calificacionesAlumnoToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.calificacionesAlumnoToolStripMenuItem.Text = "CalificacionesAlumno";
            this.calificacionesAlumnoToolStripMenuItem.Click += new System.EventHandler(this.calificacionesAlumnoToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem proyectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sueldoEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FigurasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calificacionesAlumnoToolStripMenuItem;
    }
}