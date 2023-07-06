using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int a, b, c;

        private void button3_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = a * b;
            textBox3.Text = c.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            if (b == 0)
            {
                MessageBox.Show("Enter a valid data");
                textBox2.Focus();
            }
            else
            {
                c = a / b;
                textBox3.Text = c.ToString();
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter any valid data");
                textBox1.Focus();
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Enter any valid data");
                textBox2.Focus();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar)== false)
            {
                MessageBox.Show("Enter any valid data");
                e.Handled= true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (char.IsDigit(e.KeyChar) == false)
            {
                MessageBox.Show("Enter any valid data");
                e.Handled = true;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = a - b;
            textBox3.Text = c.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a=Convert.ToInt32(textBox1.Text); 
            b=Convert.ToInt32(textBox2.Text);
            c = a + b;
            textBox3.Text=c.ToString();
        }
    }
}
