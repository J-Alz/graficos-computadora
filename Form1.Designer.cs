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
            this.btnParabola = new System.Windows.Forms.Button();
            this.cbxPaleta = new System.Windows.Forms.ComboBox();
            this.btnInter = new System.Windows.Forms.Button();
            this.bttnL = new System.Windows.Forms.Button();
            this.btnCC = new System.Windows.Forms.Button();
            this.btnTaylor = new System.Windows.Forms.Button();
            this.btnEspiral = new System.Windows.Forms.Button();
            this.btnLazo = new System.Windows.Forms.Button();
            this.btnCirculo = new System.Windows.Forms.Button();
            this.btnVector = new System.Windows.Forms.Button();
            this.btnPixel = new System.Windows.Forms.Button();
            this.btnSegmento = new System.Windows.Forms.Button();
            this.lbx = new System.Windows.Forms.ListBox();
            this.btnShowAxis = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.ventana = new System.Windows.Forms.PictureBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDeleteFigure = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barridoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unicolorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bicolorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FirstDegraded = new System.Windows.Forms.ToolStripMenuItem();
            this.SecondDegraded = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventana)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnParabola);
            this.groupBox1.Controls.Add(this.cbxPaleta);
            this.groupBox1.Controls.Add(this.btnInter);
            this.groupBox1.Controls.Add(this.bttnL);
            this.groupBox1.Controls.Add(this.btnCC);
            this.groupBox1.Controls.Add(this.btnTaylor);
            this.groupBox1.Controls.Add(this.btnEspiral);
            this.groupBox1.Controls.Add(this.btnLazo);
            this.groupBox1.Controls.Add(this.btnCirculo);
            this.groupBox1.Controls.Add(this.btnVector);
            this.groupBox1.Controls.Add(this.btnPixel);
            this.groupBox1.Controls.Add(this.btnSegmento);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 338);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // btnParabola
            // 
            this.btnParabola.Location = new System.Drawing.Point(6, 135);
            this.btnParabola.Name = "btnParabola";
            this.btnParabola.Size = new System.Drawing.Size(75, 23);
            this.btnParabola.TabIndex = 26;
            this.btnParabola.Text = "Parabola";
            this.btnParabola.UseVisualStyleBackColor = true;
            this.btnParabola.Click += new System.EventHandler(this.btnParabola_Click);
            // 
            // cbxPaleta
            // 
            this.cbxPaleta.FormattingEnabled = true;
            this.cbxPaleta.Items.AddRange(new object[] {
            "Otoño",
            "Invierno",
            "Primavera",
            "Verano",
            "Modificada",
            "Madera",
            "Otros"});
            this.cbxPaleta.Location = new System.Drawing.Point(6, 311);
            this.cbxPaleta.Name = "cbxPaleta";
            this.cbxPaleta.Size = new System.Drawing.Size(121, 21);
            this.cbxPaleta.TabIndex = 25;
            this.cbxPaleta.Text = "Tapetes";
            this.cbxPaleta.SelectedIndexChanged += new System.EventHandler(this.cbxPaleta_SelectedIndexChanged);
            // 
            // btnInter
            // 
            this.btnInter.Location = new System.Drawing.Point(6, 211);
            this.btnInter.Name = "btnInter";
            this.btnInter.Size = new System.Drawing.Size(84, 23);
            this.btnInter.TabIndex = 18;
            this.btnInter.Text = "Interpolacion";
            this.btnInter.UseVisualStyleBackColor = true;
            this.btnInter.Click += new System.EventHandler(this.btnInter_Click);
            // 
            // bttnL
            // 
            this.bttnL.Location = new System.Drawing.Point(6, 240);
            this.bttnL.Name = "bttnL";
            this.bttnL.Size = new System.Drawing.Size(84, 23);
            this.bttnL.TabIndex = 17;
            this.bttnL.Text = "Lagrange";
            this.bttnL.UseVisualStyleBackColor = true;
            this.bttnL.Click += new System.EventHandler(this.bttnL_Click);
            // 
            // btnCC
            // 
            this.btnCC.Location = new System.Drawing.Point(6, 269);
            this.btnCC.Name = "btnCC";
            this.btnCC.Size = new System.Drawing.Size(89, 36);
            this.btnCC.TabIndex = 16;
            this.btnCC.Text = "Circunferencias Concéntricas";
            this.btnCC.UseVisualStyleBackColor = true;
            this.btnCC.Click += new System.EventHandler(this.btnCC_Click);
            // 
            // btnTaylor
            // 
            this.btnTaylor.Location = new System.Drawing.Point(109, 253);
            this.btnTaylor.Name = "btnTaylor";
            this.btnTaylor.Size = new System.Drawing.Size(47, 23);
            this.btnTaylor.TabIndex = 13;
            this.btnTaylor.Text = "Taylor";
            this.btnTaylor.UseVisualStyleBackColor = true;
            this.btnTaylor.Click += new System.EventHandler(this.btnTaylor_Click);
            // 
            // btnEspiral
            // 
            this.btnEspiral.Location = new System.Drawing.Point(112, 224);
            this.btnEspiral.Name = "btnEspiral";
            this.btnEspiral.Size = new System.Drawing.Size(47, 23);
            this.btnEspiral.TabIndex = 9;
            this.btnEspiral.Text = "Espiral";
            this.btnEspiral.UseVisualStyleBackColor = true;
            this.btnEspiral.Click += new System.EventHandler(this.btnEspiral_Click);
            // 
            // btnLazo
            // 
            this.btnLazo.Location = new System.Drawing.Point(109, 282);
            this.btnLazo.Name = "btnLazo";
            this.btnLazo.Size = new System.Drawing.Size(50, 23);
            this.btnLazo.TabIndex = 8;
            this.btnLazo.Text = "Lazo";
            this.btnLazo.UseVisualStyleBackColor = true;
            this.btnLazo.Click += new System.EventHandler(this.btnLazo_Click);
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
            // lbx
            // 
            this.lbx.FormattingEnabled = true;
            this.lbx.Location = new System.Drawing.Point(9, 19);
            this.lbx.Name = "lbx";
            this.lbx.Size = new System.Drawing.Size(138, 134);
            this.lbx.TabIndex = 26;
            this.lbx.SelectedIndexChanged += new System.EventHandler(this.lbx_SelectedIndexChanged);
            // 
            // btnShowAxis
            // 
            this.btnShowAxis.Image = global::CC.Properties.Resources.eye;
            this.btnShowAxis.Location = new System.Drawing.Point(6, 19);
            this.btnShowAxis.Name = "btnShowAxis";
            this.btnShowAxis.Size = new System.Drawing.Size(30, 30);
            this.btnShowAxis.TabIndex = 15;
            this.toolTip.SetToolTip(this.btnShowAxis, "Dibujar Ejes");
            this.btnShowAxis.UseVisualStyleBackColor = true;
            this.btnShowAxis.Click += new System.EventHandler(this.btnShowAxis_Click);
            // 
            // btnColor
            // 
            this.btnColor.AutoSize = true;
            this.btnColor.Image = global::CC.Properties.Resources.paint;
            this.btnColor.Location = new System.Drawing.Point(6, 55);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(30, 30);
            this.btnColor.TabIndex = 10;
            this.toolTip.SetToolTip(this.btnColor, "Cambiar de color");
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnClear
            // 
            this.btnClear.Image = global::CC.Properties.Resources.trash;
            this.btnClear.Location = new System.Drawing.Point(6, 91);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(30, 30);
            this.btnClear.TabIndex = 1;
            this.toolTip.SetToolTip(this.btnClear, "Borrar contenido");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ventana
            // 
            this.ventana.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ventana.Location = new System.Drawing.Point(218, 34);
            this.ventana.Name = "ventana";
            this.ventana.Size = new System.Drawing.Size(700, 540);
            this.ventana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ventana.TabIndex = 0;
            this.ventana.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnColor);
            this.groupBox3.Controls.Add(this.btnClear);
            this.groupBox3.Controls.Add(this.btnShowAxis);
            this.groupBox3.Location = new System.Drawing.Point(924, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(42, 540);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDeleteFigure);
            this.groupBox4.Controls.Add(this.lbx);
            this.groupBox4.Location = new System.Drawing.Point(9, 378);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 196);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lista de elementos";
            // 
            // btnDeleteFigure
            // 
            this.btnDeleteFigure.Image = global::CC.Properties.Resources.trash;
            this.btnDeleteFigure.Location = new System.Drawing.Point(160, 19);
            this.btnDeleteFigure.Name = "btnDeleteFigure";
            this.btnDeleteFigure.Size = new System.Drawing.Size(30, 30);
            this.btnDeleteFigure.TabIndex = 5;
            this.btnDeleteFigure.UseVisualStyleBackColor = true;
            this.btnDeleteFigure.Click += new System.EventHandler(this.btnDeleteFigure_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.verToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(975, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barridoToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // barridoToolStripMenuItem
            // 
            this.barridoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unicolorToolStripMenuItem,
            this.bicolorToolStripMenuItem,
            this.FirstDegraded,
            this.SecondDegraded});
            this.barridoToolStripMenuItem.Name = "barridoToolStripMenuItem";
            this.barridoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.barridoToolStripMenuItem.Text = "Barrido";
            // 
            // unicolorToolStripMenuItem
            // 
            this.unicolorToolStripMenuItem.Name = "unicolorToolStripMenuItem";
            this.unicolorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.unicolorToolStripMenuItem.Text = "Unicolor";
            this.unicolorToolStripMenuItem.Click += new System.EventHandler(this.unicolorToolStripMenuItem_Click);
            // 
            // bicolorToolStripMenuItem
            // 
            this.bicolorToolStripMenuItem.Name = "bicolorToolStripMenuItem";
            this.bicolorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bicolorToolStripMenuItem.Text = "Bicolor";
            this.bicolorToolStripMenuItem.Click += new System.EventHandler(this.bicolorToolStripMenuItem_Click);
            // 
            // FirstDegraded
            // 
            this.FirstDegraded.Name = "FirstDegraded";
            this.FirstDegraded.Size = new System.Drawing.Size(180, 22);
            this.FirstDegraded.Text = "1º Degradado";
            this.FirstDegraded.Click += new System.EventHandler(this.FirstDegraded_Click);
            // 
            // SecondDegraded
            // 
            this.SecondDegraded.Name = "SecondDegraded";
            this.SecondDegraded.Size = new System.Drawing.Size(180, 22);
            this.SecondDegraded.Text = "2º Degradado";
            this.SecondDegraded.Click += new System.EventHandler(this.SecondDegraded_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(975, 586);
            this.Controls.Add(this.ventana);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Gráficos";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ventana)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox ventana;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSegmento;
        private System.Windows.Forms.Button btnPixel;
        private System.Windows.Forms.Button btnVector;
        private System.Windows.Forms.Button btnCirculo;
        private System.Windows.Forms.Button btnEspiral;
        private System.Windows.Forms.Button btnLazo;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btnTaylor;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnShowAxis;
        private System.Windows.Forms.Button btnCC;
        private System.Windows.Forms.Button bttnL;
        private System.Windows.Forms.Button btnInter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbx;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDeleteFigure;
        private System.Windows.Forms.ComboBox cbxPaleta;
        private System.Windows.Forms.Button btnParabola;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barridoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unicolorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bicolorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FirstDegraded;
        private System.Windows.Forms.ToolStripMenuItem SecondDegraded;
    }
}

