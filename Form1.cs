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
            ventana.CreateGraphics().DrawImageUnscaled(Rug.RugWhite(), 0, 0);

            lbx.Items.AddRange(layers.ReferenciaAll());
            foreach (Layer layer in layers.listLayers)
                ventana.CreateGraphics().DrawImageUnscaled(layer.Bmp, 0, 0);
        }

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

        private void cbxPaleta_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxPaleta.SelectedItem)
            {
                case "Otoño":
                    Rug.RugOtonno(bmp);
                    layers.AddImage(bmp,"Otoño");
                    RefreshImage();
                    break;
                case "Invierno":
                    Rug.RugInvierno(bmp);
                    layers.AddImage(bmp, "Invierno");
                    RefreshImage();
                    break;
                case "Primavera":
                    Rug.RugPrimavera(bmp);
                    layers.AddImage(bmp, "Primavera");
                    RefreshImage();
                    break;
                case "Verano":
                    Rug.RugVerano(bmp);
                    layers.AddImage(bmp, "Verano");
                    RefreshImage();
                    break;
                case "Modificada":
                    Rug.Rug2(bmp);
                    layers.AddImage(bmp, "Modificada");
                    RefreshImage();
                    break;
                case "Madera":
                    
                    break;
                default:
                    Rug.Rug1(bmp);
                    layers.AddImage(bmp, "Dibujo");
                    RefreshImage();
                    break;
            }
        }

        private void btnParabola_Click(object sender, EventArgs e)
        {
            bmp = Figura.Parabola();
            layers.AddImage(bmp, "Parabola");
            RefreshImage();
        }

        #region BARRIDO
        private void unicolorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            layers.AddImage(Scanner.ScanUniColor(Color.Yellow), "Barrido Uni");
            RefreshImage();
        }
        private void bicolorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            layers.AddImage(Scanner.ScanBiColor(Color.Red, Color.Yellow), "Barrido Bi");
            RefreshImage();
        }
        private void FirstDegraded_Click(object sender, EventArgs e)
        {
            layers.AddImage(Scanner.GradientScanner(), "1º Degradado");
            RefreshImage();
        }
        private void SecondDegraded_Click(object sender, EventArgs e)
        {
            layers.AddImage(Scanner.GradientScanner2(), "2º Degradado");
            RefreshImage();
        }

        #endregion

        #region BÁSICO
        private void pixelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            layers.AddImage(Pixel.PixelRandom(color), "Pixel");
            RefreshImage();
        }
        private void vectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vector vector = new Vector();
            bmp = vector.Prueba(bmp, color);
            layers.AddImage(bmp, "Vector");
            RefreshImage();
        }
        private void segmentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Segmento segmento = new Segmento(2, 5);
            bmp = segmento.Encender(bmp, color);
            layers.AddImage(bmp, "Segmento");
            RefreshImage();
        }

        #endregion

        #region FIGURAS
        private void circunferenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Circunferencia circulo = new Circunferencia();
            bmp = circulo.Encender(bmp, color, 2);
            layers.AddImage(bmp, "Circulo");
            RefreshImage();
        }

        private void circConcentricasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            layers.AddImage(Figura.Concentrica(), "Circ. Concénctricas");
            RefreshImage();
        }

        private void lazoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            layers.AddImage(Figura.Lazo(color), "Lazo");
            RefreshImage();
        }
        private void espiralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            layers.AddImage(Figura.Espiral(color), "Espiral");
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

        int X;
        int Y;
        private void ventana_MouseMove(object sender, MouseEventArgs e)
        {
            X = e.X;
            Y = e.Y;
            Geometria g = new Geometria();
            double a, b;
            g.Transforma(e.X,e.Y,out a, out b);
            toolTip.SetToolTip(this.ventana, "X: " + e.X + " Y: " + e.Y);
        }

        private void ventana_Click(object sender, EventArgs e)
        {
            //Circunferencia circulo = new Circunferencia();
            //circulo.Encender(bmp, color, 5,X,Y);
            //layers.AddImage(bmp, "Circulo");
            //Vector vector = new Vector();
            //vector.Encender(bmp, color, X, Y);
            //layers.AddImage(bmp, "dibujo");
            //RefreshImage();

        }

        private void cbxTextura_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbxTextura.SelectedItem)
            {
                case "Madera":
                    layers.AddImage(Texture.Madera(), "Madera");
                    RefreshImage();
                    break;
                case "Cesped":
                    layers.AddImage(Texture.Cesped(), "Cesped");
                    RefreshImage();
                    break;
                default:
                    layers.AddImage(Texture.Piedra(), "Piedra");
                    RefreshImage();
                    break;
            }
        }

        private void btnAnimation_Click(object sender, EventArgs e)
        {
            Segmento seg = new Segmento(2,5);
            layers.AddImage(seg.Encender(bmp,Color.Green), "Segmento");
            bmp = new Bitmap(700, 540);
            Circunferencia c = new Circunferencia();
            layers.AddImage(c.Encender(bmp, Color.Red, 2), "Circulo");
            bmp = new Bitmap(700, 540);
            layers.AddImage(Figura.Lazo(Color.Blue), "Lazo");
            RefreshImage();
            
            Thread.Sleep(2000);

            layers.removeImage(1);
            RefreshImage();
        }
    }
}
