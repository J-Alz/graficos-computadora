using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC
{
    internal class Utils
    {
        static float dt = 0.001f;
        public static Bitmap AxisY(Bitmap bmp)
        {
            Vector vector = new Vector();
            for (double t = Geometria.y1; t <= Geometria.y2; t += dt)
            {
                vector.X0 = 0;
                vector.Y0 = t;
                vector.Encender(bmp, Color.Red);
            }
            return bmp;
        }
        public static Bitmap AxisX(Bitmap bmp)
        {
            Vector vector = new Vector();
            for (double t = Geometria.x1; t <= Geometria.x2; t += dt)
            {
                vector.X0 = t;
                vector.Y0 = 0;
                vector.Encender(bmp, Color.Red);
            }
            return bmp;
        }
    }
}
