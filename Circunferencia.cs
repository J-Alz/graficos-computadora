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

        static float pi = 3.1416f;
        static float dt = 0.0001f;

        public Circunferencia() { }
        public Bitmap Encender(Bitmap bmp, Color color, float Rd, float x, float y)
        {
            Vector vector = new Vector();
            for (float t = -pi; t <= pi; t += dt)
            {
                vector.X0 = x + Rd * (float)Math.Cos(t);
                vector.Y0 = y + Rd * (float)Math.Sin(t);
                bmp = vector.Encender(bmp, color);
            }
            return bmp;
        }
        public Bitmap Encender(Bitmap bmp, Color color, float Rd)
        {
            Vector vector = new Vector();
            for(float t = -pi; t <= pi; t += dt)
            {
                vector.X0 = X0 + Rd * (float)Math.Cos(t);
                vector.Y0 = Y0 + Rd * (float)Math.Sin(t);
                bmp = vector.Encender(bmp, color);
            }
            return bmp;
        }
    }
}
