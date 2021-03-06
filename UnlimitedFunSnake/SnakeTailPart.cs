﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnlimitedFunSnake
{
    public class SnakeTailPart : IDrawable
    {
        public PointF Coordinates;
        public float Rotacion;
        public SnakeTailPart(float x, float y, float rot)
        {
            this.Coordinates.X = x;
            this.Coordinates.Y = y;
            this.Rotacion = rot;
        }
        public void Keyboard(PointF coords)
        {
            Coordinates = coords;
        }

        public void Draw(Graphics gfx)
        {
            gfx.DrawImage(Images.LoadImage("snakeHeadTailPart.png"), this.Coordinates);
        }

    }
}
