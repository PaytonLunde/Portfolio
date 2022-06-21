using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuizGame
{
    public partial class Form1 : Form
    {
        Random randomizer = new Random();
        int add1;
        int add2;

        int minus1;
        int minus2;

        int factor1;
        int factor2;

        int divide1;
        int divide2;

        int clock;
        public void startQuiz()
        {
            add1 = randomizer.Next(51);
            add2 = randomizer.Next(51);
            plusLeftLabel.Text = add1.ToString();
            plusRightLabel.Text = add2.ToString();
            sum.Value = 0;

            minus1 = randomizer.Next(101);
            minus2 = randomizer.Next(1, minus1);
            MinusLeftLabel.Text = minus1.ToString();
            MinusRightLabel.Text = minus2.ToString();
            diference.Value = 0;

            factor1 = randomizer.Next(2, 11);
            factor2 = randomizer.Next(2, 11);
            multiplyLeftLabel.Text = factor1.ToString();
            multiplyRightLabel.Text = factor2.ToString();
            Product.Value = 0;

            divide2 = randomizer.Next(2, 11);
            int temp = randomizer.Next(2, 11);
            divide1 = divide2 * temp;
            divisionLeftLabel.Text = divide1.ToString();
            DivisionRightLabel.Text = divide2.ToString();
            quotion.Value = 0;

            clock = 30;
            TimeLabel.Text = "30 Seconds";
            timer1.Start();
        }

        private bool CheckAnsers()
        {
            if ((add1 + add2 == sum.Value)
                && (minus1 - minus2 == diference.Value)
                && (factor1 * factor2 == Product.Value)
                && (divide1 / divide2 == quotion.Value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startQuiz();
            startButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (clock > 0)
            {
                clock = clock - 1;
                TimeLabel.Text = clock + " seconds";

            }
            else
            {
                timer1.Stop();
                TimeLabel.Text = "Time's up";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = add1 + add2;
                diference.Value = minus1 - minus2;
                Product.Value = factor1 * factor2;
                quotion.Value = divide1 / divide2;
                startButton.Enabled = true;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
    }
}
