using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC
{
    internal class Onda3D: Vector3D
    {
        double w = 2.4;
        double v = 9.3;
        double t = 0.3;
        public Onda3D OndaGrafico3D()
        {
            int color0;
            double x, y, z;
            Color c;
            for(int i = 0; i < Bmp.Width; i++)
            {
                for(int j = 0; j < Bmp.Height; j++)
                {
                    Geometria.Transforma(i, j, out x, out y);
                    z = w * Math.Sqrt(x * x + y * y) - v * t;
                    z = Math.Sin(z) + 1;
                    color0 = (int)(z * 7.5);
                    c = Paleta.paleta0[color0];
                    Bmp.SetPixel(i, j, c);
                }
            }
            return this;
        }
        public Onda3D Onda()
        {
            for(double x = -6; x <= 6; x += 0.1)
            {
                for(double y = -5; y <= 5; y += 0.1)
                {
                    X0 = x;
                    Y0 = y;
                    //double d = Math.Sqrt(Math.Pow(x + 0, 2)) + Math.Pow(y + 0, 2);
                    Z0 = t * Math.Sin(w * Math.Sqrt(x * x + y * y) - v * t);
                    //double z = w * (d - v * t);
                    //Z0 = t * Math.Sin(z);
                    Encender(Color.Black);
                }
         
            }
            return this;
        }
        public Onda3D Onda2()
        {
            for (double x = -7; x <= 7; x += 0.1)
            {
                for (double y = -6; y <= 6; y += 0.1)
                {
                    double z;
                    X0 = x - 3;
                    Y0 = y;
                    Z0 = t * Math.Sin(w * Math.Sqrt(x * x + y * y) - v * t);
                    //Encender(Color.Black);
                    X0 = x + 3;
                    Y0 = y;
                    Z0 = t * Math.Sin(w * Math.Sqrt(x * x + y * y) - v * t);
                    
                    Encender(Color.Blue);
                }

            }
            return this;
        }
        public Onda3D Onda2(double t)
        {
            for (double x = -7; x <= 7; x += 0.1)
            {
                for (double y = -6; y <= 6; y += 0.1)
                {
                    X0 = x;
                    Y0 = y;
                    Z0 = 0.4 * Math.Sin(w * Math.Sqrt(x * x + y * y) - v * t);
                    Encender(Color.Black);
                }

            }
            return this;
        }
        public Onda3D Interferencia2(double t)
        {
            for (double x = -7; x <= 7; x += 0.1)
            {
                for (double y = -6; y <= 6; y += 0.1)
                {
                    double z1, z2;
                    X0 = x;
                    Y0 = y;
                    z1 = (Math.Sqrt((Math.Pow((x + 0), 2)) + (Math.Pow((y - 3), 2))));
                    z2 = (Math.Sqrt((Math.Pow((x + 0), 2)) + (Math.Pow((y + 3), 2))));
                    z1 = w * (z1 - v * t);
                    z2 = w * (z2 - v * t);
                    Z0 = 0.4 * Math.Sin(z1) + 0.4 * Math.Sin(z2);
                    Encender(Color.Black);
                }
            }
            return this;
        }
        public void Timer(object sender, EventArgs e)
        {

        }
    }

}
