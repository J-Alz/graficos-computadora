using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC
{
    internal class Textura: Vector, IDisposable
    {
        //private bool disposed = false;
        public Textura()
        {
           
        }
        //~Textura()
        //{
        //    Dispose(true);
        //}
        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}
        //protected virtual void Dispose(bool disposing)
        //{
        //    if(!disposed)
        //    {
        //        if(disposing)
        //        {
        //            Bmp.Dispose();
        //            Bmp = null;
        //        }
        //        disposed = true;
        //    }
        //}

        public Textura UniColor(Color color)
        {
            for (int i = 0; i < Bmp.Width; i++)
                for (int j = 0; j < Bmp.Height; j++)
                    Bmp.SetPixel(i, j, color);
            return this;
        }
        public Textura BiColor(Color color1, Color color2)
        {
            for (int i = 0; i < Bmp.Width; i++)
                for (int j = 0; j < Bmp.Height; j++)
                    if (i <= Bmp.Width / 2)
                        Bmp.SetPixel(i, j, color1);
                    else
                        Bmp.SetPixel(i, j, color2);
            return this;
        }

        private static int Interpolacion(int i)
            => (int)(-0.36 * i + 255);
        public Textura DegradadoBicolor1()
        {
            for (int i = 0; i < Bmp.Width; i++)
                for (int j = 0; j <  Bmp.Height; j++)
                    Bmp.SetPixel(i, j, Color.FromArgb(255, Interpolacion(i), 0));
            return this;
        }

        public Textura DegradadoBicolor2()
        {
            for (int i = 0; i < Bmp.Width; i++)
            {
                for (int j = 0; j < Bmp.Height; j++)
                {
                    int value = Interpolacion(i);
                    Bmp.SetPixel(i, j, Color.FromArgb(value, value, 255));
                }

            }
            return this;
        }

        public Textura Tapete1()
        {
            int colorT;
            Color color;
            for (int i = 0; i < Bmp.Width; i++)
            {
                for (int j = 0; j < Bmp.Height; j++)
                {

                    colorT = (i * i + j * j) % 15;
                    color = Paleta.paleta0[(int)colorT];
                    Bmp.SetPixel(i, j, color);
                }
            }
            return this;
        }

        public Textura Tapete2()
        {
            int colorT;
            Color color;
            Console.WriteLine(Bmp.Width);
            for (int i = 0; i < Bmp.Width; i++)
            {
                for (int j = 0; j < Bmp.Height; j++)
                {

                    colorT = ((int)Math.Pow(j, 2) + i) % 15;
                    color = Paleta.paleta0[(int)colorT];
                    Bmp.SetPixel(i, j, color);
                }
            }
            return this;
        }

        public Textura TapeteOtonno()
        {
            int colorT;
            Color color;
            for (int i = 0; i < Bmp.Width; i++)
            {
                for (int j = 0; j < Bmp.Height; j++)
                {

                    colorT = ((int)Math.Pow(j, 2) + i) % 12;
                    color = Paleta.paletaOtonno[(int)colorT];
                    Bmp.SetPixel(i, j, color);
                }
            }
            return this;
        }

        public Textura TapeteInvierno()
        {
            int colorT;
            Color color;
            for (int i = 0; i < Bmp.Width; i++)
            {
                for (int j = 0; j < Bmp.Height; j++)
                {

                    colorT = ((int)Math.Pow(j, 2) + i) % 12;
                    color = Paleta.paleta0[(int)colorT];
                    Bmp.SetPixel(i, j, color);
                }
            }
            return this;
        }

        public Textura TapetePrimavera()
        {
            int colorT;
            Color color;
            for (int i = 0; i < Bmp.Width; i++)
            {
                for (int j = 0; j < Bmp.Height; j++)
                {

                    colorT = ((int)Math.Pow(j, 2) + i) % 12;
                    color = Paleta.paletaPrimavera[(int)colorT];
                    Bmp.SetPixel(i, j, color);
                }
            }
            return this;
        }

        public Textura TapeteVerano()
        {
            int colorT;
            Color color;
            for (int i = 0; i < Bmp.Width; i++)
            {
                for (int j = 0; j < Bmp.Height; j++)
                {

                    colorT = ((int)Math.Pow(j, 2) + i) % 12;
                    color = Paleta.paletaVerano[(int)colorT];
                    Bmp.SetPixel(i, j, color);
                }
            }
            return this;
        }


        public Textura TapeteBlanco()
        {
            for (int i = 0; i < Bmp.Width; i++)
            {
                for (int j = 0; j < Bmp.Height; j++)
                {
                    Bmp.SetPixel(i, j, Color.White);
                }
            }
            return this;
        }

        public Textura Madera()
        {
            int colorT;
            Color color;
            int cont = 0;
            for (int i = 0; i < Bmp.Width; i++)
            {
                for (int j = 0; j < Bmp.Height; j++)
                {
                    cont = cont + 10;
                    colorT = (int)(((j + cont)) / Math.Log(cont) % 15);
                    color = Paleta.paletaMadera()[colorT];
                    Bmp.SetPixel(i, j, color);
                }
            }
            return this;
        }
        public Textura Cesped()
        {
            int colorT;
            Color color;
            for (int i = 0; i < Bmp.Width; i++)
            {
                for (int j = 0; j < Bmp.Height; j++)
                {

                    colorT = (int)(Math.E * (i / 2) + Math.PI * (Math.Pow(j, 2)) + j * i) % 4;
                    color = Paleta.paletaCesped[colorT];
                    Bmp.SetPixel(i, j, color);
                }
            }
            return this;
        }
        public Textura Piedra()
        {
            int colorT;
            Color color;
            for (int i = 0; i < Bmp.Width; i++)
            {
                for (int j = 0; j < Bmp.Height; j++)
                {
                    colorT = (int)((Math.Pow(i * (j + 70), 7) + Math.Pow(j * i * 2 / 2.5, 2)) % 5 + 1);
                    color = Paleta.paletaPiedra[colorT];
                    Bmp.SetPixel(i, j, color);
                }
            }
            return this;
        }
    }
}
