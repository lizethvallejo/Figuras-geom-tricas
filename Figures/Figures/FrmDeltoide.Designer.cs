namespace Figures
{
    partial class FrmDeltoide
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
            this.lblAnguloMessage = new System.Windows.Forms.Label();
            this.txtAngulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.lblRadio = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.groupBox1.Location = new System.Drawing.Point(299, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 415);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafico:";
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(7, 22);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(466, 387);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // gBoxSalidas
            // 
            this.gBoxSalidas.Controls.Add(this.txtArea);
            this.gBoxSalidas.Controls.Add(this.label2);
            this.gBoxSalidas.Controls.Add(this.txtPerimetro);
            this.gBoxSalidas.Controls.Add(this.label1);
            this.gBoxSalidas.Location = new System.Drawing.Point(31, 327);
            this.gBoxSalidas.Name = "gBoxSalidas";
            this.gBoxSalidas.Size = new System.Drawing.Size(252, 100);
            this.gBoxSalidas.TabIndex = 24;
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
            this.GboxProceso.Location = new System.Drawing.Point(31, 217);
            this.GboxProceso.Name = "GboxProceso";
            this.GboxProceso.Size = new System.Drawing.Size(252, 91);
            this.GboxProceso.TabIndex = 23;
            this.GboxProceso.TabStop = false;
            this.GboxProceso.Text = "Proceso";
            // 
            // btnResetear
            // 
            this.btnResetear.Location = new System.Drawing.Point(127, 42);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(100, 23);
            this.btnResetear.TabIndex = 1;
            this.btnResetear.Text = "Resetear";
            this.btnResetear.UseVisualStyleBackColor = true;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(20, 42);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // GBoxEntradas
            // 
            this.GBoxEntradas.Controls.Add(this.lblAnguloMessage);
            this.GBoxEntradas.Controls.Add(this.txtAngulo);
            this.GBoxEntradas.Controls.Add(this.label4);
            this.GBoxEntradas.Controls.Add(this.txtLado2);
            this.GBoxEntradas.Controls.Add(this.label3);
            this.GBoxEntradas.Controls.Add(this.txtLado1);
            this.GBoxEntradas.Controls.Add(this.lblRadio);
            this.GBoxEntradas.Location = new System.Drawing.Point(31, 81);
            this.GBoxEntradas.Name = "GBoxEntradas";
            this.GBoxEntradas.Size = new System.Drawing.Size(252, 130);
            this.GBoxEntradas.TabIndex = 22;
            this.GBoxEntradas.TabStop = false;
            this.GBoxEntradas.Text = "Entradas";
            // 
            // lblAnguloMessage
            // 
            this.lblAnguloMessage.AutoSize = true;
            this.lblAnguloMessage.BackColor = System.Drawing.SystemColors.Control;
            this.lblAnguloMessage.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAnguloMessage.Location = new System.Drawing.Point(98, 113);
            this.lblAnguloMessage.Name = "lblAnguloMessage";
            this.lblAnguloMessage.Size = new System.Drawing.Size(0, 16);
            this.lblAnguloMessage.TabIndex = 6;
            // 
            // txtAngulo
            // 
            this.txtAngulo.Location = new System.Drawing.Point(98, 85);
            this.txtAngulo.Name = "txtAngulo";
            this.txtAngulo.Size = new System.Drawing.Size(100, 22);
            this.txtAngulo.TabIndex = 5;
            this.txtAngulo.Enter += new System.EventHandler(this.txtAngulo_Enter);
            this.txtAngulo.Leave += new System.EventHandler(this.txtAngulo_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Angulo:";
            // 
            // txtLado2
            // 
            this.txtLado2.Location = new System.Drawing.Point(99, 55);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(100, 22);
            this.txtLado2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lado 2:";
            // 
            // txtLado1
            // 
            this.txtLado1.Location = new System.Drawing.Point(98, 27);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(100, 22);
            this.txtLado1.TabIndex = 1;
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Location = new System.Drawing.Point(18, 34);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(51, 16);
            this.lblRadio.TabIndex = 0;
            this.lblRadio.Text = "Lado 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 32);
            this.label5.TabIndex = 26;
            this.label5.Text = "Deltoide";
            // 
            // FrmDeltoide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gBoxSalidas);
            this.Controls.Add(this.GboxProceso);
            this.Controls.Add(this.GBoxEntradas);
            this.Name = "FrmDeltoide";
            this.Text = "FrmDeltoide";
            this.Load += new System.EventHandler(this.FrmDeltoide_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.gBoxSalidas.ResumeLayout(false);
            this.gBoxSalidas.PerformLayout();
            this.GboxProceso.ResumeLayout(false);
            this.GBoxEntradas.ResumeLayout(false);
            this.GBoxEntradas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox txtAngulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.Label lblAnguloMessage;
        private System.Windows.Forms.Label label5;
    }
}