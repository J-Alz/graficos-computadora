using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC
{
    internal class Layers
    {
        readonly int Width;
        readonly int Height;

        List<Layer> listLayers = new List<Layer>();
        int counter = -1;

        public Layers(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;
        }

        public void AddImage(Bitmap bmp,string name)
        {
            counter++;
            listLayers.Add(new Layer(bmp, counter,name));
            bmp = new Bitmap(Width, Height);
        }

        public Bitmap RefreshImage()
        {
            Bitmap img = new Bitmap(700, 540);
            foreach (Layer layer in listLayers)
            {
                img = layer.Bmp;
            }
            return img;
        }
        
        public string referencia()
        {
            return counter + ". " + listLayers.Last().Name;
        }
        public string[] ReferenciaAll()
        {
            string[] lista = new string[listLayers.Count];
            for(int i = 0; i < listLayers.Count; i++)
            {
                lista[i] = i + ". " + listLayers[i].Name;
            }
            return lista;
        }

        public void ResetImage()
        {
            listLayers.Clear();
            counter = -1;
        }
        public void removeImage(int index)
        {
            listLayers.RemoveAt(index);

        }
    }
}
