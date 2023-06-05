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
        static int Heigth = 540;
        public Pixel(){}

        public static Bitmap Encender(Bitmap bmp, int x, int y, Color color)
        {
            bmp.SetPixel(x, y, color);
            return bmp;
        }
        public static Bitmap PixelRandom(Bitmap bmp, Color color)
        {
            Random random = new Random();
            int x = random.Next(0, Width);
            int y = random.Next(0, Heigth);

            bmp.SetPixel(x, y, color);
            return bmp;
        }
    }
}
