using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace FlappyBirdGame
{
    public partial class flappyBirdForm : Form
    {
        int tubeSpeed = 10;//initial speed of the tubes
        int gravity = 10;//initial gravity
        int score = 0;
        private SoundPlayer soundPlayer;
       
        public flappyBirdForm()
        {
            InitializeComponent();
            soundPlayer = new SoundPlayer("BackgroundMusic.wav");
          
        }
  
     //Timer 
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            dragon.Top += gravity;
            
            tubeDown.Left -= tubeSpeed;
            tubeUp.Left -= tubeSpeed;
            scoreCounter.Text = "Score: " + score;
            resetButton.Enabled = false;//disables the restart button 
            ExitButton.Enabled = false;//disables the exit button 
            soundButton.Enabled = false;
            soundButton.Checked = true;

            if(tubeDown.Left < -150)
            {
                tubeDown.Left = 750;
               
            }
            if(tubeUp.Left < -180)
            {
                tubeUp.Left = 655;
                score++;
            }



            //If the dragon picture box touches the tubes or the floor the game ends.
            if (dragon.Bounds.IntersectsWith(tubeUp.Bounds) || dragon.Bounds.IntersectsWith(tubeDown.Bounds) || dragon.Bounds.IntersectsWith(floor.Bounds))
            {
                endgame();  
            }



            //if statements that increases the speed of tubes as the score gets higher
            if (score >= 3)
            {
                tubeSpeed = 15;

            }else if(score > 4)
            {
                tubeSpeed = 50;
          
            }else if (score > 5)
            {
                tubeSpeed = 100;
               
            }else if(score >= 10)
            {
                tubeSpeed = 200;
            }else if(score> 20)
            {
                tubeSpeed = 300;
            }


            //If the dragon picturebox top hitbox touches the top of the screen the game ends.
            if (dragon.Top < -25 )
            {
                endgame();
            }
            
            if(score < 1)
            {
                howToPlay.Text = "Press SpaceBar!";
            }
            else
            {
                howToPlay.Text = " ";
            }

        }


        private void flappyBirdForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
               
            }


        }

        private void flappyBirdForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
              
        }



      
        private void endgame()
        {
            gameTimer.Stop();
            resetButton.Enabled = true;
            ExitButton.Enabled = true;
            soundButton.Enabled = true;
            gameOverMessage.Text = "Game Over!!";
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
        
        }

        private void resetButton_Click_1(object sender, EventArgs e)
        {
            gameTimer.Start();
            resetButton.Enabled = false;
            ExitButton.Enabled = false;
            soundButton.Enabled = false;
            score = 0;
            dragon.Location = new Point(50, 170);
            gameOverMessage.Text = "";
            tubeSpeed = 10;
            tubeDown.Left = 750;
            tubeUp.Left = 600;

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            soundPlayer.Stop();
            MainMenu main = new MainMenu();
            main.Show();
        } 

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (soundButton.Checked)
            {
                soundPlayer.PlayLooping();
            }
            else
            {
                soundPlayer.Stop();
            }
        }
    }
}
