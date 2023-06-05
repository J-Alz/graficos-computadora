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
        public static Bitmap ScanUniColor(Bitmap bmp, Color color)
        {
            for (int i = 0; i < Width; i++)
                for (int j = 0; j < Height; j++)
                    bmp.SetPixel(i, j, color);
            return bmp;
        }
        public static Bitmap ScanBiColor(Bitmap bmp, Color color1, Color color2)
        {
            for (int i = 0; i < Width; i++)
                for (int j = 0; j < Height; j++)
                    if (i <= bmp.Width / 2)
                        bmp.SetPixel(i, j, color1);
                    else
                        bmp.SetPixel(i, j, color2);
            return bmp;
        }
        private static int Interpolacion(int i)
            => (int)(-0.36 * i + 255);
        public static Bitmap GradientScanner(Bitmap bmp)
        {
            for (int i = 0; i < Width; i++)
                for (int j = 0; j < Height; j++)
                    bmp.SetPixel(i, j, Color.FromArgb(255, Interpolacion(i), 0));
            return bmp;
        }
        public static Bitmap GradientScanner2(Bitmap bmp)
        {
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    int value = Interpolacion(i);
                    bmp.SetPixel(i, j, Color.FromArgb(value, value, 255));
                }

            }
            return bmp;
        }
    }
}
