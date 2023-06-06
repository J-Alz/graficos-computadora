using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace CC
{
    internal class Paleta
    {
        public static Color[] paleta0 = 
        { 
            Color.Black,
            Color.Navy,
            Color.Green,
            Color.Aqua,
            Color.Red,
            Color.Purple,
            Color.Maroon,
            Color.LightGray,
            Color.DarkGray,
            Color.Blue,
            Color.Lime,
            Color.Silver,
            Color.Teal,
            Color.Fuchsia,
            Color.Yellow,
            Color.White
        };
        public static Color[] paletaOtonno =
        {
            Color.FromArgb(201,25,1),
            Color.FromArgb(147,39,53),
            Color.FromArgb(250,217,10),
            Color.FromArgb(229,114,60),
            Color.FromArgb(100,109,0),
            Color.FromArgb(0,66,51),
            Color.FromArgb(189,60,56),
            Color.FromArgb(100,106,78),
            Color.FromArgb(219,160,113),
            Color.FromArgb(128,179,92),
            Color.FromArgb(23,73,116),
            Color.FromArgb(95,46,23)
        };
        public static Color[] paletaInvierno =
        {
            Color.FromArgb(92,47,121),
            Color.FromArgb(255,242,101),
            Color.FromArgb(226,246,255),
            Color.FromArgb(255,233,243),
            Color.FromArgb(106,105,122),
            Color.FromArgb(197,31,86),
            Color.FromArgb(1,139,207),
            Color.FromArgb(246,45,149),
            Color.FromArgb(0,71,80),
            Color.FromArgb(25,39,130),
            Color.FromArgb(151,41,84),
            Color.FromArgb(0,0,0)
        };
        public static Color[] paletaPrimavera =
        {
            Color.FromArgb(148,202,255),
            Color.FromArgb(255,175,146),
            Color.FromArgb(255,135,135),
            Color.FromArgb(255,181,69),
            Color.FromArgb(201,242,182),
            Color.FromArgb(255,242,165),
            Color.FromArgb(255,85,79),
            Color.FromArgb(227,228,222),
            Color.FromArgb(98,203,100),
            Color.FromArgb(66,173,184),
            Color.FromArgb(47,65,150),
            Color.FromArgb(255,202,209)
        };
        public static Color[] paletaVerano =
        {
            Color.FromArgb(187,243,250),
            Color.FromArgb(252,223,245),
            Color.FromArgb(123,65,115),
            Color.FromArgb(145,197,236),
            Color.FromArgb(185,165,211),
            Color.FromArgb(205,219,231),
            Color.FromArgb(156,204,200),
            Color.FromArgb(228,102,147),
            Color.FromArgb(138,227,179),
            Color.FromArgb(72,119,190),
            Color.FromArgb(152,41,84),
            Color.FromArgb(255,253,202),
        };
        public static Color[] paletaMadera()
        {
            Color[] colores = new Color[15];
            for (int i = 0; i < 15; i++)
            {
                colores[i] = Color.FromArgb((int)(2.467 * i + 133), (2 * i + 100), 0);
            }
            return colores;
        }
        public static Color[] paletaCesped =
        {
            Color.FromArgb(0,255,0),
            Color.FromArgb(189,255,153),
            Color.FromArgb(0,140,0),
            Color.FromArgb(0,168,0)
        };
        public static Color[] paletaPiedra =
        {
            Color.FromArgb(224,244,244),
            Color.FromArgb(136,134,134),
            Color.FromArgb(255,255,255),
            Color.FromArgb(136,136,136),
            Color.White,
            Color.White
        };
    }
}
