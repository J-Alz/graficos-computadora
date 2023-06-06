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
    }
}
