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
        public Onda GrafOnda()
        {
            int color0;
            double x, y, z;
            Color color;
            for(int i = 0; i < Bmp.Width; i++)
            {
                for(int j = 0; j < Bmp.Height; j++)
                {
                    Geometria.Transforma(i, j, out x, out y);
                    z = 1.5 * Math.Sqrt(x * x + y * y) - 9.3 * 1;
                    z = Math.Sin(z) + 1;
                    color0 = (int)(z * 7.5);
                    color = Paleta.paleta0[color0];
                    Bmp.SetPixel(i, j, color);
                    //X0 = x;
                    //Y0 = y;
                    //Encender(color);
                }
            }
            return this;
        }
    }
}
