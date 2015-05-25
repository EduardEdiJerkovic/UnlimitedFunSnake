using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnlimitedFunSnake
{
    public class Box : IUpdatable, IDrawable
    {
        public PointF Coordinates;
        public Box (float x, float y)
        {
            this.Coordinates.X = x;
            this.Coordinates.Y = y;
        }
        public void Update()
        {
            this.Coordinates.X += 1;
        }

        public void Draw(Graphics gfx)
        {
            gfx.DrawImage(Images.LoadImage("box.png"), this.Coordinates);
        }
    }
}
