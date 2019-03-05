using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingGame
{
    class Object

    {

        public int x, y, width, height;
        //x-value and width could become fx, fsize
        public Object(int _x, int _y, int _width, int _height)
        {
            x = _x;
            y = _y;

            width = _width;
            height = _height;
        }

        //moving the brown paddles
        public void PaddleMove(int pspeed)
        {
           x += pspeed;
           
        }

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

        public void FishMove(int fy, int fspeed)
        {

        }


    }
}
