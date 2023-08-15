using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC
{
    internal class Fuerzas: Vector
    {
        Color color = Color.Red;
        public Fuerzas()
        {
            Graphics g = Graphics.FromImage(Bmp);
            g.DrawImageUnscaled(new Segmento(-7.8, 0, -7, 0.6).Bmp,0,0);
            g.DrawImageUnscaled(new Segmento(-7.8, 0, -7, -0.6).Bmp, 0, 0);
            g.DrawImageUnscaled(new Segmento(-7, 0.6, -7, -0.6).Bmp, 0, 0);

            g.DrawImageUnscaled(new Segmento(7.8, 0, 7, 0.6).Bmp, 0, 0);
            g.DrawImageUnscaled(new Segmento(7.8, 0, 7, -0.6).Bmp, 0, 0);
            g.DrawImageUnscaled(new Segmento(7, 0.6, 7, -0.6).Bmp, 0, 0);
        }
        double m = 0.7; //masa
        double g = -3.8; // gravedad
        double k = 1.0; //elasticidad
        double l = 14; //longitud
        public Fuerzas e(int n)
        {          
            Graphics gr = Graphics.FromImage(Bmp);
            double frac = l / (n + 1);
            double dif = -7;
            double mitad = n / 2;
            double y = m * g / 2 * k;
            double difY = y;
            for(int bolita = 1; bolita <= n; bolita++)
            {
                dif += frac;
                gr.DrawImageUnscaled(new Figura().Circulo(color, 0.3, dif, difY).Bmp,0,0);
                difY += y / bolita;
            }

            return this;
        }
    }
}
