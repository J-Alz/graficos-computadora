using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CC
{
    internal class Figura:Vector
    {
        static float pi = 3.1416f;
        double dt = 0.0001;
        public Bitmap Lazo(Bitmap bmp, Color color)
        {
            double t = 0f;
            Vector vector = new Vector(0,0);
            do
            {
                //                  * hace mas grande, / se hace mas pequeña
                //                  + se desplaza
                //           x0 +  h  *
                vector.X0 = (2 + Math.Sin(2 * t));
                vector.Y0 = (3 + Math.Cos(3 * t));
                bmp = vector.Encender(bmp, color);
                t += dt;
            } while (t <= (2 * pi));
            return bmp;
        }
        public Bitmap Curva2(Bitmap bmp, Color color)
        {
            double t = 0f;
            Vector vector = new Vector(0,0);
            do
            {
                //                   /3 se reduce el tamaño
                vector.X0 = (float)(t/3 * Math.Cos(t));
                vector.Y0 = (float)(t/3 * Math.Sin(t));
                bmp = vector.Encender(bmp, color);
                t += dt;
                //        8 aumenta el numero de vueltas
            } while (t <= 8);

            return bmp;
        }
        public Bitmap Taylor(Bitmap bmp)
        {
            float t = -6;
            float dt = 0.0001f;
            Vector vector = new Vector(0,0);
            do
            {
                vector.X0 = t;
                vector.Y0 = (float)Math.Pow(2,t);
                bmp = vector.Encender(bmp, Color.Black);
                t += dt;
            } while (t <= 6);
            t = -6;
            do
            {
                vector.X0 = t;
                vector.Y0 = (float)(1 + (0.69 * t) + 0.24 * (float)Math.Pow(t,2));
                bmp = vector.Encender(bmp, Color.Green);
                t += dt;
            } while (t <= 6);

            t = -6;
            do
            {
                vector.X0 = t;
                vector.Y0 = (float)(1 + (0.69 * t) + (0.24 * (float)Math.Pow(t,2)) + (0.05 * Math.Pow(t,3)));
                bmp = vector.Encender(bmp, Color.Blue);
                t += dt;
            } while (t <= 6);


            return bmp;


        }
    }
}
