using System.Drawing;

namespace CC
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()//Bitmap bmp
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInter = new System.Windows.Forms.Button();
            this.bttnL = new System.Windows.Forms.Button();
            this.btnCC = new System.Windows.Forms.Button();
            this.btnShowAxis = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnCurva2 = new System.Windows.Forms.Button();
            this.btnCurva1 = new System.Windows.Forms.Button();
            this.btnCirculo = new System.Windows.Forms.Button();
            this.btnVector = new System.Windows.Forms.Button();
            this.btnPixel = new System.Windows.Forms.Button();
            this.btnSegmento = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ventana = new System.Windows.Forms.PictureBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnScanUni = new System.Windows.Forms.Button();
            this.btnScanBi = new System.Windows.Forms.Button();
            this.btnScanRGB = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventana)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnScanRGB);
            this.groupBox1.Controls.Add(this.btnScanBi);
            this.groupBox1.Controls.Add(this.btnScanUni);
            this.groupBox1.Controls.Add(this.btnInter);
            this.groupBox1.Controls.Add(this.bttnL);
            this.groupBox1.Controls.Add(this.btnCC);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnCurva2);
            this.groupBox1.Controls.Add(this.btnCurva1);
            this.groupBox1.Controls.Add(this.btnCirculo);
            this.groupBox1.Controls.Add(this.btnVector);
            this.groupBox1.Controls.Add(this.btnPixel);
            this.groupBox1.Controls.Add(this.btnSegmento);
            this.groupBox1.Location = new System.Drawing.Point(12, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 503);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // btnInter
            // 
            this.btnInter.Location = new System.Drawing.Point(101, 106);
            this.btnInter.Name = "btnInter";
            this.btnInter.Size = new System.Drawing.Size(84, 23);
            this.btnInter.TabIndex = 18;
            this.btnInter.Text = "Interpolacion";
            this.btnInter.UseVisualStyleBackColor = true;
            this.btnInter.Click += new System.EventHandler(this.btnInter_Click);
            // 
            // bttnL
            // 
            this.bttnL.Location = new System.Drawing.Point(101, 77);
            this.bttnL.Name = "bttnL";
            this.bttnL.Size = new System.Drawing.Size(84, 23);
            this.bttnL.TabIndex = 17;
            this.bttnL.Text = "Interpolacion L";
            this.bttnL.UseVisualStyleBackColor = true;
            this.bttnL.Click += new System.EventHandler(this.bttnL_Click);
            // 
            // btnCC
            // 
            this.btnCC.Location = new System.Drawing.Point(6, 77);
            this.btnCC.Name = "btnCC";
            this.btnCC.Size = new System.Drawing.Size(89, 36);
            this.btnCC.TabIndex = 16;
            this.btnCC.Text = "Circunferencias Concéntricas";
            this.btnCC.UseVisualStyleBackColor = true;
            this.btnCC.Click += new System.EventHandler(this.btnCC_Click);
            // 
            // btnShowAxis
            // 
            this.btnShowAxis.Image = global::CC.Properties.Resources.eye;
            this.btnShowAxis.Location = new System.Drawing.Point(12, 19);
            this.btnShowAxis.Name = "btnShowAxis";
            this.btnShowAxis.Size = new System.Drawing.Size(30, 30);
            this.btnShowAxis.TabIndex = 15;
            this.toolTip.SetToolTip(this.btnShowAxis, "Dibujar Ejes");
            this.btnShowAxis.UseVisualStyleBackColor = true;
            this.btnShowAxis.Click += new System.EventHandler(this.btnShowAxis_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Taylor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnColor
            // 
            this.btnColor.AutoSize = true;
            this.btnColor.Image = global::CC.Properties.Resources.paint;
            this.btnColor.Location = new System.Drawing.Point(48, 19);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(30, 30);
            this.btnColor.TabIndex = 10;
            this.toolTip.SetToolTip(this.btnColor, "Cambiar de color");
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnCurva2
            // 
            this.btnCurva2.Location = new System.Drawing.Point(150, 48);
            this.btnCurva2.Name = "btnCurva2";
            this.btnCurva2.Size = new System.Drawing.Size(47, 23);
            this.btnCurva2.TabIndex = 9;
            this.btnCurva2.Text = "Espiral";
            this.btnCurva2.UseVisualStyleBackColor = true;
            this.btnCurva2.Click += new System.EventHandler(this.btnCurva2_Click);
            // 
            // btnCurva1
            // 
            this.btnCurva1.Location = new System.Drawing.Point(97, 48);
            this.btnCurva1.Name = "btnCurva1";
            this.btnCurva1.Size = new System.Drawing.Size(50, 23);
            this.btnCurva1.TabIndex = 8;
            this.btnCurva1.Text = "Lazo";
            this.btnCurva1.UseVisualStyleBackColor = true;
            this.btnCurva1.Click += new System.EventHandler(this.btnCurva1_Click);
            // 
            // btnCirculo
            // 
            this.btnCirculo.Location = new System.Drawing.Point(6, 48);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(89, 23);
            this.btnCirculo.TabIndex = 7;
            this.btnCirculo.Text = "Circunferencia";
            this.btnCirculo.UseVisualStyleBackColor = true;
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // btnVector
            // 
            this.btnVector.Location = new System.Drawing.Point(60, 19);
            this.btnVector.Name = "btnVector";
            this.btnVector.Size = new System.Drawing.Size(46, 23);
            this.btnVector.TabIndex = 6;
            this.btnVector.Text = "Vector";
            this.btnVector.UseVisualStyleBackColor = true;
            this.btnVector.Click += new System.EventHandler(this.btnVector_Click);
            // 
            // btnPixel
            // 
            this.btnPixel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPixel.Location = new System.Drawing.Point(6, 19);
            this.btnPixel.Name = "btnPixel";
            this.btnPixel.Size = new System.Drawing.Size(48, 23);
            this.btnPixel.TabIndex = 5;
            this.btnPixel.Text = "Pixel";
            this.btnPixel.UseVisualStyleBackColor = true;
            this.btnPixel.Click += new System.EventHandler(this.btnPixel_Click);
            // 
            // btnSegmento
            // 
            this.btnSegmento.Location = new System.Drawing.Point(112, 19);
            this.btnSegmento.Name = "btnSegmento";
            this.btnSegmento.Size = new System.Drawing.Size(68, 23);
            this.btnSegmento.TabIndex = 4;
            this.btnSegmento.Text = "Segmento";
            this.btnSegmento.UseVisualStyleBackColor = true;
            this.btnSegmento.Click += new System.EventHandler(this.btnSegmento_Click);
            // 
            // btnClear
            // 
            this.btnClear.Image = global::CC.Properties.Resources.trash;
            this.btnClear.Location = new System.Drawing.Point(84, 19);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(30, 30);
            this.btnClear.TabIndex = 1;
            this.toolTip.SetToolTip(this.btnClear, "Borrar contenido");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ventana);
            this.groupBox2.Location = new System.Drawing.Point(218, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(713, 566);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gráfico";
            // 
            // ventana
            // 
            this.ventana.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ventana.Location = new System.Drawing.Point(6, 19);
            this.ventana.Name = "ventana";
            this.ventana.Size = new System.Drawing.Size(700, 540);
            this.ventana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ventana.TabIndex = 0;
            this.ventana.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.verToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(943, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.defaultToolStripMenuItem.Text = "Default";
            // 
            // btnScanUni
            // 
            this.btnScanUni.Location = new System.Drawing.Point(6, 119);
            this.btnScanUni.Name = "btnScanUni";
            this.btnScanUni.Size = new System.Drawing.Size(60, 41);
            this.btnScanUni.TabIndex = 20;
            this.btnScanUni.Text = "Barrido unicolor";
            this.btnScanUni.UseVisualStyleBackColor = true;
            this.btnScanUni.Click += new System.EventHandler(this.btnScanUni_Click);
            // 
            // btnScanBi
            // 
            this.btnScanBi.Location = new System.Drawing.Point(125, 135);
            this.btnScanBi.Name = "btnScanBi";
            this.btnScanBi.Size = new System.Drawing.Size(55, 41);
            this.btnScanBi.TabIndex = 21;
            this.btnScanBi.Text = "Barrido bicolor";
            this.btnScanBi.UseVisualStyleBackColor = true;
            this.btnScanBi.Click += new System.EventHandler(this.btnScanBi_Click);
            // 
            // btnScanRGB
            // 
            this.btnScanRGB.Location = new System.Drawing.Point(6, 164);
            this.btnScanRGB.Name = "btnScanRGB";
            this.btnScanRGB.Size = new System.Drawing.Size(76, 50);
            this.btnScanRGB.TabIndex = 22;
            this.btnScanRGB.Text = "Barrido Interpolación RGB";
            this.btnScanRGB.UseVisualStyleBackColor = true;
            this.btnScanRGB.Click += new System.EventHandler(this.btnScanRGB_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnColor);
            this.groupBox3.Controls.Add(this.btnClear);
            this.groupBox3.Controls.Add(this.btnShowAxis);
            this.groupBox3.Location = new System.Drawing.Point(9, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 57);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opciones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(943, 600);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Gráficos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ventana)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox ventana;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSegmento;
        private System.Windows.Forms.Button btnPixel;
        private System.Windows.Forms.Button btnVector;
        private System.Windows.Forms.Button btnCirculo;
        private System.Windows.Forms.Button btnCurva2;
        private System.Windows.Forms.Button btnCurva1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnShowAxis;
        private System.Windows.Forms.Button btnCC;
        private System.Windows.Forms.Button bttnL;
        private System.Windows.Forms.Button btnInter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.Button btnScanUni;
        private System.Windows.Forms.Button btnScanBi;
        private System.Windows.Forms.Button btnScanRGB;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

