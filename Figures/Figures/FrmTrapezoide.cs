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
    public partial class FrmTrapezoide : Form
    {
        private Trapezoide ObjTrapezoide = new Trapezoide();
        public FrmTrapezoide()
        {
            InitializeComponent();
           
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjTrapezoide.ReadData(txtLado1, txtLado2, txtLado3, txtLado4, txtAltura);
            ObjTrapezoide.PerimeterTrapezoide();
            ObjTrapezoide.AreaTrapezoide();
            ObjTrapezoide.PrintData(txtPerimetro, txtArea);
            ObjTrapezoide.PlotShape(picCanvas);

        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            ObjTrapezoide.InitializeData(txtLado1, txtLado2, txtLado3, txtLado4, txtAltura, txtPerimetro, txtArea, picCanvas);
        }

        private void FrmTrapezoide_Load(object sender, EventArgs e)
        {
            ObjTrapezoide.InitializeData(txtLado1, txtLado2, txtLado3, txtLado4, txtAltura, txtPerimetro, txtArea, picCanvas);
        }
    }
}
