using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace rakenduste_ul
{
    public partial class form3 : Form
    {

        Label firstClicked = null;
        Label secondClicked = null;
        Container components;
        TableLayoutPanel tableLayoutPanel1;
        Label label1;
        Label label16;
        Label label15;
        Label label14;
        Label label13;
        Label label12;
        Label label11;
        Label label10;
        Label label9;
        Label label8;
        Label label7;
        Label label6;
        Label label5;
        Label label4;
        Label label3;
        Label label2;
        Timer timer1;

        Random random = new Random();

        private void InitializeComponent()
        {
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
            for (int i = 0; i < 15; i++)
            {
                label_method(label1, 6, 3, "label1", 123, 124, "C", 0, new Font("Webdings", 72F, System.Drawing.FontStyle.Regular));
            }
            

            /*label_method(label1, 6, 3, "label1", 123, 124, "C", 0, new Font("Webdings", 72F, System.Drawing.FontStyle.Regular));
            label_method(label2, 138, 3, "label1", 123, 124, "C", 1, new Font("Webdings", 72F, System.Drawing.FontStyle.Regular));
            label_method(label3, 270, 3, "label1", 123, 124, "C", 2, new Font("Webdings", 72F, System.Drawing.FontStyle.Regular));//1 rida
            label_method(label4, 402, 3, "label1", 123, 124, "C", 3, new Font("Webdings", 72F, System.Drawing.FontStyle.Regular));

            label_method(label5, 6, 130, "label1", 123, 124, "C", 4, new Font("Webdings", 72F, System.Drawing.FontStyle.Regular));
            label_method(label6, 6, 3, "label1", 123, 124, "C", 5, new Font("Webdings", 72F, System.Drawing.FontStyle.Regular));
            label_method(label7, 6, 3, "label1", 123, 124, "C", 6, new Font("Webdings", 72F, System.Drawing.FontStyle.Regular));
            label_method(label8, 6, 3, "label1", 123, 124, "C", 7, new Font("Webdings", 72F, System.Drawing.FontStyle.Regular));

            label_method(label9, 6, 3, "label1", 123, 124, "C", 8, new Font("Webdings", 72F, System.Drawing.FontStyle.Regular));
            label_method(label10, 6, 3, "label1", 123, 124, "C", 9, new Font("Webdings", 72F, System.Drawing.FontStyle.Regular));
            label_method(label11, 6, 3, "label1", 123, 124, "C", 10, new Font("Webdings", 72F, System.Drawing.FontStyle.Regular));
            label_method(label12, 6, 3, "label1", 123, 124, "C", 11, new Font("Webdings", 72F, System.Drawing.FontStyle.Regular));

            label_method(label13, 6, 3, "label1", 123, 124, "C", 12, new Font("Webdings", 72F, System.Drawing.FontStyle.Regular));
            label_method(label14, 6, 3, "label1", 123, 124, "C", 13, new Font("Webdings", 72F, System.Drawing.FontStyle.Regular));
            label_method(label15, 6, 3, "label1", 123, 124, "C", 14, new Font("Webdings", 72F, System.Drawing.FontStyle.Regular));
            label_method(label16, 6, 3, "label1", 123, 124, "C", 15, new Font("Webdings", 72F, System.Drawing.FontStyle.Regular));*/

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

        }
        
        public void label_method(Label label, int x, int y, string nimi, int a, int b, string text, int index, Font font)
        {
            label.AutoSize = true;
            label.Location = new Point(x, y);
            label.Name = nimi;
            label.Size = new Size(a, b);
            label.Text = text;
            label.TabIndex = index;
            label.Font = font;
            label.Click += new EventHandler(this.label_click);
        }

        List<string> icons = new List<string>()
        {
            "!", "!", "U", "U", "C", "C", "A", "A",
            "b", "b", "k", "k", "M", "M", "1", "1"
        };

        public form3()
        {
            InitializeComponent();
            IkoonideMaaramineRuutudele();
        }

        private void IkoonideMaaramineRuutudele()
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
        }

        private void label_click(object sender, EventArgs e)
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
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;
            firstClicked = null;
            secondClicked = null;
        }

        private void voitjakontroll()
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

        }



    }
}

//1- можно попробовать реализовать возможность менять количества клеток для иконок / võite proovida rakendada ikoonide lahtrite arvu muutmise võimalust
//2-можно попробоавть реалилзовать возможность пользователю лично выбирать картинки для игры / võite proovida rakendada võimalust, et kasutaja saab mängu jaoks pilte isiklikult valida 
//3-можно попробовать перемешывать в иконки чтобы они были разные сейчас одни и те же каждую игру но в разных местах / võite proovida ikoone segada nii, et need oleksid nüüd igas mängus samad, kuid erinevates kohtades
//4-добавлен метод создания заголовка