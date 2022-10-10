using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

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
        int AegVeel;
        private void InitializeComponent()//функция из которой запускается/работает программа
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form2));
            components = new Container();
            AegLabel = new Label();
            label1 = new Label();
            plusVasakLabel = new Label();
            label2 = new Label();
            plusParemLabel = new Label();
            label4 = new Label();
            sum = new NumericUpDown();
            erinevus = new NumericUpDown();
            label = new Label();
            erinevusParemLabel = new Label();
            label6 = new Label();
            erinevusVasakLabel = new Label();
            tood = new NumericUpDown();
            mult = new Label();
            toodParemLabel = new Label();
            label10 = new Label();
            toodVasakLabel = new Label();
            jagatis = new NumericUpDown();
            div = new Label();
            jagatisParemLabel = new Label();
            label14 = new Label();
            jagatisVasakLabel = new Label();
            startNupp = new Button();
            timer1 = new Timer(this.components);
            NaitaDate = new Label();
            Lihtsamvar = new Button(); //1
            Raskemvar = new Button(); //2
            tip = new Button();
            tip4 = new Button();
            tip3 = new Button();
            tip2 = new Button();

            // 
            // timeLabel
            // 
            AegLabel.BorderStyle = BorderStyle.FixedSingle;
            AegLabel.Font = new Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular);
            AegLabel.Location = new Point(272, 3);
            AegLabel.Name = "timeLabel";
            AegLabel.Size = new Size(200, 30);
            AegLabel.TabIndex = 0;
            AegLabel.Click += new EventHandler(this.AegLabel_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular);
            label1.Location = new Point(165, 3);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 1;
            label1.Text = "Aeg veel";
            // 
            // plusVasakLabel
            // 
            plusVasakLabel.Font = new Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular);
            plusVasakLabel.Location = new Point(50, 75);
            plusVasakLabel.Name = "plusVasakLabel";
            plusVasakLabel.Size = new Size(60, 50);
            plusVasakLabel.TabIndex = 2;
            plusVasakLabel.Text = "?";
            plusVasakLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            // plusParemLabel
            // 
            plusParemLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular);
            plusParemLabel.Location = new Point(182, 75);
            plusParemLabel.Name = "plusParemLabel";
            plusParemLabel.Size = new Size(60, 50);
            plusParemLabel.TabIndex = 4;
            plusParemLabel.Text = "?";
            plusParemLabel.TextAlign = ContentAlignment.MiddleCenter;
            plusParemLabel.Click += new EventHandler(this.label3_Click);
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
            sum.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular);
            sum.Location = new Point(314, 90);
            sum.Name = "sum";
            sum.Size = new Size(100, 35);
            sum.TabIndex = 2;
            sum.ValueChanged += new EventHandler(this.Correct_Answer);
            sum.Enter += new EventHandler(this.answer_Enter);
            // 
            // erinevus
            // 
            erinevus.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular);
            erinevus.Location = new Point(314, 140);
            erinevus.Name = "erinevus";
            erinevus.Size = new Size(100, 35);
            erinevus.TabIndex = 3;
            erinevus.ValueChanged += new EventHandler(this.Correct_Answer);
            erinevus.Enter += new EventHandler(this.answer_Enter);
            // 
            // label
            // 
            label.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular);
            label.Location = new Point(116, 125);
            label.Name = "label";
            label.Size = new Size(60, 50);
            label.TabIndex = 10;
            label.Text = "-";
            label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // erinevusParemLabel
            // 
            erinevusParemLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular);
            erinevusParemLabel.Location = new Point(182, 125);
            erinevusParemLabel.Name = "erinevusParemLabel";
            erinevusParemLabel.Size = new Size(60, 50);
            erinevusParemLabel.TabIndex = 9;
            erinevusParemLabel.Text = "?";
            erinevusParemLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular);
            label6.Location = new Point(248, 125);
            label6.Name = "label6";
            label6.Size = new Size(60, 50);
            label6.TabIndex = 8;
            label6.Text = "=";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // erinevusVasakLabel
            // 
            erinevusVasakLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular);
            erinevusVasakLabel.Location = new Point(50, 125);
            erinevusVasakLabel.Name = "erinevusVasakLabel";
            erinevusVasakLabel.Size = new Size(60, 50);
            erinevusVasakLabel.TabIndex = 7;
            erinevusVasakLabel.Text = "?";
            erinevusVasakLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tood
            // 
            tood.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular);
            tood.Location = new Point(314, 190);
            tood.Name = "tood";
            tood.Size = new Size(100, 35);
            tood.TabIndex = 4;
            tood.ValueChanged += new EventHandler(this.Correct_Answer);
            tood.Enter += new EventHandler(this.answer_Enter);
            // 
            // mult
            // 
            mult.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular);
            mult.Location = new Point(116, 175);
            mult.Name = "mult";
            mult.Size = new Size(60, 50);
            mult.TabIndex = 15;
            mult.Text = "*";
            mult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // toodParemLabel
            // 
            toodParemLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular);
            toodParemLabel.Location = new Point(182, 175);
            toodParemLabel.Name = "toodParemLabel";
            toodParemLabel.Size = new Size(60, 50);
            toodParemLabel.TabIndex = 14;
            toodParemLabel.Text = "?";
            toodParemLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular);
            label10.Location = new Point(248, 175);
            label10.Name = "label10";
            label10.Size = new Size(60, 50);
            label10.TabIndex = 13;
            label10.Text = "=";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // toodVasakLabel
            // 
            toodVasakLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular);
            toodVasakLabel.Location = new Point(50, 175);
            toodVasakLabel.Name = "toodVasakLabel";
            toodVasakLabel.Size = new Size(60, 50);
            toodVasakLabel.TabIndex = 12;
            toodVasakLabel.Text = "?";
            toodVasakLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // jagatis
            // 
            jagatis.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular);
            jagatis.Location = new Point(314, 240);
            jagatis.Name = "jagatis";
            jagatis.Size = new Size(100, 35);
            jagatis.TabIndex = 5;
            jagatis.ValueChanged += new EventHandler(this.Correct_Answer);
            jagatis.Enter += new EventHandler(this.answer_Enter);
            // 
            // div
            // 
            div.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular);
            div.Location = new Point(116, 225);
            div.Name = "div";
            div.Size = new Size(60, 50);
            div.TabIndex = 20;
            div.Text = "/";
            div.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // jagatisParemLabel
            // 
            jagatisParemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, FontStyle.Regular);
            jagatisParemLabel.Location = new Point(182, 225);
            jagatisParemLabel.Name = "jagatisParemLabel";
            jagatisParemLabel.Size = new Size(60, 50);
            jagatisParemLabel.TabIndex = 19;
            jagatisParemLabel.Text = "?";
            jagatisParemLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular);
            label14.Location = new Point(248, 225);
            label14.Name = "label14";
            label14.Size = new Size(60, 50);
            label14.TabIndex = 18;
            label14.Text = "=";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // jagatisVasakLabel
            // 
            jagatisVasakLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular);
            jagatisVasakLabel.Location = new Point(50, 225);
            jagatisVasakLabel.Name = "jagatisVasakLabel";
            jagatisVasakLabel.Size = new Size(60, 50);
            jagatisVasakLabel.TabIndex = 17;
            jagatisVasakLabel.Text = "?";
            jagatisVasakLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            startNupp.AutoSize = true;
            startNupp.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular);
            startNupp.Location = new Point(157, 302);
            startNupp.Name = "startButton";
            startNupp.Size = new Size(127, 34);
            startNupp.TabIndex = 1;
            startNupp.Text = "Algus quiz";
            startNupp.UseVisualStyleBackColor = true;
            startNupp.Click += new EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Lihtsamvar //1
            // 
            Lihtsamvar.AutoSize = true;
            Lihtsamvar.BackColor = System.Drawing.Color.Green;
            Lihtsamvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Lihtsamvar.Location = new System.Drawing.Point(22, 302);
            Lihtsamvar.Name = "Lihtsamvar";
            Lihtsamvar.Size = new System.Drawing.Size(120, 40);
            Lihtsamvar.TabIndex = 22;
            Lihtsamvar.Text = "Lihtsam";
            Lihtsamvar.UseVisualStyleBackColor = false;
            Lihtsamvar.Click += new System.EventHandler(this.Lihtsamvar_Click);
            // 
            // Raskemvar //2
            // 
            Raskemvar.BackColor = System.Drawing.Color.Red;
            Raskemvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Raskemvar.Location = new System.Drawing.Point(314, 302);
            Raskemvar.Name = "Raskemvar";
            Raskemvar.Size = new System.Drawing.Size(104, 39);
            Raskemvar.TabIndex = 23;
            Raskemvar.Text = "Raskem";
            Raskemvar.UseVisualStyleBackColor = false;
            Raskemvar.Click += new System.EventHandler(this.Raskemvar_Click);
            // 
            // showDate
            // 

            NaitaDate.AutoSize = true;
            NaitaDate.Location = new Point(360, 320);
            NaitaDate.Name = "showDate";
            NaitaDate.Size = new Size(0, 13);
            NaitaDate.TabIndex = 21;
            // 
            // tip
            // 
            tip.BackgroundImage = ((Image)(resources.GetObject("tip.BackgroundImage")));
            tip.Font = new Font("Microsoft Sans Serif", 13.1F, FontStyle.Regular);
            tip.Location = new Point(420, 90);
            tip.Name = "tip";
            tip.Size = new Size(70, 41);
            tip.TabIndex = 24;
            tip.Text = ".";
            tip.Click += new EventHandler(this.button1_Click);
            // 
            // tip4
            // 
            tip4.BackgroundImage = ((Image)(resources.GetObject("tip4.BackgroundImage")));
            tip4.Font = new Font("Microsoft Sans Serif", 13.1F, FontStyle.Regular);
            tip4.Location = new Point(420, 240);
            tip4.Name = "tip4";
            tip4.Size = new Size(70, 41);
            tip4.TabIndex = 25;
            tip4.Text = ".";
            tip4.Click += new EventHandler(this.tip4_Click);
            // 
            // tip3
            // 
            tip3.BackgroundImage = ((Image)(resources.GetObject("tip3.BackgroundImage")));
            tip3.Font = new Font("Microsoft Sans Serif", 13.1F, FontStyle.Regular);
            tip3.Location = new Point(420, 190);
            tip3.Name = "tip3";
            tip3.Size = new Size(70, 41);
            tip3.TabIndex = 26;
            tip3.Text = ".";
            tip3.Click += new EventHandler(this.tip3_Click);
            // 
            // tip2
            // 
            tip2.BackgroundImage = ((Image)(resources.GetObject("tip2.BackgroundImage")));
            tip2.Font = new Font("Microsoft Sans Serif", 13.1F, FontStyle.Regular);
            tip2.Location = new Point(420, 140);
            tip2.Name = "tip2";
            tip2.Size = new Size(70, 41);
            tip2.TabIndex = 27;
            tip2.Text = ".";
            tip2.Click += new EventHandler(this.tip2_Click);
            // 
            // Form2
            // 
            ClientSize = new Size(484, 361);
            Controls.Add(NaitaDate);
            Controls.Add(startNupp);
            Controls.Add(jagatis);
            Controls.Add(div);
            Controls.Add(jagatisParemLabel);
            Controls.Add(label14);
            Controls.Add(jagatisVasakLabel);
            Controls.Add(tood);
            Controls.Add(mult);
            Controls.Add(toodParemLabel);
            Controls.Add(label10);
            Controls.Add(toodVasakLabel);
            Controls.Add(erinevus);
            Controls.Add(label);
            Controls.Add(erinevusParemLabel);
            Controls.Add(label6);
            Controls.Add(erinevusVasakLabel);
            Controls.Add(sum);
            Controls.Add(label4);
            Controls.Add(plusParemLabel);
            Controls.Add(label2);
            Controls.Add(plusVasakLabel);
            Controls.Add(label1);
            Controls.Add(AegLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Controls.Add(Raskemvar); //2
            Controls.Add(Lihtsamvar); //1
            Controls.Add(tip);
            Controls.Add(tip2);
            Controls.Add(tip3);
            Controls.Add(tip4);


            MaximizeBox = false;
            Name = "Form1";
            Text = "Matemaateline Quiz";
        }

        public void StartTheQuiz()
        {
            //заполняем задачу сложения случайными числами и сохраняем их в переменных
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            //конвертирует случайные числа в "string" для будущих задач
            plusVasakLabel.Text = addend1.ToString();
            plusParemLabel.Text = addend2.ToString();

            //проверяет равна ли сумма нулю перед тем как добовлять знаяения
            sum.Value = 0;

            //создает задачу на вычитание
            diffend1 = randomizer.Next(1, 101);
            diffend2 = randomizer.Next(1, diffend1);

            //преобразовывет значения в "string"
            erinevusVasakLabel.Text = diffend1.ToString();
            erinevusParemLabel.Text = diffend2.ToString();
            erinevus.Value = 0;

            //генерирует задачу на умножение
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);

            //эти строки конвертируют в "string"
            toodVasakLabel.Text = multiplicand.ToString();
            toodParemLabel.Text = multiplier.ToString();
            tood.Value = 0;

            //генерирует задачу на деление
            divisor = randomizer.Next(2, 11);
            int temporayjagatis = randomizer.Next(2, 11);
            dividend = divisor * temporayjagatis;

            //эти строки конвертируют в тип "string"
            jagatisVasakLabel.Text = dividend.ToString();
            jagatisParemLabel.Text = divisor.ToString();

            //проверяет равна ли jagatis нулю
            jagatis.Value = 0;




            //эти строки запускают таймер
            AegVeel = 30;
            AegLabel.Text = "30 sekundid";
            timer1.Start();
        }//функция при которая запускается при нажатии одной из трех кнопок
        //функция проверяет правильность введеных ответов
        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value) && (diffend1 - diffend2 == erinevus.Value)
                && (multiplicand * multiplier == tood.Value)
                && (dividend / divisor == jagatis.Value)
                )

                return true;
            else
                return false;

        }
        public Form2()
        {
            InitializeComponent();
        }
        private void AegLabel_Click(object sender, EventArgs e)
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
            MuusikaKuulamine("strange.wav");
            startNupp.Enabled = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Если функция "CheckTheAnswer" вернет true то остановит таймер и поздравит пользователя сообщением

            if (CheckTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("Sa said kõik vastused õiged. Palju õnne!", "Kas tahad tegi ülesanned Raskemaks? Siis click 'Raskem'"); //4
                startNupp.Enabled = true;
            }

            if (AegVeel == 5)
            {
                AegLabel.BackColor = Color.Red;
                AegVeel = AegVeel - 1;
                AegLabel.Text = AegVeel + " selundid";

            }



            else if (AegVeel > 0)
            {

                AegVeel = AegVeel - 1;
                AegLabel.Text = AegVeel + " sekundid";
            }

            else
            {
                //Функция Останавливает время и оповещает о том что время вышло
                timer1.Stop();
                AegLabel.Text = "pole enam aega!";
                MessageBox.Show("Sa ei lõpetanud õigeks ajaks. Kas sa tahad tegi ülesanned lihtsamaks? siis click 'Lihtsamaks'", "Vabandust edu järgmisel korral");//4

                sum.Value = addend1 + addend2;
                erinevus.Value = diffend1 - diffend2;
                tood.Value = multiplicand * multiplier;
                jagatis.Value = dividend / divisor;
                startNupp.Enabled = true;
                AegLabel.BackColor = Form2.DefaultBackColor;
            }



        }
        private void answer_Enter(object sender, EventArgs e)
        {
            //выбирает ответ целиком в элементе "NumeriUpDown"
            NumericUpDown answerBox = sender as NumericUpDown;
            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
        //Функция оповещает пользователя если введен правильный ответ на все пропуски
        private void Correct_Answer(object sender, EventArgs e)
        {
            if (addend1 + addend2 == sum.Value)
            {
                System.Media.SystemSounds.Exclamation.Play();
            }
        }


        private Label AegLabel;
        private Label label1;
        private Label plusVasakLabel;
        private Label label2;
        private Label plusParemLabel;
        private Label label4;
        private NumericUpDown sum;
        private NumericUpDown erinevus;
        private Label label;
        private Label erinevusParemLabel;
        private Label label6;
        private Label erinevusVasakLabel;
        private NumericUpDown tood;
        private Label mult;
        private Label toodParemLabel;
        private Label label10;
        private Label toodVasakLabel;
        private NumericUpDown jagatis;
        private Label div;
        private Label jagatisParemLabel;
        private Label label14;
        private Label jagatisVasakLabel;
        private Button startNupp;
        private Timer timer1;
        private Label NaitaDate;
        private Button Lihtsamvar;//1
        private Button Raskemvar;//2
        private Button tip;
        private Button tip2;
        private Button tip3;
        private Button tip4;


        private void Lihtsamvar_Click(object sender, EventArgs e)
        {
            MuusikaKuulamine("det.wav");
            StartTheQuiz();
            Lihtsamvar.Enabled = false;
            //на +
            addend1 = randomizer.Next(25);
            addend2 = randomizer.Next(25);

            plusVasakLabel.Text = addend1.ToString();
            plusParemLabel.Text = addend2.ToString();

            //создает задачу на вычитание
            diffend1 = randomizer.Next(1, 50);
            diffend2 = randomizer.Next(1, diffend1);

            //преобразовывет значения в "string"
            erinevusVasakLabel.Text = diffend1.ToString();
            erinevusParemLabel.Text = diffend2.ToString();
            erinevus.Value = 0;

            //генерирует задачу на умножение
            multiplicand = randomizer.Next(1, 10);
            multiplier = randomizer.Next(1, 10);

            //эти строки конвертируют в "string"
            toodVasakLabel.Text = multiplicand.ToString();
            toodParemLabel.Text = multiplier.ToString();
            tood.Value = 0;

            //генерирует задачу на деление
            divisor = randomizer.Next(1, 10);
            int temporayjagatis = randomizer.Next(1, 10);
            dividend = divisor * temporayjagatis;

            //эти строки конвертируют в тип "string"
            jagatisVasakLabel.Text = dividend.ToString();
            jagatisParemLabel.Text = divisor.ToString();

            //проверяет равна ли jagatis нулю
            jagatis.Value = 0;
        } //1

        private void Raskemvar_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            MuusikaKuulamine("doom.wav");
            Raskemvar.Enabled = false;
            //на +
            addend1 = randomizer.Next(200);
            addend2 = randomizer.Next(200);

            plusVasakLabel.Text = addend1.ToString();
            plusParemLabel.Text = addend2.ToString();

            //создает задачу на вычитание
            diffend1 = randomizer.Next(2, 200);
            diffend2 = randomizer.Next(2, diffend1);

            //преобразовывет значения в "string"
            erinevusVasakLabel.Text = diffend1.ToString();
            erinevusParemLabel.Text = diffend2.ToString();
            erinevus.Value = 0;

            //генерирует задачу на умножение
            multiplicand = randomizer.Next(2, 12);
            multiplier = randomizer.Next(2, 12);

            //эти строки конвертируют в "string"
            toodVasakLabel.Text = multiplicand.ToString();
            toodParemLabel.Text = multiplier.ToString();
            tood.Value = 0;

            //генерирует задачу на деление
            divisor = randomizer.Next(2, 12);
            int temporayjagatis = randomizer.Next(2, 12);
            dividend = divisor * temporayjagatis;

            //эти строки конвертируют в тип "string"
            jagatisVasakLabel.Text = dividend.ToString();
            jagatisParemLabel.Text = divisor.ToString();

            //проверяет равна ли jagatis нулю
            jagatis.Value = 0;
        } //2

        private void button1_Click(object sender, EventArgs e)
        {
            int v = addend1 + addend2;
            tip.Text = v.ToString();
        } //3

        private void tip2_Click(object sender, EventArgs e)
        {
            int v = diffend1 - diffend2;
            tip2.Text = v.ToString();
        } //3

        private void tip3_Click(object sender, EventArgs e)
        {
            int v = multiplicand * multiplier;
            tip3.Text = v.ToString();
        } //3

        private void tip4_Click(object sender, EventArgs e)
        {
            int v = dividend / divisor;
            tip4.Text = v.ToString();
        } //3

        public void MuusikaKuulamine(string song)              //функция прослушивания музыки принимающая за аргумент название файла типа "string"
        {
            string[] songs = { "doom.wav", "strange.wav", "det.wav" };
            using (var muusika = new SoundPlayer(@"../../" + song))         //используя переменную "muusika" типа "var" которая равна созданнуму обьекту "SoundPlayer" с аргументом в виде "file" который мы передали
            {
                muusika.Play();                                 //используем встроенную функцию проигрывания файла
            }

        }
    }
}

//1-можно сделать задачи по сложнее / saate ülesandeid keerulisemaks muuta                       
//2-можно сделать задачи по легче / saate ülesandeid lihtsamaks muuta                            
//3-можно сделать чтобы программа моглу давать подсказку если не знаешь ответ saab / teha nii, et programm oskab anda vihje, kui vastust ei tea p.s поставить маленькую кнопку при нажатии на которую где то высвечивается ответ
//4-можно сделать чтобы программа подбадривала и утешала в частном случае / saate muuta programmi konkreetsel juhul rõõmsaks ja mugavuseks 
//5-добавить музыку на разные варианты задания
//1,2,3,4 REALISEERITUD