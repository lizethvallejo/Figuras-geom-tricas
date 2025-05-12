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
    public partial class FrmRombo : Form
    {
        private Rombo ObjRombo = new Rombo(); // Objeto de la clase Rombo
        public FrmRombo()
        {
            InitializeComponent();
          
        }

        private void FrnRombo_Load(object sender, EventArgs e)
        {
           ObjRombo.InitializeData(txtLado, txtAltura, txtArea, txtPerimetro, picCanvas);

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjRombo.ReadData(txtLado, txtAltura);
            ObjRombo.PerimeterRombo();
            ObjRombo.AreaRombo();
            ObjRombo.PrintData(txtPerimetro, txtArea);
            ObjRombo.PlotShape(picCanvas);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            ObjRombo.InitializeData(txtLado, txtAltura, txtArea, txtPerimetro, picCanvas);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ObjRombo.CloseForm(this);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
