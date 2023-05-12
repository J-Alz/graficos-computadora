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
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnCurva2 = new System.Windows.Forms.Button();
            this.btnCurva1 = new System.Windows.Forms.Button();
            this.btnCirculo = new System.Windows.Forms.Button();
            this.btnVector = new System.Windows.Forms.Button();
            this.btnPixel = new System.Windows.Forms.Button();
            this.btnSegmento = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.cbxEjes = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.win = new System.Windows.Forms.PictureBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.win)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxEjes);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.btnColor);
            this.groupBox1.Controls.Add(this.btnCurva2);
            this.groupBox1.Controls.Add(this.btnCurva1);
            this.groupBox1.Controls.Add(this.btnCirculo);
            this.groupBox1.Controls.Add(this.btnVector);
            this.groupBox1.Controls.Add(this.btnPixel);
            this.groupBox1.Controls.Add(this.btnSegmento);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 559);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 530);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(188, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // btnCurva2
            // 
            this.btnCurva2.Location = new System.Drawing.Point(26, 325);
            this.btnCurva2.Name = "btnCurva2";
            this.btnCurva2.Size = new System.Drawing.Size(127, 23);
            this.btnCurva2.TabIndex = 9;
            this.btnCurva2.Text = "curva 2";
            this.btnCurva2.UseVisualStyleBackColor = true;
            this.btnCurva2.Click += new System.EventHandler(this.btnCurva2_Click);
            // 
            // btnCurva1
            // 
            this.btnCurva1.Location = new System.Drawing.Point(26, 296);
            this.btnCurva1.Name = "btnCurva1";
            this.btnCurva1.Size = new System.Drawing.Size(127, 23);
            this.btnCurva1.TabIndex = 8;
            this.btnCurva1.Text = "curva 1";
            this.btnCurva1.UseVisualStyleBackColor = true;
            this.btnCurva1.Click += new System.EventHandler(this.btnCurva1_Click);
            // 
            // btnCirculo
            // 
            this.btnCirculo.Location = new System.Drawing.Point(26, 219);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(127, 23);
            this.btnCirculo.TabIndex = 7;
            this.btnCirculo.Text = "Circunferencia";
            this.btnCirculo.UseVisualStyleBackColor = true;
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // btnVector
            // 
            this.btnVector.Location = new System.Drawing.Point(26, 161);
            this.btnVector.Name = "btnVector";
            this.btnVector.Size = new System.Drawing.Size(127, 23);
            this.btnVector.TabIndex = 6;
            this.btnVector.Text = "Vector";
            this.btnVector.UseVisualStyleBackColor = true;
            this.btnVector.Click += new System.EventHandler(this.btnVector_Click);
            // 
            // btnPixel
            // 
            this.btnPixel.Location = new System.Drawing.Point(26, 122);
            this.btnPixel.Name = "btnPixel";
            this.btnPixel.Size = new System.Drawing.Size(127, 23);
            this.btnPixel.TabIndex = 5;
            this.btnPixel.Text = "Pixel";
            this.btnPixel.UseVisualStyleBackColor = true;
            this.btnPixel.Click += new System.EventHandler(this.btnPixel_Click);
            // 
            // btnSegmento
            // 
            this.btnSegmento.Location = new System.Drawing.Point(26, 258);
            this.btnSegmento.Name = "btnSegmento";
            this.btnSegmento.Size = new System.Drawing.Size(127, 23);
            this.btnSegmento.TabIndex = 4;
            this.btnSegmento.Text = "Segmento";
            this.btnSegmento.UseVisualStyleBackColor = true;
            this.btnSegmento.Click += new System.EventHandler(this.btnSegmento_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.win);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(713, 566);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gráfico";
            // 
            // cbxEjes
            // 
            this.cbxEjes.AutoSize = true;
            this.cbxEjes.Checked = true;
            this.cbxEjes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxEjes.Location = new System.Drawing.Point(6, 27);
            this.cbxEjes.Name = "cbxEjes";
            this.cbxEjes.Size = new System.Drawing.Size(84, 17);
            this.cbxEjes.TabIndex = 14;
            this.cbxEjes.Text = "Mostrar Ejes";
            this.cbxEjes.UseVisualStyleBackColor = true;
            this.cbxEjes.CheckedChanged += new System.EventHandler(this.cbxEjes_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "variable";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // win
            // 
            this.win.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.win.Location = new System.Drawing.Point(6, 19);
            this.win.Name = "win";
            this.win.Size = new System.Drawing.Size(700, 540);
            this.win.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.win.TabIndex = 0;
            this.win.TabStop = false;
            // 
            // btnColor
            // 
            this.btnColor.AutoSize = true;
            this.btnColor.Image = global::CC.Properties.Resources.paint;
            this.btnColor.Location = new System.Drawing.Point(128, 19);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(30, 30);
            this.btnColor.TabIndex = 10;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnClear
            // 
            this.btnClear.Image = global::CC.Properties.Resources.trash;
            this.btnClear.Location = new System.Drawing.Point(164, 19);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(30, 30);
            this.btnClear.TabIndex = 1;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 592);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Gráficos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.win)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox win;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSegmento;
        private System.Windows.Forms.Button btnPixel;
        private System.Windows.Forms.Button btnVector;
        private System.Windows.Forms.Button btnCirculo;
        private System.Windows.Forms.Button btnCurva2;
        private System.Windows.Forms.Button btnCurva1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox cbxEjes;
        private System.Windows.Forms.Button button1;
    }
}

