using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC
{
    internal class Texture
    {
        static int Width = 700;
        static int Height = 540;
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
