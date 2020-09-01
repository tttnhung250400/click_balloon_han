using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm_Clickballoon
{
    public partial class Form2 : Form
    {
        int score = 0;
        int speed = 5;
        Random rand = new Random();
        bool gameOver = false;
        PictureBox boom = new PictureBox();
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer player1 = new WMPLib.WindowsMediaPlayer();
        
    
        public Form2()
        {
            InitializeComponent();
            player.URL = "win.wav";
            player1.URL = "bk.wav";
            
        }
        
        private void pop_Balloon(object sender, EventArgs e)
        {
            player.controls.play();
            if (gameOver == false)
            {
                var balloon = (PictureBox)sender;
                balloon.Top = rand.Next(700, 1000);
                balloon.Left = rand.Next(5, 500);
                score++;
            }
        }
        private void popBomb(object sender, EventArgs e)
        {
            if (gameOver == false)
            {
                bomb.Image = Properties.Resources.bomb;
                gametimer.Stop();
                lbDiem.Text += "";
                gameOver = true;
            }
        }

        private void gameEngine(object sender, EventArgs e)
        {
            lbDiem.Text = "Score:" + score;
            foreach (Control X in this.Controls)
            {
                if (X is PictureBox)
                {
                    X.Top -= speed;
                    if (X.Top + X.Height < 0)
                    {
                        X.Top = rand.Next(700, 1000);
                        X.Left = rand.Next(5, 500);
                    }
                    if ( X.Top < -500)
                    {
                        gametimer.Stop();
                        lbDiem.Text += "Game Over! ";
                        gameOver = true;
                    }
                }
            }

            if (score >= 10)
            { speed = 8; }

            if (score >= 20)
            { speed = 14; }

            if (score >= 35)
            { speed = 17; }

            if (score >= 45)
            { speed = 20; }
        }

        private void Keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gameOver == true)
            { resetGame(); }
        }

        private void resetGame()
        {
            player1.controls.play();
            foreach (Control X in this.Controls)
            {
                if (X is PictureBox)
                {
                    X.Top = rand.Next(700, 1000);
                    X.Left = rand.Next(5, 500);
                }
            }
            bomb.Image = Properties.Resources.bomb;
            speed = 0;
            score = 0;
            gameOver = false;
            lbDiem.Text = "Score: " + score;
            gametimer.Start();
        } 


       
                
    }
}
