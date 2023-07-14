using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CC
{
    internal class Onda:Vector
    {
        //double time;
        public double t = 1;
        public Onda GrafOnda()
        {
            int color0;
            double x, y, z;
            double w = 1.5;
            double v = 9.3;
            double t = 1;
            Color color;
            for(int i = 0; i < Bmp.Width; i++)
            {
                for(int j = 0; j < Bmp.Height; j++)
                {
                    Geometria.Transforma(i, j, out x, out y );
                    x += 5;
                    y += 5;
                    z = w * Math.Sqrt(x * x + y * y) - v * t;
                    z = Math.Sin(z) + 1;
                    color0 = (int)(z * 7.5);
                    color = Paleta.paletaOnda()[color0];
                    Bmp.SetPixel(i, j, color);
                    //X0 = x;
                    //Y0 = y;
                    //Encender(color);
                }
            }
            return this;
        }
        public Onda GrafOnda(double t0)
        {
            int color0;
            double x, y, z;
            double w = 1.5;
            double v = 9.3;
            Color color;
            for (int i = 0; i < Bmp.Width; i++)
            {
                for (int j = 0; j < Bmp.Height; j++)
                {
                    Geometria.Transforma(i, j, out x, out y);
                    x += 5;
                    y += 5;
                    z = w * Math.Sqrt(x * x + y * y) - v * (t - t0);
                    z = Math.Sin(z) + 1;
                    color0 = (int)(z * 7.5);
                    color = Paleta.paletaOnda()[color0];
                    Bmp.SetPixel(i, j, color);
                }
            }
            return this;
        }

        public Onda Interferencia()
        {
            int color0;
            double w = 1.5;
            double v = 9.3;
            double t = 1;
            double x, y, z, z1, z2, z3;
            Color color;
            for(int i = 0; i < Bmp.Width;i++)
            {
                for(int j = 0;j < Bmp.Height; j++)
                {
                    Geometria.Transforma(i, j, out x, out y);
                    x += 0;//5-0
                    y += 2;//5-4
                    //z1 = w * Math.Sqrt((x - 0) * (x - 0) + (y - 3) * (y - 3)) - v * t;
                    z1 = w * Math.Sqrt(Math.Pow(x - 0, 2) + Math.Pow(y + 3, 2)) - v * t;
                    x -= 0; //2 - 0
                    y -= -2;//2-4
                    //z2 = w * Math.Sqrt((x - 0) * (x - 0) + (y + 3) * (y + 3)) - v * t;
                    z2 = w * Math.Sqrt((x - 0) * (x - 0) + Math.Pow(y - 3, 2)) - v * t;
                    x += 3;
                    y += 3;
                    z3 = 2 * Math.Sqrt((x - 0) * (x - 0) + Math.Pow(y - 3, 2)) - v * t;
                    z1 = Math.Sin(z1) + 1;
                    z2 = Math.Sin(z2) + 1;
                    z3 = Math.Sin(z3) + 1;
                    z = z1 + z2 + z3;
                    color0 = (int)(z * 1.875);//1.875
                    color = Paleta.paleta0[color0];
                    Bmp.SetPixel(i, j, color);
                }
            }
            return this;
        }
    }
}
