using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace CC
{
    internal class Segmento : Vector
    {
        float xf;
        float yf;
        public Segmento(float xf, float yf)
        {
            this.xf = xf;
            this.yf = yf;
        }
        public new Bitmap Encender(Bitmap bmp, Color color)
        {
            float t = 0f;
            float dt = 0.0001f;
            Vector vector = new Vector(-6, -4);
            do
            {
                vector.X0 = X0 + (xf - X0) * t;
                vector.Y0 = Y0 + (yf - Y0) * t;
                bmp = vector.Encender(bmp, color);
                t += dt;
            } while (t <= 1);
            return bmp;
        }
        public static Bitmap Eje(Bitmap bmp, Color color)
        {
            float t = -6.15f;
            float dt = 0.0001f;
            Vector vector = new Vector();
            do
            {
                vector.X0 = 0;
                vector.Y0 = t;
                bmp = vector.Encender(bmp, color);
                t += dt;
            } while (t <= 8);
            //-8,0
            t = -8f;
            dt = 0.0001f;
            vector = new Vector();
            do
            {
                vector.X0 = t;
                vector.Y0 = 0;
                bmp = vector.Encender(bmp, color);
                t += dt;
            } while (t <= 8);



            return bmp;
        }
    }
}
