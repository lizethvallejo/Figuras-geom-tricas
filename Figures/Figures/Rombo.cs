using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figures
{
    internal class Rombo
    {
        // Datos del miembro
        private float mLado;        // Lado del rombo
        private float mAltura;      // Altura del rombo
        private float mPerimeter;   // Perímetro del rombo
        private float mArea;       // Área del rombo
        private Graphics mGraph;    // Objeto para modo gráfico
        private const float SF = 20; // Factor de escala (zoom in/zoom out)
        private Pen mPen;           // Bolígrafo para dibujar

        // Constructor sin parámetros
        public Rombo()
        {
            mLado = 0.0f;
            mAltura = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }

        // Función que lee los datos de entrada del rombo (lado y altura)
        public void ReadData(TextBox txtLado, TextBox txtAltura)
        {
            try
            {
                mLado = float.Parse(txtLado.Text);
                mAltura = float.Parse(txtAltura.Text);

                if (mLado <= 0 || mAltura <= 0)
                {
                    MessageBox.Show("Los valores de lado y altura deben ser mayores a 0.", "Mensaje de error");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Ingreso no válido. Por favor, ingrese números válidos.", "Mensaje de error");
            }
        }

        // Función que calcula el perímetro del rombo
        public void PerimeterRombo()
        {
            mPerimeter = 4 * mLado; // Todos los lados son iguales en un rombo
        }

        // Función que calcula el área del rombo
        public void AreaRombo()
        {
            mArea = mLado * mAltura; // Área = lado * altura
        }

        // Función que imprime el perímetro y el área del rombo
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        // Función que inicializa los datos y controles del rombo
        public void InitializeData(TextBox txtLado, TextBox txtAltura,
                                 TextBox txtPerimeter, TextBox txtArea,
                                 PictureBox picCanvas)
        {
            mLado = 0.0f;
            mAltura = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;

            txtLado.Text = "";
            txtAltura.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtLado.Focus();
            picCanvas.Refresh();
        }

        // Función que grafica un rombo
        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);

            // Calcular puntos del rombo (diamante)
            PointF[] points = new PointF[4];
            float centerX = picCanvas.Width / 2;
            float centerY = picCanvas.Height / 2;

            // Puntos en orden: arriba, derecha, abajo, izquierda
            points[0] = new PointF(centerX, centerY - mAltura * SF / 2); // Arriba
            points[1] = new PointF(centerX + mLado * SF / 2, centerY);  // Derecha
            points[2] = new PointF(centerX, centerY + mAltura * SF / 2); // Abajo
            points[3] = new PointF(centerX - mLado * SF / 2, centerY);  // Izquierda

            mGraph.DrawPolygon(mPen, points);
        }

        // Función que cierra un formulario
        public void CloseForm(Form objForm)
        {
            objForm.Close();
        }
    }
}
