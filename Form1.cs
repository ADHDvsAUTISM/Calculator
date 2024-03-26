using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c;
            if (radioButton1.Checked)
            {
                c = a + b;
                label4.Text = "RESULTS: " + c.ToString();
            }
            else if (radioButton2.Checked)
            {
                c = a - b;
                label4.Text = "RESULTS: " + c.ToString();
            }
            else if (radioButton3.Checked)
            {
                c = a * b;
                label4.Text = "RESULTS: " + c.ToString();
            }
            else if (radioButton4.Checked)
            {
                c = a / b;
                label4.Text = "RESULTS: " + c.ToString();
            }
            else if (radioButton5.Checked)
            {
                c = a % b;
                label4.Text = "RESULTS: " + c.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
