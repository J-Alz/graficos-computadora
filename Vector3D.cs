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
        public new void Encender(Bitmap bmp, Color color)
        {
            double ax, ay;
            int Sx , Sy;
            Axonometria(X0,Y0,Z0, out ax, out ay);
            Geometria.Pantalla(ax, ay, out Sx, out Sy);
            if(Sx >= 0 && Sx < 700 && Sy >= 0 && Sy < 540)
                bmp.SetPixel(Sx, Sy, color);
                //Pixel.Encender(bmp,Sx,Sy,color);
        }
    }
}
