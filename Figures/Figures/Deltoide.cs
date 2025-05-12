using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figures
{
    internal class Deltoide
    {
        private float mLado1;    // Primer par de lados (diagonal menor)
        private float mLado2;    // Segundo par de lados (diagonal mayor)
        private float mAngulo;   // Ángulo entre los lados
        private float mArea;
        private float mPerimetro;

        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20; // Factor de escala para dibujar

        public Deltoide()
        {
            mLado1 = 0.0f;
            mLado2 = 0.0f;
            mAngulo = 0.0f;
            mArea = 0.0f;
            mPerimetro = 0.0f;
        }

        // Función que lee los datos de entrada
        public void ReadData(TextBox txtLado1, TextBox txtLado2, TextBox txtAngulo)
        {
            try
            {
                mLado1 = float.Parse(txtLado1.Text);
                mLado2 = float.Parse(txtLado2.Text);
                mAngulo = float.Parse(txtAngulo.Text);

                if (mLado1 <= 0 || mLado2 <= 0 || mAngulo <= 0 || mAngulo >= 180)
                {
                    MessageBox.Show("Por favor, ingrese valores positivos para los lados y un ángulo entre 0° y 180°.", "Error de entrada");
                    ResetData();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Por favor, ingrese números válidos.", "Error de entrada");
                ResetData();
            }
        }

        // Calcular el perímetro del deltoide
        public void PerimeterDeltoide()
        {
            mPerimetro = 2 * (mLado1 + mLado2);  // Dos lados de cada longitud
        }

        // Calcular el área del deltoide
        public void AreaDeltoide()
        {
            // Calcular las diagonales
            float d1 = 2 * mLado1 * (float)Math.Sin(mAngulo * Math.PI / 180 / 2);
            float d2 = 2 * mLado2 * (float)Math.Cos(mAngulo * Math.PI / 180 / 2);

            // Área = (d1 * d2) / 2
            mArea = (d1 * d2) / 2;
        }

        // Imprimir los datos de área y perímetro
        public void PrintData(TextBox txtPerimetro, TextBox txtArea)
        {
            txtPerimetro.Text = mPerimetro.ToString("0.00");
            txtArea.Text = mArea.ToString("0.00");
        }

        // Inicializar los datos
        public void InitializeData(TextBox txtLado1, TextBox txtLado2, TextBox txtAngulo,
                                   TextBox txtPerimetro, TextBox txtArea, PictureBox picCanvas)
        {
            ResetData();

            txtLado1.Text = "";
            txtLado2.Text = "";
            txtAngulo.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";
            txtLado1.Focus();
            picCanvas.Refresh();
        }

        // Restablecer los valores
        private void ResetData()
        {
            mLado1 = mLado2 = mAngulo = 0.0f;
            mArea = mPerimetro = 0.0f;
        }

        // Dibujar el deltoide
        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Purple, 3);

            // Centro del canvas
            float centerX = picCanvas.Width / 2;
            float centerY = picCanvas.Height / 2;

            // Convertir el ángulo a radianes
            float anguloRad = mAngulo * (float)Math.PI / 180;

            // Calcular los puntos del deltoide
            PointF[] points = new PointF[4];

            // En un deltoide, tenemos 4 vértices con dos pares de lados iguales

            // Vértice superior
            points[0] = new PointF(
                centerX,
                centerY - mLado1 * SF);

            // Vértice derecho
            points[1] = new PointF(
                centerX + mLado2 * SF * (float)Math.Sin(anguloRad / 2),
                centerY + mLado2 * SF * (float)Math.Cos(anguloRad / 2) - mLado1 * SF);

            // Vértice inferior
            points[2] = new PointF(
                centerX,
                centerY + mLado1 * SF - mLado1 * SF);

            // Vértice izquierdo
            points[3] = new PointF(
                centerX - mLado2 * SF * (float)Math.Sin(anguloRad / 2),
                centerY + mLado2 * SF * (float)Math.Cos(anguloRad / 2) - mLado1 * SF);

            // Dibujar el deltoide
            mGraph.DrawPolygon(mPen, points);
        }

        // Cerrar el formulario
        public void CloseForm(Form objForm)
        {
            objForm.Close();
        }
    }
}