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
    public partial class FrmRomboide : Form
    {
        private Romboide ObjRomboide = new Romboide();
        public FrmRomboide()
        {
            InitializeComponent();
          
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjRomboide.ReadData(txtBase, txtAltura);
            ObjRomboide.PerimeterRomboide();
            ObjRomboide.AreaRomboide();
            ObjRomboide.PrintData(txtPerimetro, txtArea);
            ObjRomboide.PlotShape(picCanvas);

        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            ObjRomboide.InitializeData(txtBase, txtAltura, txtPerimetro, txtArea, picCanvas);
        }

        private void FrmRomboide_Load(object sender, EventArgs e)
        {
            ObjRomboide.InitializeData(txtBase, txtAltura, txtPerimetro, txtArea, picCanvas);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
