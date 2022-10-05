using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace rakenduste_ul
{
    public partial class form3new1 : Form
    {
        
        Label firstClicked = null;
        Label secondClicked = null;
        private Container components;
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
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += new EventHandler(this.label_click);                         //оригинал выше копии с измененными (локацией,именем и индексом)
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


        List<string> icons = new List<string>()
        {
            "!", "!", "U", "U", "C", "C", "A", "A",
            "b", "b", "k", "k", "M", "M", "1", "1"
        };

        public form3new1()
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