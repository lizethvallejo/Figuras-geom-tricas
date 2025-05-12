using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figures
{
    internal class Romboide
    {
        private float mBase;
        private float mAltura;
        private float mArea;
        private float mPerimetro;
        private Graphics mGraph;
        private const float SF = 20; // Factor de escala
        private Pen mPen;

        public Romboide()
        {
            mBase = 0.0f;
            mAltura = 0.0f;
            mArea = 0.0f;
            mPerimetro = 0.0f;
        }

        // Leer base y altura desde los TextBox
        public void ReadData(TextBox txtBase, TextBox txtAltura)
        {
            try
            {
                mBase = float.Parse(txtBase.Text);
                mAltura = float.Parse(txtAltura.Text);

                if (mBase <= 0 || mAltura <= 0)
                {
                    MessageBox.Show("La base y la altura deben ser mayores a 0.", "Mensaje de error");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Ingreso no válido. Ingrese valores numéricos.", "Mensaje de error");
            }
        }

        // Área = base * altura
        public void AreaRomboide()
        {
            mArea = mBase * mAltura;
        }

        // Perímetro = 2 * (base + lado inclinado)
        // Asumiremos lado inclinado ≈ base para simplicidad si no hay otro dato
        public void PerimeterRomboide()
        {
            mPerimetro = 2 * (mBase + mBase);
        }

        public void PrintData(TextBox txtPerimetro, TextBox txtArea)
        {
            txtPerimetro.Text = mPerimetro.ToString("0.00");
            txtArea.Text = mArea.ToString("0.00");
        }

        public void InitializeData(TextBox txtBase, TextBox txtAltura,
                                   TextBox txtPerimetro, TextBox txtArea,
                                   PictureBox picCanvas)
        {
            mBase = 0.0f;
            mAltura = 0.0f;
            mArea = 0.0f;
            mPerimetro = 0.0f;

            txtBase.Text = "";
            txtAltura.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";
            txtBase.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Purple, 3);

            float baseLength = mBase * SF;
            float height = mAltura * SF;
            float offset = baseLength / 3;

            float x = (picCanvas.Width - baseLength) / 2;
            float y = (picCanvas.Height - height) / 2;

            PointF[] points = new PointF[4];
            points[0] = new PointF(x + offset, y);                     // Superior izquierda
            points[1] = new PointF(x + offset + baseLength, y);        // Superior derecha
            points[2] = new PointF(x + baseLength, y + height);        // Inferior derecha
            points[3] = new PointF(x, y + height);                     // Inferior izquierda

            mGraph.DrawPolygon(mPen, points);
        }

        public void CloseForm(Form objForm)
        {
            objForm.Close();
        }
    }
}
