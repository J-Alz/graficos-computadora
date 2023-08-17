using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CC
{
    internal class Vector//: IDisposable
    {
        private bool disposed = false;
        double x0 = 0;
        double y0 = 0;
        Bitmap bmp = new Bitmap(700, 540);
        public Color color;
        double dx = 0.0001;
        public double X0
        {
            get => x0;
            set => x0 = value;
        }
        public double Y0
        {
            get => y0;
            set => y0 = value;
        }
        public Bitmap Bmp
        {
            get => bmp;
            set => bmp = value;
        }
        //public Color Color
        //{
        //    get => color;
        //    set => color = value;
        //}
        //Graphics g = Graphics.FromImage(bmp);
             
        public double Dx
        {
            get => dx;
            set => dx = value;
        }
        public Vector(double x0, double y0, Color color)
        {
            this.x0 = x0;
            this.y0 = y0;
            this.color = color;
        }
        public Vector(Color color) 
        {
            this.color = color;
        }
        public Vector()
        {

        }
        ~Vector(){Dispose(true);}

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if(disposing)
                {
                    bmp.Dispose();
                }
                disposed = true;
            }
        }

        //static double cont1 = 0;
        int dubX, dubY;
        
        public Bitmap Encender(Color color)
        {
            int sx;
            int sy;
            Geometria.Pantalla(x0, y0, out sx, out sy);
            if (sx >= 0 && sx < 700 && sy >= 0 && sy < 540)
            {
                if(!(dubX == sx && dubY == sy)){
                    bmp.SetPixel(sx, sy, color);
                    //cont1++;
                    dubX = sx;
                    dubY = sy;
                    //Console.WriteLine("Contador: " + cont);
                }
                //bmp.SetPixel(sx, sy, color); //FORMA INEFICIENTE
            }
            return bmp;
        }

    }
}
