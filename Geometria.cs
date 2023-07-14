using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC
{
    public static class Geometria
    {
        //Ventana pantalla
        static int sx1 = 0;
        static int sy1 = 0;
        static int sx2 = 700;
        static int sy2 = 540;

        //CORRDENADOS DE MODELO, PUNTO DE VISTA NO TRANSFORMADO
        //Ventana real
        public static double x1 = -16;//-8 //-16   //8 -> 6.15
        public static double x2 = 16;//8          //16 -> 12.3
                                                //2 -> 1.54
                                                // -1 , 3 -> -1.54, 1.54
        public static double y1 = -12.3;//-7//-6.15
        public static double y2 = 12.3;//12.3

        public static void Transforma(double sx, double sy, out double x, out double y)
        {
            x = Math.Round(((sx - sx1) / (sx1 - sx2)) * (x1 - x2) + x1, 2);
            y = Math.Round(((sy - sy1) / (sy1 - sy2)) * (y2 - y1) + y2, 2);
        }
        public static void Pantalla(double x, double y, out int sx, out int sy)
        {
            sx = (int)(((x - x1) / (x1 - x2)) * (sx1 - sx2)) + sx1;
            sy = (int)(((y - y2) / (y2 - y1)) * (sy1 - sy2)) + sy1;
        }
        public static void FourierC(double x, out double fou)
        {
            double an, bn, sumF;
            double l = 2;//[1,3]
            sumF = 0;
            for(int k = 0; k <= 18; k++)
            {
                ///an = (0.333) * (k * f(1) * Math.Sin(k * Math.PI * 0.5) * f(2) * Math.Sin(k * Math.PI * 1));
                //an = an * 2 / l;
                ///bn = (0.333) * (4 * g(1) * Math.Sin(k * Math.PI * 1))
            }
            fou = sumF;
        }
    }
}
