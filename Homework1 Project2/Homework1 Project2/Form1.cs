using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework1_Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            insertComboItem();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void insertComboItem()
        {
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            char sign = char.Parse(comboBox1.Text);
            double c = 0;
            double first = double.Parse(textBox1.Text);
            double second = double.Parse(textBox2.Text);
            switch (sign)
            {
                case '+':
                    c = first + second;
                    break;
                case '-':
                    c = first - second;
                    break;
                case '*':
                    c = first * second;
                    break;
                case '/':
                    if (second != 0)
                    {
                        c = first / second;
                    }
                    else
                    {
                        textBox3.Text = "除数不能为零";
                    }

                    break;

            }
            textBox3.Text = c.ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string a = textBox1.Text;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string b = textBox2.Text;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
