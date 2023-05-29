using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC
{
    internal class Pixel
    {
        static int Width = 700;
        static int Heigth = 540;
        public Pixel(){}

        public static Bitmap Encender(Bitmap bmp, int x, int y, Color color)
        {
            bmp.SetPixel(x, y, color);
            return bmp;
        }
        public static Bitmap PixelRandom(Bitmap bmp, Color color)
        {
            Random random = new Random();
            int x = random.Next(0, Width);
            int y = random.Next(0, Heigth);

            bmp.SetPixel(x, y, color);
            return bmp;
        }

        public static Bitmap ScanUniColor(Bitmap bmp, Color color)
        {
            for (int i = 0; i < Width; i++)
                for(int j = 0; j < Heigth; j++)
                    bmp.SetPixel(i, j, color);
            return bmp;

        }
        public static Bitmap ScanBiColor(Bitmap bmp)
        {
            for (int i = 0; i < Width; i++)
                for (int j = 0; j < Heigth; j++)
                    if(i <=350)
                        bmp.SetPixel(i, j, Color.Yellow);
                    else
                        bmp.SetPixel(i, j, Color.Red);
            return bmp;

        }
        private static int interpolacionRGB(int i)
            => (int)(-0.36 * i + 255);
        public static Bitmap ScanRGB(Bitmap bmp)
        {
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Heigth; j++)
                {
                    int value = interpolacionRGB(i);
                    bmp.SetPixel(i, j, Color.FromArgb(255,value,0));
                }

            }
            return bmp;

        }
        
        public static Bitmap ScanRGB2(Bitmap bmp)
        {
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Heigth; j++)
                {
                    int value = interpolacionRGB(i);
                    bmp.SetPixel(i, j, Color.FromArgb(value, value, 255));
                }

            }
            return bmp;

        }

        public static Color paleta(int i)
        {
            List<Color> paleta0 = new List<Color>();
            paleta0.Add(Color.Black);
            paleta0.Add(Color.Navy);
            paleta0.Add(Color.Green);
            paleta0.Add(Color.Aqua);
            paleta0.Add(Color.Red);
            paleta0.Add(Color.Purple);
            paleta0.Add(Color.Maroon);
            paleta0.Add(Color.LightGray);
            paleta0.Add(Color.DarkGray);
            paleta0.Add(Color.Blue);
            paleta0.Add(Color.Lime);
            paleta0.Add(Color.Silver);
            paleta0.Add(Color.Teal);
            paleta0.Add(Color.Fuchsia);
            paleta0.Add(Color.Yellow);
            paleta0.Add(Color.White);

            return paleta0[i];
        }
        public static Bitmap colores(Bitmap bmpC)
        {

            int colorT;
            Color color;
            for(int i = 0; i < Width; i++)
            {
                for(int j = 0; j < Heigth; j++)
                {
                    
                    colorT = (i * i + j * j) % 15;
                    color = Paleta.paleta0[(int)colorT];
                    bmpC.SetPixel(i, j, color);
                }
            }
            return bmpC;
        }
        public static Bitmap colores2(Bitmap bmpC)
        {

            int colorT;
            Color color;
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Heigth; j++)
                {

                    colorT = ((int)Math.Pow(j,2) + i) % 15;
                    color = Paleta.paleta0[(int)colorT];
                    bmpC.SetPixel(i, j, color);
                }
            }
            return bmpC;
        }

        public static Bitmap coloresOtonno(Bitmap bmpC)
        {
            int colorT;
            Color color;
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Heigth; j++)
                {

                    colorT = ((int)Math.Pow(j, 2) + i) % 12;
                    color = Paleta.paletaOtonno[(int)colorT];
                    bmpC.SetPixel(i, j, color);
                }
            }
            return bmpC;
        }
        public static Bitmap coloresInvierno(Bitmap bmpC)
        {
            int colorT;
            Color color;
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Heigth; j++)
                {

                    colorT = ((int)Math.Pow(j, 2) + i) % 12;
                    color = Paleta.paletaInvierno[(int)colorT];
                    bmpC.SetPixel(i, j, color);
                }
            }
            return bmpC;
        }
        public static Bitmap coloresPrimavera(Bitmap bmpC)
        {
            int colorT;
            Color color;
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Heigth; j++)
                {

                    colorT = ((int)Math.Pow(j, 2) + i) % 12;
                    color = Paleta.paletaPrimavera[(int)colorT];
                    bmpC.SetPixel(i, j, color);
                }
            }
            return bmpC;
        }
        public static Bitmap coloresVerano(Bitmap bmpC)
        {
            int colorT;
            Color color;
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Heigth; j++)
                {

                    colorT = ((int)Math.Pow(j, 2) + i) % 12;
                    color = Paleta.paletaVerano[(int)colorT];
                    bmpC.SetPixel(i, j, color);
                }
            }
            return bmpC;
        }
    }
}
