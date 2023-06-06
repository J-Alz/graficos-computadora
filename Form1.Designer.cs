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
            this.básicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pixelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segmentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.figurasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circunferenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circConcentricasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lazoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.espiralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interpolaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interpolaciónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lagrangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taylorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxTextura = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventana)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxTextura);
            this.groupBox1.Controls.Add(this.btnParabola);
            this.groupBox1.Controls.Add(this.cbxPaleta);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 338);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // btnParabola
            // 
            this.btnParabola.Location = new System.Drawing.Point(23, 54);
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
            "Otros"});
            this.cbxPaleta.Location = new System.Drawing.Point(37, 83);
            this.cbxPaleta.Name = "cbxPaleta";
            this.cbxPaleta.Size = new System.Drawing.Size(121, 21);
            this.cbxPaleta.TabIndex = 25;
            this.cbxPaleta.Text = "Tapetes";
            this.cbxPaleta.SelectedIndexChanged += new System.EventHandler(this.cbxPaleta_SelectedIndexChanged);
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
            this.básicoToolStripMenuItem,
            this.figurasToolStripMenuItem,
            this.barridoToolStripMenuItem,
            this.interpolaciónToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.verToolStripMenuItem.Text = "Dibujar";
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
            // básicoToolStripMenuItem
            // 
            this.básicoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pixelToolStripMenuItem,
            this.vectorToolStripMenuItem,
            this.segmentoToolStripMenuItem});
            this.básicoToolStripMenuItem.Name = "básicoToolStripMenuItem";
            this.básicoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.básicoToolStripMenuItem.Text = "Básico";
            // 
            // pixelToolStripMenuItem
            // 
            this.pixelToolStripMenuItem.Name = "pixelToolStripMenuItem";
            this.pixelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pixelToolStripMenuItem.Text = "Pixel Random";
            this.pixelToolStripMenuItem.Click += new System.EventHandler(this.pixelToolStripMenuItem_Click);
            // 
            // vectorToolStripMenuItem
            // 
            this.vectorToolStripMenuItem.Name = "vectorToolStripMenuItem";
            this.vectorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vectorToolStripMenuItem.Text = "Vector";
            this.vectorToolStripMenuItem.Click += new System.EventHandler(this.vectorToolStripMenuItem_Click);
            // 
            // segmentoToolStripMenuItem
            // 
            this.segmentoToolStripMenuItem.Name = "segmentoToolStripMenuItem";
            this.segmentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.segmentoToolStripMenuItem.Text = "Segmento";
            this.segmentoToolStripMenuItem.Click += new System.EventHandler(this.segmentoToolStripMenuItem_Click);
            // 
            // figurasToolStripMenuItem
            // 
            this.figurasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.circunferenciaToolStripMenuItem,
            this.circConcentricasToolStripMenuItem,
            this.lazoToolStripMenuItem,
            this.espiralToolStripMenuItem});
            this.figurasToolStripMenuItem.Name = "figurasToolStripMenuItem";
            this.figurasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.figurasToolStripMenuItem.Text = "Figuras";
            // 
            // circunferenciaToolStripMenuItem
            // 
            this.circunferenciaToolStripMenuItem.Name = "circunferenciaToolStripMenuItem";
            this.circunferenciaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.circunferenciaToolStripMenuItem.Text = "Circunferencia";
            this.circunferenciaToolStripMenuItem.Click += new System.EventHandler(this.circunferenciaToolStripMenuItem_Click);
            // 
            // circConcentricasToolStripMenuItem
            // 
            this.circConcentricasToolStripMenuItem.Name = "circConcentricasToolStripMenuItem";
            this.circConcentricasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.circConcentricasToolStripMenuItem.Text = "Circ. Concentricas";
            this.circConcentricasToolStripMenuItem.Click += new System.EventHandler(this.circConcentricasToolStripMenuItem_Click);
            // 
            // lazoToolStripMenuItem
            // 
            this.lazoToolStripMenuItem.Name = "lazoToolStripMenuItem";
            this.lazoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lazoToolStripMenuItem.Text = "Lazo";
            this.lazoToolStripMenuItem.Click += new System.EventHandler(this.lazoToolStripMenuItem_Click);
            // 
            // espiralToolStripMenuItem
            // 
            this.espiralToolStripMenuItem.Name = "espiralToolStripMenuItem";
            this.espiralToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.espiralToolStripMenuItem.Text = "Espiral";
            this.espiralToolStripMenuItem.Click += new System.EventHandler(this.espiralToolStripMenuItem_Click);
            // 
            // interpolaciónToolStripMenuItem
            // 
            this.interpolaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.interpolaciónToolStripMenuItem1,
            this.lagrangeToolStripMenuItem,
            this.taylorToolStripMenuItem});
            this.interpolaciónToolStripMenuItem.Name = "interpolaciónToolStripMenuItem";
            this.interpolaciónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.interpolaciónToolStripMenuItem.Text = "Interpolación";
            // 
            // interpolaciónToolStripMenuItem1
            // 
            this.interpolaciónToolStripMenuItem1.Name = "interpolaciónToolStripMenuItem1";
            this.interpolaciónToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.interpolaciónToolStripMenuItem1.Text = "Interpolación  ";
            this.interpolaciónToolStripMenuItem1.Click += new System.EventHandler(this.interpolaciónToolStripMenuItem1_Click);
            // 
            // lagrangeToolStripMenuItem
            // 
            this.lagrangeToolStripMenuItem.Name = "lagrangeToolStripMenuItem";
            this.lagrangeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lagrangeToolStripMenuItem.Text = "Lagrange";
            this.lagrangeToolStripMenuItem.Click += new System.EventHandler(this.lagrangeToolStripMenuItem_Click);
            // 
            // taylorToolStripMenuItem
            // 
            this.taylorToolStripMenuItem.Name = "taylorToolStripMenuItem";
            this.taylorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.taylorToolStripMenuItem.Text = "Taylor";
            this.taylorToolStripMenuItem.Click += new System.EventHandler(this.taylorToolStripMenuItem_Click);
            // 
            // cbxTextura
            // 
            this.cbxTextura.FormattingEnabled = true;
            this.cbxTextura.Items.AddRange(new object[] {
            "Madera",
            "Cesped",
            "Piedra"});
            this.cbxTextura.Location = new System.Drawing.Point(52, 195);
            this.cbxTextura.Name = "cbxTextura";
            this.cbxTextura.Size = new System.Drawing.Size(121, 21);
            this.cbxTextura.TabIndex = 27;
            this.cbxTextura.Text = "Texturas";
            this.cbxTextura.SelectedIndexChanged += new System.EventHandler(this.cbxTextura_SelectedIndexChanged);
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
        private System.Windows.Forms.ToolStripMenuItem básicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pixelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segmentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem figurasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circunferenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circConcentricasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lazoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem espiralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interpolaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interpolaciónToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lagrangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taylorToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbxTextura;
    }
}

