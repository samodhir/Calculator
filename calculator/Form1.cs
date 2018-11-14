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

        public void disable()//create one method to disable 
        {
            textBox1.Enabled = false;
            button1.Show();
            button2.Hide();
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button3.Enabled = false;
        }

        public void enable()
        {
            textBox1.Enabled = true;
            button1.Hide();
            button2.Show();
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button3.Enabled = true;
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

        private void button11_Click(object sender, EventArgs e)
        {
            //displayed 5 in blue when click the 5 botton
            textBox1.Text = textBox1.Text + 5;
            textBox1.ForeColor = Color.Blue;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //displayed 6 in blue when click the 6 botton
            textBox1.Text = textBox1.Text + 6;
            textBox1.ForeColor = Color.Blue;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //displayed 7 in blue when click the 7 botton
            textBox1.Text = textBox1.Text + 7;
            textBox1.ForeColor = Color.Blue;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //displayed 8 in blue when click the 1 botton
            textBox1.Text = textBox1.Text + 8;
            textBox1.ForeColor = Color.Blue;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //displayed 9 in blue when click the 9 botton
            textBox1.Text = textBox1.Text + 9;
            textBox1.ForeColor = Color.Blue;
        }

        private void button2_Click(object sender, EventArgs e)//OFF button
        {
            disable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enable();
        }
    }
}
