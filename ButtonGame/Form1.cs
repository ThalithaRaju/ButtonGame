using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonGame
{
    
    public partial class Form1 : Form
    {
     int  score = 50;
       // int yourscore = 0;

        int lifes = 3;
        
        public Form1()
        {
            InitializeComponent();
        }
        System.Windows.Forms.Timer tmr = null;
        private void StartTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
           timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(48, 119, 137);
            panel1.BackColor = Color.White;
            
            pictureBox1.BackColor= Color.FromArgb(48, 119, 137);
           

           
                                       
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            


            lblUser.Text = btnOne.Text;
            Random rnd = new Random();
            int random = rnd.Next(1, 6);
            llRndom.Text = random.ToString();
            score = 50 + Convert.ToInt32(btnOne.Text);
            lblScore.Text = score.ToString();
            //if (lblUser.Text == llRndom.Text)
            //{
            //    lblWikets.Text = (lifes - 1).ToString();
            //}
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            lblUser.Text = btnTwo.Text;
            Random rnd = new Random();
            int random = rnd.Next(1, 6);
            llRndom.Text = random.ToString();
            score = 50 + Convert.ToInt32(btnTwo.Text);
            lblScore.Text = score.ToString();
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            lblUser.Text = btnThree.Text;
            Random rnd = new Random();
            int random = rnd.Next(1, 6);
            llRndom.Text = random.ToString();
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            lblUser.Text = btnFour.Text;
            Random rnd = new Random();
            int random = rnd.Next(1, 6);
            llRndom.Text = random.ToString();
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            lblUser.Text = btnFive.Text;
            Random rnd = new Random();
            int random = rnd.Next(1, 6);
            llRndom.Text = random.ToString();
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            lblUser.Text = btnSix.Text;
            Random rnd = new Random();
            int random = rnd.Next(1, 6);
            llRndom.Text = random.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
        }
    }
}
