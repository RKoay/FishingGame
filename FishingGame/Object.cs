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

        //Object rod collision with the walls method
        //Remember to add gamescree to the variable column 
        public void Collision(Object r)
        {
            Rectangle rod = new Rectangle(r.x, r.y, r.width, r.height);

            if (r.x < 0)
            {
                r.x = 0;
            }
            if (r.x > 1440 - r.width)
            {
                r.x = 1440 - r.width;
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

        //Collision with fish 


        

    }
}
