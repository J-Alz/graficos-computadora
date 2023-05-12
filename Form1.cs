using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CC
{
    public partial class Form1 : Form
    {
        private static Random initializer = new Random();

        const int WIDTH = 700;
        const int HEIGHT = 540;
        Bitmap bmp = new Bitmap(WIDTH, HEIGHT);
        Color color = Color.Black;
        public Form1()
        {
            InitializeComponent();

 
        }
        private void btnPixel_Click(object sender, EventArgs e)
        {   
            bmp = Pixel.Encender(bmp,7, 7,color);
            win.CreateGraphics().DrawImageUnscaled(bmp, 0, 0);
        }
        private void btnVector_Click(object sender, EventArgs e)
        {
            Vector vector = new Vector();
            bmp = vector.Prueba(bmp, color);
            win.CreateGraphics().DrawImageUnscaled(bmp, 0, 0);
        }
        private void btnSegmento_Click(object sender, EventArgs e)
        {
            Segmento segmento = new Segmento(2,5);
            bmp = segmento.Encender(bmp, color);
            win.CreateGraphics().DrawImageUnscaled(bmp, 0, 0);
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Limpiamos la pantalla
            win.Image = null;
            //reinicializamos el bitmap
            bmp = new Bitmap(WIDTH, HEIGHT);
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            Circunferencia circulo = new Circunferencia(2);
            bmp = circulo.Encender(bmp, color);
            win.CreateGraphics().DrawImageUnscaled(bmp, 0, 0);
        }

        private void btnCurva1_Click(object sender, EventArgs e)
        {   
            Figura figura = new Figura();
            bmp = figura.Curva1(bmp, color);
            win.CreateGraphics().DrawImageUnscaled(bmp, 0, 0);
        }

        private void btnCurva2_Click(object sender, EventArgs e)
        {
            Figura figura = new Figura();
            bmp = figura.Curva2(bmp, color);
            win.CreateGraphics().DrawImageUnscaled(bmp, 0, 0);
            
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog.Color;
                btnColor.BackColor = color;
            }
        }

        private void btnEje_Click(object sender, EventArgs e)
        {
            Segmento segmento = new Segmento(8,-7);
            bmp = Segmento.Eje(bmp,Color.Red);
            win.CreateGraphics().DrawImageUnscaled(bmp, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Figura figura = new Figura();
            bmp = figura.Taylor(bmp);
            win.CreateGraphics().DrawImageUnscaled(bmp, 0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (cbxEjes.Checked)
            {
                bmp = Segmento.Eje(bmp, Color.Red);
                win.CreateGraphics().DrawImageUnscaled(bmp, 0, 0);
            }
            else
            {
                bmp = Segmento.Eje(bmp, Color.White);
                win.CreateGraphics().DrawImageUnscaled(bmp, 0, 0);
            }
        }


        private void cbxEjes_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxEjes.Checked)
            {
                bmp = Segmento.Eje(bmp, Color.Red);
                win.CreateGraphics().DrawImageUnscaled(bmp, 0, 0);
            }
            else
            {
                bmp = Segmento.Eje(bmp, Color.White);
                win.CreateGraphics().DrawImageUnscaled(bmp, 0, 0);
            }
            
        }
    }
}
