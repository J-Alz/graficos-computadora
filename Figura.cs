using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC
{
    internal class Figura: Vector, IDisposable
    {
        //private bool disposed = false;
        public Figura(Color color): base(color)
        {

        }
        public Figura(): base(Color.Aqua)
        {

        }
        //~Figura()
        //{
        //    Dispose(false);
        //}

        //public void Dispose()
        //{
        //    Dispose(true);
        //    //if (bmp != null)
        //    //{
        //    //    bmp.Dispose();
        //    //    bmp = null;
        //    //}
        //    GC.SuppressFinalize(this);
        //}
        //override
        //protected virtual void Dispose(bool disposing)
        //{
        //    if (!disposed)
        //    {
        //        if (disposing)
        //        {
        //            Bmp.Dispose();
        //            Bmp = null;
        //        }
        //        //base.Dispose(disposing);
        //        disposed = true;
        //    }
        //}

        public Figura PixelRandom()
        {
            Random random = new Random();
            int x = random.Next(0, Bmp.Width);
            int y = random.Next(0, Bmp.Height);
            Bmp.SetPixel(x, y, color);
            return this;
        }
        public Figura VectorEjemplo()
        {
            for(double t = -8; t <= 5; t += Dx)
            {
                X0 = t;
                Y0 = (t / 2) + 1;
                Encender(color);
            }
            return this;
        }
        public Figura segmento(double x0, double y0, double xf, double yf)
        {
            color = Color.Black;
            X0 = x0;
            Y0 = y0;
            for(double t = 0; t <= 1; t+= Dx)
            {
                X0 = X0 + (xf - X0) * t;
                Y0 = Y0 + (yf - Y0) * t;
                //X0 = X0 * (1 - t) + xf * t;
                //Y0 = Y0 * (1 - t) + yf * t;
                Encender(color);
            }
            return this;
        }
        public Figura Circulo(Color color, double radio, double x, double y)
        {
            for(double t = -Math.PI; t <= Math.PI; t += Dx)
            {
                X0 = x + radio * Math.Cos(t);
                Y0 = y + radio * Math.Sin(t);
                Encender(color);
            }
            return this;
        }
        public Figura Concentrica()
        {
            Circulo(Color.Black, 1, 0, 0);
            Circulo(Color.Red, 2, 0, 0);
            Circulo(Color.Blue, 3, 0, 0);
            Circulo(Color.Aqua, 4, 0, 0);
            return this;
        }
        //Ver si se manda color como parametro de creación
        public Figura Lazo()
        {
            for(double t = 0; t <= (2 * Math.PI); t += Dx)
            {
                //          * hace mas grande, / se hace mas pequeña
                //          + se desplaza
                //  x0 +  h  *
                X0 = 2 + Math.Sin(2 * t);
                Y0 = 3 + Math.Sin(3 * t);
                Encender(color);
            }
            return this;
        }
        public Figura Espiral()
        {
            for(double t = 0; t <= 8; t += Dx)
            {
                X0 = (t / 3 * Math.Cos(t));
                Y0 = (t / 3 * Math.Sin(t));
                Encender(color);
            }
            return this;
        }
        public Figura Taylor()
        {
            for(double t = -6; t <= 6; t += Dx)
            {
                X0 = t;
                Y0 = Math.Pow(2,t);
                Encender(Color.Blue);
            }
            for(double t = -6; t <= 6; t += Dx)
            {
                X0 = t;
                Y0 = (1 + (0.69 * t) + 0.25 * Math.Pow(t, 2));
                Encender(Color.Green);
            }
            for(double t = -6; t <= 6; t += Dx)
            {
                X0 = t;
                Y0 = (1 + (0.69 * t) + (0.24 * Math.Pow(t, 2)) + (0.05 * Math.Pow(t, 3)));
                Encender(Color.Red);
            }
            return this;
        }
        public Figura Lagrange()
        {
            Circulo(Color.Black,0.3,2,8);
            Circulo(Color.Black,0.3,3,10);
            Circulo(Color.Black,0.3,4,9);
            Circulo(Color.Black,0.3,5,12);
            for(double t = 2; t <= 5;  t += Dx)
            {
                X0 = t;
                Y0 = ((1.17 * Math.Pow(t, 3)) - (12 * Math.Pow(t, 2)) + 39.83 * t - 33);
                Encender(Color.Red);
            }
            return this;
        }
        public Figura Interpolacion()
        {
            Circulo(Color.Black, 0.3, -1, 3);
            Circulo(Color.Black, 0.3, 1, 5);
            Circulo(Color.Black, 0.3, 3, 2);
            for (double t = -1.1; t <= 5; t += Dx)
            {
                X0 = t;
                Y0 = ((-0.625 * Math.Pow(t, 2)) + ((1) * Math.Pow(t, 1)) + (4.625));
                Encender(Color.Red);
            }
            return this;
        }
        public Figura Parabola()
        {
            for (double t = -16; t <= 16; t += Dx)
            {
                X0 = t;
                Y0 = (49 - Math.Pow(t, 2)) / 15;
                Encender(Color.Green);
            }
            Circulo(Color.Red, 0.1, 0, -0.48);//FOCO
            return this;
        }
        public Figura PuntoParabola(double x, double y)
        {
            Graphics g = Graphics.FromImage(Bmp);
            double yf = (49 - Math.Pow(x, 2)) / 15;
            if (y <= yf)
            {
                g.DrawImageUnscaled(Circulo(Color.Black, 0.1, x, y).Bmp, 0, 0);
                g.DrawImageUnscaled(new Segmento(x, y, x, yf).Bmp, 0, 0);
                //Console.WriteLine("x: " + x);
                //Console.WriteLine("yf: " + yf);
                //Console.WriteLine("m: " + (-0.13 * x));
                g.DrawImageUnscaled(new Segmento(x,yf,-0.13 * x).Bmp, 0, 0);
                g.DrawImageUnscaled(new Segmento(x,yf,0,-0.48).Bmp,0,0);
            }
            return this;
        }
        public Figura ParabolaLuzRebote(double x, double y)
        {
            for (double t = y; t <= ((49 - Math.Pow(y, 2)) / 15) ; t += Dx)
            {
                X0 = ((49 - Math.Pow(y, 2)) / 15);
                Y0 = t;
                Encender(Color.Black);
            }
                return this;
        }
        //Prueba, Esto es una animación
        public Figura ParabolaDoble()
        {
            //Primera Fase
            for (double t = -16; t <= 16; t += Dx)
            {
                X0 = t;
                Y0 = (100 - Math.Pow(t, 2)) / 15;
                Encender(Color.Green);

            }
            //Segunda Fase
            for (double t = -16; t <= 16; t += Dx)
            {
                X0 = t;
                Y0 = (10 - Math.Pow(t, 2)) / 15;
                Encender(Color.Green);

            }
            //la tercera fase es la animación del circulo
            return this;
        }
        //Esto tambien es parte de una animación
        public Figura ParabolasConsecutivas()
        {
            //Primera parabola
            for (double t = -16; t <= 16; t += Dx)
            {
                X0 = t;
                Y0 = -(t + 1) * (t - 2);
                if (Y0 > 0)
                    Encender(Color.Green);
            }
            //Segunda parabola
            for (double t = -16; t <= 16; t += Dx)
            {
                X0 = t;
                Y0 = -(t - 2) * (t - 4);
                if (Y0 > 0)
                    Encender(Color.Green);

            }
            //Tercera parabola
            for (double t = -16; t <= 16; t += Dx)
            {
                X0 = t;
                Y0 = -(t + 5) * (t + 1);
                if (Y0 > 0)
                    Encender(Color.Green);

            }
            return this;
        }
        public Figura axis()
        {
            for (double t = Geometria.y1; t <= Geometria.y2; t += Dx)
            {
                X0 = 0;
                Y0 = t;
                Encender(Color.Red);
            }
            for (double t = Geometria.x1; t <= Geometria.x2; t += Dx)
            {
                X0 = t;
                Y0 = 0;
                Encender(Color.Red);
            }
            return this;
        }

    }
}
