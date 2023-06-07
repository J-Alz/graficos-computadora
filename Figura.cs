using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CC
{
    internal class Figura
    {
        static float pi = 3.1416f;
        static double dt = 0.0001;
        static double t = 0;

        static int Width = 700;
        static int Height = 540;
        public static Bitmap Lazo(Color color)
        {
            Bitmap img = new Bitmap(Width, Height);
            Vector vector = new Vector(0,0);
            do
            {
                //                  * hace mas grande, / se hace mas pequeña
                //                  + se desplaza
                //           x0 +  h  *
                vector.X0 = (2 + Math.Sin(2 * t));
                vector.Y0 = (3 + Math.Cos(3 * t));
                img = vector.Encender(img, color);
                t += dt;
            } while (t <= (2 * pi));
            return img;
        }
        public static Bitmap Espiral(Color color)
        {
            Bitmap img = new Bitmap(Width, Height);
            double t = 0f;
            Vector vector = new Vector(0,0);
            do
            {
                //                   /3 se reduce el tamaño
                vector.X0 = (float)(t/3 * Math.Cos(t));
                vector.Y0 = (float)(t/3 * Math.Sin(t));
                img = vector.Encender(img, color);
                t += dt;
                //        8 aumenta el numero de vueltas
            } while (t <= 8);

            return img;
        }
        public static Bitmap Taylor()
        {
            Bitmap img = new Bitmap(Width, Height);
            t = -6;
            Vector vector = new Vector(0,0);
            do
            {
                vector.X0 = t;
                vector.Y0 = (float)Math.Pow(2,t);
                img = vector.Encender(img, Color.Black);
                t += dt;
            } while (t <= 6);
            t = -6;
            do
            {
                vector.X0 = t;
                vector.Y0 = (float)(1 + (0.69 * t) + 0.24 * (float)Math.Pow(t,2));
                img = vector.Encender(img, Color.Green);
                t += dt;
            } while (t <= 6);
            t = -6;
            do
            {
                vector.X0 = t;
                vector.Y0 = (float)(1 + (0.69 * t) + (0.24 * (float)Math.Pow(t,2)) + (0.05 * Math.Pow(t,3)));
                img = vector.Encender(img, Color.Blue);
                t += dt;
            } while (t <= 6);


            return img;
        }
        public static Bitmap Lagrange()
        {
            Bitmap img = new Bitmap(Width, Height);
            Circunferencia c = new Circunferencia();
            c.Encender(img, Color.Black, 0.3f, 2, 8);
            c.Encender(img, Color.Black, 0.3f, 3, 10);
            c.Encender(img, Color.Black, 0.3f, 4, 9);
            c.Encender(img, Color.Black, 0.3f, 5, 12);

            t = 2;
            Vector vector = new Vector();
            do
            {
                vector.X0 = t;
                vector.Y0 = (float)((1.17 * Math.Pow(t, 3)) - (12 * Math.Pow(t, 2)) + 39.83 * t - 33);
                img = vector.Encender(img, Color.Red);
                t += dt;
            } while (t <= 5);

            return img;
        }
        public static Bitmap Lagrange2()
        {
            Bitmap img = new Bitmap(Width, Height);
            Circunferencia c = new Circunferencia();
            c.Encender(img, Color.Black, 0.3f, -1, 3);
            c.Encender(img, Color.Black, 0.3f, 1, 5);
            c.Encender(img, Color.Black, 0.3f, 3, 2);

            t = -1.1f;
            Vector vector = new Vector();
            do
            {
                vector.X0 = t;
                vector.Y0 = (float)((-0.625 * Math.Pow(t, 2)) + ((1) * Math.Pow(t, 1)) + (4.625)); ;
                img = vector.Encender(img, Color.Red);
                t += dt;
            } while (t <= 5);

            return img;
        }
        public static Bitmap Concentrica()
        {
            Bitmap img = new Bitmap(Width, Height);
            Circunferencia c = new Circunferencia();
            c.Encender(img, Color.Blue, 4);
            c.Encender(img, Color.Blue, 1);
            c.Encender(img, Color.Blue, 7);
            c.Encender(img, Color.Blue, 3);
            return img;
        }
        public static Bitmap punto()
        {
            Bitmap img = new Bitmap(Width, Height);
            Circunferencia c = new Circunferencia();
            //Modificar coordenadas para graficar
            c.Encender(img, Color.Black, 0.15f, -1, 3);
            return img;
        }

        public static Bitmap Parabola()
        {
            Bitmap img = new Bitmap(Width, Height);
            t = -8;
            Vector vector = new Vector();
            do
            {
                vector.X0 = t;
                vector.Y0 = (49 - Math.Pow(t, 2)) / 15;
                img = vector.Encender(img, Color.Green);
                t += dt;
            } while (t <= 8);

            //vector.X0 = 0;
            //vector.Y0 = 48.75 / 15;
            //bmp = vector.Encender(bmp, Color.Aqua);
            Foco(img);
            Luz(img);
            return img;
        }
        // Resolver foco de la parabola anterior
        public static Bitmap Foco(Bitmap img)
        {
            //Bitmap img = new Bitmap(Width, Height);
            float t = 0.048f;
            Circunferencia c = new Circunferencia();
            do
            {
                c.Encender(img, Color.Red, t, 0, -0.48f);
                t += 0.01f;
            } while (t <= 0.05);//


            return img;
        }
        public static Bitmap Luz(Bitmap img)
        {
            Segmento segmento = new Segmento();
            segmento.X0 = -3;
            segmento.Y0 = -16;//-4
            segmento.Xf = -3;
            segmento.Yf = (float)(49 - Math.Pow(-3, 2))/15;
            segmento.Encender(img, Color.Red);

            segmento.X0 = 0;
            segmento.Y0 = -0.48;
            segmento.Encender(img, Color.Red);

            segmento.Xf = 8;
            segmento.Yf = (float)(-1.0467 * 8 - 0.48);
            segmento.Encender(img, Color.Red);
            return img;
        }
    }
}
