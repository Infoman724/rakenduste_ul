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
        //создаем обьект рандома "randomizer" для генерации случайных чисел
        Random randomizer = new Random();

        //создаем две переменные для хранения случайных чисел (+)
        int addend1;
        int addend2;

        //создаем две переменные для хранения случайных чисел (-)
        int diffend1;
        int diffend2;

        //создаем две переменные для хранения чисел (*)
        int multiplicand;
        int multiplier;

        //создаем две переменные для хранения чисел (/)
        int dividend;
        int divisor;

        //создаем таймер для нашего quiz
        int timeLeft;
        private void InitializeComponent()//функция из которой запускается/работает программа
        {
            components = new Container();
            timeLabel = new Label();
            label1 = new Label();
            plusLeftLabel = new Label();
            label2 = new Label();
            plusRightLabel = new Label();
            label4 = new Label();
            sum = new NumericUpDown();
            difference = new NumericUpDown();
            label = new Label();
            differenceRightLabel = new Label();
            label6 = new Label();
            differenceLeftLabel = new Label();
            product = new NumericUpDown();
            mult = new Label();
            productRightLabel = new Label();
            label10 = new Label();
            productLeftLabel = new Label();
            quotient = new NumericUpDown();
            div = new Label();
            quotientRightLabel = new Label();
            label14 = new Label();
            quotientLeftLabel = new Label();
            startButton = new Button();
            timer1 = new Timer(this.components);
            showDate = new Label();
            
            // 
            // timeLabel
            // 
            timeLabel.BorderStyle = BorderStyle.FixedSingle;
            timeLabel.Font = new Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular);
            timeLabel.Location = new Point(272, 3);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(200, 30);
            timeLabel.TabIndex = 0;
            timeLabel.Click += new EventHandler(this.timeLabel_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular);
            label1.Location = new Point(165, 3);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 1;
            label1.Text = "Time Left";
            // 
            // plusLeftLabel
            // 
            plusLeftLabel.Font = new Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular);
            plusLeftLabel.Location = new Point(50, 75);
            plusLeftLabel.Name = "plusLeftLabel";
            plusLeftLabel.Size = new Size(60, 50);
            plusLeftLabel.TabIndex = 2;
            plusLeftLabel.Text = "?";
            plusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular);
            label2.Location = new Point(248, 75);
            label2.Name = "label2";
            label2.Size = new Size(60, 50);
            label2.TabIndex = 3;
            label2.Text = "=";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            plusRightLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular);
            plusRightLabel.Location = new Point(182, 75);
            plusRightLabel.Name = "plusRightLabel";
            plusRightLabel.Size = new Size(60, 50);
            plusRightLabel.TabIndex = 4;
            plusRightLabel.Text = "?";
            plusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            plusRightLabel.Click += new EventHandler(this.label3_Click);
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular);
            label4.Location = new Point(116, 75);
            label4.Name = "label4";
            label4.Size = new Size(60, 50);
            label4.TabIndex = 5;
            label4.Text = "+";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += new EventHandler(this.label4_Click);
            // 
            // sum
            // 
            sum.Font = new Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular);
            sum.Location = new Point(314, 90);
            sum.Name = "sum";
            sum.Size = new Size(100, 35);
            sum.TabIndex = 2;
            sum.ValueChanged += new EventHandler(this.Correct_Answer);
            sum.Enter += new EventHandler(this.answer_Enter);
            // 
            // difference
            // 
            difference.Font = new Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular);
            difference.Location = new Point(314, 140);
            difference.Name = "difference";
            difference.Size = new Size(100, 35);
            difference.TabIndex = 3;
            difference.ValueChanged += new EventHandler(this.Correct_Answer);
            difference.Enter += new EventHandler(this.answer_Enter);
            // 
            // label
            // 
            label.Font = new Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular);
            label.Location = new Point(116, 125);
            label.Name = "label";
            label.Size = new Size(60, 50);
            label.TabIndex = 10;
            label.Text = "-";
            label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // differenceRightLabel
            // 
            differenceRightLabel.Font = new Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular);
            differenceRightLabel.Location = new Point(182, 125);
            differenceRightLabel.Name = "differenceRightLabel";
            differenceRightLabel.Size = new Size(60, 50);
            differenceRightLabel.TabIndex = 9;
            differenceRightLabel.Text = "?";
            differenceRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular);
            label6.Location = new Point(248, 125);
            label6.Name = "label6";
            label6.Size = new Size(60, 50);
            label6.TabIndex = 8;
            label6.Text = "=";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // differenceLeftLabel
            // 
            differenceLeftLabel.Font = new Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular);
            differenceLeftLabel.Location = new Point(50, 125);
            differenceLeftLabel.Name = "differenceLeftLabel";
            differenceLeftLabel.Size = new Size(60, 50);
            differenceLeftLabel.TabIndex = 7;
            differenceLeftLabel.Text = "?";
            differenceLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // product
            // 
            product.Font = new Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular);
            product.Location = new Point(314, 190);
            product.Name = "product";
            product.Size = new Size(100, 35);
            product.TabIndex = 4;
            product.ValueChanged += new EventHandler(this.Correct_Answer);
            product.Enter += new EventHandler(this.answer_Enter);
            // 
            // mult
            // 
            mult.Font = new Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular);
            mult.Location = new Point(116, 175);
            mult.Name = "mult";
            mult.Size = new Size(60, 50);
            mult.TabIndex = 15;
            mult.Text = "*";
            mult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // productRightLabel
            // 
            productRightLabel.Font = new Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular);
            productRightLabel.Location = new Point(182, 175);
            productRightLabel.Name = "productRightLabel";
            productRightLabel.Size = new Size(60, 50);
            productRightLabel.TabIndex = 14;
            productRightLabel.Text = "?";
            productRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Font = new Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular);
            label10.Location = new Point(248, 175);
            label10.Name = "label10";
            label10.Size = new Size(60, 50);
            label10.TabIndex = 13;
            label10.Text = "=";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // productLeftLabel
            // 
            productLeftLabel.Font = new Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular);
            productLeftLabel.Location = new Point(50, 175);
            productLeftLabel.Name = "productLeftLabel";
            productLeftLabel.Size = new Size(60, 50);
            productLeftLabel.TabIndex = 12;
            productLeftLabel.Text = "?";
            productLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // quotient
            // 
            quotient.Font = new Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular);
            quotient.Location = new Point(314, 240);
            quotient.Name = "quotient";
            quotient.Size = new Size(100, 35);
            quotient.TabIndex = 5;
            quotient.ValueChanged += new EventHandler(this.Correct_Answer);
            quotient.Enter += new EventHandler(this.answer_Enter);
            // 
            // div
            // 
            div.Font = new Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular);
            div.Location = new Point(116, 225);
            div.Name = "div";
            div.Size = new Size(60, 50);
            div.TabIndex = 20;
            div.Text = "/";
            div.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // quotientRightLabel
            // 
            quotientRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular);
            quotientRightLabel.Location = new Point(182, 225);
            quotientRightLabel.Name = "quotientRightLabel";
            quotientRightLabel.Size = new Size(60, 50);
            quotientRightLabel.TabIndex = 19;
            quotientRightLabel.Text = "?";
            quotientRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.Font = new Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular);
            label14.Location = new Point(248, 225);
            label14.Name = "label14";
            label14.Size = new Size(60, 50);
            label14.TabIndex = 18;
            label14.Text = "=";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // quotientLeftLabel
            // 
            quotientLeftLabel.Font = new Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular);
            quotientLeftLabel.Location = new Point(50, 225);
            quotientLeftLabel.Name = "quotientLeftLabel";
            quotientLeftLabel.Size = new Size(60, 50);
            quotientLeftLabel.TabIndex = 17;
            quotientLeftLabel.Text = "?";
            quotientLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            startButton.AutoSize = true;
            startButton.Font = new Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular);
            startButton.Location = new Point(157, 302);
            startButton.Name = "startButton";
            startButton.Size = new Size(127, 34);
            startButton.TabIndex = 1;
            startButton.Text = "Start the quiz";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += new EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // showDate
            // 
            showDate.AutoSize = true;
            showDate.Location = new Point(360, 320);
            showDate.Name = "showDate";
            showDate.Size = new Size(0, 13);
            showDate.TabIndex = 21;
            // 
            // Form1
            // 
            ClientSize = new Size(484, 361);
            Controls.Add(showDate);
            Controls.Add(startButton);
            Controls.Add(quotient);
            Controls.Add(div);
            Controls.Add(quotientRightLabel);
            Controls.Add(label14);
            Controls.Add(quotientLeftLabel);
            Controls.Add(product);
            Controls.Add(mult);
            Controls.Add(productRightLabel);
            Controls.Add(label10);
            Controls.Add(productLeftLabel);
            Controls.Add(difference);
            Controls.Add(label);
            Controls.Add(differenceRightLabel);
            Controls.Add(label6);
            Controls.Add(differenceLeftLabel);
            Controls.Add(sum);
            Controls.Add(label4);
            Controls.Add(plusRightLabel);
            Controls.Add(label2);
            Controls.Add(plusLeftLabel);
            Controls.Add(label1);
            Controls.Add(timeLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;

            MaximizeBox = false;
            Name = "Form1";
            Text = "Matemaateline Quiz";
        }

        

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
        

        private Label timeLabel;
        private Label label1;
        private Label plusLeftLabel;
        private Label label2;
        private Label plusRightLabel;
        private Label label4;
        private NumericUpDown sum;
        private NumericUpDown difference;
        private Label label;
        private Label differenceRightLabel;
        private Label label6;
        private Label differenceLeftLabel;
        private NumericUpDown product;
        private Label mult;
        private Label productRightLabel;
        private Label label10;
        private Label productLeftLabel;
        private NumericUpDown quotient;
        private Label div;
        private Label quotientRightLabel;
        private Label label14;
        private Label quotientLeftLabel;
        private Button startButton;
        private Timer timer1;
        private Label showDate;
    }
}