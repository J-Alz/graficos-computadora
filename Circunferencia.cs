using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC
{
    internal class Circunferencia:Vector
    {
        float Rd;
        static float pi = 3.1416f;
        public Circunferencia(float Rd)
        {
            this.Rd = Rd;
        }
        public new Bitmap Encender(Bitmap bmp, Color color)
        {
            float t = -pi;
            float dt = 0.001f;
            Vector vector = new Vector(5, -1);
            do
            {
                vector.X0 = X0 + Rd * (float)Math.Cos(t);
                vector.Y0 = Y0 + Rd * (float)Math.Sin(t);
                bmp = vector.Encender(bmp, color);
                t += dt;
            } while (t <= pi);

            return bmp;
        }
    }
}
