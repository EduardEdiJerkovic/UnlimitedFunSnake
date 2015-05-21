using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnlimitedFunSnake
{
    public partial class SnakeForm : Form
    {
        public List<IUpdatable> UpdatableList;
        public List<IDrawable> DrawableList;
        public List<IKeyboardDependers> KeyboardList;
        public Graphics Gfx;
        public Stopwatch Stopwatch;
        public Dictionary<Keys, bool> KeyboardDic;
        public Keys TmpPressedKey;

        public SnakeForm()
        {
            InitializeComponent();
            this.ClientSize = new Size(800, 496);
            var bmp = new Bitmap(800, 496);
            snakePictureBox.Image = bmp;
            Gfx = Graphics.FromImage(bmp);
            UpdatableList = new List<IUpdatable>();
            DrawableList = new List<IDrawable>();
            KeyboardList = new List<IKeyboardDependers>();
            KeyboardDic = new Dictionary<Keys, bool>();
            TmpPressedKey = Keys.Right;

            //Gfx.FillRectangle(new SolidBrush(Color.Red), 100, 100, 100, 100);
            var timer = new Timer();
            timer.Interval = 16;
            timer.Tick += Update;
            timer.Tick += Draw;          
            timer.Start();

            KeyboardDic.Add(Keys.Up, false);
            KeyboardDic.Add(Keys.Down, false);
            KeyboardDic.Add(Keys.Left, false);
            KeyboardDic.Add(Keys.Right, false);

            var box = new Box(10, 10);
            UpdatableList.Add(box);
            DrawableList.Add(box);

            var snake = new Snake(3);
            UpdatableList.Add(snake);
            DrawableList.Add(snake);
            KeyboardList.Add(snake);

            this.KeyDown += Keyboard;
            this.KeyDown += DictionaryDown;

            this.KeyUp += DictionaryUp;


            Stopwatch = new Stopwatch();
        }
        public void Update(object t, EventArgs e)
        {
            //Stopwatch.Stop();
            //Debug.WriteLine(1F / ((float)Stopwatch.ElapsedTicks / Stopwatch.Frequency));
            //Stopwatch.Restart();
            UpdatableList.ForEach(a => a.Update());
        }
        public void Draw(object t, EventArgs e)
        {
            Gfx.Clear(Color.White);
            DrawableList.ForEach(a => a.Draw(Gfx));
            Refresh();
        }
        public void Keyboard(object t, KeyEventArgs e)
        {
            var list = new List<Keys>(){Keys.Up, Keys.Down, Keys.Right, Keys.Left};

            if (list.Contains(e.KeyCode))
                KeyboardList.ForEach(a => a.Keyboard(e.KeyCode));
        }
        public void DictionaryUp(object t, KeyEventArgs e)
        {
            KeyboardDic[e.KeyCode] = true;
        }
        public void DictionaryDown(object t, KeyEventArgs e)
        {
            KeyboardDic[e.KeyCode] = false;
        }
    }
}
