using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace FishingGame
{
    class Object

    {
        public Color color;
        public int x, y, width, height, speed;


        //x-value and width could become fx, fsize
        public Object(int _x, int _y, int _width, int _height, Color _color)
        {
            x = _x;
            y = _y;

            width = _width;
            height = _height;
            color = _color;
        }

        //Creating fish object 
        public Object(int _x, int _y, int _width, int _height, int _speed, Color _color)
        {
            x = _x;
            y = _y;

            width = _width;
            height = _height;
            color = _color;
            speed = _speed;
        }
        //moving the brown paddles
        public void PaddleMove(int pspeed)
        {
            x += pspeed;
            //y-values stay the same, not moving up or down
        
        }
        
        //Moving the Rod
        public void Move(int speed, string direction)
        {
            if (direction == "left")
            {
                x -= speed;
            }
            if (direction == "right")
            {
                x += speed;
            }
            if (direction == "up")
            {
                y -= speed;
            }
            if (direction == "down")
            {
                y += speed;
            }
        }

        //Rod collision with paddles 
        public void Collision(Object r, Object p1, Object p2)
        {
            // the rod
            Rectangle rod = new Rectangle(r.x, r.y, r.width, r.height);

            // the paddles
            Rectangle paddle1 = new Rectangle(p1.x, p1.y, p1.width, p1.height);
            Rectangle paddle2 = new Rectangle(p2.x, p2.y, p2.width, p2.height);

            //when rod intersects with paddles, go back to original position
            if (rod.IntersectsWith(paddle1) || rod.IntersectsWith(paddle2))
            {
                r.x = 720 - r.width/2;
                r.y = -662;
            }
        }

        public bool HitTracker(Object o)
        {
            // the rod
            Rectangle ob = new Rectangle(o.x, o.y, o.width, o.height);

            // the paddles
            Rectangle rod = new Rectangle(x, y, width, height);

            if (ob.IntersectsWith(rod))
            {
                return true;
            }

            return false;
        }
        //public bool Collision(Character c)

        //{
        //    Rectangle thisRec = new Rectangle(x, y, width, height);
        //    Rectangle cRec = new Rectangle(c.x, c.y, c.width, c.height);

        //    if (thisRec.IntersectsWith(cRec))
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //Object rod collision with the walls method
        //Remember to add gamescreen to the variable column 
        public void Collision(Object r)
        {
            Rectangle rod = new Rectangle(r.x, r.y, r.width, r.height);

            //collision with left wall
            if (r.x < 200)
            {
                r.x = 200;
            }
            //Collision with right wall
            if (r.x > 1440 - r.width)
            {
                r.x = 1440 - r.width;
            }
            if (r.y > 0)
            {
                r.y = 0;
            }
            if (r.y + r.height < 0)
            {
                r.y = -662;
            }
        }

        
        //Fishy interactions
        public void FishMove()
        { 
            x += speed;
            y += speed;
        }


        //Fish Collision with walls 

        public void FishCollision()
        {
            if (x < 0 || x > 1440 - width)
            {
                speed *= -1;
            }
            if (y < 480 || y > 962 - height)
            {
                speed *= -1;
            }
        }
        

        //Rod collision with fish 
        //Fish will be on rod
        public void RodFishCollision(Object r, Object f/*, int fishscore, int constant*/)
        {
            Rectangle rod = new Rectangle(r.x, r.y, r.width, r.height);
            Rectangle fishes = new Rectangle(f.x, f.y, f.width, f.height);

            //the command below somehow move the fish forward from their original position
            //if (rod.IntersectsWith(fishes))
            //{
            //    f.y = r.y + r.height;
            //}
            
            if (rod.IntersectsWith(fishes))
            {
                //fishscore += constant;
                Random randGen = new Random();
                f.x = randGen.Next(20, 101);
                f.y = randGen.Next(20, 101);
            }
        }
        
        

    }
}
