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
            this.btnDraw = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rtbPaletaOnda = new System.Windows.Forms.RadioButton();
            this.rbtPaleta0 = new System.Windows.Forms.RadioButton();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.btnAnimacion = new System.Windows.Forms.Button();
            this.btnShowAxis = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.ventana = new System.Windows.Forms.PictureBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FiguraPixel = new System.Windows.Forms.ToolStripMenuItem();
            this.FiguraVector = new System.Windows.Forms.ToolStripMenuItem();
            this.FiguraSegmento = new System.Windows.Forms.ToolStripMenuItem();
            this.FiguraCirculo = new System.Windows.Forms.ToolStripMenuItem();
            this.FiguraConcentrica = new System.Windows.Forms.ToolStripMenuItem();
            this.FiguraLazo = new System.Windows.Forms.ToolStripMenuItem();
            this.FiguraEspiral = new System.Windows.Forms.ToolStripMenuItem();
            this.FiguraTaylor = new System.Windows.Forms.ToolStripMenuItem();
            this.FiguraLagrange = new System.Windows.Forms.ToolStripMenuItem();
            this.FiguraInterpolacion = new System.Windows.Forms.ToolStripMenuItem();
            this.FiguraParabola = new System.Windows.Forms.ToolStripMenuItem();
            this.animaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemAnimationDiagonal = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemAnimationLinealX = new System.Windows.Forms.ToolStripMenuItem();
            this.ej3NoImplementadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemAnimationParabola = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemAnimationEspiral = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemAnimationCarretera = new System.Windows.Forms.ToolStripMenuItem();
            this.texturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TexturaUnicolor = new System.Windows.Forms.ToolStripMenuItem();
            this.TexturaBicolor = new System.Windows.Forms.ToolStripMenuItem();
            this.TexturaDegradado1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TexturaDegradado2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tapeteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tapete1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Tapete2 = new System.Windows.Forms.ToolStripMenuItem();
            this.TapeteInvierno = new System.Windows.Forms.ToolStripMenuItem();
            this.TapeteVerano = new System.Windows.Forms.ToolStripMenuItem();
            this.TapeteOtonno = new System.Windows.Forms.ToolStripMenuItem();
            this.TapetePrimavera = new System.Windows.Forms.ToolStripMenuItem();
            this.TexturaMadera = new System.Windows.Forms.ToolStripMenuItem();
            this.TexturaCesped = new System.Windows.Forms.ToolStripMenuItem();
            this.TexturaPiedra = new System.Windows.Forms.ToolStripMenuItem();
            this.figuras3DToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Figura3DCirculo = new System.Windows.Forms.ToolStripMenuItem();
            this.Figura3DEspiral = new System.Windows.Forms.ToolStripMenuItem();
            this.animacionOnda = new System.Windows.Forms.ToolStripMenuItem();
            this.AniOnda = new System.Windows.Forms.ToolStripMenuItem();
            this.AniOnda3D = new System.Windows.Forms.ToolStripMenuItem();
            this.OndaInterferencia3D = new System.Windows.Forms.ToolStripMenuItem();
            this.Onda = new System.Windows.Forms.ToolStripMenuItem();
            this.ondaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.OndaOrigen = new System.Windows.Forms.ToolStripMenuItem();
            this.OndaInterferencia2 = new System.Windows.Forms.ToolStripMenuItem();
            this.OndaInterferencia3 = new System.Windows.Forms.ToolStripMenuItem();
            this.Onda3D = new System.Windows.Forms.ToolStripMenuItem();
            this.Onda2SinInter = new System.Windows.Forms.ToolStripMenuItem();
            this.Onda2ConInter = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cuerdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuerda2D = new System.Windows.Forms.ToolStripMenuItem();
            this.cuerda3D = new System.Windows.Forms.ToolStripMenuItem();
            this.fuerza = new System.Windows.Forms.ToolStripMenuItem();
            this.animaciónCuerdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AniCuerda2D = new System.Windows.Forms.ToolStripMenuItem();
            this.AniCuerda3D = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventana)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDraw);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.rtbPaletaOnda);
            this.groupBox1.Controls.Add(this.rbtPaleta0);
            this.groupBox1.Controls.Add(this.btnDibujar);
            this.groupBox1.Controls.Add(this.btnAnimacion);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 316);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(35, 167);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(121, 49);
            this.btnDraw.TabIndex = 48;
            this.btnDraw.Text = "button1";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBox1.Location = new System.Drawing.Point(35, 250);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 47;
            // 
            // rtbPaletaOnda
            // 
            this.rtbPaletaOnda.AutoSize = true;
            this.rtbPaletaOnda.Location = new System.Drawing.Point(109, 40);
            this.rtbPaletaOnda.Name = "rtbPaletaOnda";
            this.rtbPaletaOnda.Size = new System.Drawing.Size(84, 17);
            this.rtbPaletaOnda.TabIndex = 46;
            this.rtbPaletaOnda.TabStop = true;
            this.rtbPaletaOnda.Text = "Paleta Onda";
            this.rtbPaletaOnda.UseVisualStyleBackColor = true;
            this.rtbPaletaOnda.CheckedChanged += new System.EventHandler(this.rtbPaletaOnda_CheckedChanged);
            // 
            // rbtPaleta0
            // 
            this.rbtPaleta0.AutoSize = true;
            this.rbtPaleta0.Location = new System.Drawing.Point(109, 19);
            this.rbtPaleta0.Name = "rbtPaleta0";
            this.rbtPaleta0.Size = new System.Drawing.Size(64, 17);
            this.rbtPaleta0.TabIndex = 45;
            this.rbtPaleta0.TabStop = true;
            this.rbtPaleta0.Text = "Paleta 0";
            this.rbtPaleta0.UseVisualStyleBackColor = true;
            this.rbtPaleta0.CheckedChanged += new System.EventHandler(this.rbtPaleta0_CheckedChanged);
            // 
            // btnDibujar
            // 
            this.btnDibujar.Location = new System.Drawing.Point(35, 76);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(75, 23);
            this.btnDibujar.TabIndex = 32;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // btnAnimacion
            // 
            this.btnAnimacion.Location = new System.Drawing.Point(35, 114);
            this.btnAnimacion.Name = "btnAnimacion";
            this.btnAnimacion.Size = new System.Drawing.Size(75, 23);
            this.btnAnimacion.TabIndex = 29;
            this.btnAnimacion.Text = "Animacion";
            this.btnAnimacion.UseVisualStyleBackColor = true;
            this.btnAnimacion.Click += new System.EventHandler(this.btnAnimacion_Click);
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
            this.ventana.Click += new System.EventHandler(this.ventana_Click);
            this.ventana.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ventana_MouseMove);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verToolStripMenuItem,
            this.animaciónToolStripMenuItem,
            this.texturasToolStripMenuItem,
            this.figuras3DToolStripMenuItem1,
            this.animacionOnda,
            this.Onda,
            this.cuerdaToolStripMenuItem,
            this.animaciónCuerdaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(975, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FiguraPixel,
            this.FiguraVector,
            this.FiguraSegmento,
            this.FiguraCirculo,
            this.FiguraConcentrica,
            this.FiguraLazo,
            this.FiguraEspiral,
            this.FiguraTaylor,
            this.FiguraLagrange,
            this.FiguraInterpolacion,
            this.FiguraParabola});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.verToolStripMenuItem.Text = "Figuras 2D";
            // 
            // FiguraPixel
            // 
            this.FiguraPixel.Name = "FiguraPixel";
            this.FiguraPixel.Size = new System.Drawing.Size(147, 22);
            this.FiguraPixel.Text = "Pixel Random";
            this.FiguraPixel.Click += new System.EventHandler(this.FiguraPixel_Click);
            // 
            // FiguraVector
            // 
            this.FiguraVector.Name = "FiguraVector";
            this.FiguraVector.Size = new System.Drawing.Size(147, 22);
            this.FiguraVector.Text = "Vector";
            this.FiguraVector.Click += new System.EventHandler(this.FiguraVector_Click);
            // 
            // FiguraSegmento
            // 
            this.FiguraSegmento.Name = "FiguraSegmento";
            this.FiguraSegmento.Size = new System.Drawing.Size(147, 22);
            this.FiguraSegmento.Text = "Segmento";
            this.FiguraSegmento.Click += new System.EventHandler(this.FiguraSegmento_Click);
            // 
            // FiguraCirculo
            // 
            this.FiguraCirculo.Name = "FiguraCirculo";
            this.FiguraCirculo.Size = new System.Drawing.Size(147, 22);
            this.FiguraCirculo.Text = "Círculo";
            this.FiguraCirculo.Click += new System.EventHandler(this.FiguraCirculo_Click);
            // 
            // FiguraConcentrica
            // 
            this.FiguraConcentrica.Name = "FiguraConcentrica";
            this.FiguraConcentrica.Size = new System.Drawing.Size(147, 22);
            this.FiguraConcentrica.Text = "Concéntricas";
            this.FiguraConcentrica.Click += new System.EventHandler(this.FiguraConcentrica_Click);
            // 
            // FiguraLazo
            // 
            this.FiguraLazo.Name = "FiguraLazo";
            this.FiguraLazo.Size = new System.Drawing.Size(147, 22);
            this.FiguraLazo.Text = "Lazo";
            this.FiguraLazo.Click += new System.EventHandler(this.FiguraLazo_Click);
            // 
            // FiguraEspiral
            // 
            this.FiguraEspiral.Name = "FiguraEspiral";
            this.FiguraEspiral.Size = new System.Drawing.Size(147, 22);
            this.FiguraEspiral.Text = "Espiral";
            this.FiguraEspiral.Click += new System.EventHandler(this.FiguraEspiral_Click);
            // 
            // FiguraTaylor
            // 
            this.FiguraTaylor.Name = "FiguraTaylor";
            this.FiguraTaylor.Size = new System.Drawing.Size(147, 22);
            this.FiguraTaylor.Text = "Taylor";
            this.FiguraTaylor.Click += new System.EventHandler(this.FiguraTaylor_Click);
            // 
            // FiguraLagrange
            // 
            this.FiguraLagrange.Name = "FiguraLagrange";
            this.FiguraLagrange.Size = new System.Drawing.Size(147, 22);
            this.FiguraLagrange.Text = "Lagrange";
            this.FiguraLagrange.Click += new System.EventHandler(this.FiguraLagrange_Click);
            // 
            // FiguraInterpolacion
            // 
            this.FiguraInterpolacion.Name = "FiguraInterpolacion";
            this.FiguraInterpolacion.Size = new System.Drawing.Size(147, 22);
            this.FiguraInterpolacion.Text = "Interpolación";
            this.FiguraInterpolacion.Click += new System.EventHandler(this.FiguraInterpolacion_Click);
            // 
            // FiguraParabola
            // 
            this.FiguraParabola.Name = "FiguraParabola";
            this.FiguraParabola.Size = new System.Drawing.Size(147, 22);
            this.FiguraParabola.Text = "Parábola";
            this.FiguraParabola.Click += new System.EventHandler(this.FiguraParabola_Click);
            // 
            // animaciónToolStripMenuItem
            // 
            this.animaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemAnimationDiagonal,
            this.ItemAnimationLinealX,
            this.ej3NoImplementadoToolStripMenuItem,
            this.ItemAnimationParabola,
            this.ItemAnimationEspiral,
            this.ItemAnimationCarretera});
            this.animaciónToolStripMenuItem.Name = "animaciónToolStripMenuItem";
            this.animaciónToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.animaciónToolStripMenuItem.Text = "Animación 2D";
            // 
            // ItemAnimationDiagonal
            // 
            this.ItemAnimationDiagonal.Name = "ItemAnimationDiagonal";
            this.ItemAnimationDiagonal.Size = new System.Drawing.Size(189, 22);
            this.ItemAnimationDiagonal.Text = "Diagonal";
            this.ItemAnimationDiagonal.Click += new System.EventHandler(this.ItemAnimationDiagonal_Click);
            // 
            // ItemAnimationLinealX
            // 
            this.ItemAnimationLinealX.Name = "ItemAnimationLinealX";
            this.ItemAnimationLinealX.Size = new System.Drawing.Size(189, 22);
            this.ItemAnimationLinealX.Text = "Lineal X";
            this.ItemAnimationLinealX.Click += new System.EventHandler(this.ItemAnimationLinealX_Click);
            // 
            // ej3NoImplementadoToolStripMenuItem
            // 
            this.ej3NoImplementadoToolStripMenuItem.Name = "ej3NoImplementadoToolStripMenuItem";
            this.ej3NoImplementadoToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.ej3NoImplementadoToolStripMenuItem.Text = "Ej3 No implementado";
            // 
            // ItemAnimationParabola
            // 
            this.ItemAnimationParabola.Name = "ItemAnimationParabola";
            this.ItemAnimationParabola.Size = new System.Drawing.Size(189, 22);
            this.ItemAnimationParabola.Text = "Parabola";
            this.ItemAnimationParabola.Click += new System.EventHandler(this.ItemAnimationParabola_Click);
            // 
            // ItemAnimationEspiral
            // 
            this.ItemAnimationEspiral.Name = "ItemAnimationEspiral";
            this.ItemAnimationEspiral.Size = new System.Drawing.Size(189, 22);
            this.ItemAnimationEspiral.Text = "Espiral";
            this.ItemAnimationEspiral.Click += new System.EventHandler(this.ItemAnimationEspiral_Click);
            // 
            // ItemAnimationCarretera
            // 
            this.ItemAnimationCarretera.Name = "ItemAnimationCarretera";
            this.ItemAnimationCarretera.Size = new System.Drawing.Size(189, 22);
            this.ItemAnimationCarretera.Text = "Carretera (No funca)";
            this.ItemAnimationCarretera.Click += new System.EventHandler(this.ItemAnimationCarretera_Click);
            // 
            // texturasToolStripMenuItem
            // 
            this.texturasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TexturaUnicolor,
            this.TexturaBicolor,
            this.TexturaDegradado1,
            this.TexturaDegradado2,
            this.tapeteToolStripMenuItem,
            this.TexturaMadera,
            this.TexturaCesped,
            this.TexturaPiedra});
            this.texturasToolStripMenuItem.Name = "texturasToolStripMenuItem";
            this.texturasToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.texturasToolStripMenuItem.Text = "Texturas";
            // 
            // TexturaUnicolor
            // 
            this.TexturaUnicolor.Name = "TexturaUnicolor";
            this.TexturaUnicolor.Size = new System.Drawing.Size(180, 22);
            this.TexturaUnicolor.Text = "UniColor";
            this.TexturaUnicolor.Click += new System.EventHandler(this.TexturaUnicolor_Click);
            // 
            // TexturaBicolor
            // 
            this.TexturaBicolor.Name = "TexturaBicolor";
            this.TexturaBicolor.Size = new System.Drawing.Size(180, 22);
            this.TexturaBicolor.Text = "Bicolor";
            this.TexturaBicolor.Click += new System.EventHandler(this.TexturaBicolor_Click);
            // 
            // TexturaDegradado1
            // 
            this.TexturaDegradado1.Name = "TexturaDegradado1";
            this.TexturaDegradado1.Size = new System.Drawing.Size(180, 22);
            this.TexturaDegradado1.Text = "1º Degradado";
            this.TexturaDegradado1.Click += new System.EventHandler(this.TexturaDegradado1_Click);
            // 
            // TexturaDegradado2
            // 
            this.TexturaDegradado2.Name = "TexturaDegradado2";
            this.TexturaDegradado2.Size = new System.Drawing.Size(180, 22);
            this.TexturaDegradado2.Text = "2º Degradado";
            this.TexturaDegradado2.Click += new System.EventHandler(this.TexturaDegradado2_Click);
            // 
            // tapeteToolStripMenuItem
            // 
            this.tapeteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tapete1,
            this.Tapete2,
            this.TapeteInvierno,
            this.TapeteVerano,
            this.TapeteOtonno,
            this.TapetePrimavera});
            this.tapeteToolStripMenuItem.Name = "tapeteToolStripMenuItem";
            this.tapeteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tapeteToolStripMenuItem.Text = "Tapete";
            // 
            // Tapete1
            // 
            this.Tapete1.Name = "Tapete1";
            this.Tapete1.Size = new System.Drawing.Size(127, 22);
            this.Tapete1.Text = "Ejemplo 1";
            this.Tapete1.Click += new System.EventHandler(this.Tapete1_Click);
            // 
            // Tapete2
            // 
            this.Tapete2.Name = "Tapete2";
            this.Tapete2.Size = new System.Drawing.Size(127, 22);
            this.Tapete2.Text = "Ejemplo 2";
            this.Tapete2.Click += new System.EventHandler(this.Tapete2_Click);
            // 
            // TapeteInvierno
            // 
            this.TapeteInvierno.Name = "TapeteInvierno";
            this.TapeteInvierno.Size = new System.Drawing.Size(127, 22);
            this.TapeteInvierno.Text = "Invierno";
            this.TapeteInvierno.Click += new System.EventHandler(this.TapeteInvierno_Click);
            // 
            // TapeteVerano
            // 
            this.TapeteVerano.Name = "TapeteVerano";
            this.TapeteVerano.Size = new System.Drawing.Size(127, 22);
            this.TapeteVerano.Text = "Verano";
            this.TapeteVerano.Click += new System.EventHandler(this.TapeteVerano_Click);
            // 
            // TapeteOtonno
            // 
            this.TapeteOtonno.Name = "TapeteOtonno";
            this.TapeteOtonno.Size = new System.Drawing.Size(127, 22);
            this.TapeteOtonno.Text = "Otoño";
            this.TapeteOtonno.Click += new System.EventHandler(this.TapeteOtonno_Click);
            // 
            // TapetePrimavera
            // 
            this.TapetePrimavera.Name = "TapetePrimavera";
            this.TapetePrimavera.Size = new System.Drawing.Size(127, 22);
            this.TapetePrimavera.Text = "Primavera";
            this.TapetePrimavera.Click += new System.EventHandler(this.TapetePrimavera_Click);
            // 
            // TexturaMadera
            // 
            this.TexturaMadera.Name = "TexturaMadera";
            this.TexturaMadera.Size = new System.Drawing.Size(180, 22);
            this.TexturaMadera.Text = "Madera";
            this.TexturaMadera.Click += new System.EventHandler(this.TexturaMadera_Click);
            // 
            // TexturaCesped
            // 
            this.TexturaCesped.Name = "TexturaCesped";
            this.TexturaCesped.Size = new System.Drawing.Size(180, 22);
            this.TexturaCesped.Text = "Césped";
            this.TexturaCesped.Click += new System.EventHandler(this.TexturaCesped_Click);
            // 
            // TexturaPiedra
            // 
            this.TexturaPiedra.Name = "TexturaPiedra";
            this.TexturaPiedra.Size = new System.Drawing.Size(180, 22);
            this.TexturaPiedra.Text = "Piedra";
            this.TexturaPiedra.Click += new System.EventHandler(this.TexturaPiedra_Click);
            // 
            // figuras3DToolStripMenuItem1
            // 
            this.figuras3DToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Figura3DCirculo,
            this.Figura3DEspiral});
            this.figuras3DToolStripMenuItem1.Name = "figuras3DToolStripMenuItem1";
            this.figuras3DToolStripMenuItem1.Size = new System.Drawing.Size(74, 20);
            this.figuras3DToolStripMenuItem1.Text = "Figuras 3D";
            // 
            // Figura3DCirculo
            // 
            this.Figura3DCirculo.Name = "Figura3DCirculo";
            this.Figura3DCirculo.Size = new System.Drawing.Size(180, 22);
            this.Figura3DCirculo.Text = "Círculo";
            this.Figura3DCirculo.Click += new System.EventHandler(this.Figura3DCirculo_Click);
            // 
            // Figura3DEspiral
            // 
            this.Figura3DEspiral.Name = "Figura3DEspiral";
            this.Figura3DEspiral.Size = new System.Drawing.Size(180, 22);
            this.Figura3DEspiral.Text = "Espiral";
            this.Figura3DEspiral.Click += new System.EventHandler(this.Figura3DEspiral_Click);
            // 
            // animacionOnda
            // 
            this.animacionOnda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AniOnda,
            this.AniOnda3D,
            this.OndaInterferencia3D});
            this.animacionOnda.Name = "animacionOnda";
            this.animacionOnda.Size = new System.Drawing.Size(109, 20);
            this.animacionOnda.Text = "Animación Onda";
            // 
            // AniOnda
            // 
            this.AniOnda.Name = "AniOnda";
            this.AniOnda.Size = new System.Drawing.Size(180, 22);
            this.AniOnda.Text = "Onda";
            this.AniOnda.Click += new System.EventHandler(this.AniOnda_Click);
            // 
            // AniOnda3D
            // 
            this.AniOnda3D.Name = "AniOnda3D";
            this.AniOnda3D.Size = new System.Drawing.Size(180, 22);
            this.AniOnda3D.Text = "Onda 3D";
            this.AniOnda3D.Click += new System.EventHandler(this.AniOnda3D_Click);
            // 
            // OndaInterferencia3D
            // 
            this.OndaInterferencia3D.Name = "OndaInterferencia3D";
            this.OndaInterferencia3D.Size = new System.Drawing.Size(180, 22);
            this.OndaInterferencia3D.Text = "Interferencia 3D";
            this.OndaInterferencia3D.Click += new System.EventHandler(this.OndaInterferencia3D_Click);
            // 
            // Onda
            // 
            this.Onda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ondaToolStripMenuItem1,
            this.OndaOrigen,
            this.OndaInterferencia2,
            this.OndaInterferencia3,
            this.Onda3D,
            this.Onda2SinInter,
            this.Onda2ConInter});
            this.Onda.Name = "Onda";
            this.Onda.Size = new System.Drawing.Size(48, 20);
            this.Onda.Text = "Onda";
            // 
            // ondaToolStripMenuItem1
            // 
            this.ondaToolStripMenuItem1.Name = "ondaToolStripMenuItem1";
            this.ondaToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.ondaToolStripMenuItem1.Text = "Onda";
            this.ondaToolStripMenuItem1.Click += new System.EventHandler(this.ondaToolStripMenuItem1_Click);
            // 
            // OndaOrigen
            // 
            this.OndaOrigen.Name = "OndaOrigen";
            this.OndaOrigen.Size = new System.Drawing.Size(204, 22);
            this.OndaOrigen.Text = "Con diferente origen";
            this.OndaOrigen.Click += new System.EventHandler(this.OndaOrigen_Click);
            // 
            // OndaInterferencia2
            // 
            this.OndaInterferencia2.Name = "OndaInterferencia2";
            this.OndaInterferencia2.Size = new System.Drawing.Size(204, 22);
            this.OndaInterferencia2.Text = "Interferencia 2 ondas";
            this.OndaInterferencia2.Click += new System.EventHandler(this.OndaInterferencia2_Click);
            // 
            // OndaInterferencia3
            // 
            this.OndaInterferencia3.Name = "OndaInterferencia3";
            this.OndaInterferencia3.Size = new System.Drawing.Size(204, 22);
            this.OndaInterferencia3.Text = "Interferencia 3 ondas";
            this.OndaInterferencia3.Click += new System.EventHandler(this.OndaInterferencia3_Click);
            // 
            // Onda3D
            // 
            this.Onda3D.Name = "Onda3D";
            this.Onda3D.Size = new System.Drawing.Size(204, 22);
            this.Onda3D.Text = "Onda 3D";
            this.Onda3D.Click += new System.EventHandler(this.Onda3D_Click);
            // 
            // Onda2SinInter
            // 
            this.Onda2SinInter.Name = "Onda2SinInter";
            this.Onda2SinInter.Size = new System.Drawing.Size(204, 22);
            this.Onda2SinInter.Text = "2 Ondas sin Interferencia";
            this.Onda2SinInter.Click += new System.EventHandler(this.Onda2SinInter_Click);
            // 
            // Onda2ConInter
            // 
            this.Onda2ConInter.Name = "Onda2ConInter";
            this.Onda2ConInter.Size = new System.Drawing.Size(204, 22);
            this.Onda2ConInter.Text = "2 Ondas Interferencia";
            this.Onda2ConInter.Click += new System.EventHandler(this.Onda2ConInter_Click);
            // 
            // cuerdaToolStripMenuItem
            // 
            this.cuerdaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuerda2D,
            this.cuerda3D,
            this.fuerza});
            this.cuerdaToolStripMenuItem.Name = "cuerdaToolStripMenuItem";
            this.cuerdaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.cuerdaToolStripMenuItem.Text = "Cuerda";
            // 
            // cuerda2D
            // 
            this.cuerda2D.Name = "cuerda2D";
            this.cuerda2D.Size = new System.Drawing.Size(180, 22);
            this.cuerda2D.Text = "Cuerda 2D";
            this.cuerda2D.Click += new System.EventHandler(this.cuerda2D_Click);
            // 
            // cuerda3D
            // 
            this.cuerda3D.Name = "cuerda3D";
            this.cuerda3D.Size = new System.Drawing.Size(180, 22);
            this.cuerda3D.Text = "Cuerda 3D";
            this.cuerda3D.Click += new System.EventHandler(this.cuerda3D_Click);
            // 
            // fuerza
            // 
            this.fuerza.Name = "fuerza";
            this.fuerza.Size = new System.Drawing.Size(180, 22);
            this.fuerza.Text = "Fuerza";
            this.fuerza.Click += new System.EventHandler(this.fuerza_Click);
            // 
            // animaciónCuerdaToolStripMenuItem
            // 
            this.animaciónCuerdaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AniCuerda2D,
            this.AniCuerda3D});
            this.animaciónCuerdaToolStripMenuItem.Name = "animaciónCuerdaToolStripMenuItem";
            this.animaciónCuerdaToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.animaciónCuerdaToolStripMenuItem.Text = "Animación Cuerda";
            // 
            // AniCuerda2D
            // 
            this.AniCuerda2D.Name = "AniCuerda2D";
            this.AniCuerda2D.Size = new System.Drawing.Size(180, 22);
            this.AniCuerda2D.Text = "Cuerda 2D";
            this.AniCuerda2D.Click += new System.EventHandler(this.AniCuerda2D_Click);
            // 
            // AniCuerda3D
            // 
            this.AniCuerda3D.Name = "AniCuerda3D";
            this.AniCuerda3D.Size = new System.Drawing.Size(180, 22);
            this.AniCuerda3D.Text = "Cuerda 3D";
            this.AniCuerda3D.Click += new System.EventHandler(this.AniCuerda3D_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(975, 586);
            this.Controls.Add(this.ventana);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Gráficos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventana)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox ventana;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnShowAxis;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.Button btnAnimacion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem animaciónToolStripMenuItem;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.ToolStripMenuItem ItemAnimationDiagonal;
        private System.Windows.Forms.ToolStripMenuItem animacionOnda;
        private System.Windows.Forms.ToolStripMenuItem ItemAnimationLinealX;
        private System.Windows.Forms.ToolStripMenuItem ej3NoImplementadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ItemAnimationParabola;
        private System.Windows.Forms.ToolStripMenuItem ItemAnimationEspiral;
        private System.Windows.Forms.ToolStripMenuItem ItemAnimationCarretera;
        private System.Windows.Forms.RadioButton rtbPaletaOnda;
        private System.Windows.Forms.RadioButton rbtPaleta0;
        private System.Windows.Forms.ToolStripMenuItem figuras3DToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem texturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TexturaBicolor;
        private System.Windows.Forms.ToolStripMenuItem TexturaDegradado1;
        private System.Windows.Forms.ToolStripMenuItem TexturaDegradado2;
        private System.Windows.Forms.ToolStripMenuItem tapeteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tapete1;
        private System.Windows.Forms.ToolStripMenuItem Tapete2;
        private System.Windows.Forms.ToolStripMenuItem TapeteInvierno;
        private System.Windows.Forms.ToolStripMenuItem TapeteVerano;
        private System.Windows.Forms.ToolStripMenuItem TapeteOtonno;
        private System.Windows.Forms.ToolStripMenuItem TexturaUnicolor;
        private System.Windows.Forms.ToolStripMenuItem TexturaMadera;
        private System.Windows.Forms.ToolStripMenuItem TexturaCesped;
        private System.Windows.Forms.ToolStripMenuItem TexturaPiedra;
        private System.Windows.Forms.ToolStripMenuItem TapetePrimavera;
        private System.Windows.Forms.ToolStripMenuItem FiguraPixel;
        private System.Windows.Forms.ToolStripMenuItem FiguraVector;
        private System.Windows.Forms.ToolStripMenuItem FiguraSegmento;
        private System.Windows.Forms.ToolStripMenuItem FiguraCirculo;
        private System.Windows.Forms.ToolStripMenuItem FiguraConcentrica;
        private System.Windows.Forms.ToolStripMenuItem FiguraLazo;
        private System.Windows.Forms.ToolStripMenuItem FiguraEspiral;
        private System.Windows.Forms.ToolStripMenuItem FiguraTaylor;
        private System.Windows.Forms.ToolStripMenuItem FiguraLagrange;
        private System.Windows.Forms.ToolStripMenuItem FiguraInterpolacion;
        private System.Windows.Forms.ToolStripMenuItem FiguraParabola;
        private System.Windows.Forms.ToolStripMenuItem Figura3DCirculo;
        private System.Windows.Forms.ToolStripMenuItem Figura3DEspiral;
        private System.Windows.Forms.ToolStripMenuItem AniOnda;
        private System.Windows.Forms.ToolStripMenuItem AniOnda3D;
        private System.Windows.Forms.ToolStripMenuItem OndaInterferencia3D;
        private System.Windows.Forms.ToolStripMenuItem Onda;
        private System.Windows.Forms.ToolStripMenuItem ondaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem OndaOrigen;
        private System.Windows.Forms.ToolStripMenuItem OndaInterferencia2;
        private System.Windows.Forms.ToolStripMenuItem OndaInterferencia3;
        private System.Windows.Forms.ToolStripMenuItem Onda3D;
        private System.Windows.Forms.ToolStripMenuItem Onda2SinInter;
        private System.Windows.Forms.ToolStripMenuItem Onda2ConInter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.ToolStripMenuItem cuerdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuerda2D;
        private System.Windows.Forms.ToolStripMenuItem cuerda3D;
        private System.Windows.Forms.ToolStripMenuItem fuerza;
        private System.Windows.Forms.ToolStripMenuItem animaciónCuerdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AniCuerda2D;
        private System.Windows.Forms.ToolStripMenuItem AniCuerda3D;
    }
}

