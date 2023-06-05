using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CC
{
    internal class Figura
    {
        static float pi = 3.1416f;
        static double dt = 0.0001;
        static double t = 0;
        public static Bitmap Lazo(Bitmap bmp, Color color)
        {
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
        public static Bitmap Espiral(Bitmap bmp, Color color)
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
        public static Bitmap Taylor(Bitmap bmp)
        {
            t = -6;
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
        public static Bitmap Parabola(Bitmap bmp)
        {
            t = -8;
            Vector vector = new Vector();
            do
            {
                vector.X0 = t;
                vector.Y0 = (49 - Math.Pow(t, 2)) / 15;
                bmp = vector.Encender(bmp, Color.Yellow);
                t += dt;
            } while (t <= 8);

            //vector.X0 = 0;
            //vector.Y0 = 48.75 / 15;
            //bmp = vector.Encender(bmp, Color.Aqua);
            //Foco(bmp);
            return bmp;
        }
        // Resolver foco de la parabola anterior
        public Bitmap Foco(Bitmap bmp)
        {
            float t = 0.05f;
            Circunferencia c = new Circunferencia();
            do
            {
                c.Encender(bmp, Color.Red, t, 0, -0.048f);
                t += 0.01f;
            } while (t <= 0.5);


            return bmp;
        }
    }
}
