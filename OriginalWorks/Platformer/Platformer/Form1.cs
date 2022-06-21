using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platformer
{
    public partial class FormPlatformer : Form
    {
        const int JUMP_HEIGHT = 50;
        const int GRAVITY = 2;
        const int VERTICAL_SPEED_CHANGE = 4;
        int level = 1;
        int verticalVolocity = 0;
        int horizontalVolocity = 0;
        int xPos = 0;
        int yPos = 0; 

        public FormPlatformer()
        {
            InitializeComponent();
        }
        

        private void pbPlayer_Click(object sender, EventArgs e)
        {

        }

        private void timerMovement_Tick(object sender, EventArgs e)
        {
            horizontalVolocity = -1 * VERTICAL_SPEED_CHANGE;
            bool isColiding = false;
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "ground")
                {
                    if (pbPlayer.Bounds.IntersectsWith(x.Bounds) && verticalVolocity <= 10)
                    {
                        isColiding = true;
                    }
                }
                
            }

            if (isColiding == true)
            {
                verticalVolocity = 0;
            }
            else
            {
                verticalVolocity -= GRAVITY;
            }

            if (verticalVolocity <= -10)
            {
                pbPlayer.Top += 10;
                verticalVolocity = -10;
            }
            else if ( verticalVolocity >= 10)
            {
                pbPlayer.Top -= 10;
            }
            else
            {
                pbPlayer.Top -= verticalVolocity;
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "ground")
                {
                    x.Left += horizontalVolocity;
                }
            }
            if (horizontalVolocity > 4) {
                horizontalVolocity = 4;
            }
            else if (horizontalVolocity < -4)
            {
                horizontalVolocity = -4;
            }
            xPos -= horizontalVolocity;
           
            textBox1.Text = "Pos: (" + (pbPlayer.Location.X + xPos) + ", " + (pbPlayer.Top + yPos) + ")";
            textBox1.Text += "\r\nVertical Speed: " + verticalVolocity;
            textBox1.Text += "\r\nHorizontal Speed: " + horizontalVolocity;
        }
        private void FormPlatformer_KeyDown(object sender, KeyEventArgs e)
        {            
            if (e.KeyCode == Keys.Up)
            {
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && x.Tag == "ground")
                    {
                        if (pbPlayer.Bounds.IntersectsWith(x.Bounds) && verticalVolocity <= JUMP_HEIGHT)
                        {
                            verticalVolocity += JUMP_HEIGHT;
                            
                        }
                    }
                }
            }
        }
        
        private void FormPlatformer_KeyUp(object sender, KeyEventArgs e)
        {
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormPlatformer_Load(object sender, EventArgs e)
        {
            pbPlayer.BringToFront();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void gameOver()
        {
            
        }
    }
}
