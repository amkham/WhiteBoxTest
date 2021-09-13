using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhiteBoxTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);

            float d = b * b - 4 * a * c;

            float x1 = (float)((-b + Math.Sqrt(d)) / (2 * a));
            float x2 = (float)((-b - Math.Sqrt(d)) / (2 * a));
            label4.Text = "x1 = " + x1.ToString();
            label5.Text = "x2 = " + x2.ToString();
        }
    }
}
