﻿namespace Figures
{
    partial class FrmCuadrado
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
            this.txtLado = new System.Windows.Forms.TextBox();
            this.lblRadio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.groupBox1.Size = new System.Drawing.Size(489, 415);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafico:";
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(7, 22);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(476, 387);
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
            this.gBoxSalidas.TabIndex = 47;
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
            this.GboxProceso.Location = new System.Drawing.Point(31, 209);
            this.GboxProceso.Name = "GboxProceso";
            this.GboxProceso.Size = new System.Drawing.Size(252, 100);
            this.GboxProceso.TabIndex = 46;
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
            this.GBoxEntradas.Controls.Add(this.txtLado);
            this.GBoxEntradas.Controls.Add(this.lblRadio);
            this.GBoxEntradas.Location = new System.Drawing.Point(31, 91);
            this.GBoxEntradas.Name = "GBoxEntradas";
            this.GBoxEntradas.Size = new System.Drawing.Size(252, 100);
            this.GBoxEntradas.TabIndex = 45;
            this.GBoxEntradas.TabStop = false;
            this.GBoxEntradas.Text = "Entradas";
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(81, 35);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(100, 22);
            this.txtLado.TabIndex = 1;
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Location = new System.Drawing.Point(18, 42);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(41, 16);
            this.lblRadio.TabIndex = 0;
            this.lblRadio.Text = "Lado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 32);
            this.label3.TabIndex = 49;
            this.label3.Text = "Cuadrado";
            // 
            // FrmCuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gBoxSalidas);
            this.Controls.Add(this.GboxProceso);
            this.Controls.Add(this.GBoxEntradas);
            this.Name = "FrmCuadrado";
            this.Text = "FrmCuadrado";
            this.Load += new System.EventHandler(this.FrmCuadrado_Load);
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
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.Label label3;
    }
}