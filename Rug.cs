using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC
{
    internal class Rug
    {
        public static Bitmap Rug1(Bitmap bmp)
        {

            int colorT;
            Color color;
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {

                    colorT = (i * i + j * j) % 15;
                    color = Paleta.paleta0[(int)colorT];
                    bmp.SetPixel(i, j, color);
                }
            }
            return bmp;
        }
        public static Bitmap Rug2(Bitmap bmp)
        {

            int colorT;
            Color color;
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {

                    colorT = ((int)Math.Pow(j, 2) + i) % 15;
                    color = Paleta.paleta0[(int)colorT];
                    bmp.SetPixel(i, j, color);
                }
            }
            return bmp;
        }

        public static Bitmap RugOtonno(Bitmap bmp)
        {
            int colorT;
            Color color;
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {

                    colorT = ((int)Math.Pow(j, 2) + i) % 12;
                    color = Paleta.paletaOtonno[(int)colorT];
                    bmp.SetPixel(i, j, color);
                }
            }
            return bmp;
        }
        public static Bitmap RugInvierno(Bitmap bmp)
        {
            int colorT;
            Color color;
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {

                    colorT = ((int)Math.Pow(j, 2) + i) % 12;
                    color = Paleta.paleta0[(int)colorT];
                    bmp.SetPixel(i, j, color);
                }
            }
            return bmp;
        }
        public static Bitmap RugPrimavera(Bitmap bmp)
        {
            int colorT;
            Color color;
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {

                    colorT = ((int)Math.Pow(j, 2) + i) % 12;
                    color = Paleta.paletaPrimavera[(int)colorT];
                    bmp.SetPixel(i, j, color);
                }
            }
            return bmp;
        }
        public static Bitmap RugVerano(Bitmap bmp)
        {
            int colorT;
            Color color;
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {

                    colorT = ((int)Math.Pow(j, 2) + i) % 12;
                    color = Paleta.paletaVerano[(int)colorT];
                    bmp.SetPixel(i, j, color);
                }
            }
            return bmp;
        }
        public static Bitmap RugMadera(Bitmap bmp)
        {
            int colorT;
            Color color;
            int cont = 0;
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    cont = cont + 10;
                    colorT = (int)(((j + cont)) / Math.Log(cont) % 15);
                    color = Paleta.paletaMadera()[colorT];
                    bmp.SetPixel(i, j, color);
                }
            }
            return bmp;
        }
    }
}
