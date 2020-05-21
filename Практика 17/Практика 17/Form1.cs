using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            if (!Correct())
                textBox2.Text = "Введено не двоичное число";
            else
            {
                if (radioButton1.Checked)
                    textBox2.Text = Translate.translate8(textBox1.Text);
                if (radioButton2.Checked)
                    textBox2.Text = Translate.translate10(textBox1.Text);
                if (radioButton3.Checked)
                    textBox2.Text = Translate.translate16(textBox1.Text);
            }
        }
        private bool Correct()
        {
            bool f = false;
            string s = "";
            for(int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] != '0' && textBox1.Text[i] != '1')
                    return false;
                if (textBox1.Text[i] == '1')
                    f = true;
                if (f)
                    s += textBox1.Text[i];
            }
            textBox1.Text = s;
            return true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void textBox1_KeyDown(object sender, KeyEventArgs e){ }
    }
}
