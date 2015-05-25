using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnlimitedFunSnake
{
    public class SnakeHeadPart :IDrawable
    {
        public PointF Coordinates;
        public float Rotacion;
        public SnakeHeadPart(float x, float y, float rot)
        {
            this.Coordinates.X = x;
            this.Coordinates.Y = y;
            this.Rotacion = rot;
        }
        public PointF Keyboard(Keys e)
        {
            PointF coor = this.Coordinates;
            switch (e)
            {
                case Keys.Up:
                   // if(!CheckCollisions('y', -16))
                        Coordinates.Y -= 16;
                    return coor;
                case Keys.Down:
                    Coordinates.Y += 16;
                    return coor;
                case Keys.Left:
                    Coordinates.X -= 16;
                    return coor;
                case Keys.Right:
                    Coordinates.X += 16;
                    return coor;
                default:
                    coor.X = -100;
                    coor.Y = -100;
                    return coor;
                    
            }         
        }       
        //public bool CheckCollisions(char axis, int pixels)
        //{
        //    switch(axis)
        //    {
        //        case 'x':
        //            if (0 > Coordinates.X + pixels || Coordinates.X + pixels > 800)
        //            {
        //                DestroyBody();
        //                return true;
        //            }
        //            break;
        //        case 'y':
        //            if (0 > Coordinates.Y + pixels || Coordinates.Y > 496)
        //            {
        //                DestroyBody();
        //                return true;
        //            }
        //            break;
        //        default:
        //            break;
        //    }
        //    return false;
        //}

        public void DestroyBody()
        {

        }

        public void Draw(Graphics gfx)
        {
            //gfx.tra
            //gfx.RotateTransform((float)Math.PI / 2);
            gfx.DrawImage(Images.LoadImage("snakeHeadTailPart.png"), this.Coordinates);
            //gfx.ResetTransform();
        }

    }
}
