using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace CC
{
    internal class Vector3D : Vector
    {
        double z0;
        public double Z0
        {
            get { return z0; }
            set { z0 = value; }
        }
        public void Axonometria(double x, double y, double z, out double ax, out double ay)
        {
            ax = x + 0.55 * y * Math.Cos(0.8);
            ay = 0.55 * y * Math.Sin(0.8) + z;
        }
        int dubX, dubY;
        public new Bitmap Encender(Color color)
        {
            double ax, ay;
            int sx , sy;
            Axonometria(X0,Y0,Z0, out ax, out ay);
            Geometria.Pantalla(ax, ay, out sx, out sy);
            if(sx >= 0 && sx < 700 && sy >= 0 && sy < 540)
            {
                Bmp.SetPixel(sx, sy, color);
                if(!(dubX == sx && dubY == sy))
                {
                    dubX = sx;
                    dubY = sy;
                }
            }
            return Bmp;
        }
    }
}
