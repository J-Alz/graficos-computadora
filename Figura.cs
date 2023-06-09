using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC
{
    internal static class Figura
    {
        static int Width = 700;
        static int Height = 540;
        static double Pi = 3.14159;
        readonly static double dx = 0.0001;
        public static Bitmap Circle(Color color, double Rd, double x, double y)
        {
            Bitmap bmp = new Bitmap(Width, Height);
            Vector vector = new Vector();
            for (double t = -Pi; t <= Pi; t += dx)
            {
                vector.X0 = x + Rd * Math.Cos(t);
                vector.Y0 = y + Rd * Math.Sin(t);
                bmp = vector.Encender(bmp, color);
            }
            return bmp;
        }
        public static Bitmap Circle(Color color, double Rd)
        {
            Bitmap bmp = new Bitmap(Width, Height);
            Vector vector = new Vector();
            for (double t = -Pi; t <= Pi; t += dx)
            {
                vector.X0 = Rd * Math.Cos(t);
                vector.Y0 = Rd * Math.Sin(t);
                bmp = vector.Encender(bmp, color);
            }
            return bmp;
        }

        public static Bitmap Concentrica()
        {
            Bitmap img = new Bitmap(Width, Height);
            Graphics g = Graphics.FromImage(img);
            g.DrawImageUnscaled(Circle(Color.Blue, 4),0,0);
            g.DrawImageUnscaled(Circle(Color.Blue, 1), 0, 0);
            g.DrawImageUnscaled(Circle(Color.Blue, 7), 0, 0);
            g.DrawImageUnscaled(Circle(Color.Blue, 3), 0, 0);
            return img;
        }

        public static Bitmap Lazo(Color color)
        {
            double t = 0;
            Bitmap img = new Bitmap(Width, Height);
            Vector vector = new Vector(0, 0);
            do
            {
                //                  * hace mas grande, / se hace mas pequeña
                //                  + se desplaza
                //           x0 +  h  *
                vector.X0 = (2 + Math.Sin(2 * t));
                vector.Y0 = (3 + Math.Cos(3 * t));
                img = vector.Encender(img, color);
                t += dx;
            } while (t <= (2 * Pi));
            return img;
        }
        public static Bitmap Espiral(Color color)
        {
            Bitmap img = new Bitmap(Width, Height);
            Vector vector = new Vector(0, 0);
            for (double t = 0; t <= 8; t += dx)
            {
                //                   /3 se reduce el tamaño
                vector.X0 = (t / 3 * Math.Cos(t));
                //        8 aumenta el numero de vueltas
                vector.Y0 = (t / 3 * Math.Sin(t));
                img = vector.Encender(img, color);

            }
            return img;
        }
        public static Bitmap Taylor()
        {
            Bitmap img = new Bitmap(Width, Height);
            Vector vector = new Vector(0, 0);
            for(double t = -6; t <= 6; t += dx)
            {
                vector.X0 = t;
                vector.Y0 = Math.Pow(2, t);
                img = vector.Encender(img, Color.Black);

            }
            for (double t = -6; t <= 6; t += dx)
            {
                vector.X0 = t;
                vector.Y0 = (1 + (0.69 * t) + 0.24 * Math.Pow(t, 2));
                img = vector.Encender(img, Color.Green);

            }
            for (double t = -6; t <= 6; t += dx)
            {
                vector.X0 = t;
                vector.Y0 = (1 + (0.69 * t) + (0.24 * Math.Pow(t, 2)) + (0.05 * Math.Pow(t, 3)));
                img = vector.Encender(img, Color.Blue);

            }
            return img;
        }
        public static Bitmap Lagrange()
        {
            Bitmap img = new Bitmap(Width, Height);
            Graphics g = Graphics.FromImage(img);
            g.DrawImageUnscaled(Circle(Color.Black, 0.3, 2, 8), 0, 0);
            g.DrawImageUnscaled(Circle(Color.Black,0.3,3,10), 0, 0);
            g.DrawImageUnscaled(Circle(Color.Black,0.3,4,9), 0, 0);
            g.DrawImageUnscaled(Circle(Color.Black,0.3,5,12), 0, 0);

            Vector vector = new Vector();
            for(double t = 2; t<= 5; t += dx)
            {
                vector.X0 = t;
                vector.Y0 = ((1.17 * Math.Pow(t, 3)) - (12 * Math.Pow(t, 2)) + 39.83 * t - 33);
                img = vector.Encender(img, Color.Red);

            }

            return img;
        }
        public static Bitmap Lagrange2()
        {
            Bitmap img = new Bitmap(Width, Height);
            Graphics g = Graphics.FromImage(img);
            g.DrawImageUnscaled(Circle(Color.Black, 0.3, -1,3), 0, 0);
            g.DrawImageUnscaled(Circle(Color.Black, 0.3, 1,5), 0, 0);
            g.DrawImageUnscaled(Circle(Color.Black, 0.3, 3,2), 0, 0);
            Vector vector = new Vector();
            for (double t = -1.1; t <= 5; t += dx)
            {
                vector.X0 = t;
                vector.Y0 = ((-0.625 * Math.Pow(t, 2)) + ((1) * Math.Pow(t, 1)) + (4.625)); ;
                img = vector.Encender(img, Color.Red);

            }
            return img;
        }



        public static Bitmap Parabola()
        {
            Bitmap img = new Bitmap(Width, Height);
            Vector vector = new Vector();
            for (double t = -16; t <= 16; t += dx)
            {
                vector.X0 = t;
                vector.Y0 = (49 - Math.Pow(t, 2)) / 15;
                img = vector.Encender(img, Color.Green);

            }
            Foco(img);
            Luz(img);
            return img;
        }
        public static Bitmap Foco(Bitmap img)
        {
            Graphics g = Graphics.FromImage(img);
            float t = 0.048f;

            do
            {
                g.DrawImageUnscaled(Circle(Color.Red,t,0,-0.48), 0, 0);
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
            segmento.Yf = (49 - Math.Pow(-3, 2)) / 15;
            segmento.Encender(img, Color.Red);

            segmento.X0 = 0;
            segmento.Y0 = -0.48;
            segmento.Encender(img, Color.Red);

            segmento.Xf = 8;
            segmento.Yf = (-1.0467 * 8 - 0.48);
            segmento.Encender(img, Color.Red);
            return img;
        }

    }
}
