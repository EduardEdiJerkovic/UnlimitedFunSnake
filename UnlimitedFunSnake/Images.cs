using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnlimitedFunSnake
{
    public class Images
    {
        static Dictionary<string, Bitmap> dict;
        static Images()
        {
            dict = new Dictionary<string, Bitmap>();
        }
        public static Bitmap LoadImage(string str)
        {
            Bitmap bitmap;
            if(dict.TryGetValue(str, out bitmap))
            {
                return bitmap;
            }
            else 
            {
                var bmp = new Bitmap(str);
                bitmap = new Bitmap(bmp.Width, bmp.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                var gfx = Graphics.FromImage(bitmap);
                gfx.DrawImage(bmp, 0, 0);
                for (int i = 0; i < bitmap.Width; ++i )
                {
                    for (int j = 0; j < bitmap.Height; ++j )
                    {
                        var pix = bitmap.GetPixel(i, j);
                        if (pix.B == 255 && pix.G == 255 && pix.R == 255)
                        {
                            bitmap.SetPixel(i, j, Color.Transparent);
                        }
                    }
                }
                dict[str] = bitmap;
                return bitmap;
            }
        }

    }
}
