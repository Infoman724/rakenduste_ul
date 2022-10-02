using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rakenduste_ul
{
    public partial class Form2 : Form
    {
        //Create a random object called randomizer to generate random numbers
        Random randomizer = new Random();

        //create two variables to store the random numbers
        int addend1;
        int addend2;

        //these two variables store the difference random numbers
        int diffend1;
        int diffend2;

        //store the multiplication variables
        int multiplicand;
        int multiplier;

        //store the division variables
        int dividend;
        int divisor;

        //create the timer for the quiz
        int timeLeft;

        //add a method called StartTheQuiz()

        public void StartTheQuiz()
        {
            //fill the addition problem with random numbers and store them in the variables
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            //convert random numbers into strings for the addition problem
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            //check if sum is 0 before adding values.
            sum.Value = 0;

            //fill the subtraction problem
            diffend1 = randomizer.Next(1, 101);
            diffend2 = randomizer.Next(1, diffend1);

            //convert the values to strings
            differenceLeftLabel.Text = diffend1.ToString();
            differenceRightLabel.Text = diffend2.ToString();
            difference.Value = 0;

            //generate and fill the product problem
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);

            //convert to string
            productLeftLabel.Text = multiplicand.ToString();
            productRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            //generate and fill the division problem
            divisor = randomizer.Next(2, 11);
            int temporayQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporayQuotient;

            //convert to string
            quotientLeftLabel.Text = dividend.ToString();
            quotientRightLabel.Text = divisor.ToString();

            //check if quotient is 0
            quotient.Value = 0;




            //start the timer
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }

        //check the answer to see if correct
        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value) && (diffend1 - diffend2 == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value)
                )

                return true;
            else
                return false;

        }



        public Form2()
        {
            InitializeComponent();
        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if CheckTheAnswer returns true, stop the timer and congratulate the user with a message.

            if (CheckTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("You got all the answers correct. Congratulations!");
                startButton.Enabled = true;
            }

            if (timeLeft == 5)
            {
                timeLabel.BackColor = Color.Red;
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";

            }



            else if (timeLeft > 0)
            {

                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
            }

            else
            {
                //stop time, and show a message if time runs out
                timer1.Stop();
                timeLabel.Text = "Time is up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");

                sum.Value = addend1 + addend2;
                difference.Value = diffend1 - diffend2;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
                timeLabel.BackColor = Form2.DefaultBackColor;
            }



        }


        private void answer_Enter(object sender, EventArgs e)
        {
            //Select the whole answer in the NumericUpDown control
            NumericUpDown answerBox = sender as NumericUpDown;
            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }




        


        //alert user when correct answer is entered
        private void Correct_Answer(object sender, EventArgs e)
        {
            if (addend1 + addend2 == sum.Value)
            {
                System.Media.SystemSounds.Exclamation.Play();
            }
        }
    }
}