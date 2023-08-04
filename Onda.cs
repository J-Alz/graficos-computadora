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
        public double t = 1;
        public double w = 1.5;
        public double v = 9.3;
        double x, y, z;
        public Onda DrawOnda(Color[] paleta)
        {
            int color0;
            for(int i = 0; i < Bmp.Width; i++)
            {
                for(int j = 0; j < Bmp.Height; j++)
                {
                    Geometria.Transforma(i, j, out x, out y );
                    z = w * Math.Sqrt(x * x + y * y) - v * t;
                    z = Math.Sin(z) + 1;
                    color0 = (int)(z * 7.5);
                    Bmp.SetPixel(i, j, paleta[color0]);
                }
            }
            return this;
        }
        public Onda DrawOnda(Color[] paleta, int xp, int yp)
        {
            int color0;
            for (int i = 0; i < Bmp.Width; i++)
            {
                for (int j = 0; j < Bmp.Height; j++)
                {
                    Geometria.Transforma(i, j, out x, out y);
                    x += xp;
                    y += yp;
                    z = w * Math.Sqrt(x * x + y * y) - v * t;
                    z = Math.Sin(z) + 1;
                    color0 = (int)(z * 7.5);
                    Bmp.SetPixel(i, j, paleta[color0]);
                }
            }
            return this;
        }
        
        public Onda DrawOnda(Color[] paleta, double t0)
        {
            int color0;
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
                    Bmp.SetPixel(i, j, paleta[color0]);
                }
            }
            return this;
        }

        public Onda Interferencia2(Color[] paleta)
        {
            int color0;
            double z1, z2;
            for(int i = 0; i < Bmp.Width;i++)
            {
                for(int j = 0;j < Bmp.Height; j++)
                {
                    Geometria.Transforma(i, j, out x, out y);
                    x += 0;
                    y += 2;
                    z1 = w * Math.Sqrt((x - 0) * (x - 0) + (y - 3) * (y - 3)) - v * t;
                    x -= 0; 
                    y -= -2;
                    z2 = w * Math.Sqrt((x - 0) * (x - 0) + (y + 3) * (y + 3)) - v * t;
                    z1 = Math.Sin(z1) + 1;
                    z2 = Math.Sin(z2) + 1;
                    z = z1 + z2;
                    color0 = (int)(z * 1.875);
                    Bmp.SetPixel(i, j, paleta[color0]);
                }
            }
            return this;
        }
        public Onda Interferencia3(Color[] paleta)
        {
            int color0;
            double z1, z2, z3;
            
            for (int i = 0; i < Bmp.Width; i++)
            {
                for (int j = 0; j < Bmp.Height; j++)
                {
                    Geometria.Transforma(i, j, out x, out y);
                    x += 0;//5-0
                    y += 2;//5-4
                    z1 = w * Math.Sqrt(Math.Pow(x - 0, 2) + Math.Pow(y + 3, 2)) - v * t;
                    x -= 0; //2 - 0
                    y -= -2;//2-4
                    z2 = w * Math.Sqrt((x - 0) * (x - 0) + Math.Pow(y - 3, 2)) - v * t;
                    x += 3;
                    y += 3;
                    z3 = 2 * Math.Sqrt((x - 0) * (x - 0) + Math.Pow(y - 3, 2)) - v * t;
                    z1 = Math.Sin(z1) + 1;
                    z2 = Math.Sin(z2) + 1;
                    z3 = Math.Sin(z3) + 1;
                    z = z1 + z2 + z3;
                    color0 = (int)(z * 1.875);//1.875
                    Bmp.SetPixel(i, j, paleta[color0]);
                }
            }
            return this;
        }
    }
}
