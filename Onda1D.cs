using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC
{
    internal class Onda1D: Vector3D
    {
        //posicion inicial
        //velocidad inicial
        private double f(int k)
            => Math.Sin(k * Math.PI * 0.5);
        private double g(int k)
            => Math.Sin(k * Math.PI * 2);
        
        public void Fourier(double x, out double fou)
        {
            double an, bn, sumf, c;
            c = 1;
            int k = 0;
            sumf = 0;
            double t = 1.5;
            do
            {
                k++;
                an = (0.333) * ((4.0 * (x / 5.0) * f(k)) + ((x / 5.0) * g(k)));
                bn = (0.333) * ((4.0 * 1.0 * f(k)) * (1.0 * g(k)));
                bn = bn * (2.0 / (k * Math.PI * c));
                sumf = sumf + (an * Math.Cos((k * Math.PI * c * t) / 2.0) + (bn * Math.Sin(k * Math.PI * c * t) / 2.0)) * Math.Sin((k * Math.PI * x) / 2.0);

            } while (k <= 16);
            fou = sumf;
        }
        public Onda1D Graphic()
        {
            double x = -8;
            do
            {
                //X0 = x;
                Y0 = x;
                Fourier(x, out var sum);
                Z0 = sum;
                Encender(Color.Black);
                x += Dx;

            } while (x <= 5);
            return this;

        }
        /*
         * public void Fourier(double x, out double sol)
        {
            var k = 1;
            double sum = 0;
            do
            {
                var ak = (2.0 / L) * (L / 6.0) * (0 + 4 * F(L / 2.0) * Math.Sin(k * Math.PI / 2.0) + 0);
                var bk = (2.0 / (k * Math.PI * C)) * (L / 6.0) * (0 + 4 * G(L / 2.0) * Math.Sin((k * Math.PI) / 2.0) + 0);
                sum = (sum + (ak * Math.Cos((k * Math.PI * C * T) / L) + bk * Math.Sin((k * Math.PI * C * T) / L)) * Math.Sin((k * Math.PI * x) / L)) / 1.5;
                k++;
            } while (k <= 25);

            sol = sum;
        }
         */
    }
}
