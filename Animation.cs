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

        //private int circleX = 0;
        //private void Timer_TickEjemplo(object sender, EventArgs e)
        //{
        //    using (Graphics graphics = Graphics.FromImage(this.bitmap))
        //    {
        //        // Borra el Bitmap.
        //        graphics.Clear(Color.White);
        //        // Dibuja un círculo en la posición x actual.
        //        graphics.FillEllipse(Brushes.Red, this.circleX, 50, 50, 50);
        //    }
        //    // Mueve la posición x del círculo.
        //    this.circleX += 10;
        //    // Si el círculo llega al final del PictureBox, reinicia su posición x.
        //    if (this.circleX > this.pictureBox.Width)
        //        this.circleX = 0;
        //    // Asigna el Bitmap a la propiedad Image del PictureBox.
        //    this.pictureBox.Image = this.bitmap;
        //}

        double inc = 0;
        //double t = 0.25;
        double dx = 0.2;
        private void Timer_Ejemplo1(object sender, EventArgs e)
        {
            this.bitmap = new Figura().Circulo(Color.Red, 2, inc, inc).Bmp;
            this.inc += x;
            this.pictureBox.Image = this.bitmap;
            if (inc >= 6)
                Stop();
            
        }
        double t = -7;
        private void Timer_Ejemplo2(object sender, EventArgs e)
        {
            this.t += dx;
            this.pictureBox.Image = new Figura().Circulo(Color.Red, 1, t, 0).Bmp;
            if ( t >= 7) 
                Stop();
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
    }
}
