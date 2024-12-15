namespace Empleado
{
    partial class BancoLogin
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
            this.NombreLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CuentaLogin = new System.Windows.Forms.TextBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // NombreLogin
            // 
            this.NombreLogin.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLogin.Location = new System.Drawing.Point(219, 98);
            this.NombreLogin.Name = "NombreLogin";
            this.NombreLogin.Size = new System.Drawing.Size(152, 28);
            this.NombreLogin.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cuenta:";
            // 
            // CuentaLogin
            // 
            this.CuentaLogin.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CuentaLogin.Location = new System.Drawing.Point(219, 178);
            this.CuentaLogin.Name = "CuentaLogin";
            this.CuentaLogin.Size = new System.Drawing.Size(152, 28);
            this.CuentaLogin.TabIndex = 3;
            // 
            // Aceptar
            // 
            this.Aceptar.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F);
            this.Aceptar.Location = new System.Drawing.Point(157, 250);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(164, 73);
            this.Aceptar.TabIndex = 4;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Salir
            // 
            this.Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.Location = new System.Drawing.Point(12, 12);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(90, 35);
            this.Salir.TabIndex = 5;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // BancoLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 395);
            this.ControlBox = false;
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.CuentaLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombreLogin);
            this.Controls.Add(this.label1);
            this.Name = "BancoLogin";
            this.Text = "Banco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CuentaLogin;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button Salir;
    }
}