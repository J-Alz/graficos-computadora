using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC
{
    internal class Geometria
    {
        //Ventana pantalla
        int sx1 = 0;
        int sy1 = 0;
        int sx2 = 700;//
        int sy2 = 540;

        //CORRDENADOS DE MODELO, PUNTO DE VISTA NO TRANSFORMADO
        //Ventana real
        double x1 = -8;//-8 //-16
        double x2 = 8;//8
        double y1 = -12.3f;//-7//-6.15
        double y2 = 12.3f;

        public Geometria() { }
        public Geometria(double x1, double y1, double x2, double y2, int sx1, int sy1, int sx2, int sy2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.sx1 = sx1;
            this.sy1 = sy1;
            this.sx2 = sx2;
            this.sy2 = sy2;
        }
        public double X1{ get => x1; }
        public double X2{ get => x2; }
        public double Y1{ get => y1; }
        public double Y2{ get => y2; }
        //func. carta
        public void Transforma(int sx, int sy, out double x, out double y)
        {
            x = (((sx - sx1) / (sx1 - sx2)) * (x1 - x2)) + x1;
            y = (((sy - sy1) / (sy1 - sy2)) * (y1 - y2)) + y1;
        }
        public void Pantalla(double x, double y, out int sx, out int sy)
        {
            sx = (int)(((x - x1) / (x1 - x2)) * (sx1 - sx2)) + sx1;
            sy = (int)(((y - y2) / (y2 - y1)) * (sy1 - sy2)) + sy1;
        }
    }
}
