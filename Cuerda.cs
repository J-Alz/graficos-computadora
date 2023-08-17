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
        double C = 0.6;
        double L = 9;
        double T = 0;
        public Cuerda(double T)
        {
            this.T = T;
            for (double x = -5; x <= 5; x += Dx)
            {
                X0 = x;
                Fourier(x, out var sum);
                Y0 = sum;
                Encender(Color.Black);
            }
        }
        public void Fourier(double x, out double sol)
        {
            double sum = 0;
            for(int k = 1; k <= 25; k++)
            {
                var ak = (2.0 / L) * (L / 6.0) * (0 + 4 * F(L / 2.0) * Math.Sin(k * Math.PI / 2.0) + 0);
                var bk = (2.0 / (k * Math.PI * C)) * (L / 6.0) * (0 + 4 * G(L / 2.0) * Math.Sin((k * Math.PI) / 2.0) + 0);
                sum = (sum + (ak * Math.Cos((k * Math.PI * C * T) / L) + bk * Math.Sin((k * Math.PI * C * T) / L)) * Math.Sin((k * Math.PI * x) / L)) / 1.5;
            }

            sol = sum;
        }

        public double F(double x)
            => x / 5;
        public double G(double x)
            => x / 5;

    }
}
