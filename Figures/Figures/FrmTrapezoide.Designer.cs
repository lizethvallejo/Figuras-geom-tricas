namespace Figures
{
    partial class FrmTrapezoide
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.gBoxSalidas = new System.Windows.Forms.GroupBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GboxProceso = new System.Windows.Forms.GroupBox();
            this.btnResetear = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.GBoxEntradas = new System.Windows.Forms.GroupBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLado4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLado3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.lblRadio = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.gBoxSalidas.SuspendLayout();
            this.GboxProceso.SuspendLayout();
            this.GBoxEntradas.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picCanvas);
            this.groupBox1.Location = new System.Drawing.Point(317, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 365);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafico:";
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(7, 22);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(440, 337);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // gBoxSalidas
            // 
            this.gBoxSalidas.Controls.Add(this.txtArea);
            this.gBoxSalidas.Controls.Add(this.label2);
            this.gBoxSalidas.Controls.Add(this.txtPerimetro);
            this.gBoxSalidas.Controls.Add(this.label1);
            this.gBoxSalidas.Location = new System.Drawing.Point(31, 308);
            this.gBoxSalidas.Name = "gBoxSalidas";
            this.gBoxSalidas.Size = new System.Drawing.Size(252, 100);
            this.gBoxSalidas.TabIndex = 28;
            this.gBoxSalidas.TabStop = false;
            this.gBoxSalidas.Text = "Salidas";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(88, 55);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 22);
            this.txtArea.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Area";
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(88, 27);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.Size = new System.Drawing.Size(100, 22);
            this.txtPerimetro.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Perimetro";
            // 
            // GboxProceso
            // 
            this.GboxProceso.Controls.Add(this.btnResetear);
            this.GboxProceso.Controls.Add(this.btnCalcular);
            this.GboxProceso.Location = new System.Drawing.Point(31, 221);
            this.GboxProceso.Name = "GboxProceso";
            this.GboxProceso.Size = new System.Drawing.Size(252, 65);
            this.GboxProceso.TabIndex = 27;
            this.GboxProceso.TabStop = false;
            this.GboxProceso.Text = "Proceso";
            // 
            // btnResetear
            // 
            this.btnResetear.Location = new System.Drawing.Point(127, 21);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(100, 23);
            this.btnResetear.TabIndex = 1;
            this.btnResetear.Text = "Resetear";
            this.btnResetear.UseVisualStyleBackColor = true;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(21, 21);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // GBoxEntradas
            // 
            this.GBoxEntradas.Controls.Add(this.txtAltura);
            this.GBoxEntradas.Controls.Add(this.label5);
            this.GBoxEntradas.Controls.Add(this.txtLado4);
            this.GBoxEntradas.Controls.Add(this.label6);
            this.GBoxEntradas.Controls.Add(this.txtLado3);
            this.GBoxEntradas.Controls.Add(this.label4);
            this.GBoxEntradas.Controls.Add(this.txtLado2);
            this.GBoxEntradas.Controls.Add(this.label3);
            this.GBoxEntradas.Controls.Add(this.txtLado1);
            this.GBoxEntradas.Controls.Add(this.lblRadio);
            this.GBoxEntradas.Location = new System.Drawing.Point(31, 42);
            this.GBoxEntradas.Name = "GBoxEntradas";
            this.GBoxEntradas.Size = new System.Drawing.Size(252, 159);
            this.GBoxEntradas.TabIndex = 26;
            this.GBoxEntradas.TabStop = false;
            this.GBoxEntradas.Text = "Entradas";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(114, 131);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 22);
            this.txtAltura.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Altura:";
            // 
            // txtLado4
            // 
            this.txtLado4.Location = new System.Drawing.Point(114, 103);
            this.txtLado4.Name = "txtLado4";
            this.txtLado4.Size = new System.Drawing.Size(100, 22);
            this.txtLado4.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Lado 4:";
            // 
            // txtLado3
            // 
            this.txtLado3.Location = new System.Drawing.Point(114, 76);
            this.txtLado3.Name = "txtLado3";
            this.txtLado3.Size = new System.Drawing.Size(100, 22);
            this.txtLado3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lado 3:";
            // 
            // txtLado2
            // 
            this.txtLado2.Location = new System.Drawing.Point(114, 48);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(100, 22);
            this.txtLado2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lado 2:";
            // 
            // txtLado1
            // 
            this.txtLado1.Location = new System.Drawing.Point(114, 17);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(100, 22);
            this.txtLado1.TabIndex = 1;
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Location = new System.Drawing.Point(18, 23);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(51, 16);
            this.lblRadio.TabIndex = 0;
            this.lblRadio.Text = "Lado 1:";
            // 
            // FrmTrapezoide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gBoxSalidas);
            this.Controls.Add(this.GboxProceso);
            this.Controls.Add(this.GBoxEntradas);
            this.Name = "FrmTrapezoide";
            this.Text = "FrmTrapezoide";
            this.Load += new System.EventHandler(this.FrmTrapezoide_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.gBoxSalidas.ResumeLayout(false);
            this.gBoxSalidas.PerformLayout();
            this.GboxProceso.ResumeLayout(false);
            this.GBoxEntradas.ResumeLayout(false);
            this.GBoxEntradas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.GroupBox gBoxSalidas;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GboxProceso;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox GBoxEntradas;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLado4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLado3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.Label lblRadio;
    }
}