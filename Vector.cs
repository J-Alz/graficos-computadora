using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CC
{
    internal class Vector
    {
        double x0;
        double y0;
        //int sx, sy;

        public double X0
        {
            get => x0;
            set => x0 = value;
        }
        public double Y0
        {
            get => y0;
            set => y0 = value;
        }
        
        public Vector(double x0, double y0)
        {
            this.x0 = x0;
            this.y0 = y0;
        }
        public Vector() 
        { 
            this.x0 = 0;
            this.y0 = 0;
        }
        

        public Bitmap Encender(Bitmap bmp,Color color)
        {
            int sx;
            int sy;
            Geometria.Pantalla(x0, y0, out sx, out sy);
            if (sx >= 0 && sx < 700 && sy >= 0 && sy < 540)
            {
                //bmp = Pixel.Encender(bmp,sx, sy, color);
                bmp.SetPixel(sx, sy, color);
                //Console.WriteLine("Sx: " + sx + " Sy: " + sy);
            }
            return bmp;
        }
        public Bitmap Encender(Bitmap bmp, Color color, int sx,int sy)
        {
            double x;
            double y;
            //System.Console.WriteLine("sx: " + sx + " sy: " + sy);
            //geometry.Transforma(sx,sy,out x,out y);
            //System.Console.WriteLine("x: " + x + " y: " + y);
            //geometry.Pantalla(x, y, out sx, out sy);
            //System.Console.WriteLine("sx: " + sx + " sy: " + sy);
            //bmp = Pixel.Encender(bmp, sx, sy, color);
            return bmp;
        }
        public Bitmap Prueba(Bitmap bmp, Color color)
        {
            float t = -8f;
            Vector vector = new Vector(0, 0);
            do
            {
                X0 = t;
                Y0 = (t / 2) + 1;
                bmp = vector.Encender(bmp, color);
                t += 0.01f;
            } while (t <= 5);
            return bmp;
        }
    }
}
