using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC
{
    internal class Cuerda: Vector
    {
        double l = 15;
        double c = 0.3;
        public double t = 0;

        //  double ve = 1;
        //double g = 1; // representa la velocidad 
        public Cuerda()
        {
            for(double x = -5; x <= l; x += Dx)
            {
                X0 = x;
                Y0 = Fourier(x);
                Encender(Color.Blue);

            }
        }

        public double Fourier(double x)
        {
            double sol;
            double bk, ak, sun;
            sun = 0;

            for(int k = 1; k <= 10; k++)
            {
                ak = (2.0 / l) * (l / 6.0);
                ak = ak * (0 + 4 * f(l / 2.0) * Math.Sin(k * Math.PI / 2.0) + 0);

                bk = (2.0 / (k * Math.PI * c)) * (l / 6.0);
                bk = bk * (0 + 4 * g(l / 2.0) * Math.Sin((k * Math.PI) / 2.0) + 0);
                sun = sun + (ak * Math.Cos((k * Math.PI * c * t) / l) + bk * Math.Sin((k * Math.PI * c * t) / l)) * Math.Sin((k * Math.PI * x) / l);
                sun = sun / 1.5;
            }
            sol = sun;
            return sol;
        }

        public double f(double x)
        {
            return x / 5;
        }

        public double g(double x)
        {
            return x / 5;
        }
        
    }
}
