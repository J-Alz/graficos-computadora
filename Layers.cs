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
        int Width;
        int Height;

        public List<Layer> listLayers = new List<Layer>();
        int counter = -1;

        public Layers(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;
        }
        public List<Layer> ListLayers { get { return listLayers; } }

        public void AddImage(Bitmap bmp,string name)
        {
            counter++;
            listLayers.Add(new Layer(bmp, counter,name));
            //bmp = new Bitmap(Width, Height);
        }

        public Bitmap RefreshImage(Bitmap img)
        {
            //Bitmap img = new Bitmap(700, 540);
            foreach (Layer layer in listLayers)
            {
                System.Console.WriteLine(layer.Name);
                //if(layer.Index != 0)
                    img = layer.Bmp;
            }
            return img;
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
