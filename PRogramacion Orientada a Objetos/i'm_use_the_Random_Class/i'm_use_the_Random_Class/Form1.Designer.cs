namespace i_m_use_the_Random_Class
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblshownumber = new System.Windows.Forms.Label();
            this.btnrestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(297, 248);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(187, 26);
            this.txtnum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(200, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 98);
            this.label1.TabIndex = 2;
            this.label1.Text = "The number has been generate, please enter the number. \r\n\r\nYou only have got 5 tr" +
    "y for win, good luck\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblshownumber
            // 
            this.lblshownumber.AutoSize = true;
            this.lblshownumber.BackColor = System.Drawing.Color.Yellow;
            this.lblshownumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblshownumber.Location = new System.Drawing.Point(222, 174);
            this.lblshownumber.Name = "lblshownumber";
            this.lblshownumber.Size = new System.Drawing.Size(335, 20);
            this.lblshownumber.TabIndex = 3;
            this.lblshownumber.Text = "Here will show if you number is near o not near";
            // 
            // btnrestart
            // 
            this.btnrestart.Location = new System.Drawing.Point(146, 309);
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.Size = new System.Drawing.Size(134, 72);
            this.btnrestart.TabIndex = 4;
            this.btnrestart.Text = "Restart";
            this.btnrestart.UseVisualStyleBackColor = true;
            this.btnrestart.Click += new System.EventHandler(this.btnrestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.btnrestart);
            this.Controls.Add(this.lblshownumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Random Class";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblshownumber;
        private System.Windows.Forms.Button btnrestart;
    }
}

