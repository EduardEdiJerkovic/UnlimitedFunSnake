using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnlimitedFunSnake
{
    public class SnakeHeadPart :IUpdatable, IDrawable
    {
        public PointF Coordinates;
        public float Rotacion;
        public SnakeHeadPart(float x, float y, float rot)
        {
            this.Coordinates.X = x;
            this.Coordinates.Y = y;
            this.Rotacion = rot;
        }
        public PointF Keyboard(KeyEventArgs e)
        {
            PointF coor = this.Coordinates;
            switch (e.KeyCode)
            {
                case Keys.Up:
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

        public void Update(Dictionary<Keys, bool> keys)
        {
            
        }

        public void Draw(Graphics gfx)
        {
            gfx.DrawImage(Image.FromFile("snakeHeadTailPart.png"), this.Coordinates);
        }

    }
}
