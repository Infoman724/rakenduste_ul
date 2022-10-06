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
    public partial class Form1 : Form
    {   
        public Form1()
        {
            

            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            naita = new Button();
            puhasta = new Button();
            taustvarv = new Button();
            sulgeNupp = new Button();
            openFileDialog1 = new OpenFileDialog();
            colorDialog1 = new ColorDialog();
            
            
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(this.checkBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(800, 450);
            
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(794, 399);
          
            
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(3, 408);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(68, 20);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "stretch";
            checkBox1.CheckedChanged += new EventHandler(this.checkBox1_CheckedChanged);

            // 
            // flowLayoutPanel1
            // 

            flowLayoutPanel1.Controls.Add(this.naita);
            flowLayoutPanel1.Controls.Add(this.puhasta);
            flowLayoutPanel1.Controls.Add(this.taustvarv);
            flowLayoutPanel1.Controls.Add(this.sulgeNupp);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(123, 408);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(674, 39);
            
            // 
            // naita
            // 

            naita.AutoSize = true;
            naita.Location = new Point(596, 3);
            naita.Name = "naita";
            naita.Size = new Size(75, 26);
            naita.Text = "Näita pilt";
            naita.Click += new EventHandler(this.naita_Click);

            // 
            // puhasta
            // 

            puhasta.AutoSize = true;
            puhasta.Location = new Point(505, 3);
            puhasta.Name = "puhasta";
            puhasta.Size = new Size(85, 26);
            puhasta.TabIndex = 1;
            puhasta.Text = "puhasta pilt";
            puhasta.UseVisualStyleBackColor = true;
            puhasta.Click += new EventHandler(this.puhasta_Click);

            // 
            // taustvarv
            // 

            taustvarv.AutoSize = true;
            taustvarv.Location = new Point(363, 3);
            taustvarv.Name = "taustvarv";
            taustvarv.Size = new Size(136, 26);
            taustvarv.Text = "Määrake taustavärv";
            taustvarv.Click += new EventHandler(this.taustvarv_Click);

            // 
            // sulgeNupp
            // 

            sulgeNupp.AutoSize = true;
            sulgeNupp.Location = new Point(282, 3);
            sulgeNupp.Name = "sulgeNupp";
            sulgeNupp.Size = new Size(75, 26);
            sulgeNupp.Text = "sulge";
            sulgeNupp.Click += new EventHandler(this.sulgeNupp_Click);

            // 
            // openFileDialog1
            // 

            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
            "s (*.*)|*.*";
            openFileDialog1.Title = "Valige a pilt fail";

            // 
            // Form1
            // 

            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(this.tableLayoutPanel1);
            Name = "Form1";
            Text = "PildiVaatamineApp";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            
          



        }



        private void puhasta_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void taustvarv_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
                
        }

        private void naita_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
        

        private void sulgeNupp_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

//1-можно попробовать реализовать возможность просмотра видео?) / võite proovida rakendada video vaatamise võimalust)
//2-думаем 
//3-думаем