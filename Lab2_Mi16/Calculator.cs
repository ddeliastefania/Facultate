using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laborator2
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private double FirstNumber;
        private string operationPerformed;
        private double resultValue;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "1";
            else
                textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "2";
            else
                textBox1.Text = textBox1.Text + "2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "6";
            else
                textBox1.Text = textBox1.Text + "6";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = textBox1.Text + "1";
            else
                textBox1.Text = "1";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "-";
            else
                textBox1.Text = textBox1.Text + "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "*";
            else
                textBox1.Text = textBox1.Text + "*";
        }

        //private void buttonEqual_Click(object sender, EventArgs e)
        //{
        //    double SecondNumber;
        //    double Result;

        //    SecondNumber = Convert.ToDouble(textBox1.Text.Length);

        //    if (Operation == "+")
        //    {
        //        Result = (FirstNumber + SecondNumber);
        //        textBox1.Text = Convert.ToString(Result);
        //        FirstNumber = Result;
        //    }

        //}

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {

                case "+":
                    if(textBox1.Text[textBox1.Text.Length - 1] != Convert.ToChar("+"))
                    {
                        textBox1.Text = (resultValue + Double.Parse(textBox1.Text)).ToString();
                    }
                    break;
                case "-":
                    if (textBox1.Text[textBox1.Text.Length - 1] != Convert.ToChar("-"))
                    {
                        textBox1.Text = (resultValue + Double.Parse(textBox1.Text)).ToString();
                    }
                    break;
                case "/":
                    if (textBox1.Text[textBox1.Text.Length - 1] != Convert.ToChar("/"))
                    {
                        textBox1.Text = (resultValue + Double.Parse(textBox1.Text)).ToString();
                    }
                    break;
                case "*":
                    if (textBox1.Text[textBox1.Text.Length - 1] != Convert.ToChar("*"))
                    {
                        textBox1.Text = (resultValue + Double.Parse(textBox1.Text)).ToString();
                    }
                    break;
            }
        }
        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void buttonPunct_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "0.";
            else
                textBox1.Text = textBox1.Text + ".";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "3";
            else
                textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "4";
            else
                textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "5";
            else
                textBox1.Text = textBox1.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "7";
            else
                textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "8";
            else
                textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "9";
            else
                textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "/";
            else
                textBox1.Text = textBox1.Text + "/";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            if (textBox1.Text == "0")
                textBox1.Text = "+";
            else
                textBox1.Text = textBox1.Text + "+";
            operationPerformed = "+";

        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            if (textBox1.Text == "0")
                textBox1.Text = "-";
            else
                textBox1.Text = textBox1.Text + "-";
            operationPerformed = "-";

        }
        private void buttonMult_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            if (textBox1.Text == "0")
                textBox1.Text = "*";
            else
                textBox1.Text = textBox1.Text + "*";
            operationPerformed = "*";

        }
        private void buttonDiv_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            if (textBox1.Text == "0")
                textBox1.Text = "/";
            else
                textBox1.Text = textBox1.Text + "/";
            operationPerformed = "/";

        }
        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
