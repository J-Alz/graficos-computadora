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

        Color[] paleta = Paleta.paleta0;
        


        bool activeLuz = false;
        private void RefreshImage()
        {
            //figuras.Reverse();
            //figuras3d.Reverse();
            //texturas.Reverse();
            using ( Graphics g = Graphics.FromImage(bmp))
            {
                foreach (Vector elemento in lista)
                    g.DrawImageUnscaled(elemento.Bmp, 0, 0);
                //bmp = elemento.Bmp;

            }
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
            //btnAnimacion.Visible = false;
            //btnDibujar.Visible = false;
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

        private void rbtPaleta0_CheckedChanged(object sender, EventArgs e)
        {
            paleta = Paleta.paleta0;
        }

        private void rtbPaletaOnda_CheckedChanged(object sender, EventArgs e)
        {
            paleta = Paleta.paletaOnda();
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


        #region VENTANA

        double Sx, Sy;
        double x, y;
        private void ventana_MouseMove(object sender, MouseEventArgs e)
        {
            Sx = e.X;
            Sy = e.Y;
            Geometria.Transforma(e.X, e.Y, out x, out y);
            toolTip.SetToolTip(this.ventana, "x: " + x + " Y: " + y + "\nSx: " + Sx + " Sy: " + Sy);
        }

        private void ventana_Click(object sender, EventArgs e)
        {
            if (activeLuz == true)
            {
                Geometria.Transforma(Sx, Sy, out x, out y);
                lista.Add(new Figura().PuntoParabola(x, y));

            }
            RefreshImage();
        }


        #endregion

        #region FIGURAS 2D
        private void FiguraPixel_Click(object sender, EventArgs e)
        {
            lista.Add(new Figura(color).PixelRandom());
            RefreshImage();
        }

        private void FiguraVector_Click(object sender, EventArgs e)
        {
            lista.Add(new Figura(color).VectorEjemplo());
            RefreshImage();
        }

        private void FiguraSegmento_Click(object sender, EventArgs e)
        {
            lista.Add(new Figura(color).segmento(0, 0, 4, 0));
            RefreshImage();
        }

        private void FiguraCirculo_Click(object sender, EventArgs e)
        {
            lista.Add(new Figura(color).Circulo(Color.Blue, 2, 0, 0));
            RefreshImage();
        }

        private void FiguraConcentrica_Click(object sender, EventArgs e)
        {
            lista.Add(new Figura().Concentrica());
            RefreshImage();
        }

        private void FiguraLazo_Click(object sender, EventArgs e)
        {
            lista.Add(new Figura(color).Lazo());
            RefreshImage();
        }

        private void FiguraEspiral_Click(object sender, EventArgs e)
        {
            lista.Add(new Figura(color).Espiral());
            RefreshImage();
        }

        private void FiguraTaylor_Click(object sender, EventArgs e)
        {
            lista.Add(new Figura().Taylor());
            RefreshImage();
        }

        private void FiguraLagrange_Click(object sender, EventArgs e)
        {
            lista.Add(new Figura().Lagrange());
            RefreshImage();
        }

        private void FiguraInterpolacion_Click(object sender, EventArgs e)
        {
            lista.Add(new Figura().Interpolacion());
            RefreshImage();
        }

        private void FiguraParabola_Click(object sender, EventArgs e)
        {
            lista.Add(new Figura().Parabola());
            activeLuz = true;
            RefreshImage();
        }

        #endregion

        #region TEXTURAS
        private void TexturaUnicolor_Click(object sender, EventArgs e)
        {
            lista.Add(new Textura().UniColor(Color.Yellow));
            RefreshImage();
        }

        private void TexturaBicolor_Click(object sender, EventArgs e)
        {
            lista.Add(new Textura().BiColor(Color.Red, Color.Yellow));
            RefreshImage();
        }

        private void TexturaDegradado1_Click(object sender, EventArgs e)
        {
            lista.Add(new Textura().DegradadoBicolor1());
            RefreshImage();
        }

        private void TexturaDegradado2_Click(object sender, EventArgs e)
        {
            lista.Add(new Textura().DegradadoBicolor2());
            RefreshImage();
        }

        private void Tapete1_Click(object sender, EventArgs e)
        {
            lista.Add(new Textura().Tapete1());
            RefreshImage();
        }

        private void Tapete2_Click(object sender, EventArgs e)
        {
            lista.Add(new Textura().Tapete2());
            RefreshImage();
        }

        private void TapeteInvierno_Click(object sender, EventArgs e)
        {
            lista.Add(new Textura().TapeteInvierno());
            RefreshImage();
        }

        private void TapeteVerano_Click(object sender, EventArgs e)
        {
            lista.Add(new Textura().TapeteVerano());
            RefreshImage();
        }

        private void TapeteOtonno_Click(object sender, EventArgs e)
        {
            lista.Add(new Textura().TapeteOtonno());
            RefreshImage();
        }

        private void TapetePrimavera_Click(object sender, EventArgs e)
        {
            lista.Add(new Textura().TapetePrimavera());
            RefreshImage();
        }

        private void TexturaMadera_Click(object sender, EventArgs e)
        {
            lista.Add(new Textura().Madera());
            RefreshImage();
        }

        private void TexturaCesped_Click(object sender, EventArgs e)
        {
            lista.Add(new Textura().Cesped());
            RefreshImage();
        }

        private void TexturaPiedra_Click(object sender, EventArgs e)
        {
            lista.Add(new Textura().Piedra());
            RefreshImage();
        }

        #endregion

        #region FIGURAS 3D
        private void Figura3DCirculo_Click(object sender, EventArgs e)
        {
            lista.Add(new Figura3D().Circulo());
            RefreshImage();
        }

        private void Figura3DEspiral_Click(object sender, EventArgs e)
        {
            lista.Add(new Figura3D().Espiral());
            RefreshImage();
        }
        #endregion

        #region ANIMACIÓN
        private void ItemAnimationDiagonal_Click(object sender, EventArgs e)
        {
            animation = new Animation(ventana);
            animation.Start(animation.Diagonal, 0);
        }

        private void ItemAnimationLinealX_Click(object sender, EventArgs e)
        {
            this.animation = new Animation(ventana);
            this.animation.Start(animation.Lineal_X, -7);
        }

        private void ItemAnimationParabola_Click(object sender, EventArgs e)
        {
            animation = new Animation(ventana);
            animation.Start(animation.Parabola, -7);
        }

        private void ItemAnimationEspiral_Click(object sender, EventArgs e)
        {
            animation = new Animation(ventana);
            animation.Start(animation.Espiral, 0);
        }
        private void ItemAnimationCarretera_Click(object sender, EventArgs e)
        {
            animation = new Animation(ventana);
            animation.Start(animation.Timer_Examen2, -10);
        }

        #endregion

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            //lista.Add(new Reflexion(1,0,6.15).segmentoXf());

            //lista.Add(new Segmento(60,1,0).Dibujar());
            //lista.Add(new Segmento(300, 1, 0).Dibujar());
            //double x = 1, y = 0;
            //lista.Add(new Segmento().D(ref x, ref y, 60));
            //Console.WriteLine("X: " + x + " Y: " + y);
            //lista.Add(new Segmento().Linea(0,3,3,0));
            lista.Add(new Onda1D().Graphic());
            RefreshImage();
        }
        private void btnAnimacion_Click(object sender, EventArgs e)
        {
            animation = new Animation(ventana);
            animation.Start(animation.Timer_Onda, 0);
        }

        #region Ondas


        private void ondaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lista.Add(new Onda().DrawOnda(paleta));
            RefreshImage();
        }

        private void OndaOrigen_Click(object sender, EventArgs e)
        {
            lista.Add(new Onda().DrawOnda(paleta, 5, 6));
            RefreshImage();
        }

        private void OndaInterferencia2_Click(object sender, EventArgs e)
        {
            lista.Add(new Onda().Interferencia2(paleta));
            RefreshImage();
        }

        private void OndaInterferencia3_Click(object sender, EventArgs e)
        {
            lista.Add(new Onda().Interferencia3(paleta));
            RefreshImage();
        }

        private void Onda3D_Click(object sender, EventArgs e)
        {
            lista.Add(new Onda3D().Onda());
            RefreshImage();
        }

        private void Onda2SinInter_Click(object sender, EventArgs e)
        {
            lista.Add(new Onda3D().Onda2());
            RefreshImage();
        }

        private void Onda2ConInter_Click(object sender, EventArgs e)
        {
            lista.Add(new Onda3D().Interferencia2());
            RefreshImage();
        }

        private void AniOnda_Click(object sender, EventArgs e)
        {
            animation = new Animation(ventana);
            animation.Paleta = paleta;
            animation.Start(animation.Timer_Onda, 0);
        }

        private void AniOnda3D_Click(object sender, EventArgs e)
        {
            animation = new Animation(ventana);
            animation.Start(animation.Timer_Onda3D, 0);
        }

        private void OndaInterferencia3D_Click(object sender, EventArgs e)
        {
            animation = new Animation(ventana);
            animation.Start(animation.Timer_Interferencia3D, 0);
        }

        #endregion



    }
}