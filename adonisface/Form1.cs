using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adonisface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label5.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = double.Parse(textBox3.Text);

            label5.Visible = true;

            if(Class1.X1(a, b, c) == Class1.X2(a, b, c))
            {
                label5.Text = "answer: " + $"x = {Class1.X1(a, b, c)};
            }
            else
                label5.Text = "answer: " + $"x1 = {Class1.X1(a, b, c)}, x2 = {Class1.X2(a, b, c)}";
        }
    }
}
