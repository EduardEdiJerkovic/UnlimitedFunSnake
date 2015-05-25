using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnlimitedFunSnake
{
    public class Rebbit : IDrawable, IUpdatable
    {
        public PointF Coordinates;
        public bool Life;

        public Rebbit(float x, float y)
        {
            this.Coordinates.X = x;
            this.Coordinates.Y = y;
        }

        public void Draw(Graphics gfx)
        {
            gfx.DrawImage(Images.LoadImage("Rebbit.png"), this.Coordinates);
        }

        public void Update()
        {
            
        }

        public PointF GetCordinates()
        {
            return this.Coordinates;
        }
    }
}
