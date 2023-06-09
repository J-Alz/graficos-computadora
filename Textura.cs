using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC
{
    internal static class Textura
    {
        static int Width = 700;
        static int Height = 540;

        public static Bitmap UniColor(Color color)
        {
            Bitmap img = new Bitmap(Width, Height);
            for (int i = 0; i < Width; i++)
                for (int j = 0; j < Height; j++)
                    img.SetPixel(i, j, color);
            return img;
        }
        public static Bitmap BiColor(Color color1, Color color2)
        {
            Bitmap img = new Bitmap(Width, Height);
            for (int i = 0; i < Width; i++)
                for (int j = 0; j < Height; j++)
                    if (i <= Width / 2)
                        img.SetPixel(i, j, color1);
                    else
                        img.SetPixel(i, j, color2);
            return img;
        }

        private static int Interpolacion(int i)
            => (int)(-0.36 * i + 255);
        public static Bitmap DegradadoBicolor1()
        {
            Bitmap img = new Bitmap(Width, Height);
            for (int i = 0; i < Width; i++)
                for (int j = 0; j < Height; j++)
                    img.SetPixel(i, j, Color.FromArgb(255, Interpolacion(i), 0));
            return img;
        }

        public static Bitmap DegradadoBicolor2()
        {
            Bitmap img = new Bitmap(Width, Height);
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    int value = Interpolacion(i);
                    img.SetPixel(i, j, Color.FromArgb(value, value, 255));
                }

            }
            return img;
        }

        public static Bitmap Tapete1()
        {
            Bitmap bitmap = new Bitmap(Width, Height);
            int colorT;
            Color color;
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {

                    colorT = (i * i + j * j) % 15;
                    color = Paleta.paleta0[(int)colorT];
                    bitmap.SetPixel(i, j, color);
                }
            }
            return bitmap;
        }

        public static Bitmap Tapete2()
        {
            Bitmap bitmap = new Bitmap(Width, Height);
            int colorT;
            Color color;
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {

                    colorT = ((int)Math.Pow(j, 2) + i) % 15;
                    color = Paleta.paleta0[(int)colorT];
                    bitmap.SetPixel(i, j, color);
                }
            }
            return bitmap;
        }

        public static Bitmap TapeteOtonno()
        {
            Bitmap bitmap = new Bitmap(Width, Height);
            int colorT;
            Color color;
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {

                    colorT = ((int)Math.Pow(j, 2) + i) % 12;
                    color = Paleta.paletaOtonno[(int)colorT];
                    bitmap.SetPixel(i, j, color);
                }
            }
            return bitmap;
        }

        public static Bitmap TapeteInvierno()
        {
            Bitmap bitmap = new Bitmap(Width, Height);
            int colorT;
            Color color;
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {

                    colorT = ((int)Math.Pow(j, 2) + i) % 12;
                    color = Paleta.paleta0[(int)colorT];
                    bitmap.SetPixel(i, j, color);
                }
            }
            return bitmap;
        }

        public static Bitmap TapetePrimavera()
        {
            Bitmap bitmap = new Bitmap(Width, Height);
            int colorT;
            Color color;
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {

                    colorT = ((int)Math.Pow(j, 2) + i) % 12;
                    color = Paleta.paletaPrimavera[(int)colorT];
                    bitmap.SetPixel(i, j, color);
                }
            }
            return bitmap;
        }

        public static Bitmap TapeteVerano()
        {
            Bitmap bitmap = new Bitmap(Width, Height);
            int colorT;
            Color color;
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {

                    colorT = ((int)Math.Pow(j, 2) + i) % 12;
                    color = Paleta.paletaVerano[(int)colorT];
                    bitmap.SetPixel(i, j, color);
                }
            }
            return bitmap;
        }


        public static Bitmap TapeteBlanco()
        {
            Bitmap bmp = new Bitmap(700, 540);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    bmp.SetPixel(i, j, Color.White);
                }
            }
            return bmp;
        }

        public static Bitmap Madera()
        {
            Bitmap img = new Bitmap(Width, Height);
            int colorT;
            Color color;
            int cont = 0;
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    cont = cont + 10;
                    colorT = (int)(((j + cont)) / Math.Log(cont) % 15);
                    color = Paleta.paletaMadera()[colorT];
                    img.SetPixel(i, j, color);
                }
            }
            return img;
        }
        public static Bitmap Cesped()
        {
            Bitmap img = new Bitmap(Width, Height);
            int colorT;
            Color color;
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 540; j++)
                {

                    colorT = (int)(Math.E * (i / 2) + Math.PI * (Math.Pow(j, 2)) + j * i) % 4;
                    color = Paleta.paletaCesped[colorT];
                    img.SetPixel(i, j, color);
                }
            }
            return img;
        }
        public static Bitmap Piedra()
        {
            Bitmap img = new Bitmap(Width, Height);
            int colorT;
            Color color;
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 540; j++)
                {
                    colorT = (int)((Math.Pow(i * (j + 70), 7) + Math.Pow(j * i * 2 / 2.5, 2)) % 5 + 1);
                    color = Paleta.paletaPiedra[colorT];
                    img.SetPixel(i, j, color);
                }
            }
            return img;
        }
    }
}
