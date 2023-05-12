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
        //Ventana pantalla
        static int sx1 = 0;
        static int sy1 = 0;
        static int sx2 = 700;//
        static int sy2 = 540;

        //Ventana real
        static int x1 = -8;
        static int x2 = 8;
        static float y1 = -6.15f;//-7
        static float y2 = 6.15f;
        
        public Pixel(){}

        public static Bitmap Encender(Bitmap bmp, int x, int y, Color color)
        {
            bmp.SetPixel(x, y, color);
            return bmp;
        }
        public static void Transforma(int sx, int sy, out double x, out double y)
        {
            x = (((sx - sx1) / (sx1 - sx2)) * (x1 - x2)) + x1;
            y = (((sy - sy1) / (sy1 - sy2)) * (y1 - y2)) + y1;
        }
        public static void Pantalla(double x, double y, out int sx, out int sy)
        {
            sx = (int)(((x - x1) / (x1 - x2)) * (sx1 - sx2)) + sx1;
            sy = (int)(((y - y1) / (y1 - y2)) * (sy1 - sy2)) + sy1;     
        }

    }
}
