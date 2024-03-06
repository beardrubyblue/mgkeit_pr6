using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);

            textBox3.Text += "Результат работы программы " + "ст. Сысоев А.А" + Environment.NewLine;
            textBox3.Text += "При X = " + textBox1.Text + Environment.NewLine;
            textBox3.Text += "При Y = " + textBox2.Text + Environment.NewLine;

            double a = 0;

            if (radioButton1.Checked)
            {
                if ((x * y) == 0)
                    a = Math.Pow(Math.Sinh(x) + y, 2) - Math.Sqrt((Math.Sinh(x) * y));
                else
                    if ((x * y) > 0)
                        a = Math.Pow(Math.Sinh(x) + y, 2) + Math.Sqrt(Math.Abs(Math.Sinh(x) * y));
                    else
                        a = Math.Pow(Math.Sinh(x) + y, 2) + 1;
            }
            else if (radioButton2.Checked)
            {
                if ((x * y) == 0)
                    a = Math.Pow(Math.Pow(x, 2) + y, 2) - Math.Sqrt((Math.Pow(x, 2) * y));
                else
                    if ((x * y) > 0)
                    a = Math.Pow(Math.Pow(x, 2) + y, 2) + Math.Sqrt(Math.Abs(Math.Pow(x, 2) * y));
                else
                    a = Math.Pow(Math.Pow(x, 2) + y, 2) + 1;
            }
             else if (radioButton3.Checked)
            {
                if ((x * y) == 0)
                    a = Math.Pow(Math.Exp(x) + y, 2) - Math.Sqrt((Math.Exp(x) * y));
                else
                    if ((x * y) > 0)
                    a = Math.Pow(Math.Exp(x) + y, 2) + Math.Sqrt(Math.Abs(Math.Exp(x) * y));
                else
                    a = Math.Pow(Math.Exp(x) + y, 2) + 1;
            }

            textBox3.Text += "A = " + a.ToString() + Environment.NewLine;
        }
    }
}