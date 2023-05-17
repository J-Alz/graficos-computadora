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
        static int x1 = -16;//-8
        static int x2 = 16;//8
        static float y1 = -12.3f;//-7//-6.15
        static float y2 = 12.3f;
        
        public static float X1 
        {
            get {return x1; }
        }
        public static float X2
        {
            get { return x2; }
        }
        public static float Y1
        {
            get { return y1; }
        }
        public static float Y2
        {
            get { return y2; }
        }


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
            sy = (int)(((y - y2) / (y2 - y1)) * (sy1 - sy2)) + sy1;     
        }

    }
}
