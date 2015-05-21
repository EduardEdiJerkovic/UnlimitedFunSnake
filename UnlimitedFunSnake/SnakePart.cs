using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnlimitedFunSnake
{
    public class SnakePart :IDrawable, IUpdatable
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
        public void Update(Dictionary<Keys, bool> keys)
        {

        }
        //public void Keyboard(KeyEventArgs e)
        //{
        //    switch (e.KeyCode)
        //    {
        //        case Keys.Up:
        //            //Coordinates.X = 
        //            break;
        //        case Keys.Down:
        //            break;
        //        case Keys.Left:
        //            break;
        //        case Keys.Right:
        //            break;
        //        default:
        //            break;
        //    }
        //}
    }
}
