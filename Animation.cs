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

        public Animation (PictureBox pictureBox, string tipoAnimacion)
        {
            this.pictureBox = pictureBox;
            this.bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            this.timer = new System.Windows.Forms.Timer();
            this.timer.Interval = 5;
            switch (tipoAnimacion)
            {
                case "Ejemplo1":
                    this.timer.Tick += Timer_Ejemplo1;
                    break;
                case "Ejemplo2":
                    this.timer.Tick += Timer_Ejemplo2;
                    break;
                case "Ejemplo3":
                    this.timer.Tick += Timer_Ejemplo3;
                    break;
                case "Ejemplo4":
                    this.timer.Tick += Timer_Ejemplo4;
                    break;
                case "Ejemplo5":
                    this.timer.Tick += Timer_Ejemplo5;
                    break;
                case "Examen2":
                    this.timer.Tick += Timer_Examen2;
                    break;
                case "salto":
                    this.timer.Tick += Timer_Salto;
                    break;
                case "salto2":
                    this.timer.Tick += Timer_Salto2;
                    break;
                case "salto3":
                    this.timer.Tick += Timer_Salto3;
                    break;
                case "onda":
                    this.timer.Tick += Timer_Onda;
                    break;
                default: 
                    break;
            }
        }

        public void Start()
        {
            this.timer.Start();
        }
        public void Stop()
        {
            this.timer.Stop();
            this.pictureBox.Image.Dispose();
            this.pictureBox.Image = null;
        }
        double inc = 0;
        double dx = 0.2;
        private void Timer_Ejemplo1(object sender, EventArgs e)
        {
            this.bitmap = new Figura().Circulo(Color.Red, 2, inc, inc).Bmp;
            this.inc += dx;
            this.pictureBox.Image = this.bitmap;
            if (inc >= 6)
                this.timer.Stop();

        }
        double t = -7;
        private void Timer_Ejemplo2(object sender, EventArgs e)
        {
            this.t += dx;
            this.pictureBox.Image = new Figura().Circulo(Color.Red, 1, t, 0).Bmp;
            if ( t >= 7)
                this.timer.Stop();
        }
        
        private void Timer_Ejemplo3(object sender, EventArgs e)
        {
            double x = t;
            double y = t /2;
            this.bitmap = new Figura().Circulo(Color.Red, 1, x, y).Bmp;
            this.t += 0.2;
            this.pictureBox.Image = this.bitmap;
            if (t >= 7)
                this.timer.Stop();
        }
        private void Timer_Ejemplo4(object sender, EventArgs e)
        {
            double x = t;
            double y = (Math.Pow(t,2) - 9) / 10;
            this.bitmap = new Figura().Circulo(Color.Red, 1, x, y).Bmp;
            this.t += 0.2;
            this.pictureBox.Image = this.bitmap;
            if (t >= 7)
                this.timer.Stop();
        }
        private void Timer_Ejemplo5(object sender, EventArgs e)
        {
            double x = t;
            double y = Math.Sin(t);
            this.bitmap = new Figura().Circulo(Color.Red, 1, x, y).Bmp;
            this.t += 0.2;
            this.pictureBox.Image = this.bitmap;
            if (t >= 7)
                this.timer.Stop();
        }

        //Fase 3. Animación
        double x = -16;
        private void Timer_Examen2(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(this.bitmap)){
                g.Clear(Color.White);
                g.DrawImageUnscaled(new Figura().ParabolaDoble().Bmp, 0, 0);
                double x0 = x;
                double y0 = (45 - Math.Pow(x, 2)) / 15;
                g.DrawImageUnscaled(new Figura().Circulo(Color.Red, 0.5, x0, y0).Bmp,0,0);
            }
            this.pictureBox.Image = this.bitmap;

            this.x += 0.2;
            if (x >= 16)
                this.timer.Stop();
        }
        private void Timer_Salto(object sender, EventArgs e)
        {
            int cont = 0;
            double x = t;
            if ( cont == 0)
            {
                double y = -(t + 1) * (t - 2);
                if(y > 0)
                    this.bitmap = new Figura().Circulo(Color.Red, 0.2, x, y).Bmp;
                cont++;
            }
            if ( cont == 1)
            {
                double y = -(t - 2) * (t - 4);
                if (y > 0)
                    this.bitmap = new Figura().Circulo(Color.Red, 0.2, x, y).Bmp;
                cont++;
            }
            if ( cont == 3)
            {
                double y = -(t + 5) * (t + 1);
                if (y > 0)
                    this.bitmap = new Figura().Circulo(Color.Red, 0.2, x, y).Bmp;
            }
            this.t += 0.2;
            this.pictureBox.Image = this.bitmap;
            if (t >= 16)
                this.timer.Stop();

        }
        private void Timer_Salto2(object sender, EventArgs e)
        {
            double x = t;
            double y = -(t -2) * (t - 4);
            if (y > 0)
                this.bitmap = new Figura().Circulo(Color.Red, 0.2, x, y).Bmp;
            this.t += 0.2;
            this.pictureBox.Image = this.bitmap;
            

        }
        private void Timer_Salto3(object sender, EventArgs e)
        {
            double x = t;
            double y = -(t +5) * (t +1);
            if (y > 0)
                this.bitmap = new Figura().Circulo(Color.Red, 0.2, x, y).Bmp;
            this.t += 0.2;
            this.pictureBox.Image = this.bitmap;
            if (t >= 16)
                this.timer.Stop();

        }
        double t0 = 0;
        public void Timer_Onda(object sender, EventArgs e)
        {

            //this.bitmap = new Onda().GrafOnda(t0).Bmp;
            //this.pictureBox.Image = this.bitmap;
            //this.bitmap = new Onda3D().Onda2(t0).Bmp;
            this.bitmap?.Dispose();
            this.bitmap = new Onda3D().Interferencia2(t0).Bmp;
            this.pictureBox.Image = this.bitmap;
            t0 += 0.01;
            if(t0 > 7)
                this.timer.Stop();
        }
    }
}
