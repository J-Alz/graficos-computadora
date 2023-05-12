using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC
{
    internal class Vector
    {
        float x0;
        float y0;

        public float X0
        {
            get => x0;
            set => x0 = value;
        }
        public float Y0
        {
            get => y0;
            set => y0 = value;
        }
        
        public Vector(float x0, float y0)
        {
            this.x0 = x0;
            this.y0 = y0;
        }
        public Vector() { }
        
        public Bitmap Encender(Bitmap bmp,Color color)
        {
            int sx;
            int sy;
            Pixel.Pantalla(x0, y0, out sx, out sy);
            if (sx >= 0 && sx < 700 && sy >= 0 && sy < 540)
            {
                bmp = Pixel.Encender(bmp,sx, sy, color);
            }
            return bmp;
        }
        public Bitmap Prueba(Bitmap bmp, Color color)
        {
            float t = -8f;
            Vector vector = new Vector(0, 0);
            do
            {
                X0 = t;
                X0 = (t / 2) + 1;
                bmp = vector.Encender(bmp, color);
                t += 0.01f;
            } while (t <= 5);
            return bmp;
        }
    }
}
