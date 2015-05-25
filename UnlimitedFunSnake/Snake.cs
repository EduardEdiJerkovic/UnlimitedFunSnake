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
        public Keys LastMovment;
        public Queue<Keys> Direction;
        public bool check;
        public int count;
        public Snake(int lgth)
        {
            int i;
            count = 0;
            this.Length = lgth;
            SnakeParts = new Queue<SnakePart>();
            LastMovment = Keys.Right;
            Direction = new Queue<Keys>();

            Tail = new SnakeTailPart(96, 96, 0);          
            for (i = 1; i < lgth - 1; ++i)
            {
                this.SnakeParts.Enqueue( new SnakePart(96+(16*i), 96));
            }
            Head = new SnakeHeadPart(96 + (16 * i), 96, 0);
        }
        public void Draw(Graphics gfx)
        {
            Head.Draw(gfx);
            PrintValues(SnakeParts, gfx);
            Tail.Draw(gfx);
        }
        public void Update()
        {
            PointF coor;
            Keys tmp;
            count = (count + 1) % 15;
            if (count == 8)
            {
                while (Direction.Count != 0)
                {
                    tmp = Direction.Dequeue();
                    if (!Opposite(LastMovment, tmp))
                    {
                        LastMovment = tmp;
                        break;
                    }
                }
                coor = Head.Keyboard(LastMovment);
                if (coor.X > -100)
                {
                    Tail.Keyboard(SnakeParts.Last().Coordinates);
                    SnakeParts.Dequeue();
                    SnakeParts.Enqueue(new SnakePart(coor.X, coor.Y));
                }
            }
        }
        public void Keyboard(Keys key)
        {
                Direction.Enqueue(key);
        }
        public static void PrintValues(IEnumerable myCollection, Graphics gfx)
        {
            foreach (SnakePart obj in myCollection)
                obj.Draw(gfx);
        }
        public bool Opposite(Keys key1, Keys key2)
        {
            var listUpDown = new List<Keys>() { Keys.Up, Keys.Down };
            var listLeftRight = new List<Keys>() { Keys.Left, Keys.Right };
            return (listUpDown.Contains(key1) && listUpDown.Contains(key2)) || (listLeftRight.Contains(key1) && (listLeftRight.Contains(key2)));
        }
    }
}
