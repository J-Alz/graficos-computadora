using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC
{
    internal class Scanner
    {
        static int Width = 700;
        static int Height = 540;
        public static Bitmap ScanUniColor(Color color)
        {
            Bitmap img = new Bitmap(Width, Height);
            for (int i = 0; i < Width; i++)
                for (int j = 0; j < Height; j++)
                    img.SetPixel(i, j, color);
            return img;
        }
        public static Bitmap ScanBiColor(Color color1, Color color2)
        {
            Bitmap img = new Bitmap(Width, Height);
            for (int i = 0; i < Width; i++)
                for (int j = 0; j < Height; j++)
                    if (i <= Width / 2)
                        img.SetPixel(i, j, color1);
                    else
                        img.SetPixel(i, j, color2);
            return img;
        }
        private static int Interpolacion(int i)
            => (int)(-0.36 * i + 255);
        public static Bitmap GradientScanner()
        {
            Bitmap img = new Bitmap(Width, Height);
            for (int i = 0; i < Width; i++)
                for (int j = 0; j < Height; j++)
                    img.SetPixel(i, j, Color.FromArgb(255, Interpolacion(i), 0));
            return img;
        }
        public static Bitmap GradientScanner2()
        {
            Bitmap img = new Bitmap(Width, Height);
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    int value = Interpolacion(i);
                    img.SetPixel(i, j, Color.FromArgb(value, value, 255));
                }

            }
            return img;
        }
    }
}
