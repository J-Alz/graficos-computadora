using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace CC
{
    public partial class Form1 : Form
    {
        const int WIDTH = 700;
        const int HEIGHT = 540;
        Layers layers = new Layers(WIDTH, HEIGHT);
        Bitmap bmp = new Bitmap(WIDTH, HEIGHT);
        Color color = Color.Black;
        Segmento segmento = new Segmento();
        void RefreshImage()
        {
            lbx.Items.Clear();
            ventana.CreateGraphics().DrawImageUnscaled(Textura.TapeteBlanco(), 0, 0);

            lbx.Items.AddRange(layers.ReferenciaAll());
            foreach (Layer layer in layers.listLayers)
                ventana.CreateGraphics().DrawImageUnscaled(layer.Bmp, 0, 0);
        }
        private Animation animation;
        public Form1()
        {
            InitializeComponent();
        }
        //TODO
        /* 1. Obtener valores del pictureBox
         * 3. Mejorar botones
         */
        #region OPCIONES
        bool showAxis = false;
        private void btnShowAxis_Click(object sender, EventArgs e)
        {
            if (!showAxis)
            {
                segmento.AxisY(bmp, Color.Red);
                segmento.AxisX(bmp, Color.Red);
                btnShowAxis.Image = global::CC.Properties.Resources.eye_slash;
                showAxis = true;
                toolTip.SetToolTip(this.btnShowAxis, "Borrar Ejes");
            }
            else
            {
                segmento.AxisY(bmp, Color.White);
                segmento.AxisX(bmp, Color.White);
                btnShowAxis.Image = global::CC.Properties.Resources.eye;
                showAxis = false;
                toolTip.SetToolTip(this.btnShowAxis, "Dibujar Ejes");
            }
            ventana.CreateGraphics().DrawImageUnscaled(bmp, 0, 0);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            /*
             */
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog.Color;
                btnColor.BackColor = color;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ventana.Image = null;
            bmp = new Bitmap(WIDTH, HEIGHT);
            layers.ResetImage();
            lbx.Items.Clear();
            
        }

        #endregion

        private void btnDeleteFigure_Click(object sender, EventArgs e)
        {
            layers.removeImage(0);
            RefreshImage();
        }

        private void lbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(lbx.SelectedItems == null))
            {
                btnDeleteFigure.Enabled = true;
            }
            //lbx.SelectedItem.ToString();
            //lbx.Items.Add(lbx.SelectedIndex.ToString());
        }
        

        private void btnAnimacion_Click(object sender, EventArgs e)
        {
            this.animation = new Animation(ventana,"Ejemplo1");
            this.animation.Start();
        }

        #region FIGURAS
        private void ItemFiguraPixelRandom_Click(object sender, EventArgs e)
        {
            layers.AddImage(Pixel.PixelRandom(color), "Pixel");
            RefreshImage();
        }

        private void ItemFiguraVector_Click(object sender, EventArgs e)
        {
            Vector vector = new Vector();
            bmp = vector.Prueba(bmp, color);
            layers.AddImage(bmp, "Vector");
            RefreshImage();
        }

        private void ItemFiguraSegmento_Click(object sender, EventArgs e)
        {
            Segmento segmento = new Segmento(2, 5);
            bmp = segmento.Encender(bmp, color);
            layers.AddImage(bmp, "Segmento");
            RefreshImage();
        }

        private void ItemFiguraCircunferencia_Click(object sender, EventArgs e)
        {
            layers.AddImage(Figura.Circle(color, 2), "Circulo");
            RefreshImage();
        }

        private void ItemFiguraConcentricas_Click(object sender, EventArgs e)
        {
            layers.AddImage(Figura.Concentrica(), "Circ. Concénctricas");
            RefreshImage();
        }

        private void ItemFiguraLazo_Click(object sender, EventArgs e)
        {
            layers.AddImage(Figura.Lazo(color), "Lazo");
            RefreshImage();
        }

        private void ItemFiguraEspiral_Click(object sender, EventArgs e)
        {
            layers.AddImage(Figura.Espiral(color), "Espiral");
            RefreshImage();
        }

        private void ItemFiguraParabola_Click_1(object sender, EventArgs e)
        {
            layers.AddImage(Figura.Parabola(), "Parabola");
            RefreshImage();
        }
        #endregion

        #region INTERPOLACIÓN
        private void interpolaciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            layers.AddImage(Figura.Lagrange2(), "Inter");
            RefreshImage();
        }

        private void lagrangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            layers.AddImage(Figura.Lagrange(), "Lagrange");
            RefreshImage();
        }

        private void taylorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            layers.AddImage(Figura.Taylor(), "Gráfico Taylor");
            RefreshImage();
        }


        #endregion

        #region TEXTURA
        private void ItemTexturaUniColor_Click(object sender, EventArgs e)
        {
            layers.AddImage(Textura.UniColor(Color.Yellow), "Barrido Uni");
            RefreshImage();
        }

        private void ItemTexturaBiColor_Click(object sender, EventArgs e)
        {
            layers.AddImage(Textura.BiColor(Color.Red, Color.Yellow), "Barrido Bi");
            RefreshImage();
        }

        private void ItemTexturaDegradado1_Click(object sender, EventArgs e)
        {
            layers.AddImage(Textura.DegradadoBicolor1(), "1º Degradado");
            RefreshImage();
        }

        private void ItemTexturaDegradado2_Click(object sender, EventArgs e)
        {
            layers.AddImage(Textura.DegradadoBicolor2(), "2º Degradado");
            RefreshImage();
        }

        private void ItemTexturaMadera_Click(object sender, EventArgs e)
        {
            layers.AddImage(Textura.Madera(), "Madera");
            RefreshImage();
        }

        private void ItemTexturaCesped_Click(object sender, EventArgs e)
        {
            layers.AddImage(Textura.Cesped(), "Cesped");
            RefreshImage();
        }

        private void ItemTexturaPiedra_Click(object sender, EventArgs e)
        {
            layers.AddImage(Textura.Piedra(), "Piedra");
            RefreshImage();
        }

        private void ItemTexturaEjemplo1_Click(object sender, EventArgs e)
        {
            
            layers.AddImage(Textura.Tapete1(), "Dibujo");
            RefreshImage();
        }

        private void ItemTexturaEjemplo2_Click(object sender, EventArgs e)
        {
            layers.AddImage(Textura.Tapete2(), "Modificada");
            RefreshImage();
        }

        private void ItemTexturaInvierno_Click(object sender, EventArgs e)
        {
            layers.AddImage(Textura.TapeteInvierno(), "Invierno");
            RefreshImage();
        }

        private void ItemTexturaPrimavera_Click(object sender, EventArgs e)
        {
            layers.AddImage(Textura.TapetePrimavera(), "Primavera");
            RefreshImage();
        }

        private void ItemTexturaVerano_Click(object sender, EventArgs e)
        {
            layers.AddImage(Textura.TapeteVerano(), "Verano");
            RefreshImage();
        }

        private void ItemTexturaOtonno_Click(object sender, EventArgs e)
        {
            layers.AddImage(Textura.TapeteOtonno(), "Otoño");
            RefreshImage();
        }



        #endregion

        //Agregar funcionalidad de carta
        #region VENTANA

        int X = 0;
        int Y = 0;
        private void ventana_MouseMove(object sender, MouseEventArgs e)
        {
            X = e.X;
            Y = e.Y;
            toolTip.SetToolTip(this.ventana, "X: " + e.X + " Y: " + e.Y);
        }

        private void ventana_Click(object sender, EventArgs e)
        {
            layers.AddImage(Figura.Circle(color, 0.5, X, Y), $"Punto({X},{Y})");
            RefreshImage();
        }

        #endregion

        #region ANIMACIÓN

        private void ItemAnimacionEjemplo1_Click(object sender, EventArgs e)
        {
            //Segmento seg = new Segmento(2, 5);
            //layers.AddImage(seg.Encender(bmp, Color.Green), "Segmento");
            //bmp = new Bitmap(700, 540);
            //layers.AddImage(Figura.Circle(Color.Red, 2), "Circulo");
            //bmp = new Bitmap(700, 540);
            //layers.AddImage(Figura.Lazo(Color.Blue), "Lazo");
            //RefreshImage();

            //Thread.Sleep(2000);

            //layers.removeImage(1);
            //RefreshImage();
            this.animation = new Animation(ventana, "Ejemplo1");
            this.animation.Start();
        }

        private void ItemAnimacionEjemplo2_Click(object sender, EventArgs e)
        {
            this.animation = new Animation(ventana, "Ejemplo2");
            this.animation.Start();
        }

        private void ItemAnimacionEjemplo3_Click(object sender, EventArgs e)
        {
            this.animation = new Animation(ventana, "Ejemplo3");
            this.animation.Start();
        }

        private void ItemAnimacionEjemplo4_Click(object sender, EventArgs e)
        {
            this.animation = new Animation(ventana, "Ejemplo4");
            this.animation.Start();
        }

        private void ItemAnimacionEjemplo5_Click(object sender, EventArgs e)
        {
            this.animation = new Animation(ventana, "Ejemplo5");
            this.animation.Start();
        }
        #endregion
    }
}
