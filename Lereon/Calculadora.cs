using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lereon
{
    public partial class calculadora : Form
    {
        public calculadora()
        {
            InitializeComponent();
        }

        public string input = "";
        public string operador1 = "";
        public string operador2 = "";
        public char operante = ' ';
        public double total = 0.0;


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            this.input = string.Empty;
            this.operador1 = string.Empty;
            this.operador2 = string.Empty;
            buttonPoint.Enabled = true;
            button12.Enabled = true;
        }

        private void buttonCero_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operador2 = input;
            double num1=0, num2=0;
            double.TryParse(operador1, out num1);
            double.TryParse(operador2, out num2);
            switch (operante){
                case '+':
                    total = num1 + num2;
                    textBox1.Text = total.ToString();
                    break;
                case '-':
                    total = num1 - num2;
                    textBox1.Text = total.ToString();
                    break;
                case '*':
                    total = num1 * num2;
                    textBox1.Text = total.ToString();
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        total = num1 / num2;
                        textBox1.Text = total.ToString();
                    }
                    else
                    {
                        textBox1.Text = "Error no divida por cero, pulse la telca C para volver a calcular";
                        button12.Enabled = false;
                    }
                    break;
            }
            input = total.ToString();

        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            operador1 = input;
            operante = '+';
            input = string.Empty;
        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            operador1 = input;
            operante = '-';
            input = string.Empty;
        }

        private void buttonMultiplicar_Click(object sender, EventArgs e)
        {
            operador1 = input;
            operante = '*';
            input = string.Empty;
        }

        private void buttonDividir_Click(object sender, EventArgs e)
        {
            operador1 = input;
            operante = '/';
            input = string.Empty;
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {

            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {

            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += ".";
            this.textBox1.Text += input;
            buttonPoint.Enabled = false;
        }
    }
 }
