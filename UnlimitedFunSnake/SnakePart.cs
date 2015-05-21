using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnlimitedFunSnake
{
    public class SnakePart : IDrawable
    {
        public PointF Coordinates;
        public SnakePart (float x, float y)
        {
            this.Coordinates.X = x;
            this.Coordinates.Y = y;            
        }
        public void Draw(Graphics gfx)
        {
            gfx.DrawImage(Image.FromFile("snakePart.png"), this.Coordinates);
        }
    }
}
