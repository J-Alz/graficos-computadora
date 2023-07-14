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
            this.btnDibujar = new System.Windows.Forms.Button();
            this.btnAnimacion = new System.Windows.Forms.Button();
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
            this.figurasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemFiguraPixelRandom = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemFiguraVector = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemFiguraSegmento = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemFiguraCirculo = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemFiguraConcentrica = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemFiguraLazo = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemFiguraEspiral = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemFiguraTaylor = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemFiguraLagrange = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemFiguraInterpolacion = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemFiguraParabola = new System.Windows.Forms.ToolStripMenuItem();
            this.barridoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemTexturaUniColor = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemTexturaBiColor = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemTextura1Degradado = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemTextura2Degradado = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemTexturaEjemplo1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemTexturaEjemplo2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemTexturaInvierno = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemTexturaPrimavera = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemTexturaVerano = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemTexturaOtonno = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemTexturaMadera = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemTexturaCesped = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemTexturaPiedra = new System.Windows.Forms.ToolStripMenuItem();
            this.figuras3DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Item3DCirculo = new System.Windows.Forms.ToolStripMenuItem();
            this.Item3DEspiral = new System.Windows.Forms.ToolStripMenuItem();
            this.animaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemAnimationDiagonal = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemAnimationLinealX = new System.Windows.Forms.ToolStripMenuItem();
            this.ej3NoImplementadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemAnimationParabola = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemAnimationEspiral = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemAnimationCarretera = new System.Windows.Forms.ToolStripMenuItem();
            this.animación3DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventana)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDibujar);
            this.groupBox1.Controls.Add(this.btnAnimacion);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 338);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // btnDibujar
            // 
            this.btnDibujar.Location = new System.Drawing.Point(51, 76);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(75, 23);
            this.btnDibujar.TabIndex = 32;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // btnAnimacion
            // 
            this.btnAnimacion.Location = new System.Drawing.Point(51, 137);
            this.btnAnimacion.Name = "btnAnimacion";
            this.btnAnimacion.Size = new System.Drawing.Size(75, 23);
            this.btnAnimacion.TabIndex = 29;
            this.btnAnimacion.Text = "Animacion";
            this.btnAnimacion.UseVisualStyleBackColor = true;
            this.btnAnimacion.Click += new System.EventHandler(this.btnAnimacion_Click);
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
            this.verToolStripMenuItem,
            this.animaciónToolStripMenuItem,
            this.animación3DToolStripMenuItem});
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
            this.figurasToolStripMenuItem,
            this.barridoToolStripMenuItem,
            this.figuras3DToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.verToolStripMenuItem.Text = "Dibujar";
            // 
            // figurasToolStripMenuItem
            // 
            this.figurasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemFiguraPixelRandom,
            this.ItemFiguraVector,
            this.ItemFiguraSegmento,
            this.ItemFiguraCirculo,
            this.ItemFiguraConcentrica,
            this.ItemFiguraLazo,
            this.ItemFiguraEspiral,
            this.ItemFiguraTaylor,
            this.ItemFiguraLagrange,
            this.ItemFiguraInterpolacion,
            this.ItemFiguraParabola});
            this.figurasToolStripMenuItem.Name = "figurasToolStripMenuItem";
            this.figurasToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.figurasToolStripMenuItem.Text = "Figuras";
            // 
            // ItemFiguraPixelRandom
            // 
            this.ItemFiguraPixelRandom.Name = "ItemFiguraPixelRandom";
            this.ItemFiguraPixelRandom.Size = new System.Drawing.Size(157, 22);
            this.ItemFiguraPixelRandom.Text = "Pixel Random";
            this.ItemFiguraPixelRandom.Click += new System.EventHandler(this.ItemFiguraPixelRandom_Click);
            // 
            // ItemFiguraVector
            // 
            this.ItemFiguraVector.Name = "ItemFiguraVector";
            this.ItemFiguraVector.Size = new System.Drawing.Size(157, 22);
            this.ItemFiguraVector.Text = "Vector";
            this.ItemFiguraVector.Click += new System.EventHandler(this.ItemFiguraVector_Click);
            // 
            // ItemFiguraSegmento
            // 
            this.ItemFiguraSegmento.Name = "ItemFiguraSegmento";
            this.ItemFiguraSegmento.Size = new System.Drawing.Size(157, 22);
            this.ItemFiguraSegmento.Text = "Segmento";
            this.ItemFiguraSegmento.Click += new System.EventHandler(this.ItemFiguraSegmento_Click);
            // 
            // ItemFiguraCirculo
            // 
            this.ItemFiguraCirculo.Name = "ItemFiguraCirculo";
            this.ItemFiguraCirculo.Size = new System.Drawing.Size(157, 22);
            this.ItemFiguraCirculo.Text = "Círculo";
            this.ItemFiguraCirculo.Click += new System.EventHandler(this.ItemFiguraCirculo_Click);
            // 
            // ItemFiguraConcentrica
            // 
            this.ItemFiguraConcentrica.Name = "ItemFiguraConcentrica";
            this.ItemFiguraConcentrica.Size = new System.Drawing.Size(157, 22);
            this.ItemFiguraConcentrica.Text = "C. Concentricas";
            this.ItemFiguraConcentrica.Click += new System.EventHandler(this.ItemFiguraConcentrica_Click);
            // 
            // ItemFiguraLazo
            // 
            this.ItemFiguraLazo.Name = "ItemFiguraLazo";
            this.ItemFiguraLazo.Size = new System.Drawing.Size(157, 22);
            this.ItemFiguraLazo.Text = "Lazo";
            this.ItemFiguraLazo.Click += new System.EventHandler(this.ItemFiguraLazo_Click);
            // 
            // ItemFiguraEspiral
            // 
            this.ItemFiguraEspiral.Name = "ItemFiguraEspiral";
            this.ItemFiguraEspiral.Size = new System.Drawing.Size(157, 22);
            this.ItemFiguraEspiral.Text = "Espiral";
            this.ItemFiguraEspiral.Click += new System.EventHandler(this.ItemFiguraEspiral_Click);
            // 
            // ItemFiguraTaylor
            // 
            this.ItemFiguraTaylor.Name = "ItemFiguraTaylor";
            this.ItemFiguraTaylor.Size = new System.Drawing.Size(157, 22);
            this.ItemFiguraTaylor.Text = "Taylor";
            this.ItemFiguraTaylor.Click += new System.EventHandler(this.ItemFiguraTaylor_Click);
            // 
            // ItemFiguraLagrange
            // 
            this.ItemFiguraLagrange.Name = "ItemFiguraLagrange";
            this.ItemFiguraLagrange.Size = new System.Drawing.Size(157, 22);
            this.ItemFiguraLagrange.Text = "Lagrange";
            this.ItemFiguraLagrange.Click += new System.EventHandler(this.ItemFiguraLagrange_Click);
            // 
            // ItemFiguraInterpolacion
            // 
            this.ItemFiguraInterpolacion.Name = "ItemFiguraInterpolacion";
            this.ItemFiguraInterpolacion.Size = new System.Drawing.Size(157, 22);
            this.ItemFiguraInterpolacion.Text = "Interpolacion";
            this.ItemFiguraInterpolacion.Click += new System.EventHandler(this.ItemFiguraInterpolacion_Click);
            // 
            // ItemFiguraParabola
            // 
            this.ItemFiguraParabola.Name = "ItemFiguraParabola";
            this.ItemFiguraParabola.Size = new System.Drawing.Size(157, 22);
            this.ItemFiguraParabola.Text = "Parábola";
            this.ItemFiguraParabola.Click += new System.EventHandler(this.ItemFiguraParabola_Click);
            // 
            // barridoToolStripMenuItem
            // 
            this.barridoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemTexturaUniColor,
            this.ItemTexturaBiColor,
            this.ItemTextura1Degradado,
            this.ItemTextura2Degradado,
            this.ItemTexturaEjemplo1,
            this.ItemTexturaEjemplo2,
            this.ItemTexturaInvierno,
            this.ItemTexturaPrimavera,
            this.ItemTexturaVerano,
            this.ItemTexturaOtonno,
            this.ItemTexturaMadera,
            this.ItemTexturaCesped,
            this.ItemTexturaPiedra});
            this.barridoToolStripMenuItem.Name = "barridoToolStripMenuItem";
            this.barridoToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.barridoToolStripMenuItem.Text = "Textura";
            // 
            // ItemTexturaUniColor
            // 
            this.ItemTexturaUniColor.Name = "ItemTexturaUniColor";
            this.ItemTexturaUniColor.Size = new System.Drawing.Size(163, 22);
            this.ItemTexturaUniColor.Text = "UniColor";
            this.ItemTexturaUniColor.Click += new System.EventHandler(this.ItemTexturaUniColor_Click);
            // 
            // ItemTexturaBiColor
            // 
            this.ItemTexturaBiColor.Name = "ItemTexturaBiColor";
            this.ItemTexturaBiColor.Size = new System.Drawing.Size(163, 22);
            this.ItemTexturaBiColor.Text = "Bicolor";
            this.ItemTexturaBiColor.Click += new System.EventHandler(this.ItemTexturaBiColor_Click);
            // 
            // ItemTextura1Degradado
            // 
            this.ItemTextura1Degradado.Name = "ItemTextura1Degradado";
            this.ItemTextura1Degradado.Size = new System.Drawing.Size(163, 22);
            this.ItemTextura1Degradado.Text = "1º Degradado";
            this.ItemTextura1Degradado.Click += new System.EventHandler(this.ItemTextura1Degradado_Click);
            // 
            // ItemTextura2Degradado
            // 
            this.ItemTextura2Degradado.Name = "ItemTextura2Degradado";
            this.ItemTextura2Degradado.Size = new System.Drawing.Size(163, 22);
            this.ItemTextura2Degradado.Text = "2º Degradado";
            this.ItemTextura2Degradado.Click += new System.EventHandler(this.ItemTextura2Degradado_Click);
            // 
            // ItemTexturaEjemplo1
            // 
            this.ItemTexturaEjemplo1.Name = "ItemTexturaEjemplo1";
            this.ItemTexturaEjemplo1.Size = new System.Drawing.Size(163, 22);
            this.ItemTexturaEjemplo1.Text = "Tapete Ejemplo 1";
            this.ItemTexturaEjemplo1.Click += new System.EventHandler(this.ItemTexturaEjemplo1_Click);
            // 
            // ItemTexturaEjemplo2
            // 
            this.ItemTexturaEjemplo2.Name = "ItemTexturaEjemplo2";
            this.ItemTexturaEjemplo2.Size = new System.Drawing.Size(163, 22);
            this.ItemTexturaEjemplo2.Text = "Tapete Ejemplo 2";
            this.ItemTexturaEjemplo2.Click += new System.EventHandler(this.ItemTexturaEjemplo2_Click);
            // 
            // ItemTexturaInvierno
            // 
            this.ItemTexturaInvierno.Name = "ItemTexturaInvierno";
            this.ItemTexturaInvierno.Size = new System.Drawing.Size(163, 22);
            this.ItemTexturaInvierno.Text = "T. Invierno";
            this.ItemTexturaInvierno.Click += new System.EventHandler(this.ItemTexturaInvierno_Click);
            // 
            // ItemTexturaPrimavera
            // 
            this.ItemTexturaPrimavera.Name = "ItemTexturaPrimavera";
            this.ItemTexturaPrimavera.Size = new System.Drawing.Size(163, 22);
            this.ItemTexturaPrimavera.Text = "T. Primavera";
            this.ItemTexturaPrimavera.Click += new System.EventHandler(this.ItemTexturaPrimavera_Click);
            // 
            // ItemTexturaVerano
            // 
            this.ItemTexturaVerano.Name = "ItemTexturaVerano";
            this.ItemTexturaVerano.Size = new System.Drawing.Size(163, 22);
            this.ItemTexturaVerano.Text = "T. Verano";
            this.ItemTexturaVerano.Click += new System.EventHandler(this.ItemTexturaVerano_Click);
            // 
            // ItemTexturaOtonno
            // 
            this.ItemTexturaOtonno.Name = "ItemTexturaOtonno";
            this.ItemTexturaOtonno.Size = new System.Drawing.Size(163, 22);
            this.ItemTexturaOtonno.Text = "T. Otoño";
            this.ItemTexturaOtonno.Click += new System.EventHandler(this.ItemTexturaOtonno_Click);
            // 
            // ItemTexturaMadera
            // 
            this.ItemTexturaMadera.Name = "ItemTexturaMadera";
            this.ItemTexturaMadera.Size = new System.Drawing.Size(163, 22);
            this.ItemTexturaMadera.Text = "Madera";
            this.ItemTexturaMadera.Click += new System.EventHandler(this.ItemTexturaMadera_Click);
            // 
            // ItemTexturaCesped
            // 
            this.ItemTexturaCesped.Name = "ItemTexturaCesped";
            this.ItemTexturaCesped.Size = new System.Drawing.Size(163, 22);
            this.ItemTexturaCesped.Text = "Césped";
            this.ItemTexturaCesped.Click += new System.EventHandler(this.ItemTexturaCesped_Click);
            // 
            // ItemTexturaPiedra
            // 
            this.ItemTexturaPiedra.Name = "ItemTexturaPiedra";
            this.ItemTexturaPiedra.Size = new System.Drawing.Size(163, 22);
            this.ItemTexturaPiedra.Text = "Piedra";
            this.ItemTexturaPiedra.Click += new System.EventHandler(this.ItemTexturaPiedra_Click);
            // 
            // figuras3DToolStripMenuItem
            // 
            this.figuras3DToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Item3DCirculo,
            this.Item3DEspiral});
            this.figuras3DToolStripMenuItem.Name = "figuras3DToolStripMenuItem";
            this.figuras3DToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.figuras3DToolStripMenuItem.Text = "Figuras 3D";
            // 
            // Item3DCirculo
            // 
            this.Item3DCirculo.Name = "Item3DCirculo";
            this.Item3DCirculo.Size = new System.Drawing.Size(112, 22);
            this.Item3DCirculo.Text = "Círculo";
            this.Item3DCirculo.Click += new System.EventHandler(this.Item3DCirculo_Click);
            // 
            // Item3DEspiral
            // 
            this.Item3DEspiral.Name = "Item3DEspiral";
            this.Item3DEspiral.Size = new System.Drawing.Size(112, 22);
            this.Item3DEspiral.Text = "Espiral";
            this.Item3DEspiral.Click += new System.EventHandler(this.Item3DEspiral_Click);
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
            this.animaciónToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.animaciónToolStripMenuItem.Text = "Animación";
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
            // animación3DToolStripMenuItem
            // 
            this.animación3DToolStripMenuItem.Name = "animación3DToolStripMenuItem";
            this.animación3DToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.animación3DToolStripMenuItem.Text = "Animación 3D";
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
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnShowAxis;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbx;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDeleteFigure;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barridoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem figurasToolStripMenuItem;
        private System.Windows.Forms.Button btnAnimacion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem animaciónToolStripMenuItem;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.ToolStripMenuItem ItemFiguraPixelRandom;
        private System.Windows.Forms.ToolStripMenuItem ItemFiguraVector;
        private System.Windows.Forms.ToolStripMenuItem ItemFiguraSegmento;
        private System.Windows.Forms.ToolStripMenuItem ItemFiguraCirculo;
        private System.Windows.Forms.ToolStripMenuItem ItemFiguraConcentrica;
        private System.Windows.Forms.ToolStripMenuItem ItemFiguraLazo;
        private System.Windows.Forms.ToolStripMenuItem ItemFiguraEspiral;
        private System.Windows.Forms.ToolStripMenuItem ItemFiguraParabola;
        private System.Windows.Forms.ToolStripMenuItem ItemFiguraInterpolacion;
        private System.Windows.Forms.ToolStripMenuItem ItemFiguraLagrange;
        private System.Windows.Forms.ToolStripMenuItem ItemFiguraTaylor;
        private System.Windows.Forms.ToolStripMenuItem ItemTexturaUniColor;
        private System.Windows.Forms.ToolStripMenuItem ItemTexturaBiColor;
        private System.Windows.Forms.ToolStripMenuItem ItemTextura1Degradado;
        private System.Windows.Forms.ToolStripMenuItem ItemTextura2Degradado;
        private System.Windows.Forms.ToolStripMenuItem ItemTexturaEjemplo1;
        private System.Windows.Forms.ToolStripMenuItem ItemTexturaEjemplo2;
        private System.Windows.Forms.ToolStripMenuItem ItemTexturaInvierno;
        private System.Windows.Forms.ToolStripMenuItem ItemTexturaPrimavera;
        private System.Windows.Forms.ToolStripMenuItem ItemTexturaVerano;
        private System.Windows.Forms.ToolStripMenuItem ItemTexturaOtonno;
        private System.Windows.Forms.ToolStripMenuItem ItemTexturaMadera;
        private System.Windows.Forms.ToolStripMenuItem ItemTexturaCesped;
        private System.Windows.Forms.ToolStripMenuItem ItemTexturaPiedra;
        private System.Windows.Forms.ToolStripMenuItem figuras3DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Item3DCirculo;
        private System.Windows.Forms.ToolStripMenuItem Item3DEspiral;
        private System.Windows.Forms.ToolStripMenuItem ItemAnimationDiagonal;
        private System.Windows.Forms.ToolStripMenuItem animación3DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ItemAnimationLinealX;
        private System.Windows.Forms.ToolStripMenuItem ej3NoImplementadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ItemAnimationParabola;
        private System.Windows.Forms.ToolStripMenuItem ItemAnimationEspiral;
        private System.Windows.Forms.ToolStripMenuItem ItemAnimationCarretera;
    }
}

