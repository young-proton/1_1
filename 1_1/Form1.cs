using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HidePB();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void HidePB()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
        }
        Random rand = new Random();
        private void ShowRandomPictureBox()
        {
            int randomIndex = rand.Next(1, 11);
            HidePB();

            switch (randomIndex)
            {
                case 1:
                    pictureBox1.Visible = true;
                    break;
                case 2:
                    pictureBox2.Visible = true;
                    break;
                case 3:
                    pictureBox3.Visible = true;
                    break;
                case 4:
                    pictureBox4.Visible = true;
                    break;
                case 5:
                    pictureBox5.Visible = true;
                    break;
                case 6:
                    pictureBox6.Visible = true;
                    break;
                case 7:
                    pictureBox7.Visible = true;
                    break;
                case 8:
                    pictureBox7.Visible = true;
                    break;
                case 9:
                    pictureBox7.Visible = true;
                    break;
                case 10:
                    pictureBox7.Visible = true;
                    break;
            }
        }

        int counter = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            ShowRandomPictureBox();
            counter = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowRandomPictureBox();
            counter += 1;
            score_amount.Text = $"{counter}";
        }
    }
}
