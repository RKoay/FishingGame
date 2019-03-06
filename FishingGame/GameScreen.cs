using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FishingGame
{
    public partial class GameScreen : UserControl
    {
        //GLOBAL VARIABLES

        //related to rod
        int rodx, rodw;
        int rodhspeed, rodvspeed;

        //related to paddles
        int p1x = 0;
        int p1w = 200;
        int p1y = 310; //Allowing allowance to start to avoid collision from the start
        int p1h = 50;
        //speed of paddles
        int p1speed = 10;
        int p2speed = 5;

        //related to speed
        //speed of fish
        int newFishCounter;
        int fx, fy, fsize;

        Random randGen = new Random();


        // related to keys down and keys up 
        Boolean leftArrowDown, rightArrowDown, upArrowDown, downArrowDown;

        

        // thinking of creating a counter/tracker to track the amount of times the paddles hit the wall
        //increase in the number of hits decrease the distance between the paddles and the fish 
        Object rod;
        Object paddle1, paddle2;
  
        List<Object> Paddles = new List<Object>();
        List<Object> Fish = new List<Object>();
        SolidBrush brush;

        


        public GameScreen()
        {
            InitializeComponent();
            
            rodw = randGen.Next(10, 41);
            rodx = randGen.Next(0, this.Width - rodw);
            
            brush = new SolidBrush(Color.White);
            rodhspeed = 8;
            rodvspeed = 6;

            
            //Starting positions of rod and paddle
            rod = new Object(rodx, -662, rodw, this.Height, Color.DarkRed);

            paddle1 = new Object(p1x, p1y, p1w, p1h, Color.Tan);
            Paddles.Add(paddle1);

            paddle2 = new Object(p1x + this.Width/2 - p1w/2, p1y + p1h + 10, p1w, p1h, Color.Tan);
            Paddles.Add(paddle2);

            //declaring the method to make fish 
            MakeFish();
            

        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //player button presses
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;

                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
            }

            
        }


        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
            }

            
        }

        int fspeed; 

        //Method to make fish 
       public void MakeFish()
        {
            newFishCounter = 0;

            //About fish location and size
            fx = randGen.Next(0, this.Width - fsize);
            fy = randGen.Next(480, this.Height - fsize);
            fspeed = randGen.Next(-11, 12);
            fsize = randGen.Next(10, 100);

            //generating random colours
            int r = randGen.Next(0, 256);
            int g = randGen.Next(0, 256);
            int b = randGen.Next(0, 256);
            Color c = Color.FromArgb(r, g, b); 

            //Adding object(s) to a list 
            Object fishes = new Object(fx, fy, fsize, fsize, fspeed, c);
            Fish.Add(fishes);

        }

        private void GameLoop_Tick(object sender, EventArgs e)
        {
            newFishCounter++;
            //making new fish at certain intervals 
            if (newFishCounter == 10)
            {
                MakeFish();
            }

            //fish changes directions when hit with "walls"
            foreach (Object f in Fish)
            {
                f.FishMove();
                f.FishCollision();
                
            }

            
            //if the number of fish reaches a certain #, then
            if (Fish.Count == 200)
            {
                
            }
      
            
            //foreach statements used to control the directions of the paddles
            
            paddle1.PaddleMove(p1speed);
            paddle2.PaddleMove(p2speed);

            //changing the directions of the paddles 
            if (paddle1.x < 0)
            {
                p1speed *= -1;
            }
            if (paddle1.x > this.Width - paddle1.width)
            {
                p1speed *= -1;
            
            }
            if (paddle2.x < 0)
            {
                p2speed *= -1;
            }
            if (paddle2.x > this.Width - paddle2.width)
            {
                p2speed *= -1;

            }




            //Rod is able to move but paddle is unable to 
            //else ifs are used because both cannot happen at the same time
            if (leftArrowDown)
            {
                rod.Move(rodhspeed, "left");
            }
            else if (rightArrowDown)
            {
                rod.Move(rodhspeed, "right");
            }

            //if statement is used in this one because up and right can happen at the same time but 
            //up and down cannot
            if (upArrowDown)
            {
                rod.Move(rodvspeed, "up");
            }
            else if (downArrowDown)
            {
                rod.Move(rodvspeed, "down");
            }

            //checking rod collision with walls and with paddles
            rod.Collision(rod, paddle1, paddle2);
            rod.Collision(rod);

            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
             brush.Color = rod.color;
             e.Graphics.FillRectangle(brush, rod.x , rod.y, rod.width, rod.height);
            

            foreach (Object p in Paddles)
            {
                brush.Color = p.color;
                e.Graphics.FillRectangle(brush, p.x, p.y, p.width, p.height);

            }

            foreach (Object f in Fish)
            {
                //changing the color of every fish
                brush.Color = f.color;
                e.Graphics.FillEllipse(brush, f.x, f.y, f.width, f.height);
            }
        }

        
    }
}


