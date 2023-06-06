using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC
{
    internal class Pixel
    {
        static int Width = 700;
        static int Height = 540;
        public Pixel(){}

        public static Bitmap Encender(Bitmap bmp, int x, int y, Color color)
        {
            bmp.SetPixel(x, y, color);
            return bmp;
        }
        public static Bitmap PixelRandom(Color color)
        {
            Bitmap img = new Bitmap(Width, Height);
            Random random = new Random();
            int x = random.Next(0, Width);
            int y = random.Next(0, Height);

            img.SetPixel(x, y, color);
            return img;
        }
    }
}
