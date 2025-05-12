using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figures
{
    internal class Trapezoide
    {
        private float mLado1;   // Lado superior
        private float mLado2;   // Lado derecho
        private float mLado3;   // Lado inferior
        private float mLado4;   // Lado izquierdo
        private float mAltura;  // Altura entre los lados
        private float mPerimetro;
        private float mArea;

        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20; // Factor de escala para dibujar

        public Trapezoide()
        {
            mLado1 = mLado2 = mLado3 = mLado4 = mAltura = 0.0f;
            mPerimetro = mArea = 0.0f;
        }

        // Función que lee los datos de entrada
        public void ReadData(TextBox txtLado1, TextBox txtLado2, TextBox txtLado3,
                             TextBox txtLado4, TextBox txtAltura)
        {
            try
            {
                mLado1 = float.Parse(txtLado1.Text);
                mLado2 = float.Parse(txtLado2.Text);
                mLado3 = float.Parse(txtLado3.Text);
                mLado4 = float.Parse(txtLado4.Text);
                mAltura = float.Parse(txtAltura.Text);

                if (mLado1 <= 0 || mLado2 <= 0 || mLado3 <= 0 || mLado4 <= 0 || mAltura <= 0)
                {
                    MessageBox.Show("Todos los valores deben ser positivos.", "Error de entrada");
                    ResetData();
                    return;
                }

            }
            catch
            {
                MessageBox.Show("Por favor, ingrese solo números válidos.", "Error de entrada");
                ResetData();
            }
        }

        // Calcular el perímetro
        public void PerimeterTrapezoide()
        {
            mPerimetro = mLado1 + mLado2 + mLado3 + mLado4;
        }

        // Calcular el área
        public void AreaTrapezoide()
        {
            mArea = ((mLado1 + mLado3) / 2) * mAltura;
        }

        // Imprimir el perímetro y área
        public void PrintData(TextBox txtPerimetro, TextBox txtArea)
        {
            txtPerimetro.Text = mPerimetro.ToString("0.00");
            txtArea.Text = mArea.ToString("0.00");
        }

        // Inicializar los datos y controles
        public void InitializeData(TextBox txtLado1, TextBox txtLado2, TextBox txtLado3,
                                   TextBox txtLado4, TextBox txtAltura, TextBox txtPerimetro,
                                   TextBox txtArea, PictureBox picCanvas)
        {
            ResetData();

            txtLado1.Text = "";
            txtLado2.Text = "";
            txtLado3.Text = "";
            txtLado4.Text = "";
            txtAltura.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";
            txtLado1.Focus();
            picCanvas.Refresh();
        }

        // Restablecer los valores de los datos
        private void ResetData()
        {
            mLado1 = mLado2 = mLado3 = mLado4 = mAltura = 0.0f;
            mPerimetro = mArea = 0.0f;
        }

        // Dibujar el trapezoide
        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.DarkRed, 3);

            // Escalando las dimensiones
            float lado1 = mLado1 * SF;
            float lado2 = mLado2 * SF;
            float lado3 = mLado3 * SF;
            float lado4 = mLado4 * SF;
            float altura = mAltura * SF;

            // Coordenadas de los vértices (Punto A, B, C, D)
            float centerX = picCanvas.Width / 2;
            float centerY = picCanvas.Height / 2;

            // Límite superior e inferior
            float y1 = centerY - altura / 2; // Coordenada Y de la parte superior
            float y2 = centerY + altura / 2; // Coordenada Y de la parte inferior

            // Dibujando el trapecio
            PointF[] points = new PointF[4];
            points[0] = new PointF(centerX - lado1 / 2, y1);    // Punto A
            points[1] = new PointF(centerX + lado1 / 2, y1);    // Punto B
            points[2] = new PointF(centerX + lado3 / 2, y2);    // Punto C
            points[3] = new PointF(centerX - lado3 / 2, y2);    // Punto D

            // Dibujando el trapezoide en el canvas
            mGraph.DrawPolygon(mPen, points);
        }

        // Cerrar el formulario
        public void CloseForm(Form objForm)
        {
            objForm.Close();
        }
    }
}
