using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figures
{
    internal class Pentagono
    {
        private float mRadio;
        private float mPerimetro;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 20; // Factor de escala
        private Pen mPen;

        public Pentagono()
        {
            mRadio = 0.0f;
            mPerimetro = 0.0f;
            mArea = 0.0f;
        }

        public void ReadData(TextBox txtRadio)
        {
            try
            {
                mRadio = float.Parse(txtRadio.Text);
                if (mRadio <= 0)
                {
                    MessageBox.Show("El radio debe ser un número positivo.", "Error de validación");
                    mRadio = 0.0f;
                }
            }
            catch
            {
                MessageBox.Show("Ingreso no válido. Ingrese un número válido.", "Mensaje de error");
            }
        }


        public void PerimeterPentagono()
        {
            float lado = 2 * mRadio * (float)Math.Sin(Math.PI / 5);
            mPerimetro = 5 * lado;

        }

        public void AreaPentagono()
        {
            mArea = (5 / 2.0f) * mRadio * mRadio * (float)Math.Sin(2 * Math.PI / 5);
        }

        public void PrintData(TextBox txtPerimetro, TextBox txtArea)
        {
            txtPerimetro.Text = mPerimetro.ToString();
            txtArea.Text = mArea.ToString();
        }

        public void InitializeData(TextBox txtRadio, TextBox txtPerimetro,
                                   TextBox txtArea, PictureBox picCanvas)
        {
            mRadio = 0.0f;
            mPerimetro = 0.0f;
            mArea = 0.0f;

            txtRadio.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";
            txtRadio.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Green, 3);

            PointF[] points = new PointF[5];
            float centerX = picCanvas.Width / 2;
            float centerY = picCanvas.Height / 2;

            for (int i = 0; i < 5; i++)
            {
                float angle = (float)(2 * Math.PI * i / 5 - Math.PI / 2); // Inicio hacia arriba
                float x = centerX + mRadio * SF * (float)Math.Cos(angle);
                float y = centerY + mRadio * SF * (float)Math.Sin(angle);
                points[i] = new PointF(x, y);
            }

            mGraph.DrawPolygon(mPen, points);
        }

        public void CloseForm(Form objForm)
        {
            objForm.Close();
        }
    }
}
