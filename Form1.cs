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
        String input = String.Empty;
        String op1 = String.Empty;
        String op2 = String.Empty;
        char operation;
        double res = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        // Accessor method to set the value of 'input'
        public void SetInput(string value)
        {
            input = value;
        }

        // Accessor method to get the value of 'input'
        public string GetInput()
        {
            return input;
        }

        // Accessor method to set the value of 'op1'
        public void SetOp1(string value)
        {
            op1 = value;
        }

        // Accessor method to get the value of 'op1'
        public string GetOp1()
        {
            return op1;
        }

        // Accessor method to set the value of 'op2'
        public void SetOp2(string value)
        {
            op2 = value;
        }

        // Accessor method to get the value of 'op2'
        public string GetOp2()
        {
            return op2;
        }

        // Accessor method to set the value of 'operation'
        public void SetOperation(char value)
        {
            operation = value;
        }

        // Accessor method to get the value of 'operation'
        public char GetOperation()
        {
            return operation;
        }

        // Accessor method to set the value of 'res'
        public void SetResult(double value)
        {
            res = value;
        }

        // Accessor method to get the value of 'res'
        public double GetResult()
        {
            return res;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;

        }

        private void five_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void one_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
        }

        private void point_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += ".";
            this.textBox1.Text += input;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            op1 = input;
            operation = '/';
            input = String.Empty;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            op1 = input;
            operation = '*';
            input = String.Empty;
        }

        private void add_Click(object sender, EventArgs e)
        {
            op1 = input;
            operation = '+';
            input = String.Empty;
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            op1 = input;
            operation = '-';
            input = String.Empty;
        }

        private void solve_Click(object sender, EventArgs e)
        {
            op2 = input;
            double num1, num2;
            double.TryParse(op1, out num1);
            double.TryParse(op2, out num2);

            if (operation == '+')
            {
                res = num1 + num2;
                textBox1.Text = res.ToString();
            }
            else if (operation == '-')
            {
                res = num1 - num2;
                textBox1.Text = res.ToString();
            }
            else if (operation == '*')
            {
                res = num1 * num2;
                textBox1.Text = res.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    res = num1 / num2;
                    textBox1.Text = res.ToString();
                }
                else
                {
                    textBox1.Text = "DIV/Zero!";
                }

            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.op1 = string.Empty;
            this.op2 = string.Empty;
        }
    }
}
