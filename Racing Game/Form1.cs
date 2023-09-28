using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racing_Game
{
    public partial class Form1 : Form
    {

        int speed = 10;
        int score = 0;
        int hp = 3;
        int playerType = 0; //0 = green, 1 = blue
        int screenWidth = Screen.PrimaryScreen.Bounds.Width;
        int screenHeight = Screen.PrimaryScreen.Bounds.Height;


        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            setupGame();

        }

        private void setupGame()
        {
            Cursor.Position = PointToScreen(startBtn.Location);

            scoreLabel.Top = 20;
            scoreLabel.Left = 50;
            overLabel.Top = screenHeight / 2 - 100;
            overLabel.Left = screenWidth / 2 - 136;
            overLabel.Visible = false;
            hpLabel.Top = 20;
            hpLabel.Left = screenWidth - 150;
            pictureBox1.Visible = false;
            redBox1.Visible = false;
            redBox2.Visible = false;
            greenBox.Visible = false;
            blueBox.Visible = false;
            titleLabel.Left = screenWidth/2 - 175;
            titleLabel.Top = screenHeight / 2 - 100;
            startBtn.Top = screenHeight - (screenHeight / 2) - 10;
            startBtn.Left = screenWidth / 2 - 75;
            exitBtn.Top = screenHeight - (screenHeight / 2) + 50;
            exitBtn.Left = screenWidth / 2 - 75;

        }
          

        private void spawnObjects()
        {
            redBox1.Left = rnd.Next(2, screenWidth); // random numbers where they appear on the left
            redBox1.Top = rnd.Next(100, 200) * -1; // random numbers where they appear on top
            redBox2.Left = rnd.Next(2, screenWidth); // random numbers where they appear on the left
            redBox2.Top = rnd.Next(100, 200) * -1; // random numbers where they appear on top
            greenBox.Left = rnd.Next(2, screenWidth); // random numbers where they appear on the left
            greenBox.Top = rnd.Next(100, 200) * -1; // random numbers where they appear on top
            blueBox.Left = rnd.Next(2, screenWidth); // random numbers where they appear on the left
            blueBox.Top = rnd.Next(100, 200) * -1; // random numbers where they appear on top
            pictureBox1.Left = screenWidth / 2 - 50;
            pictureBox1.Top = screenHeight / 2;
        }

        private void showObjects()
        {
            redBox1.Visible = true;
            redBox2.Visible = true;
            greenBox.Visible = true;
            blueBox.Visible = true;
            pictureBox1.Visible = true;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            timer.Start();
            startBtn.Visible = false;
            exitBtn.Visible = false;
            titleLabel.Visible = false;
            overLabel.Visible = false;
            Cursor.Hide();
            speed = 10;
            score = 0;
            hp = 3;
            showObjects();
            spawnObjects();
            scoreLabel.Text = "Score: " + score;

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left = MousePosition.X;
            pictureBox1.Top = MousePosition.Y;

            greenBox.Top += speed;
            blueBox.Top += speed;
            redBox1.Top += speed;
            redBox2.Top += speed;


            if (pictureBox1.Bounds.IntersectsWith(greenBox.Bounds))
            {
                if(playerType==0)
                {
                    score++;
                    scoreLabel.Text = "Score: " + score;

                    greenBox.Left = rnd.Next(2, screenWidth); // random numbers where they appear on the left
                    greenBox.Top = rnd.Next(100, 200) * -1; // random numbers where they appear on top

                    speed += 2;
                }
                else
                {
                    greenBox.Left = rnd.Next(2, screenWidth); // random numbers where they appear on the left
                    greenBox.Top = rnd.Next(100, 200) * -1; // random numbers where they appear on top
                    hp--;
                }

            }

            if (pictureBox1.Bounds.IntersectsWith(blueBox.Bounds))
            {
                if (playerType == 1)
                {
                    score++;
                    scoreLabel.Text = "Score: " + score;

                    blueBox.Left = rnd.Next(2, screenWidth); // random numbers where they appear on the left
                    blueBox.Top = rnd.Next(100, 200) * -1; // random numbers where they appear on top

                    speed += 2;
                }
                else
                {
                    blueBox.Left = rnd.Next(2, screenWidth); // random numbers where they appear on the left
                    blueBox.Top = rnd.Next(100, 200) * -1; // random numbers where they appear on top
                    hp--;
                }
            }

            if (pictureBox1.Bounds.IntersectsWith(redBox1.Bounds))
            {
                redBox1.Left = rnd.Next(2, screenWidth); // random numbers where they appear on the left
                redBox1.Top = rnd.Next(100, 200) * -1; // random numbers where they appear on top
                hp--;
            }

            if (pictureBox1.Bounds.IntersectsWith(redBox2.Bounds))
            {
                redBox2.Left = rnd.Next(2, screenWidth); // random numbers where they appear on the left
                redBox2.Top = rnd.Next(100, 200) * -1; // random numbers where they appear on top
                hp--;
            }

            if (greenBox.Top > backgroundPanel.Height)
            {
                //changeAI1(); // change the AI car images once they left the scene
                greenBox.Left = rnd.Next(2, screenWidth); // random numbers where they appear on the left
                greenBox.Top = rnd.Next(100, 200) * -1; // random numbers where they appear on top
                speed += 2;
                hp--;
            }
            if (blueBox.Top > backgroundPanel.Height)
            {
                //changeAI1(); // change the AI car images once they left the scene
                blueBox.Left = rnd.Next(2, screenWidth); // random numbers where they appear on the left
                blueBox.Top = rnd.Next(100, 200) * -1; // random numbers where they appear on top
                speed += 2;
                hp--;
            }

            hpLabel.Text = "HP: " + hp;
            if (hp <= 0)
            { gameOver(); }

            if (redBox1.Top > backgroundPanel.Height)
            {
                //changeAI1(); // change the AI car images once they left the scene
                redBox1.Left = rnd.Next(2, screenWidth); // random numbers where they appear on the left
                redBox1.Top = rnd.Next(100, 200) * -1; // random numbers where they appear on top
                speed += 2;
            }
            if (redBox2.Top > backgroundPanel.Height)
            {
                //changeAI1(); // change the AI car images once they left the scene
                redBox2.Left = rnd.Next(2, screenWidth); // random numbers where they appear on the left
                redBox2.Top = rnd.Next(100, 200) * -1; // random numbers where they appear on top
                speed += 2;
            }
        }

        private void gameOver()
        {
            timer.Stop(); // stop the timer
            overLabel.Visible = true;
            exitBtn.Visible= true;
            Cursor.Show();
            startBtn.Visible = true;
            startBtn.Text = "Try again";
        }

        private void playerClick(object sender, EventArgs e)
        {
            if(playerType == 1)
            {
                pictureBox1.BackColor = Color.Green;
                playerType = 0;

            }
            else if (playerType == 0)
            {
                pictureBox1.BackColor = Color.Blue;
                playerType = 1;
            }

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
