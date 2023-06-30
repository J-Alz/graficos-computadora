using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC
{
    internal class Figura3D : Vector3D
    {
        public Figura3D Circulo()
        {
            for(double t = 0; t <= 9.8; t += Dx)
            {
                X0 = 0;
                Y0 = 1 + 3 * Math.Sin(t);
                Z0 = -2 + 3 * Math.Cos(t);
                Encender(Color.Black);
            }
            return this;
        }
        public Figura3D Espiral()
        {
            for (double t = 0; t <= 9.8; t += Dx)
            {
                X0 = -3 + (t / 2);
                Y0 = 1 + 3 * Math.Sin(t);
                Z0 = 1 + 3 * Math.Cos(t);
                Encender(Color.Black);
            }
            return this;
        }
    }
}
