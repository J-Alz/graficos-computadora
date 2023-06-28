using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace CC
{
    internal class Segmento : Vector
    {
        double xf;
        double yf;
        static float dt = 0.0001f;
        public Segmento() { }
        public double Xf
        {
            get { return xf; }
            set { xf = value; }
        }
        public double Yf
        {
            get => yf;
            set { yf = value; }
        }
        public Segmento(double xf, double yf)
        {
            this.xf = xf;
            this.yf = yf;
        }
        public new Bitmap Encender(Bitmap bmp, Color color)
        {
            float t = 0f;
            float dt = 0.0001f;
            Vector vector = new Vector(-6, -4);
            do
            {
                vector.X0 = X0 + (xf - X0) * t;
                vector.Y0 = Y0 + (yf - Y0) * t;
                bmp = vector.Encender(bmp, color);
                t += dt;
            } while (t <= 1);
            return bmp;
        }
        
        
    }
}
