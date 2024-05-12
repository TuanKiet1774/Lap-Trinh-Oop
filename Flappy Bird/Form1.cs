using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;

        bool gameOver = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            FlappyBird.Top += gravity;
            PipeBottom.Left -= pipeSpeed;
            PipeTop.Left -= pipeSpeed;
            ScoreText.Text = "Score: " + score.ToString();

            if(PipeBottom.Left < -150)
            {
                PipeBottom.Left = 800;
                score++;
            }    
            if(PipeTop.Left < -180)
            {
                PipeTop.Left = 950;
                score++;
            }    

            if(FlappyBird.Bounds.IntersectsWith(PipeBottom.Bounds) ||
               FlappyBird.Bounds.IntersectsWith(PipeTop.Bounds) ||
               FlappyBird.Bounds.IntersectsWith(Ground.Bounds) ||
               FlappyBird.Top < -25)
            {
                endGame();
            }    

            if(score > 5)
            {
                pipeSpeed = 15; 
            }    

               
        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }    
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
            if(e.KeyCode == Keys.R  && gameOver)
            {
                RestartGame();
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            ScoreText.Text = "Score: " + score.ToString() + "   Game Over - Press R to Restart";
            gameOver = true;
        }

        private void RestartGame()
        {
            gameOver = false;
            FlappyBird.Location = new Point(30, 226);
            PipeBottom.Left = 800;
            PipeTop.Left = 1200;

            score = 0;
            pipeSpeed = 8;

            ScoreText.Text = "Score: 0";
            gameTimer.Start();
        }
    }
}
