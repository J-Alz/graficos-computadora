using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC
{
    internal class Figura3D
    {
        public static Bitmap ejemplo()
        {
            Bitmap img = new Bitmap(700, 540);
            Vector3D v3d = new Vector3D();
            for(double t = 0; t <= 9.8; t += 0.005)
            {
                v3d.X0 = 0;
                v3d.Y0 = 1 + 3 * Math.Sin(t);
                v3d.Z0 = -2 + 3 * Math.Cos(t);
                v3d.Encender(img, Color.Black);
            }
            return img;
        }
        public static Bitmap ejemplo2()
        {
            Bitmap img = new Bitmap(700, 540);
            Vector3D v3d = new Vector3D();
            for (double t = 0; t <= 9.8; t += 0.005)
            {
                v3d.X0 = -3 + (t / 2);
                v3d.Y0 = 1 + 3 * Math.Sin(t);
                v3d.Z0 = 1 + 3 * Math.Cos(t);
                v3d.Encender(img, Color.Black);
            }
            return img;
        }
    }
}
