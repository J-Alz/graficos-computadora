using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CC
{
    internal class Segmento:Vector
    {
        //Intro: P0 y Pf
        //convertir punto P0 de real a pantalla
        //for(calcular y = mx + b)
        // m -> tang(teta), tambien necesito un angulo
        double angulo, b, m, maximo;
        public Segmento(double angulo,double x, double y)
        {
            this.angulo = angulo;
            this.X0 = x;
            this.Y0 = y;
            this.m = calcularPendiente(angulo);
            Console.WriteLine(m);
            b = calcularInterseccion(x,y);
            Console.WriteLine(b);
            maximo = (Geometria.y2 - b) / m;
        }
        public Segmento() { }
        private double calcularPendiente(double angulo)
            => Math.Tan(angulo * Math.PI / 180);
        private double calcularInterseccion(double x, double y)
            => y - (m * x);

        public Segmento D(ref double xi,ref double yi,double angulo)
        {
            m = calcularPendiente(angulo);
            b = calcularInterseccion(xi, yi);
            Y0 = -6.15;
            for (double x = -8; X0 <= 8 && Y0 <= 6.15; x += Dx)
            {
                X0 = x;
                Y0 = m * X0 + b;
                Encender(Color.Blue);
            }
            Console.WriteLine("X0: " + X0 + " Y0: " + Y0);
            xi = X0;
            yi = Y0;
            return this;
        }

        public Segmento Linea(double xi, double yi, double xf, double yf)
        {
            m =  (yf - yi)/(xf - xi);
            b = calcularInterseccion(xi, yi);
            for(double x = -8; x <=8; x += Dx)
            {
                X0 = x;
                Y0 = m + X0 + b;
                Encender(Color.Red);
            }
            return this;
        }

        public Segmento iterativoD()
        {
            double x = 1;
            double y = 0;
            Graphics g = Graphics.FromImage(Bmp);
            //g.DrawImageUnscaled(D(ref x, ref y, 60).Bmp, 0, 0);
            g.DrawImageUnscaled(D(ref x, ref y, 300).Bmp, 0, 0);
            g.DrawImageUnscaled(D(ref x, ref y, 240).Bmp, 0, 0);
            g.DrawImageUnscaled(D(ref x, ref y, 120).Bmp, 0, 0);
            //for (int i = 1; i <= 4; i++)
            //{
            //    Console.WriteLine("X: " + x + " Y: " + y);
            //}
            return this;
        }
        
    }
}
