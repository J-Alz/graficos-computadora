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

        private void Draw(Bitmap bmp, string name)
        {
            layers.AddImage(bmp, name);
            lbx.Items.Add(layers.referencia());
            ventana.CreateGraphics().DrawImageUnscaled(layers.RefreshImage(), 0, 0);
        }

        public Form1()
        {
            InitializeComponent();
        }
        //TODO
        /* 1. Obtener valores del pictureBox
         * 2. Acomodar nombres de funciones y variables
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
            Pixel.PixelRandom(bmp, color);
            Draw(bmp, "Pixel");
        }

        private void btnVector_Click(object sender, EventArgs e)
        {
            Vector vector = new Vector();
            vector.Prueba(bmp, color);
            Draw(bmp, "Vector");
        }
        private void btnSegmento_Click(object sender, EventArgs e)
        {
            Segmento segmento = new Segmento(2,5);
            segmento.Encender(bmp, color);

            Draw(bmp, "Segmento");
            
        }

        
        
        private void btnCirculo_Click(object sender, EventArgs e)
        {
            Circunferencia circulo = new Circunferencia();
            circulo.Encender(bmp, color,2);
            Draw(bmp, "Circulo");
        }

        private void btnCC_Click(object sender, EventArgs e)
        {
            Circunferencia c = new Circunferencia();
            c.Encender(bmp, Color.Red,4);
            c.Encender(bmp, Color.Red,1);
            c.Encender(bmp, Color.Red,7);
            c.Encender(bmp, Color.Red,3);
            Draw(bmp, "Circ. Concénctricas");
        }

        private void bttnL_Click(object sender, EventArgs e)
        {
            Circunferencia c = new Circunferencia();
            c.Encender(bmp, color, 0.3f, 2, 8);
            c.Encender(bmp, color, 0.3f, 3, 10);
            c.Encender(bmp, color, 0.3f, 4, 9);
            c.Encender(bmp, color, 0.3f, 5, 12);
            Segmento.L(bmp, Color.Red);
            Draw(bmp, "Lagrange");
        }

        private void btnInter_Click(object sender, EventArgs e)
        {
            Circunferencia c = new Circunferencia();
            c.Encender(bmp, color, 0.3f, -1, 3);
            c.Encender(bmp, color, 0.3f, 1, 5);
            c.Encender(bmp, color, 0.3f, 3, 2);
            Segmento.L2(bmp, Color.Red);
            Draw(bmp, "Inter");
        }


        private void btnScanUni_Click(object sender, EventArgs e)
        {
            Scanner.ScanUniColor(bmp, Color.Yellow);
            Draw(bmp, "Barrido Uni");
        }

        private void btnScanBi_Click(object sender, EventArgs e)
        {
            Scanner.ScanBiColor(bmp,Color.Red, Color.Yellow);
            Draw(bmp, "Barrido Bi");
        }

        

        private void btnLazo_Click(object sender, EventArgs e)
        {
            Figura.Lazo(bmp, color);
            Draw(bmp, "Lazo");
        }

        private void btnDegraded1_Click(object sender, EventArgs e)
        {
            Scanner.GradientScanner(bmp);
            Draw(bmp, "1º Degradado");
        }

        private void btnTaylor_Click(object sender, EventArgs e)
        {
            Figura.Taylor(bmp);
            Draw(bmp, "Gráfico Taylor");
        }

        private void btnDegraded2_Click(object sender, EventArgs e)
        {
            Scanner.GradientScanner2(bmp);
            Draw(bmp, "2º Degradado");
        }

        private void btnEspiral_Click(object sender, EventArgs e)
        {
            Figura.Espiral(bmp, color);
            Draw(bmp, "Espiral");
        }

        private void btnDeleteFigure_Click(object sender, EventArgs e)
        {
            // 1. Seleccionar item
            // 2. Tomar valor
            //int indexItem = lbx.SelectedIndex;
            // 3. Remover item
            //layers.removeImage(indexItem);
            // 4. Borrar todo
            //ventana.Image = null;
            //bmp = new Bitmap(WIDTH, HEIGHT);
            //lbx.Items.Clear();
            //Escribir listbox
            //Dibujar
            //bmp = layers.RefreshImage();
            ventana.Image = null;
            lbx.Items.Clear();
            lbx.Items.AddRange(layers.ReferenciaAll());
            layers.removeImage(1);
            ventana.CreateGraphics().DrawImageUnscaled(layers.RefreshImage(), 0, 0);
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
                    Draw(bmp,"Otoño");
                    break;
                case "Invierno":
                    Rug.RugInvierno(bmp);
                    Draw(bmp, "Invierno");
                    break;
                case "Primavera":
                    Rug.RugPrimavera(bmp);
                    Draw(bmp, "Primavera");
                    break;
                case "Verano":
                    Rug.RugVerano(bmp);
                    Draw(bmp, "Verano");
                    break;
                case "Modificada":
                    Rug.Rug2(bmp);
                    Draw(bmp, "Modificada");
                    break;
                case "Madera":
                    Rug.RugMadera(bmp);
                    Draw(bmp, "Madera");
                    break;
                default:
                    Rug.Rug1(bmp);
                    Draw(bmp, "Dibujo");
                    break;
            }
        }

        private void btnParabola_Click(object sender, EventArgs e)
        {
            Figura.Parabola(bmp);
            Draw(bmp, "Parabola");
        }
    }
}
