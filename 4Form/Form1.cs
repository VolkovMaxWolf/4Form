using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FindFuncButton(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && Сheck(textBox1.Text) &&
                textBox2.Text != "" && Сheck(textBox2.Text))
            {
                textBox3.Text = Convert.ToString(Func(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
            }
                
        }
        private bool Сheck(String s)
        {
            char[] arr = s.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!char.IsDigit(arr[i]) && arr[i] == '-' && arr[i] != ',')
                {
                    return false;
                }
            }
            return true;
        }
        private double Func(double x, double n)
        {
            if (n == 0) return 1;
            else if (n < 0) return 1 / Func(x, -n);
            else return x * Func(x, n - 1);
        }

        private void FindGeomProgButton(object sender, EventArgs e)
        {
            if (textBox5.Text != "" && Сheck(textBox5.Text) &&
                textBox4.Text != "" && Сheck(textBox4.Text) && 
                textBox6.Text != "" && Сheck(textBox6.Text) )
            {
                GeometricProgression(Convert.ToDouble(textBox5.Text), Convert.ToDouble(textBox4.Text),
                    Convert.ToInt32(textBox6.Text), 0);
            }
        }
        private void GeometricProgression(double b, double q, int n, double sum)
        {
            if (n == 0) return;
            textBox7.AppendText(Convert.ToString(b * q));
            sum += (b * q);
            textBox7.AppendText(" sum: " + sum + Environment.NewLine);
            GeometricProgression(b * q, q, --n, sum);
        }
    }
}
