using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace i_m_use_the_Random_Class
{
    public partial class Form1 : Form
    {
        static Random num = new Random();
        static int randomnumber = num.Next(0, 101); // Generate random number between 0 and 100
        static int trys = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int intentos = 0;

            string text = txtnum.Text;

            
            if (int.TryParse(text, out int number))
            {
                if (number < 100)
                {
                    intentos++;
                    if (number > randomnumber)
                    {
                        label1.Text = $"The number has been generate, please enter the number. \r\n\r\nYou only have got {trys} try for win, good luck\r\n";
                        lblshownumber.Text = "Your number is high.";
                        txtnum.Clear();
                    }
                    else if (number < randomnumber)
                    {
                        label1.Text = $"The number has been generate, please enter the number. \r\n\r\nYou only have got {trys} try for win, good luck\r\n";
                        lblshownumber.Text = "Your number is low.";
                        txtnum.Clear();
                    }
                    else
                    {
                        label1.Text = $"The number has been generate, please enter the number. \r\n\r\nYou only have got {trys} try for win, good luck\r\n";
                        lblshownumber.Text = $"You win. trys: {intentos}";
                        button1.Enabled = false;
                        txtnum.Clear();
                    }
                }
                else 
                {
                    lblshownumber.Text =  "You onli type numbers 0 to 100";
                    txtnum.Clear();
                }
            }
            else
            {
                lblshownumber.Text = "Invalid input. Please enter a valid number.";
                txtnum.Clear();
            }

            if (trys == 0)
            {
                lblshownumber.Text = $"Game Over The number was {randomnumber}.";
                button1.Enabled = false;
                txtnum.Clear();
            }


            trys--;
        }

        private void btnrestart_Click(object sender, EventArgs e)
        {
            trys = 5;
            button1.Enabled = true;
            txtnum.Clear();
            randomnumber = num.Next(0, 101);
            lblshownumber.Text = "here will show if you number is near o not near.";
        }
    }
}
