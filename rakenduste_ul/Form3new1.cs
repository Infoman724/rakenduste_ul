using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace rakenduste_ul
{
    public partial class form3new1 : Form
    {
        Random random = new Random();                                                                                           //{
        TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel();
        Label lbl1;       
        Label AegLabel, time, katse, katseLabel;
        Timer timer2 = new Timer { Interval = 1000 };
        Label firstClicked = null;
        Label secondClicked = null;
        Label keerukus;                                                                                                                 //обьявление переменных
        Button lihtsaltvar, keskminevar, raskevar, kinni;
        Timer timer = new Timer { Interval = 500 };//время, спустя которое картинки пропадают, когда картинки не совпадают
        int r = 0;//перемнные для создания игрового поля r-rida
        int t = 0;//t-tulp
        int tik = 30;
        int ttik = 60;
        int tikk = 120;
        int katsed = 60;                                                                                                        //}
        
        public form3new1()
        {
            tableLayoutPanel1 = new TableLayoutPanel();                                                                         //{         
            lihtsaltvar = new Button();
            keskminevar = new Button();
            raskevar = new Button();
            keerukus = new Label();
            kinni = new Button();                                                                                                       //создание экземпляров
            katseLabel = new Label();
            katse = new Label();                                                                                                        
            time = new Label();
            AegLabel = new Label();                                                                                             //}

            this.Size = new System.Drawing.Size(900, 600);
            this.Text = "Soobitamine mäng";
            this.MaximizeBox = false;
            //                                                                                                                  //{  
            // tableLayoutPanel1
            //                                                                                                                  
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.Location = new System.Drawing.Point(3, 4);
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.Size = new System.Drawing.Size(550, 550);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel1.BackColor = System.Drawing.Color.CornflowerBlue;
            // 
            // lihtsalt
            //
            lihtsaltvar.Text = "lihtsalt";
            lihtsaltvar.AutoSize = false;
            lihtsaltvar.Size = new System.Drawing.Size(250, 100);
            lihtsaltvar.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            lihtsaltvar.BackColor = System.Drawing.Color.Green;
            lihtsaltvar.Location = new System.Drawing.Point(50, 100);
            // 
            // keskmine
            //
            keskminevar.Text = "keskmine";
            keskminevar.AutoSize = false;
            keskminevar.Size = new System.Drawing.Size(250, 100);
            keskminevar.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            keskminevar.BackColor = System.Drawing.Color.Gray;
            keskminevar.Location = new System.Drawing.Point(325, 100);
            // 
            // raske
            //
            raskevar.Text = "raske";
            raskevar.AutoSize = false;
            raskevar.Size = new System.Drawing.Size(250, 100);
            raskevar.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            raskevar.BackColor = System.Drawing.Color.Red;                                                                      //описание элеиентов формы(заголовков/кнопок/панели управления
            raskevar.Location = new System.Drawing.Point(600, 100);
            // 
            // keerukus
            //
            keerukus.Text = "Vali keerukus:";
            keerukus.AutoSize = true;
            keerukus.Location = new System.Drawing.Point(285, 15);
            keerukus.Font = new Font("Arial", 30, FontStyle.Bold);
            // 
            // kinni
            //
            kinni.Text = "kinni";
            kinni.AutoSize = false;
            kinni.Size = new System.Drawing.Size(75, 50);
            kinni.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            kinni.BackColor = System.Drawing.Color.LightCyan;
            kinni.Location = new System.Drawing.Point(810, 0);
            // 
            // katseLabel
            //
            katseLabel.Text = "veel katsed: ";
            katseLabel.AutoSize = true;
            katseLabel.Location = new System.Drawing.Point(600,25);
            katseLabel.Size = new System.Drawing.Size(200, 30);
            katseLabel.Font = new Font("Times New Roman", 21, FontStyle.Bold);
            // 
            // katse
            //
            katse.Text = "80";
            katse.AutoSize = true;
            katse.Size = new System.Drawing.Size(200, 30);
            katse.Font = new Font("Times New Roman", 21, FontStyle.Bold);
            katse.Location = new System.Drawing.Point(755, 25);
            // 
            // time
            //
            time.Text = "aega veel:";
            time.AutoSize = true;
            time.Size = new System.Drawing.Size(200, 30);
            time.Font = new Font("Times New Roman", 21, FontStyle.Bold);
            time.Location = new System.Drawing.Point(600, 55);
            // 
            // timeLabel
            //
            AegLabel.Text = "0";
            AegLabel.AutoSize = true;
            AegLabel.Size = new System.Drawing.Size(200, 30);
            AegLabel.Font = new Font("Times New Roman", 18, FontStyle.Bold);
            AegLabel.Location = new System.Drawing.Point(725, 60);                                                              //}
            //
            // Controls                                                                                                         //добавление элементов в controls/на экран                                              
            //
            Controls.Add(keskminevar);                                                                                          
            Controls.Add(lihtsaltvar);
            Controls.Add(raskevar);
            Controls.Add(keerukus);                                                                                             
            //
            // Events                                                                                                           //привязка элементов управления к событию/ивенту
            //                                                                                                      
            timer.Tick += Timer1_Tick;
            lihtsaltvar.Click += Lihtsalt_Click;
            keskminevar.Click += Keskmine_Click;
            raskevar.Click += Raske_Click;

            
        }
        //
        // raskus variandi metodid
        //
        private void Lihtsalt_Click(object sender, EventArgs e)
        {
            Controls.Clear();                                                                                                   //отчищаем экран/пануль управления от всего
            Controls.Add(kinni);                                                                                                //добавляем кнопку закрытия
            kinni.Click += Kinni_Click;                                                                                         //привязываем событие к кнопке
            Controls.Add(katseLabel);                                                                                           //добавляем заголовок на экран/панель управления
            Controls.Add(katse);                                                                                                //добавляем заголовок  на экран/панель управления 
            Controls.Add(time);                                                                                                 //добавляем заголовок  на экран/панель управления 
            Controls.Add(AegLabel);                                                                                             //добавляем заголовок  на экран/панель управления 
            timer2.Enabled = true;                                                                                              //включаем таймер для легкого варианта
            timer2.Tick += Timer2_Tick;                                                                                         //привязываем таймер легкого варианта к нужному событию
            MuusikaKuulamine("easy.wav");
            this.Controls.Add(this.tableLayoutPanel1);                                                                          //добавляем на экран/панель управления именно этот tableLayoutPanel1
            List<string> icons = new List<string>()                                                                             //список иконок из шрифта "webdings"
            {
                "?", "?", "k", "k", "v", "v",
                "e", "e", "a", "a", "t", "t",
            };
                    
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));                                         //добавление столбцов на макет
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));

            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));                                               //добавление рядов на макет
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));

            for (int i = 0; i < 3; i++)                                                                                         //цикл для добавления заголовков где i (количество рядов равно 0) и пока меньше 3 прибавляется 1
            {
                for (int j = 0; j < 4; j++)                                                                                     //где j (количество столбцов равно 0) и пока меньше 4 прибавляется 1
                {
                    lbl1 = new Label()                                                                                          //как условия создается заголовок(квадратик) ниже его описание
                    {
                        BackColor = System.Drawing.Color.CornflowerBlue,                                                        
                        AutoSize = false,
                        Dock = System.Windows.Forms.DockStyle.Fill,
                        TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                        Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
                        Text = "c",
                    };
                    tableLayoutPanel1.Controls.Add(lbl1, r, t);
                    r++;

                }
                t++;
                r = 0;
            }
            foreach (Control control in tableLayoutPanel1.Controls)                                                             //этот кусок кода отвечает за добавление иконок в случайные места                               
            {
                Label iconLabel1 = control as Label;
                if (iconLabel1 != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel1.Text = icons[randomNumber];
                    icons.RemoveAt(randomNumber);
                }
                iconLabel1.ForeColor = iconLabel1.BackColor;
                iconLabel1.Click += Lbl1_Click;
            }

        }                                                                                                                       //в среднем и сложном варианте суть таже поэтому прокоментирована только эта часть

        private void Keskmine_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            Controls.Add(kinni);
            kinni.Click += Kinni_Click;
            Controls.Add(katseLabel);
            Controls.Add(katse);
            Controls.Add(time);
            Controls.Add(AegLabel);
            timer2.Enabled = true;
            timer2.Tick += Timer2_Tick1;
            MuusikaKuulamine("norm.wav");
            this.Controls.Add(this.tableLayoutPanel1);
            List<string> icons = new List<string>()//иконки(картинки), которым надо искать пару
            {
                "?", "?", "k", "k", "v", "v", "u", "u",
                "e", "e", "a", "a", "t", "t", "n", "n"
            };

            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));

            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));

            for (int i = 0; i < 4; i++)//цикл для добавления лейблов
            {
                for (int j = 0; j < 4; j++)
                {
                    lbl1 = new Label()
                    {
                        BackColor = System.Drawing.Color.CornflowerBlue,
                        AutoSize = false,
                        Dock = System.Windows.Forms.DockStyle.Fill,
                        TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                        Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
                        Text = "c",
                    };
                    tableLayoutPanel1.Controls.Add(lbl1, r, t);
                    r++;

                }
                t++;
                r = 0;
            }
            foreach (Control control in tableLayoutPanel1.Controls)//добавление иконок рандомно
            {
                Label iconLabel1 = control as Label;
                if (iconLabel1 != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel1.Text = icons[randomNumber];
                    icons.RemoveAt(randomNumber);
                }
                iconLabel1.ForeColor = iconLabel1.BackColor;
                iconLabel1.Click += Lbl1_Click;
            }
        }

        private void Raske_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            Controls.Add(kinni);
            kinni.Click += Kinni_Click;
            Controls.Add(katseLabel);
            Controls.Add(katse);
            Controls.Add(time);
            Controls.Add(AegLabel);
            timer2.Enabled = true;
            timer2.Tick += Timer2_Tick2;
            MuusikaKuulamine("hard.wav");
            this.Controls.Add(this.tableLayoutPanel1);
            List<string> icons = new List<string>()//иконки(картинки), которым надо искать пару
            {
                "?", "?", "k", "k", "v", "v", "u", "u","!","!",
                "e", "e", "a", "a", "t", "t", "n", "n","w","w"
            };

            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));

            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));

            for (int i = 0; i < 4; i++)//цикл для добавления лейблов
            {
                for (int j = 0; j < 5; j++)
                {
                    lbl1 = new Label()
                    {
                        BackColor = System.Drawing.Color.CornflowerBlue,
                        AutoSize = false,
                        Dock = System.Windows.Forms.DockStyle.Fill,
                        TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                        Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
                        Text = "c",
                    };
                    tableLayoutPanel1.Controls.Add(lbl1, r, t);
                    r++;

                }
                t++;
                r = 0;
            }
            foreach (Control control in tableLayoutPanel1.Controls)//добавление иконок рандомно
            {
                Label iconLabel1 = control as Label;
                if (iconLabel1 != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel1.Text = icons[randomNumber];
                    icons.RemoveAt(randomNumber);
                }
                iconLabel1.ForeColor = iconLabel1.BackColor;
                iconLabel1.Click += Lbl1_Click;
            }
        }
        
        

        private void Lbl1_Click(object sender, EventArgs e)                                                                     //метод при нажатии на заголовок(квадратик)  проверяет какой конкретно заголовок был нажат и исполняет определенную инструкцию/вычитает одну попытку и если их колво равно нулю то проигрывается звук "поражения" выводиться сообщение и форма закрывается
        {
            katsed -= 1;
            katse.Text = katsed.ToString();
            if (katsed == 0)
            {
                MuusikaKuulamine("lose.wav");
                MessageBox.Show("Sul pole enam katseid((", "ATTENTION");
                this.Close();
                
            }
            if (timer.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }

                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                voitjakontroll();

                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }

                timer.Start();
            }

        }

        

        private void Timer1_Tick(object sender, EventArgs e)                                                                    //метод таймера( времени после нажатия первого заголовка(квадратика)
        {
            timer.Stop();
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;
            firstClicked = null;
            secondClicked = null;
        }

        private void Timer2_Tick(object sender, EventArgs e)                                                                    //метод для таймера показывающего сколько времени отведенно на игру в легком варианте
        {
            tik -= 1;
            AegLabel.Text = tik.ToString();
            if (tik == 0)
            {
                MuusikaKuulamine("lose.wav");
                MessageBox.Show("Sul sai aega otsa((", "ATTENTION");
                this.Close();
            }

        }

        private void Timer2_Tick1(object sender, EventArgs e)                                                                   //метод для таймера показывающего сколько времени отведенно на игру в среднем варианте
        {
            ttik -= 1;
            AegLabel.Text = ttik.ToString();
            if (ttik == 0)
            {
                MuusikaKuulamine("lose.wav");
                MessageBox.Show("Sul sai aega otsa((", "ATTENTION");
                this.Close();
            }
        }

        private void Timer2_Tick2(object sender, EventArgs e)                                                                   //метод для таймера показывающего сколько времени отведенно на игру в сложном варианте
        {
            tikk -= 1;
            AegLabel.Text = tikk.ToString();
            if (tikk == 0)
            {
                MuusikaKuulamine("lose.wav");
                MessageBox.Show("Sul sai aega otsa((", "ATTENTION");
                this.Close();
            }
        }

        private void Kinni_Click(object sender, EventArgs e)
        {
            this.Close();
            MuusikaKuulamine("Tuhi.wav");
        }

        public void voitjakontroll()                                                                                            //метод проверяет завершил ли пользователь сесию победой или нет/заголовков/квадратиков
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }
            MuusikaKuulamine("win.wav");
            MessageBox.Show("Sa leised kõik paarid!!!", "Palju õnne!");
            this.Close();
            
        }
        public void MuusikaKuulamine(string song)              //функция прослушивания музыки принимающая за аргумент название файла типа "string"
        {
            string[] songs = { "win.wav","lose.wav" };
            using (var muusika = new SoundPlayer(@"../../" + song))         //используя переменную "muusika" типа "var" которая равна созданнуму обьекту "SoundPlayer" с аргументом в виде "file" который мы передали
            {
                muusika.Play();                                 //используем встроенную функцию проигрывания файла
                
            }

        }

    }
}

//1-можно попробовать реализовать возможность менять количества клеток для иконок / võite proovida rakendada ikoonide lahtrite arvu muutmise võimalust //DONE
//2-lisas klõpsude (katsete) arvu, mille jaoks peate leidma kõik paarid, kui teil pole aega, ilmub mesagebox ja vorm sulgub
//3-Музыкальное сопровождение/для всего процесса/и для выигрыша например   /Muusikaline saate/kogu protsessi/ja auhinnavõidu eest//DONE
//4-можно добавить видимый таймер показывающий сколько времени осталось чтобы пройти игру / saate lisada nähtava taimeri, mis näitab, kui palju aega on mängu lõpetamiseks jäänud//DONE
//5-сначала показывать картинки а потом они пропадают чтобы отгадывать / kõigepealt näita pilte ja siis need kaovad ära arvama


//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ПОДВАЛ ИДЕЙ--------------------------------------------------------------------------------------------------------------------------------------------------------
/*private void label_method(Label label,int x, int y,string nimi,int a, int b, string text, int index, Font font)
        {
            label.AutoSize = true;
            label.Location = new Point(x, y);
            label.Name = nimi;
            label.Size = new Size(a, b);
            label.Text = text;
            label.TabIndex = index;
            label.Font = font;

        }*/


/* private void voitjakontroll()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }

            MessageBox.Show("Sa sobisid iga ikooniga! Selline võitja, sina.");
            Close();

        }*/

/*private void label_click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;


            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                //clickedLabel.ForeColor = Color.Black;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;

                    return;
                }
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                voitjakontroll();

                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }

                timer1.Start();
            }
        }*/

/*private void IkoonideMaaramineRuutudele()
        {

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];

                    iconLabel.ForeColor = iconLabel.BackColor;

                    icons.RemoveAt(randomNumber);
                }

            }
        }*/

/*
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            timer1 = new Timer(this.components);


            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.MenuHighlight;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));

            tableLayoutPanel1.Controls.Add(label16, 3, 3);
            tableLayoutPanel1.Controls.Add(label15, 2, 3);
            tableLayoutPanel1.Controls.Add(label14, 1, 3);
            tableLayoutPanel1.Controls.Add(label13, 0, 3);
            tableLayoutPanel1.Controls.Add(label12, 3, 2);
            tableLayoutPanel1.Controls.Add(label11, 2, 2);
            tableLayoutPanel1.Controls.Add(label10, 1, 2);
            tableLayoutPanel1.Controls.Add(label9, 0, 2);
            tableLayoutPanel1.Controls.Add(label8, 3, 1);
            tableLayoutPanel1.Controls.Add(label7, 2, 1);
            tableLayoutPanel1.Controls.Add(label6, 1, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 3, 0);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);

            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(534, 511);

            // 
            // label16
            // 
            label16.Font = new Font("Webdings", 72F, FontStyle.Regular);
            label16.Location = new Point(402, 384);
            label16.Name = "label16";
            label16.Size = new Size(126, 124);
            label16.TabIndex = 0;
            label16.Click += new EventHandler(this.label_click);
            // 
            // label15
            // 
            label15.Font = new Font("Webdings", 72F, System.Drawing.FontStyle.Regular);
            label15.Location = new Point(270, 384);
            label15.Name = "label15";
            label15.Size = new Size(123, 124);
            label15.TabIndex = 1;
            label15.Click += new EventHandler(this.label_click);
            // 
            // label14
            // 
            label14.Font = new Font("Webdings", 72F, System.Drawing.FontStyle.Regular);
            label14.Location = new Point(138, 384);
            label14.Name = "label14";
            label14.Size = new Size(123, 124);
            label14.TabIndex = 2;
            label14.Click += new EventHandler(this.label_click);
            // 
            // label13
            // 
            label13.Font = new Font("Webdings", 72F, System.Drawing.FontStyle.Regular);
            label13.Location = new Point(6, 384);
            label13.Name = "label13";
            label13.Size = new Size(123, 124);
            label13.TabIndex = 3;
            label13.Click += new EventHandler(this.label_click);
            // 
            // label12
            // 
            label12.Font = new Font("Webdings", 72F, System.Drawing.FontStyle.Regular);
            label12.Location = new Point(402, 257);
            label12.Name = "label12";
            label12.Size = new Size(126, 124);
            label12.TabIndex = 4;
            label12.Click += new EventHandler(this.label_click);
            // 
            // label11
            // 
            label11.Font = new Font("Webdings", 72F, System.Drawing.FontStyle.Regular);
            label11.Location = new Point(270, 257);
            label11.Name = "label11";
            label11.Size = new Size(123, 124);
            label11.TabIndex = 5;
            label11.Click += new EventHandler(this.label_click);
            // 
            // label10
            // 
            label10.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Regular);
            label10.Location = new Point(138, 257);
            label10.Name = "label10";
            label10.Size = new Size(123, 124);
            label10.TabIndex = 6;
            label10.Click += new EventHandler(this.label_click);
            // 
            // label9
            // 
            label9.Font = new Font("Webdings", 72F, System.Drawing.FontStyle.Regular);
            label9.Location = new Point(6, 257);
            label9.Name = "label9";
            label9.Size = new Size(123, 124);
            label9.TabIndex = 7;
            label9.Click += new EventHandler(this.label_click);
            // 
            // label8
            // 
            label8.Font = new Font("Webdings", 72F, System.Drawing.FontStyle.Regular);
            label8.Location = new Point(402, 130);
            label8.Name = "label8";
            label8.Size = new Size(126, 124);
            label8.TabIndex = 8;
            label8.Click += new EventHandler(this.label_click);
            // 
            // label7
            // 
            label7.Font = new Font("Webdings", 72F, System.Drawing.FontStyle.Regular);
            label7.Location = new Point(270, 130);
            label7.Name = "label7";
            label7.Size = new Size(123, 124);
            label7.TabIndex = 9;
            label7.Click += new EventHandler(this.label_click);
            // 
            // label6
            // 
            label6.Font = new Font("Webdings", 72F, System.Drawing.FontStyle.Regular);
            label6.Location = new Point(138, 130);
            label6.Name = "label6";
            label6.Size = new Size(123, 124);
            label6.TabIndex = 10;
            label6.Click += new EventHandler(this.label_click);
            // 
            // label5
            // 
            label5.Font = new Font("Webdings", 72F, System.Drawing.FontStyle.Regular);
            label5.Location = new Point(6, 130);
            label5.Name = "label5";
            label5.Size = new Size(123, 124);
            label5.TabIndex = 11;
            label5.Click += new EventHandler(this.label_click);
            // 
            // label4
            // 
            label4.Font = new Font("Webdings", 72F, System.Drawing.FontStyle.Regular);
            label4.Location = new Point(402, 3);
            label4.Name = "label4";
            label4.Size = new Size(126, 124);
            label4.TabIndex = 12;
            label4.Click += new EventHandler(this.label_click);
            // 
            // label3
            // 
            label3.Font = new Font("Webdings", 72F, System.Drawing.FontStyle.Regular);
            label3.Location = new Point(270, 3);
            label3.Name = "label3";
            label3.Size = new Size(123, 124);
            label3.TabIndex = 13;
            label3.Click += new EventHandler(this.label_click);
            // 
            // label2
            // 
            label2.Font = new Font("Webdings", 72F, System.Drawing.FontStyle.Regular);
            label2.Location = new Point(138, 3);
            label2.Name = "label2";
            label2.Size = new Size(123, 124);
            label2.TabIndex = 14;
            label2.Click += new EventHandler(this.label_click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Webdings", 72F, System.Drawing.FontStyle.Regular);
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(123, 124);
            label1.TabIndex = 0;
            label1.Text = "C";
            label1.TextAlign = ContentAlignment.MiddleCenter;                           //клеточки для иконок
            label1.Click += new EventHandler(this.label_click);                         //оригинал, выше копии с измененными (локацией,именем и индексом) 
            // 
            // timer1
            // 
            timer1.Interval = 750;
            timer1.Tick += new EventHandler(this.Timer1_Tick);
            // 
            // Arena
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 511);
            Controls.Add(this.tableLayoutPanel1);
            Name = "Form3";
            Text = "sobitamise mäng";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            */