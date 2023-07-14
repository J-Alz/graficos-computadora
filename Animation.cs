using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CC
{
    internal class Animation
    {
        readonly private System.Windows.Forms.Timer timer;
        readonly private PictureBox pictureBox;
        private Bitmap bitmap;
        double t;
        double tn;
        double dt = 0.1; //incremento
        public Animation (PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
            this.bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            this.timer = new System.Windows.Forms.Timer();
            this.timer.Interval = 5;
        }

        public void Start(EventHandler e, double t0)
        {
            this.timer.Start();
            this.timer.Tick += e;
            //this.tn = tn;
            this.t = t0;
        }
        public void Stop()
        {
            this.timer.Stop();
            //if (tx >= tn)
            //else
            //    this.t = dt;
            this.pictureBox.Image.Dispose();
            this.pictureBox.Image = null;
        }
        public void Diagonal(object sender, EventArgs e)
        {
            this.bitmap?.Dispose();
            this.bitmap = new Figura().Circulo(Color.Red, 1, t, t).Bmp;
            this.pictureBox.Image = this.bitmap;
            this.t += dt;
            if (t >= 7)
                Stop();
        }
        
        public void Lineal_X(object sender, EventArgs e)
        {
            this.bitmap?.Dispose();
            this.bitmap = new Figura().Circulo(Color.Red, 1, t, 0).Bmp;
            this.pictureBox.Image = this.bitmap;
            this.t += dt;
            if ( t >= 7)
                Stop();
        }

        public void Timer_Ejemplo3(object sender, EventArgs e)
        {
            //t0= -7
            this.bitmap?.Dispose();
            this.bitmap = new Figura().Circulo(Color.Red, 1, t, t/2).Bmp;
            this.pictureBox.Image = this.bitmap;
            this.t += dt;
            if (t >= 7)
                Stop();
        }
        public void Parabola(object sender, EventArgs e)
        {
            this.bitmap?.Dispose();
            double y = (Math.Pow(t,2) - 9) / 10;
            this.bitmap = new Figura().Circulo(Color.Red, 1, t, y).Bmp;
            this.pictureBox.Image = this.bitmap;
            this.t += dt;
            if (t >= 7)
                Stop();
        }
        public void Espiral(object sender, EventArgs e)
        {
            this.bitmap?.Dispose();
            this.bitmap = new Figura().Circulo(Color.Red, 1, t, Math.Sin(t)).Bmp;
            this.pictureBox.Image = this.bitmap;
            this.t += dt;
            if (t >= 7)
                Stop();
        }

        //Fase 3. Animación
        public void Timer_Examen2(object sender, EventArgs e)
        {
            //this.pictureBox.Image = new Figura().ParabolaDoble().Bmp;
            //this.bitmap?.Dispose();
            double y = (45 - Math.Pow(t, 2)) / 15;
            this.bitmap = new Figura().Circulo(Color.Red, 1, t, y).Bmp;
            this.bitmap = new Figura().ParabolaDoble().Bmp;
            this.pictureBox.Image = this.bitmap;
            /*
             * using (Graphics g = Graphics.FromImage(this.bitmap)){
                g.Clear(Color.White);
                g.DrawImageUnscaled(new Figura().ParabolaDoble().Bmp, 0, 0);
                double x0 = x;
                double y0 = (45 - Math.Pow(x, 2)) / 15;
                g.DrawImageUnscaled(new Figura().Circulo(Color.Red, 0.5, x0, y0).Bmp,0,0);
            }
             */
            this.t += dt;
            if (t >= 10)
                Stop();
        }
        public void Timer_Salto(object sender, EventArgs e)
        {
            int cont = 0;
            if ( cont == 0)
            {
                double y = -(t + 1) * (t - 2);
                if(y > 0)
                    this.bitmap = new Figura().Circulo(Color.Red, 0.2, t, y).Bmp;
                cont++;
            }
            if ( cont == 1)
            {
                double y = -(t - 2) * (t - 4);
                if (y > 0)
                    this.bitmap = new Figura().Circulo(Color.Red, 0.2, t, y).Bmp;
                cont++;
            }
            if ( cont == 3)
            {
                double y = -(t + 5) * (t + 1);
                if (y > 0)
                    this.bitmap = new Figura().Circulo(Color.Red, 0.2, t, y).Bmp;
            }
            this.t += 0.2;
            this.pictureBox.Image = this.bitmap;
            if (t >= 16)
                this.timer.Stop();

        }
        double t0 = 0;
        public void Timer_Onda(object sender, EventArgs e)
        {
            //this.bitmap = new Onda3D().Onda2(t0).Bmp;
            this.bitmap?.Dispose();
            this.bitmap = new Onda().GrafOnda(t).Bmp;
            //this.bitmap = new Onda3D().Interferencia2(t0).Bmp;
            this.pictureBox.Image = this.bitmap;
            t += dt;
            if(t > 2)
                Stop();
        }
    }
}
