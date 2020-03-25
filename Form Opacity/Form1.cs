using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Form_Opacity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button7.BackColor = Color.Yellow;
            // opacity özelliği kullanılan aracın şeffaflığı ile ilgili bir özelliktir.
            // biz bu uygulamamızda 1. si butonlar yardımı ile 2.side zamana bağlı olarak
            // form şeffaflığını değiştireceğiz 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Yellow;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button7.BackColor = Color.White;
            this.Opacity = 0.75;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Yellow;
            button1.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button7.BackColor = Color.White;
            this.Opacity = 0.50;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Yellow;
            button2.BackColor = Color.White;
            button1.BackColor = Color.White;
            button4.BackColor = Color.White;
            button7.BackColor = Color.White;
            this.Opacity = 0.25;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Yellow;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button1.BackColor = Color.White;
            button7.BackColor = Color.White;
            this.Opacity = 0.10;
        }

        int t = 0;

        private void button5_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button7.BackColor = Color.White;
            button6.BackColor = Color.White;
            button5.BackColor = Color.Yellow;
            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t++;

            switch (t)
            {
                case 1:
                    this.Opacity = 0.90; label1.Text="%90"; break;
                case 2:
                    this.Opacity = 0.80; label1.Text="%80"; break;
                case 3:
                    this.Opacity = 0.70; label1.Text="%70"; break;
                case 4:
                    this.Opacity = 0.60; label1.Text="%60"; break;
                case 5:
                    this.Opacity = 0.50; label1.Text="%50"; break;
                case 6:
                    this.Opacity = 0.40; label1.Text="%40"; break;
                case 7:
                    this.Opacity = 0.30; label1.Text="%30"; break;
                case 8:
                    this.Opacity = 0.20; label1.Text="%20"; break;
                case 9:
                    this.Opacity = 0.10; label1.Text="%10"; break;
                default :
                    t=0;break;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button7.BackColor = Color.White;
            button6.BackColor = Color.Yellow;
            button5.BackColor = Color.White;
            timer1.Stop();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Yellow;
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            this.Opacity = 100;
        }
    }
}
