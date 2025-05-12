using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figures
{
    internal class Circle
    {
        // Datos del miembro
        private float mRadius;       // Radio del círculo
        private float mPerimeter;   // Perímetro del círculo
        private float mArea;         // Área del círculo
        private Graphics mGraph;    // Objeto para modo gráfico
        private const float SF = 20; // Factor de escala (zoom in/zoom out)
        private Pen mPen;            // Bolígrafo para dibujar

        // Constructor sin parámetros
        public Circle()
        {
            mRadius = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }

        // Función que lee los datos de entrada del círculo (solo radio)
        public void ReadData(TextBox txtRadius)
        {
            try
            {
                mRadius = float.Parse(txtRadius.Text);
                if (mRadius <= 0)
                {
                    MessageBox.Show("El radio debe ser un número positivo.", "Error de validación");
                    mRadius = 0.0f;
                }
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }

        // Función que calcula el perímetro del círculo
        public void PerimeterCircle()
        {
            mPerimeter = 2 * (float)Math.PI * mRadius;
        }

        // Función que calcula el área del círculo
        public void AreaCircle()
        {
            mArea = (float)Math.PI * mRadius * mRadius;
        }

        // Función que imprime el perímetro y el área del círculo
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        // Función que inicializa los datos y controles del círculo
        public void InitializeData(TextBox txtRadius, TextBox txtPerimeter,
                                 TextBox txtArea, PictureBox picCanvas)
        {
            mRadius = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;

            txtRadius.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtRadius.Focus();
            picCanvas.Refresh();
        }

        // Función que grafica un círculo
        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Violet, 3);

            // Graficar un círculo (elipse con igual ancho y alto)
            float diameter = mRadius * 2 * SF;
            mGraph.DrawEllipse(mPen, 0, 0, diameter, diameter);
        }

        // Función que cierra un formulario
        public void CloseForm(Form objForm)
        {
            objForm.Close();
        }
    }
}