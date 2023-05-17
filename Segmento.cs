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
        static float dt = 0.0001f;
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
        public static Bitmap AxisY(Bitmap bmp, Color color)
        {
            float t = Pixel.Y1;
            Vector vector = new Vector();
            do
            {
                vector.X0 = 0;
                vector.Y0 = t;
                bmp = vector.Encender(bmp, color);
                t += dt;
            } while (t <= Pixel.Y2);
            return bmp;
        }
        public static Bitmap AxisX(Bitmap bmp, Color color)
        {
            float t = Pixel.X1;
            Vector vector = new Vector();
            do
            {
                vector.X0 = t;
                vector.Y0 = 0;
                bmp = vector.Encender(bmp, color);
                t += dt;
            } while (t <= Pixel.X2);
            return bmp;
        }

        public static Bitmap L(Bitmap bmp, Color color)
        {
            float t = 2;
            float dt = 0.0001f;
            Vector vector = new Vector();
            do
            {
                vector.X0 = t;
                vector.Y0 = (float)((1.17*Math.Pow(t,3)) - (12 * Math.Pow(t,2)) + 39.83 * t - 33);
                bmp  = vector.Encender(bmp, color);
                t += dt;
            } while (t <= 5);

            return bmp;
        }
        public static Bitmap L2(Bitmap bmp, Color color)
        {
            float t = -1.1f;
            float dt = 0.0001f;
            Vector vector = new Vector();
            do
            {
                vector.X0 = t;
                vector.Y0 = (float)((-0.625 * Math.Pow(t, 2)) + ((1) * Math.Pow(t, 1)) + (4.625)); ;
                bmp = vector.Encender(bmp, color);
                t += dt;
            } while (t <= 5);

            return bmp;
        }
    }
}
