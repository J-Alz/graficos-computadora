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
        Bitmap bmp = new Bitmap(WIDTH, HEIGHT);
        Color color = Color.Black;
        //ArrayList figuras = new ArrayList();
        //ArrayList texturas = new ArrayList();
        //ArrayList figuras3d = new ArrayList();
        List<Vector> lista = new List<Vector>();

        bool activeLuz = false;
        private void RefreshImage()
        {
            //figuras.Reverse();
            //figuras3d.Reverse();
            //texturas.Reverse();
            foreach (Vector elemento in lista)
                bmp = elemento.Bmp;
            //foreach (Figura figura in figuras)
            //    bmp = figura.Bmp;
            //foreach(Textura textura in texturas)
            //    bmp = textura.Bmp;
            ventana.CreateGraphics().DrawImageUnscaled(bmp, 0, 0);
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
                lista.Add(new Figura().axis());
                btnShowAxis.Image = global::CC.Properties.Resources.eye_slash;
                showAxis = true;
                toolTip.SetToolTip(this.btnShowAxis, "Borrar Ejes");
            }
            else
            {
                //modificar para asegurar borrado
                lista.Add(new Figura().axis());
                btnShowAxis.Image = global::CC.Properties.Resources.eye;
                showAxis = false;
                toolTip.SetToolTip(this.btnShowAxis, "Dibujar Ejes");
            }
            RefreshImage();
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
            lbx.Items.Clear();
            foreach (Vector elemento in lista)
                elemento.Dispose();
            lista.Clear();
        }

        #endregion

        private void btnDeleteFigure_Click(object sender, EventArgs e)
        {
            
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




        #region FIGURAS
        private void ItemFiguraPixelRandom_Click(object sender, EventArgs e)
        {
            lista.Add(new Figura(color).PixelRandom());
            RefreshImage();
        }

        private void ItemFiguraVector_Click(object sender, EventArgs e)
        {
            lista.Add(new Figura(color).VectorEjemplo());
            RefreshImage();
        }

        private void ItemFiguraSegmento_Click(object sender, EventArgs e)
        {
            lista.Add(new Figura(color).segmento(0,0,2,5));
            RefreshImage();
        }
        
        private void ItemFiguraCirculo_Click(object sender, EventArgs e)
        {
            lista.Add(new Figura(color).Circulo(Color.Blue, 2, 0, 0));
            RefreshImage();
        }

        private void ItemFiguraConcentrica_Click(object sender, EventArgs e)
        {
            lista.Add(new Figura().Concentrica());
            RefreshImage();
        }

        private void ItemFiguraLazo_Click(object sender, EventArgs e)
        {
            lista.Add(new Figura(color).Lazo());
            RefreshImage();
        }

        private void ItemFiguraEspiral_Click(object sender, EventArgs e)
        {
            lista.Add(new Figura(color).Espiral());
            RefreshImage();
        }

        private void ItemFiguraTaylor_Click(object sender, EventArgs e)
        {
            lista.Add(new Figura().Taylor());
            RefreshImage();
        }

        private void ItemFiguraLagrange_Click(object sender, EventArgs e)
        {
            lista.Add(new Figura().Lagrange());
            RefreshImage();
        }

        private void ItemFiguraInterpolacion_Click(object sender, EventArgs e)
        {
            lista.Add(new Figura().Interpolacion());
            RefreshImage();
        }
        private void ItemFiguraParabola_Click(object sender, EventArgs e)
        {
            lista.Add(new Figura().Parabola());
            activeLuz = true;
            RefreshImage();
        }

        #endregion

        #region TEXTURA
        private void ItemTexturaUniColor_Click(object sender, EventArgs e)
        {
            
            lista.Add(new Textura().UniColor(Color.Yellow));
            RefreshImage();
        }

        private void ItemTexturaBiColor_Click(object sender, EventArgs e)
        {
            lista.Add(new Textura().BiColor(Color.Red, Color.Yellow));
            RefreshImage();
        }

        private void ItemTextura1Degradado_Click(object sender, EventArgs e)
        {
            lista.Add(new Textura().DegradadoBicolor1());
            RefreshImage();
        }

        private void ItemTextura2Degradado_Click(object sender, EventArgs e)
        {
            lista.Add(new Textura().DegradadoBicolor2());
            RefreshImage();
        }

        private void ItemTexturaEjemplo1_Click(object sender, EventArgs e)
        {
            lista.Add(new Textura().Tapete1());
            RefreshImage();
        }

        private void ItemTexturaEjemplo2_Click(object sender, EventArgs e)
        {
            lista.Add(new Textura().Tapete2());
            RefreshImage();
        }

        private void ItemTexturaInvierno_Click(object sender, EventArgs e)
        {
            lista.Add(new Textura().TapeteInvierno());
            RefreshImage();
        }

        private void ItemTexturaPrimavera_Click(object sender, EventArgs e)
        {
            lista.Add(new Textura().TapetePrimavera());
            RefreshImage();
        }

        private void ItemTexturaVerano_Click(object sender, EventArgs e)
        {
            lista.Add(new Textura().TapeteVerano());
            RefreshImage();
        }

        private void ItemTexturaOtonno_Click(object sender, EventArgs e)
        {
            lista.Add(new Textura().TapeteOtonno());
            RefreshImage();
        }

        private void ItemTexturaMadera_Click(object sender, EventArgs e)
        {
            lista.Add(new Textura().Madera());
            RefreshImage();
        }

        private void ItemTexturaCesped_Click(object sender, EventArgs e)
        {
            lista.Add(new Textura().Cesped());
            RefreshImage();
        }

        private void ItemTexturaPiedra_Click(object sender, EventArgs e)
        {
            lista.Add(new Textura().Piedra());
            RefreshImage();
        }

        #endregion

        #region VENTANA

        double Sx, Sy;
        double x, y;
        private void ventana_MouseMove(object sender, MouseEventArgs e)
        {
            Sx = e.X;
            Sy = e.Y;
            Geometria.Transforma(e.X,e.Y,out x,out y);
            toolTip.SetToolTip(this.ventana, "x: " + x + " Y: " + y + "\nSx: " + Sx + " Sy: " + Sy);
        }

        private void ventana_Click(object sender, EventArgs e)
        {
            if(activeLuz == true)
            {
                Geometria.Transforma(Sx, Sy, out x, out y);
                lista.Add(new Figura().PuntoParabola(x,y));

            }
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

        private void Item3DCirculo_Click(object sender, EventArgs e)
        {
            lista.Add(new Figura3D().Circulo());
            RefreshImage();
        }

        private void Item3DEspiral_Click(object sender, EventArgs e)
        {
            lista.Add(new Figura3D().Espiral());
            RefreshImage();
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            lista.Add(new Onda().GrafOnda());
            RefreshImage();
        }
        private void btnAnimacion_Click(object sender, EventArgs e)
        {
            this.animation = new Animation(ventana, "Examen2");
            this.animation.Start();
        }
    }
}