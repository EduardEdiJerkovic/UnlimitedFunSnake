using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnlimitedFunSnake
{
    public class Background :IDrawable
    {
        int length;
        int width;
        Bitmap bmp;

        public Background(int l, int w)
        {
            this.width = w;
            this.length = l;

            bmp = new Bitmap(800, 496);
            var gfx = Graphics.FromImage(bmp);
            var img = Images.LoadImage("background.png");
            for (int i = 0; i < this.length; i += 16)
            {
                for (int j = 0; j < this.width; j += 16)
                {
                    gfx.DrawImage(img, i, j);
                }
            }
        }

        public void Draw(Graphics gfx)
        {
            gfx.DrawImage(bmp, 0, 0);
        }
    }
}
