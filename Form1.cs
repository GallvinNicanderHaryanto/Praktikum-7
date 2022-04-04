using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            {
                textBox1 = textBox2;
            }
            textBox1.Clear();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            {
                textBox2 = textBox3;
            }
            textBox1.Clear();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            {
                textBox3 = textBox1;
            }
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == " " && textBox1.Text != null)
            {
                textBox2.Text = "c";
            }
            else
            {
                textBox2.Text = textBox3.Text = "a";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
    }
