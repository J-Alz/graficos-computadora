using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC
{
    internal class Reflexion: Vector
    {
        double yf;
        double xf;
        double angulo = 60;

        public Reflexion(double x0, double y0,double yf)
        {
            X0 = x0;
            Y0 = y0;
            this.yf = yf;
        }
        public Reflexion(double x0, double y0, double xf,bool ejemplo)
        {
            X0 = x0;
            Y0 = y0;
            this.xf = xf;
        }

        public Reflexion segmentoXf()
        {
            xf = calcularXf();
            for (double t = 0; t <= 0.1; t += 0.000001)
            {
                X0 = X0 + (xf - X0) * t;
                Y0 = Y0 + (yf - Y0) * t;
                Encender(Color.Black);
            }
            return this;
        }
        public Reflexion segmentoYf()
        {
            yf = calcularYf();
            for (double t = 0; t <= 1; t += Dx)
            {
                X0 = X0 + (xf - X0) * t;
                Y0 = Y0 + (yf - Y0) * t;
                Encender(color);
            }
            return this;
        }
        public double calcularXf()
        {
            return (yf - Y0) / Math.Tan(angulo) + X0;
        }
        public double calcularYf()
        {
            return Math.Tan(angulo) * (xf - X0) + Y0;
        }
    }
}
