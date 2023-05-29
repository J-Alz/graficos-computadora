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
            this.cbxPaleta = new System.Windows.Forms.ComboBox();
            this.btnDegraded2 = new System.Windows.Forms.Button();
            this.btnDegraded1 = new System.Windows.Forms.Button();
            this.btnScanBi = new System.Windows.Forms.Button();
            this.btnScanUni = new System.Windows.Forms.Button();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ventana = new System.Windows.Forms.PictureBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDeleteFigure = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventana)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxPaleta);
            this.groupBox1.Controls.Add(this.btnDegraded2);
            this.groupBox1.Controls.Add(this.btnDegraded1);
            this.groupBox1.Controls.Add(this.btnScanBi);
            this.groupBox1.Controls.Add(this.btnScanUni);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 338);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
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
            this.cbxPaleta.Location = new System.Drawing.Point(64, 260);
            this.cbxPaleta.Name = "cbxPaleta";
            this.cbxPaleta.Size = new System.Drawing.Size(121, 21);
            this.cbxPaleta.TabIndex = 25;
            this.cbxPaleta.SelectedIndexChanged += new System.EventHandler(this.cbxPaleta_SelectedIndexChanged);
            // 
            // btnDegraded2
            // 
            this.btnDegraded2.Location = new System.Drawing.Point(88, 182);
            this.btnDegraded2.Name = "btnDegraded2";
            this.btnDegraded2.Size = new System.Drawing.Size(76, 50);
            this.btnDegraded2.TabIndex = 23;
            this.btnDegraded2.Text = "Segundo Degradado";
            this.btnDegraded2.UseVisualStyleBackColor = true;
            this.btnDegraded2.Click += new System.EventHandler(this.btnDegraded2_Click);
            // 
            // btnDegraded1
            // 
            this.btnDegraded1.Location = new System.Drawing.Point(6, 164);
            this.btnDegraded1.Name = "btnDegraded1";
            this.btnDegraded1.Size = new System.Drawing.Size(76, 50);
            this.btnDegraded1.TabIndex = 22;
            this.btnDegraded1.Text = "Primer Degradado";
            this.btnDegraded1.UseVisualStyleBackColor = true;
            this.btnDegraded1.Click += new System.EventHandler(this.btnDegraded1_Click);
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
            // btnTaylor
            // 
            this.btnTaylor.Location = new System.Drawing.Point(72, 135);
            this.btnTaylor.Name = "btnTaylor";
            this.btnTaylor.Size = new System.Drawing.Size(47, 23);
            this.btnTaylor.TabIndex = 13;
            this.btnTaylor.Text = "Taylor";
            this.btnTaylor.UseVisualStyleBackColor = true;
            this.btnTaylor.Click += new System.EventHandler(this.btnTaylor_Click);
            // 
            // btnEspiral
            // 
            this.btnEspiral.Location = new System.Drawing.Point(150, 48);
            this.btnEspiral.Name = "btnEspiral";
            this.btnEspiral.Size = new System.Drawing.Size(47, 23);
            this.btnEspiral.TabIndex = 9;
            this.btnEspiral.Text = "Espiral";
            this.btnEspiral.UseVisualStyleBackColor = true;
            this.btnEspiral.Click += new System.EventHandler(this.btnEspiral_Click);
            // 
            // btnLazo
            // 
            this.btnLazo.Location = new System.Drawing.Point(97, 48);
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
            this.btnShowAxis.Location = new System.Drawing.Point(12, 19);
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
            this.btnColor.Location = new System.Drawing.Point(48, 19);
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDeleteFigure);
            this.groupBox4.Controls.Add(this.lbx);
            this.groupBox4.Location = new System.Drawing.Point(12, 434);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 159);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lista de elementos";
            // 
            // btnDeleteFigure
            // 
            this.btnDeleteFigure.Enabled = false;
            this.btnDeleteFigure.Image = global::CC.Properties.Resources.trash;
            this.btnDeleteFigure.Location = new System.Drawing.Point(160, 19);
            this.btnDeleteFigure.Name = "btnDeleteFigure";
            this.btnDeleteFigure.Size = new System.Drawing.Size(30, 30);
            this.btnDeleteFigure.TabIndex = 5;
            this.btnDeleteFigure.UseVisualStyleBackColor = true;
            this.btnDeleteFigure.Click += new System.EventHandler(this.btnDeleteFigure_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(943, 600);
            this.Controls.Add(this.groupBox4);
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
            this.groupBox4.ResumeLayout(false);
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.Button btnScanUni;
        private System.Windows.Forms.Button btnScanBi;
        private System.Windows.Forms.Button btnDegraded1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDegraded2;
        private System.Windows.Forms.ListBox lbx;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDeleteFigure;
        private System.Windows.Forms.ComboBox cbxPaleta;
    }
}

