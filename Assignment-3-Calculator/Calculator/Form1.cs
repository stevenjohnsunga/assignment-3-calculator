using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            textBox1.Focus();       }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("7");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("5");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("0");
        }

        private void button43_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("8");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("9");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("4");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("6");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("1");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("2");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("3");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(".");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Text = "0";
        }

        private void button35_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }
    }
}
