using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figures
{
    public partial class FrmIndex : Form
    {

        public FrmIndex()
        {
            InitializeComponent();
        }

        private void OpenForm(Form formulario)
        {
            panelContenedor.Controls.Clear();     // Limpiar contenido anterior
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void circuloToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenForm(new FrmCircle());
        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmCuadrado());
        }

        private void rectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmRectangulo());
        }

        private void romboToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmRombo());
        }

        private void romboideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmRomboide());  
        }

        private void trapecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmTrapecio());
        }

        private void trapecioisocelesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmTrapecioIso());
        }

        private void trapezoideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmTrapezoide());
        }

        private void deltoideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmDeltoide());
        }

        private void elipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmElipse());
        }

        private void ovaloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmOvalo());
        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmCircle());
        }

        private void trianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmTriangulo());
        }

        private void pentagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmPentagono());
        }

        private void hexagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmHexagono());
        }

        private void heptagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmHeptagono());
        }

        private void octagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmOctagono());
        }

        private void eneagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmEneagono());
        }

        private void decagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmDecagono());
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
 