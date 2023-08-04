using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC
{
    internal class Onda3D: Vector3D
    {
        double t = 0.3;
        double w = 2.4;
        double v = 9.3;
        public Onda3D Onda()
        {
            for(double x = -6; x <= 6; x += 0.1)
            {
                for(double y = -5; y <= 5; y += 0.1)
                {
                    X0 = x;
                    Y0 = y;
                    Z0 = t * Math.Sin(w * Math.Sqrt(x * x + y * y) - v * t);
                    Encender(Color.Black);
                }
            }
            return this;
        }
        public Onda3D Onda2()
        {
            for (double x = -7; x <= 7; x += 0.1)
            {
                for (double y = -6; y <= 6; y += 0.1)
                {
                    double z;
                    X0 = x - 3;
                    Y0 = y;
                    Z0 = t * Math.Sin(w * Math.Sqrt(x * x + y * y) - v * t);
                    Encender(Color.Green);
                    X0 = x + 3;
                    Y0 = y;
                    Z0 = t * Math.Sin(w * Math.Sqrt(x * x + y * y) - v * t);
                    Encender(Color.Blue);
                }
            }
            return this;
        }
        //add para mover la onda
        public Onda3D Onda(double tx)
        {
            for (double x = -7; x <= 7; x += 0.1)
            {
                for (double y = -6; y <= 6; y += 0.1)
                {
                    X0 = x;
                    Y0 = y;
                    Z0 = 0.4 * Math.Sin(w * Math.Sqrt(x * x + y * y) - v * tx);
                    Encender(Color.Black);
                }
            }
            return this;
        }
        public Onda3D Interferencia2()
        {
            for (double x = -7; x <= 7; x += 0.1)
            {
                for (double y = -6; y <= 6; y += 0.1)
                {
                    double z1, z2;
                    X0 = x;
                    Y0 = y;
                    z1 = (Math.Sqrt((Math.Pow((x + 0), 2)) + (Math.Pow((y - 3), 2))));
                    z2 = (Math.Sqrt((Math.Pow((x + 0), 2)) + (Math.Pow((y + 3), 2))));
                    z1 = w * (z1 - v * t);
                    z2 = w * (z2 - v * t);
                    Z0 = 0.4 * Math.Sin(z1) + 0.4 * Math.Sin(z2);
                    Encender(Color.Black);
                }
            }
            return this;
        }
        public Onda3D Interferencia2(double tx)
        {
            for (double x = -7; x <= 7; x += 0.1)
            {
                for (double y = -6; y <= 6; y += 0.1)
                {
                    double z1, z2;
                    X0 = x;
                    Y0 = y;
                    z1 = (Math.Sqrt((Math.Pow((x + 0), 2)) + (Math.Pow((y - 3), 2))));
                    z2 = (Math.Sqrt((Math.Pow((x + 0), 2)) + (Math.Pow((y + 3), 2))));
                    z1 = w * (z1 - v * tx);
                    z2 = w * (z2 - v * tx);
                    Z0 = 0.4 * Math.Sin(z1) + 0.4 * Math.Sin(z2);
                    Encender(Color.Black);
                }
            }
            return this;
        }
    }

}
