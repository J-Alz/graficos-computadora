using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC
{
    internal class Anima
    {
        readonly private System.Windows.Forms.Timer timer;
        readonly private PictureBox pictureBox;
        private Bitmap bmp;
        public Bitmap Bmp
        {
            get { return bmp; }
            set { bmp = value; }
        }
        public Anima(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
            this.bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            this.timer = new System.Windows.Forms.Timer();
            this.timer.Interval = 5;
        }
        public void Start(EventHandler function)
        {
            //this.timer.Stop();
            this.timer.Tick += function;
            this.timer.Start();
            //t0 = 0; Se reinicia solo
        }
        public void Stop()
        {
            this.timer.Stop();
            this.pictureBox.Image.Dispose();
            this.pictureBox.Image = null;
        }
        double t0 = 0;
        public void Timer(object sender, EventArgs e)
        {
            Console.WriteLine("Valor de t0: " + t0);
            this.bmp?.Dispose();
            this.bmp = new Onda3D().Interferencia2(t0).Bmp;
            this.pictureBox.Image = this.bmp;
            t0 += 0.01;
            if (t0 > 2)
                this.timer.Stop();
        }
        public void Timer2(object sender, EventArgs e)
        {
            Console.WriteLine("Valor de t0: " + t0);
            this.bmp?.Dispose();
            this.bmp = new Onda3D().Onda2(t0).Bmp;
            this.pictureBox.Image = this.bmp;
            t0 += 0.01;
            if (t0 > 2)
                this.timer.Stop();
        }
    }
}
