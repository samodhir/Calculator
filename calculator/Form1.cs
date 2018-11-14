using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            //displayed dot(.) button with blue
            textBox1.Text = textBox1.Text + ".";
            textBox1.ForeColor = Color.Blue;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //displayed 0 in blue when click the 0 botton
            textBox1.Text = textBox1.Text + 0;
            textBox1.ForeColor = Color.Blue;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //displayed 1 in blue when click the 1 botton
            textBox1.Text = textBox1.Text + 1;
            textBox1.ForeColor = Color.Blue;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //displayed 2 in blue when click the 2 botton
            textBox1.Text = textBox1.Text + 2;
            textBox1.ForeColor = Color.Blue;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //displayed 3 in blue when click the 3 botton
            textBox1.Text = textBox1.Text + 3;
            textBox1.ForeColor = Color.Blue;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //displayed 4 in blue when click the 4 botton
            textBox1.Text = textBox1.Text + 4;
            textBox1.ForeColor = Color.Blue;
        }
    }
}
