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
        private void ClearImage()
        {
            lbx.Items.Clear();
            ventana.CreateGraphics().DrawImageUnscaled(Rug.RugWhite(), 0, 0);
        }
        private void RefreshImage()
        {
            ClearImage();
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


        private void btnPixel_Click(object sender, EventArgs e)
        {
            layers.AddImage(Pixel.PixelRandom(color), "Pixel");
            RefreshImage();
        }

        private void btnVector_Click(object sender, EventArgs e)
        {
            Vector vector = new Vector();
            bmp = vector.Prueba(bmp, color);
            layers.AddImage(bmp, "Vector");
            RefreshImage();
        }
        private void btnSegmento_Click(object sender, EventArgs e)
        {
            Segmento segmento = new Segmento(2,5);
            bmp = segmento.Encender(bmp, color);
            layers.AddImage(bmp, "Segmento");
            RefreshImage();
        }
        private void btnCirculo_Click(object sender, EventArgs e)
        {
            Circunferencia circulo = new Circunferencia();
            bmp = circulo.Encender(bmp, color,2);
            layers.AddImage(bmp, "Circulo");
            RefreshImage();
        }

        private void btnCC_Click(object sender, EventArgs e)
        {
            bmp = Figura.Concentrica();
            layers.AddImage(bmp, "Circ. Concénctricas");
            RefreshImage();
        }

        private void bttnL_Click(object sender, EventArgs e)
        {
            bmp = Figura.Lagrange();
            layers.AddImage(bmp, "Lagrange");
            RefreshImage();
        }

        private void btnInter_Click(object sender, EventArgs e)
        {
            bmp = Figura.Lagrange2();
            layers.AddImage(bmp, "Inter");
            RefreshImage();
        }

        private void btnLazo_Click(object sender, EventArgs e)
        {
            bmp = Figura.Lazo(color);
            layers.AddImage(bmp, "Lazo");
            RefreshImage();
        }

        private void btnTaylor_Click(object sender, EventArgs e)
        {
            bmp = Figura.Taylor();
            layers.AddImage(bmp, "Gráfico Taylor");
            RefreshImage();
        }

        private void btnEspiral_Click(object sender, EventArgs e)
        {
            bmp = Figura.Espiral(color);
            layers.AddImage(bmp, "Espiral");
            RefreshImage();
        }

        private void btnDeleteFigure_Click(object sender, EventArgs e)
        {
            //bmp = new Bitmap(WIDTH, HEIGHT);
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
                    bmp = Texture.Madera();
                    layers.AddImage(bmp, "Madera");
                    RefreshImage();
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

        #region STRIP_MENU
        private void unicolorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bmp = Scanner.ScanUniColor(Color.Yellow);
            layers.AddImage(bmp, "Barrido Uni");
            RefreshImage();
        }
        private void bicolorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bmp = Scanner.ScanBiColor(Color.Red, Color.Yellow);
            layers.AddImage(bmp, "Barrido Bi");
            RefreshImage();
        }
        private void FirstDegraded_Click(object sender, EventArgs e)
        {
            bmp = Scanner.GradientScanner();
            layers.AddImage(bmp, "1º Degradado");
            RefreshImage();
        }
        private void SecondDegraded_Click(object sender, EventArgs e)
        {
            bmp = Scanner.GradientScanner2();
            layers.AddImage(bmp, "2º Degradado");
            RefreshImage();
        }
        #endregion


    }
}
