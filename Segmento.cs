using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace CC
{
    internal class Segmento:Vector
    {
        
        public Segmento(double xi, double yi, double xf, double yf)
        {
            X0 = xi;
            Y0 = yi;
            Dx = 0.000001;
            for (double t = 0; t <= 1; t += Dx)
            {
                X0 = (X0 * (1 - t)) + (xf * t);
                Y0 = (Y0 * (1 - t)) + (yf * t);
                Encender(Color.Blue);
            }
        }
        public Segmento(double xi, double yi, double m)
        {
            double b = yi - m * xi;
            for (double x = -8; X0 <= 8; x += Dx)
            {
                X0 = x;
                Y0 = m * X0 + b;
                //Console.WriteLine("x: " + X0);
                //Console.WriteLine("yf: " + Y0);
                Encender(Color.Red);
            }
        }
        public Segmento() { }

        //Falla al momento de dibujar en las x positivas
        public Segmento pendienteXi(double xi, double yi, double xf, double yf)
        {
            double m;
            m = (yf - yi) / (xf - xi);
            double b = yi - m * xi;
            for (double x = xi; X0 <= 8 && Y0 <= 6.15; x += Dx)
            {
                X0 = x;
                Y0 = m * X0 + b;
                Encender(Color.Blue);
            }
            return this;
        }
        
        
    }
}
