using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Media;
using System.Xml.XPath;


namespace Mobile_Devise
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {

        private int xPos = 0;
        public RadForm1()
        {
            InitializeComponent();
        }

        public void sound(string btn)
        {
            if (txt_Box.Text == "111")
            {
                Console.Beep();
                txt_Box.Text = btn;
                SoundPlayer splayer = new SoundPlayer();
                splayer.SoundLocation = @".\Recording.wav";
                splayer.Stop();
            }
            else
            {
                Console.Beep();
                txt_Box.Text = txt_Box.Text + btn;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (txt_Box.Text == "111")
            {
                txt_Box.Text = "1";


                SoundPlayer splayer = new SoundPlayer();
                splayer.SoundLocation = @".\Recording (3) (1).wav";
                splayer.Play();



            }
            sound("1");


        }


        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            if (txt_Box.Text == "111")
            {
                txt_Box.Text = "2";


                SoundPlayer splayer = new SoundPlayer();
                splayer.SoundLocation = @".\Recording (3) (2).wav";
                splayer.Play();



            }
            sound("2");
        }



        private void guna2Button3_Click(object sender, EventArgs e)
        {

            sound("3");
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

            sound("4");
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

            sound("5");
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {


            sound("6");
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

            sound("7");
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {


            sound("8");
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {


            sound("9");
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {

            sound("*");
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {

            sound("0");
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {

            sound("#");
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            if (txt_Box.Text == "111")
            {
                SoundPlayer splayer = new SoundPlayer();
                splayer.SoundLocation = @".\Recording.wav";
                splayer.Play();
            }
            else
            {

                SoundPlayer splayer = new SoundPlayer();
                splayer.SoundLocation = @".\Recording.wav";
                splayer.Stop();
                MessageBox.Show("Wrong Number");
            }


        }

        private void textclear()
        {
            txt_Box.Clear();
        }

        private void txt_Box_TextChanged(object sender, EventArgs e)
        {

        }
        private void RadForm1_Load(object sender, EventArgs e)
        {


            timer1.Start();

        }

        private void lblMarquee_Click(object sender, EventArgs e)
        {

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Width == xPos)
            {
                //repeat marquee
                this.lblMarquee.Location = new Point(79, 38);
                xPos = 0;
            }
            else
            {
                this.lblMarquee.Location = new Point(xPos, 38);
                xPos++;
            }

        }
    }
}

