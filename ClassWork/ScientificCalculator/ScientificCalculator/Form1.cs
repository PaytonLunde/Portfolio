using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScientificCalculator
{
    public partial class Form1 : Form
    {
        public decimal num1;
        public decimal num2;
        string operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BtnRadical.Text = "\u221A";
        }
        private void Input(string a)
        {
            if (Display.Text == "0")
            {
                Display.Text = a;
            }
            else
            {
                Display.Text += a;
            }
        }

        private void numberOne_Click(object sender, EventArgs e)
        {
            Input("1");
        }

        private void numberTwo_Click(object sender, EventArgs e)
        {
            Input("2");
        }

        private void numberThree_Click(object sender, EventArgs e)
        {
            Input("3");
        }

        private void numberFour_Click(object sender, EventArgs e)
        {
            Input("4");
        }

        private void numberFive_Click(object sender, EventArgs e)
        {
            Input("5");
        }

        private void numberSix_Click(object sender, EventArgs e)
        {
            Input("6");
        }

        private void numberSeven_Click(object sender, EventArgs e)
        {
            Input("7");
        }

        private void numberEight_Click(object sender, EventArgs e)
        {
            Input("8");
        }

        private void numberNine_Click(object sender, EventArgs e)
        {
            Input("9");
        }

        private void numberZero_Click(object sender, EventArgs e)
        {
            Input("0");
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(Display.Text);
            operation = "+";
            Display.Text = "0";
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(Display.Text);
            operation = "-";
            Display.Text = "0";
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(Display.Text);
            operation = "*";
            Display.Text = "0";
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(Display.Text);
            operation = "/";
            Display.Text = "0";
        }

        private void BtnMod_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(Display.Text);
            operation = "%";
            Display.Text = "0";
        }

        private void BtnExponention_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(Display.Text);
            operation = "^";
            Display.Text = "0";
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            num2 = decimal.Parse(Display.Text);
            switch (operation)
            {
                case "+":
                    Display.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    Display.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    Display.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    Display.Text = (num1 / num2).ToString();
                    break;
                case "^":
                    Display.Text = (int.Parse(num1.ToString()) ^ int.Parse(num2.ToString())).ToString();
                    break;
                case "%":
                    Display.Text = (num1 % num2).ToString();
                    break;
            }
        }

        private void BtnCosine_Click(object sender, EventArgs e)
        {
            Display.Text = (Math.Cos(double.Parse(Display.Text))).ToString();
        }

        private void BtnSine_Click(object sender, EventArgs e)
        {
            Display.Text = (Math.Sin(double.Parse(Display.Text))).ToString();
        }

        private void BtnTangent_Click(object sender, EventArgs e)
        {
            Display.Text = (Math.Tan(double.Parse(Display.Text))).ToString();
        }

        private void BtnFactorial_Click(object sender, EventArgs e)
        {
            long f = 1;
            for (long i = 1; i <= long.Parse(Display.Text); i++)
            {
                f = f * i;
            }
            Display.Text = f.ToString();
        }

        private void BtnRadical_Click(object sender, EventArgs e)
        {
            Display.Text = (Math.Sqrt(double.Parse(Display.Text))).ToString();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            num1 = 0;
            operation = "";
            Display.Text = "0";
        }
    }
}
