using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnlimitedFunSnake
{
    public class Snake : IDrawable, IKeyboardDependers, IUpdatable
    {
        public Queue<SnakePart> SnakeParts;
        public int Length;
        public SnakeHeadPart Head;
        public SnakeTailPart Tail;
        public Snake(int lgth)
        {
            int i;
            this.Length = lgth;
            SnakeParts = new Queue<SnakePart>();
            Tail = new SnakeTailPart(100, 100, 0);          
            for (i = 1; i < lgth - 1; ++i)
            {
                this.SnakeParts.Enqueue( new SnakePart(100+(16*i), 100));
            }
            Head = new SnakeHeadPart(100 + (16 * i), 100, 0);
        }
        public void Draw(Graphics gfx)
        {
            Head.Draw(gfx);
            PrintValues(SnakeParts, gfx);
            Tail.Draw(gfx);
        }
        public void Update(Dictionary<Keys, bool> keys)
        {
            if(keys[Keys.Up])
            {

            }
        }
        public void Keyboard(KeyEventArgs e)
        {
            PointF coor;
            coor = Head.Keyboard(e);
            if (coor.X > -100)
            {
                Tail.Keyboard(SnakeParts.Last().Coordinates);
                SnakeParts.Dequeue();
                SnakeParts.Enqueue(new SnakePart(coor.X, coor.Y));
            }
        }
        public static void PrintValues(IEnumerable myCollection, Graphics gfx)
        {
            foreach (SnakePart obj in myCollection)
                obj.Draw(gfx);
        }
    }
}
