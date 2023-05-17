﻿using System;
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
            //bmp = Segmento.Eje(bmp, Color.Red);
            //ventana.CreateGraphics().DrawImageUnscaled(bmp, 0, 0);
        }
        //int Widt = (ulong)ventana.Width;
        //TODO
        /* 1. Obtener valores del pictureBox
         * 3. Mejorar botones
         */
        private void btnPixel_Click(object sender, EventArgs e)
        {   
            bmp = Pixel.Encender(bmp,7, 7,color);
            ventana.CreateGraphics().DrawImageUnscaled(bmp, 0, 0);
        }
        private void btnVector_Click(object sender, EventArgs e)
        {
            Vector vector = new Vector();
            bmp = vector.Prueba(bmp, color);
            ventana.CreateGraphics().DrawImageUnscaled(bmp, 0, 0);
        }
        private void btnSegmento_Click(object sender, EventArgs e)
        {
            Segmento segmento = new Segmento(2,5);
            bmp = segmento.Encender(bmp, color);
            ventana.CreateGraphics().DrawImageUnscaled(bmp, 0, 0);
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Limpiamos la pantalla
            ventana.Image = null;
            //reinicializamos el bitmap
            bmp = new Bitmap(WIDTH, HEIGHT);
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            Circunferencia circulo = new Circunferencia();
            bmp = circulo.Encender(bmp, color,2);
            ventana.CreateGraphics().DrawImageUnscaled(bmp, 0, 0);
        }

        private void btnCurva1_Click(object sender, EventArgs e)
        {   
            Figura figura = new Figura();
            bmp = figura.Curva1(bmp, color);
            ventana.CreateGraphics().DrawImageUnscaled(bmp, 0, 0);
        }

        private void btnCurva2_Click(object sender, EventArgs e)
        {
            Figura figura = new Figura();
            bmp = figura.Curva2(bmp, color);
            ventana.CreateGraphics().DrawImageUnscaled(bmp, 0, 0);
            
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog.Color;
                btnColor.BackColor = color;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Figura figura = new Figura();
            bmp = figura.Taylor(bmp);
            ventana.CreateGraphics().DrawImageUnscaled(bmp, 0, 0);
        }

        bool showAxis = false;
        private void btnShowAxis_Click(object sender, EventArgs e)
        {
            if (!showAxis)
            {
                Segmento.AxisY(bmp, Color.Red);
                Segmento.AxisX(bmp, Color.Red);
                btnShowAxis.Image = global::CC.Properties.Resources.eye_slash;
                showAxis = true;
                toolTip.SetToolTip(this.btnShowAxis, "Borrar Ejes");
            }
            else
            {
                Segmento.AxisY(bmp, Color.White);
                Segmento.AxisX(bmp, Color.White);
                btnShowAxis.Image = global::CC.Properties.Resources.eye;
                showAxis = false;
                toolTip.SetToolTip(this.btnShowAxis, "Dibujar Ejes");
            }
            ventana.CreateGraphics().DrawImageUnscaled(bmp, 0, 0);
        }

        private void btnCC_Click(object sender, EventArgs e)
        {
            Circunferencia c = new Circunferencia();
            c.Encender(bmp, Color.Red,4);
            c.Encender(bmp, Color.Red,1);
            c.Encender(bmp, Color.Red,7);
            c.Encender(bmp, Color.Red,3);
            ventana.CreateGraphics().DrawImageUnscaled(bmp, 0, 0);

        }

        private void bttnL_Click(object sender, EventArgs e)
        {
            Circunferencia c = new Circunferencia();
            c.Encender(bmp, color, 0.3f, 2, 8);
            c.Encender(bmp, color, 0.3f, 3, 10);
            c.Encender(bmp, color, 0.3f, 4, 9);
            c.Encender(bmp, color, 0.3f, 5, 12);
            bmp = Segmento.L(bmp, Color.Red);
            ventana.CreateGraphics().DrawImageUnscaled(bmp, 0, 0);
        }

        private void btnInter_Click(object sender, EventArgs e)
        {
            Circunferencia c = new Circunferencia();
            c.Encender(bmp, color, 0.3f, -1, 3);
            c.Encender(bmp, color, 0.3f, 1, 5);
            c.Encender(bmp, color, 0.3f, 3, 2);
            bmp = Segmento.L2(bmp, Color.Red);
            ventana.CreateGraphics().DrawImageUnscaled(bmp, 0, 0);
        }
    }
}
