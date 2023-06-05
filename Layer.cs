using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC
{
    internal class Layer
    {
        Bitmap bmp;
        int index = 0;
        string name;
        public Layer() { }
        public Layer(Bitmap bmp, int index, string name)
        {
            this.index = index;
            this.bmp = bmp;
            this.name = name;
        }
        
        public Bitmap Bmp
        {
            get => bmp;
            set => bmp = value;
        }
        public int Index
        {
            get => index;
            set => index = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
    }
}
