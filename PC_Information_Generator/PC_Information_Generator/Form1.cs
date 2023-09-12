using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_Information_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(MessageBox.Show("Page Loading!, Would you like to Continue","Alert",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                MessageBox.Show("Continue with Checking your PC Checkings!");
            }
            else
            {
                MessageBox.Show("Thanks for using the Application");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = Environment.MachineName;
            MessageBox.Show("The Detail in the box is Your Pc Name");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox2.Text= Environment.UserName;
            MessageBox.Show("This is your Login name");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = Environment.ProcessorCount.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x;int j;
            x = Environment.TickCount;
            j = x / 1000; int y = j / 3600;//This changes the seconds to hours
            this.textBox4.Text = y.ToString();
            MessageBox.Show($"It is {y} hours from the Last Boot");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox5.Text = System.Windows.Forms.Screen.PrimaryScreen.Bounds.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox6.Text = Application.ProductVersion;
        }
    }
}
