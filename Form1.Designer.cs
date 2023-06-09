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
            this.básicoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemFiguraPixelRandom = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemFiguraVector = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemFiguraSegmento = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemFiguraCircunferencia = new System.Windows.Forms.ToolStripMenuItem();
            this.avanzadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemFiguraConcentricas = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemFiguraLazo = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemFiguraEspiral = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemFiguraParabola = new System.Windows.Forms.ToolStripMenuItem();
            this.barridoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.básicoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemTexturaUniColor = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemTexturaBiColor = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemTexturaDegradado1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemTexturaDegradado2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tapeteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemTexturaEjemplo1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemTexturaEjemplo2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemTexturaInvierno = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemTexturaPrimavera = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemTexturaVerano = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemTexturaOtonno = new System.Windows.Forms.ToolStripMenuItem();
            this.proceduralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemTexturaMadera = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemTexturaCesped = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemTexturaPiedra = new System.Windows.Forms.ToolStripMenuItem();
            this.interpolaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interpolaciónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lagrangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taylorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ItemAnimacionEjemplo1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemAnimacionEjemplo2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemAnimacionEjemplo3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemAnimacionEjemplo4 = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemAnimacionEjemplo5 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventana)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAnimacion);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 338);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // btnAnimacion
            // 
            this.btnAnimacion.Location = new System.Drawing.Point(6, 77);
            this.btnAnimacion.Name = "btnAnimacion";
            this.btnAnimacion.Size = new System.Drawing.Size(75, 23);
            this.btnAnimacion.TabIndex = 29;
            this.btnAnimacion.Text = "Animación";
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
            this.animaciónToolStripMenuItem});
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
            this.interpolaciónToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.verToolStripMenuItem.Text = "Dibujar";
            // 
            // figurasToolStripMenuItem
            // 
            this.figurasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.básicoToolStripMenuItem2,
            this.avanzadaToolStripMenuItem});
            this.figurasToolStripMenuItem.Name = "figurasToolStripMenuItem";
            this.figurasToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.figurasToolStripMenuItem.Text = "Figuras";
            // 
            // básicoToolStripMenuItem2
            // 
            this.básicoToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemFiguraPixelRandom,
            this.ItemFiguraVector,
            this.ItemFiguraSegmento,
            this.ItemFiguraCircunferencia});
            this.básicoToolStripMenuItem2.Name = "básicoToolStripMenuItem2";
            this.básicoToolStripMenuItem2.Size = new System.Drawing.Size(125, 22);
            this.básicoToolStripMenuItem2.Text = "Básico";
            // 
            // ItemFiguraPixelRandom
            // 
            this.ItemFiguraPixelRandom.Name = "ItemFiguraPixelRandom";
            this.ItemFiguraPixelRandom.Size = new System.Drawing.Size(151, 22);
            this.ItemFiguraPixelRandom.Text = "Pixel Random";
            this.ItemFiguraPixelRandom.Click += new System.EventHandler(this.ItemFiguraPixelRandom_Click);
            // 
            // ItemFiguraVector
            // 
            this.ItemFiguraVector.Name = "ItemFiguraVector";
            this.ItemFiguraVector.Size = new System.Drawing.Size(151, 22);
            this.ItemFiguraVector.Text = "Vector";
            this.ItemFiguraVector.Click += new System.EventHandler(this.ItemFiguraVector_Click);
            // 
            // ItemFiguraSegmento
            // 
            this.ItemFiguraSegmento.Name = "ItemFiguraSegmento";
            this.ItemFiguraSegmento.Size = new System.Drawing.Size(151, 22);
            this.ItemFiguraSegmento.Text = "Segmento";
            this.ItemFiguraSegmento.Click += new System.EventHandler(this.ItemFiguraSegmento_Click);
            // 
            // ItemFiguraCircunferencia
            // 
            this.ItemFiguraCircunferencia.Name = "ItemFiguraCircunferencia";
            this.ItemFiguraCircunferencia.Size = new System.Drawing.Size(151, 22);
            this.ItemFiguraCircunferencia.Text = "Circunferencia";
            this.ItemFiguraCircunferencia.Click += new System.EventHandler(this.ItemFiguraCircunferencia_Click);
            // 
            // avanzadaToolStripMenuItem
            // 
            this.avanzadaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemFiguraConcentricas,
            this.ItemFiguraLazo,
            this.ItemFiguraEspiral,
            this.ItemFiguraParabola});
            this.avanzadaToolStripMenuItem.Name = "avanzadaToolStripMenuItem";
            this.avanzadaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.avanzadaToolStripMenuItem.Text = "Avanzada";
            // 
            // ItemFiguraConcentricas
            // 
            this.ItemFiguraConcentricas.Name = "ItemFiguraConcentricas";
            this.ItemFiguraConcentricas.Size = new System.Drawing.Size(170, 22);
            this.ItemFiguraConcentricas.Text = "Circ. Concéntricas";
            this.ItemFiguraConcentricas.Click += new System.EventHandler(this.ItemFiguraConcentricas_Click);
            // 
            // ItemFiguraLazo
            // 
            this.ItemFiguraLazo.Name = "ItemFiguraLazo";
            this.ItemFiguraLazo.Size = new System.Drawing.Size(170, 22);
            this.ItemFiguraLazo.Text = "Lazo";
            this.ItemFiguraLazo.Click += new System.EventHandler(this.ItemFiguraLazo_Click);
            // 
            // ItemFiguraEspiral
            // 
            this.ItemFiguraEspiral.Name = "ItemFiguraEspiral";
            this.ItemFiguraEspiral.Size = new System.Drawing.Size(170, 22);
            this.ItemFiguraEspiral.Text = "Espiral";
            this.ItemFiguraEspiral.Click += new System.EventHandler(this.ItemFiguraEspiral_Click);
            // 
            // ItemFiguraParabola
            // 
            this.ItemFiguraParabola.Name = "ItemFiguraParabola";
            this.ItemFiguraParabola.Size = new System.Drawing.Size(170, 22);
            this.ItemFiguraParabola.Text = "Parabola";
            this.ItemFiguraParabola.Click += new System.EventHandler(this.ItemFiguraParabola_Click_1);
            // 
            // barridoToolStripMenuItem
            // 
            this.barridoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.básicoToolStripMenuItem1,
            this.tapeteToolStripMenuItem,
            this.proceduralToolStripMenuItem});
            this.barridoToolStripMenuItem.Name = "barridoToolStripMenuItem";
            this.barridoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.barridoToolStripMenuItem.Text = "Textura";
            // 
            // básicoToolStripMenuItem1
            // 
            this.básicoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemTexturaUniColor,
            this.ItemTexturaBiColor,
            this.ItemTexturaDegradado1,
            this.ItemTexturaDegradado2});
            this.básicoToolStripMenuItem1.Name = "básicoToolStripMenuItem1";
            this.básicoToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.básicoToolStripMenuItem1.Text = "Básico";
            // 
            // ItemTexturaUniColor
            // 
            this.ItemTexturaUniColor.Name = "ItemTexturaUniColor";
            this.ItemTexturaUniColor.Size = new System.Drawing.Size(146, 22);
            this.ItemTexturaUniColor.Text = "UniColor";
            this.ItemTexturaUniColor.Click += new System.EventHandler(this.ItemTexturaUniColor_Click);
            // 
            // ItemTexturaBiColor
            // 
            this.ItemTexturaBiColor.Name = "ItemTexturaBiColor";
            this.ItemTexturaBiColor.Size = new System.Drawing.Size(146, 22);
            this.ItemTexturaBiColor.Text = "Bicolor";
            this.ItemTexturaBiColor.Click += new System.EventHandler(this.ItemTexturaBiColor_Click);
            // 
            // ItemTexturaDegradado1
            // 
            this.ItemTexturaDegradado1.Name = "ItemTexturaDegradado1";
            this.ItemTexturaDegradado1.Size = new System.Drawing.Size(146, 22);
            this.ItemTexturaDegradado1.Text = "1º Degradado";
            this.ItemTexturaDegradado1.Click += new System.EventHandler(this.ItemTexturaDegradado1_Click);
            // 
            // ItemTexturaDegradado2
            // 
            this.ItemTexturaDegradado2.Name = "ItemTexturaDegradado2";
            this.ItemTexturaDegradado2.Size = new System.Drawing.Size(146, 22);
            this.ItemTexturaDegradado2.Text = "2º Degradado";
            this.ItemTexturaDegradado2.Click += new System.EventHandler(this.ItemTexturaDegradado2_Click);
            // 
            // tapeteToolStripMenuItem
            // 
            this.tapeteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemTexturaEjemplo1,
            this.ItemTexturaEjemplo2,
            this.ItemTexturaInvierno,
            this.ItemTexturaPrimavera,
            this.ItemTexturaVerano,
            this.ItemTexturaOtonno});
            this.tapeteToolStripMenuItem.Name = "tapeteToolStripMenuItem";
            this.tapeteToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.tapeteToolStripMenuItem.Text = "Tapete";
            // 
            // ItemTexturaEjemplo1
            // 
            this.ItemTexturaEjemplo1.Name = "ItemTexturaEjemplo1";
            this.ItemTexturaEjemplo1.Size = new System.Drawing.Size(127, 22);
            this.ItemTexturaEjemplo1.Text = "Ejemplo 1";
            this.ItemTexturaEjemplo1.Click += new System.EventHandler(this.ItemTexturaEjemplo1_Click);
            // 
            // ItemTexturaEjemplo2
            // 
            this.ItemTexturaEjemplo2.Name = "ItemTexturaEjemplo2";
            this.ItemTexturaEjemplo2.Size = new System.Drawing.Size(127, 22);
            this.ItemTexturaEjemplo2.Text = "Ejemplo 2";
            this.ItemTexturaEjemplo2.Click += new System.EventHandler(this.ItemTexturaEjemplo2_Click);
            // 
            // ItemTexturaInvierno
            // 
            this.ItemTexturaInvierno.Name = "ItemTexturaInvierno";
            this.ItemTexturaInvierno.Size = new System.Drawing.Size(127, 22);
            this.ItemTexturaInvierno.Text = "Invierno";
            this.ItemTexturaInvierno.Click += new System.EventHandler(this.ItemTexturaInvierno_Click);
            // 
            // ItemTexturaPrimavera
            // 
            this.ItemTexturaPrimavera.Name = "ItemTexturaPrimavera";
            this.ItemTexturaPrimavera.Size = new System.Drawing.Size(127, 22);
            this.ItemTexturaPrimavera.Text = "Primavera";
            this.ItemTexturaPrimavera.Click += new System.EventHandler(this.ItemTexturaPrimavera_Click);
            // 
            // ItemTexturaVerano
            // 
            this.ItemTexturaVerano.Name = "ItemTexturaVerano";
            this.ItemTexturaVerano.Size = new System.Drawing.Size(127, 22);
            this.ItemTexturaVerano.Text = "Verano";
            this.ItemTexturaVerano.Click += new System.EventHandler(this.ItemTexturaVerano_Click);
            // 
            // ItemTexturaOtonno
            // 
            this.ItemTexturaOtonno.Name = "ItemTexturaOtonno";
            this.ItemTexturaOtonno.Size = new System.Drawing.Size(127, 22);
            this.ItemTexturaOtonno.Text = "Otoño";
            this.ItemTexturaOtonno.Click += new System.EventHandler(this.ItemTexturaOtonno_Click);
            // 
            // proceduralToolStripMenuItem
            // 
            this.proceduralToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemTexturaMadera,
            this.ItemTexturaCesped,
            this.ItemTexturaPiedra});
            this.proceduralToolStripMenuItem.Name = "proceduralToolStripMenuItem";
            this.proceduralToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.proceduralToolStripMenuItem.Text = "Procedural";
            // 
            // ItemTexturaMadera
            // 
            this.ItemTexturaMadera.Name = "ItemTexturaMadera";
            this.ItemTexturaMadera.Size = new System.Drawing.Size(114, 22);
            this.ItemTexturaMadera.Text = "Madera";
            this.ItemTexturaMadera.Click += new System.EventHandler(this.ItemTexturaMadera_Click);
            // 
            // ItemTexturaCesped
            // 
            this.ItemTexturaCesped.Name = "ItemTexturaCesped";
            this.ItemTexturaCesped.Size = new System.Drawing.Size(114, 22);
            this.ItemTexturaCesped.Text = "Césped";
            this.ItemTexturaCesped.Click += new System.EventHandler(this.ItemTexturaCesped_Click);
            // 
            // ItemTexturaPiedra
            // 
            this.ItemTexturaPiedra.Name = "ItemTexturaPiedra";
            this.ItemTexturaPiedra.Size = new System.Drawing.Size(114, 22);
            this.ItemTexturaPiedra.Text = "Piedra";
            this.ItemTexturaPiedra.Click += new System.EventHandler(this.ItemTexturaPiedra_Click);
            // 
            // interpolaciónToolStripMenuItem
            // 
            this.interpolaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.interpolaciónToolStripMenuItem1,
            this.lagrangeToolStripMenuItem,
            this.taylorToolStripMenuItem});
            this.interpolaciónToolStripMenuItem.Name = "interpolaciónToolStripMenuItem";
            this.interpolaciónToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.interpolaciónToolStripMenuItem.Text = "Interpolación";
            // 
            // interpolaciónToolStripMenuItem1
            // 
            this.interpolaciónToolStripMenuItem1.Name = "interpolaciónToolStripMenuItem1";
            this.interpolaciónToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.interpolaciónToolStripMenuItem1.Text = "Interpolación  ";
            this.interpolaciónToolStripMenuItem1.Click += new System.EventHandler(this.interpolaciónToolStripMenuItem1_Click);
            // 
            // lagrangeToolStripMenuItem
            // 
            this.lagrangeToolStripMenuItem.Name = "lagrangeToolStripMenuItem";
            this.lagrangeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.lagrangeToolStripMenuItem.Text = "Lagrange";
            this.lagrangeToolStripMenuItem.Click += new System.EventHandler(this.lagrangeToolStripMenuItem_Click);
            // 
            // taylorToolStripMenuItem
            // 
            this.taylorToolStripMenuItem.Name = "taylorToolStripMenuItem";
            this.taylorToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.taylorToolStripMenuItem.Text = "Taylor";
            this.taylorToolStripMenuItem.Click += new System.EventHandler(this.taylorToolStripMenuItem_Click);
            // 
            // animaciónToolStripMenuItem
            // 
            this.animaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemAnimacionEjemplo1,
            this.ItemAnimacionEjemplo2,
            this.ItemAnimacionEjemplo3,
            this.ItemAnimacionEjemplo4,
            this.ItemAnimacionEjemplo5});
            this.animaciónToolStripMenuItem.Name = "animaciónToolStripMenuItem";
            this.animaciónToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.animaciónToolStripMenuItem.Text = "Animación";
            // 
            // ItemAnimacionEjemplo1
            // 
            this.ItemAnimacionEjemplo1.Name = "ItemAnimacionEjemplo1";
            this.ItemAnimacionEjemplo1.Size = new System.Drawing.Size(180, 22);
            this.ItemAnimacionEjemplo1.Text = "Ejemplo 1";
            this.ItemAnimacionEjemplo1.Click += new System.EventHandler(this.ItemAnimacionEjemplo1_Click);
            // 
            // ItemAnimacionEjemplo2
            // 
            this.ItemAnimacionEjemplo2.Name = "ItemAnimacionEjemplo2";
            this.ItemAnimacionEjemplo2.Size = new System.Drawing.Size(180, 22);
            this.ItemAnimacionEjemplo2.Text = "Ejemplo 2";
            this.ItemAnimacionEjemplo2.Click += new System.EventHandler(this.ItemAnimacionEjemplo2_Click);
            // 
            // ItemAnimacionEjemplo3
            // 
            this.ItemAnimacionEjemplo3.Name = "ItemAnimacionEjemplo3";
            this.ItemAnimacionEjemplo3.Size = new System.Drawing.Size(180, 22);
            this.ItemAnimacionEjemplo3.Text = "Ejemplo 3";
            this.ItemAnimacionEjemplo3.Click += new System.EventHandler(this.ItemAnimacionEjemplo3_Click);
            // 
            // ItemAnimacionEjemplo4
            // 
            this.ItemAnimacionEjemplo4.Name = "ItemAnimacionEjemplo4";
            this.ItemAnimacionEjemplo4.Size = new System.Drawing.Size(180, 22);
            this.ItemAnimacionEjemplo4.Text = "Ejemplo 4";
            this.ItemAnimacionEjemplo4.Click += new System.EventHandler(this.ItemAnimacionEjemplo4_Click);
            // 
            // ItemAnimacionEjemplo5
            // 
            this.ItemAnimacionEjemplo5.Name = "ItemAnimacionEjemplo5";
            this.ItemAnimacionEjemplo5.Size = new System.Drawing.Size(180, 22);
            this.ItemAnimacionEjemplo5.Text = "Ejemplo 5";
            this.ItemAnimacionEjemplo5.Click += new System.EventHandler(this.ItemAnimacionEjemplo5_Click);
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
        private System.Windows.Forms.ToolStripMenuItem interpolaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interpolaciónToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lagrangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taylorToolStripMenuItem;
        private System.Windows.Forms.Button btnAnimacion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem tapeteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proceduralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem básicoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ItemTexturaUniColor;
        private System.Windows.Forms.ToolStripMenuItem ItemTexturaBiColor;
        private System.Windows.Forms.ToolStripMenuItem ItemTexturaDegradado1;
        private System.Windows.Forms.ToolStripMenuItem ItemTexturaDegradado2;
        private System.Windows.Forms.ToolStripMenuItem ItemTexturaMadera;
        private System.Windows.Forms.ToolStripMenuItem ItemTexturaCesped;
        private System.Windows.Forms.ToolStripMenuItem ItemTexturaPiedra;
        private System.Windows.Forms.ToolStripMenuItem ItemTexturaEjemplo1;
        private System.Windows.Forms.ToolStripMenuItem ItemTexturaEjemplo2;
        private System.Windows.Forms.ToolStripMenuItem ItemTexturaInvierno;
        private System.Windows.Forms.ToolStripMenuItem ItemTexturaPrimavera;
        private System.Windows.Forms.ToolStripMenuItem ItemTexturaVerano;
        private System.Windows.Forms.ToolStripMenuItem ItemTexturaOtonno;
        private System.Windows.Forms.ToolStripMenuItem animaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem básicoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ItemFiguraPixelRandom;
        private System.Windows.Forms.ToolStripMenuItem ItemFiguraVector;
        private System.Windows.Forms.ToolStripMenuItem ItemFiguraSegmento;
        private System.Windows.Forms.ToolStripMenuItem avanzadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ItemFiguraCircunferencia;
        private System.Windows.Forms.ToolStripMenuItem ItemFiguraConcentricas;
        private System.Windows.Forms.ToolStripMenuItem ItemFiguraLazo;
        private System.Windows.Forms.ToolStripMenuItem ItemFiguraEspiral;
        private System.Windows.Forms.ToolStripMenuItem ItemFiguraParabola;
        private System.Windows.Forms.ToolStripMenuItem ItemAnimacionEjemplo1;
        private System.Windows.Forms.ToolStripMenuItem ItemAnimacionEjemplo2;
        private System.Windows.Forms.ToolStripMenuItem ItemAnimacionEjemplo3;
        private System.Windows.Forms.ToolStripMenuItem ItemAnimacionEjemplo4;
        private System.Windows.Forms.ToolStripMenuItem ItemAnimacionEjemplo5;
    }
}

