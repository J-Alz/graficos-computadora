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
        public Pixel(){}

        public static Bitmap Encender(Bitmap bmp, int x, int y, Color color)
        {
            bmp.SetPixel(x, y, color);
            return bmp;
        }
        
        public static Bitmap ScanUniColor(Bitmap bmp, Color color)
        {
            for (int i = 0; i < 700; i++)
                for(int j = 0; j < 540; j++)
                    bmp.SetPixel(i, j, color);
            return bmp;

        }
        public static Bitmap ScanBiColor(Bitmap bmp)
        {
            for (int i = 0; i < 700; i++)
                for (int j = 0; j < 540; j++)
                    if(i <=350)
                        bmp.SetPixel(i, j, Color.Yellow);
                    else
                        bmp.SetPixel(i, j, Color.Red);
            return bmp;

        }
        public static Bitmap ScanRGB(Bitmap bmp)
        {
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 540; j++)
                {
                    bmp.SetPixel(i, j, Color.FromArgb(255,(int)(-0.36 * i + 255),0));
                }

            }
            return bmp;

        }
    }
}
