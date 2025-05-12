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
    public partial class FrmPentagono : Form
    {
        private Pentagono ObjPentagono = new Pentagono();
        public FrmPentagono()
        {
            InitializeComponent();
            
        }

        private void FrmPentagono_Load(object sender, EventArgs e)
        {
            ObjPentagono.InitializeData(txtRadio, txtPerimetro, txtArea, picCanvas);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjPentagono.ReadData(txtRadio);
            ObjPentagono.PerimeterPentagono();
            ObjPentagono.AreaPentagono();
            ObjPentagono.PrintData(txtPerimetro, txtArea);
            ObjPentagono.PlotShape(picCanvas);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            ObjPentagono.InitializeData(txtRadio, txtPerimetro, txtArea, picCanvas);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
