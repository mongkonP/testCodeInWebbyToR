using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1300__Path
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/QuadraticBezierCurvewithPathFigure.htm
    public partial  class frmQuadraticBezierCurvewithPathFigure:Form
    {
        public frmQuadraticBezierCurvewithPathFigure()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmQuadraticBezierCurvewithPathFigure
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmQuadraticBezierCurvewithPathFigure";
            this.Text = "frmQuadraticBezierCurvewithPathFigure";
            this.Load += new System.EventHandler(this.frmQuadraticBezierCurvewithPathFigure_Load);
            this.ResumeLayout(false);

        }

        private void frmQuadraticBezierCurvewithPathFigure_Load(object sender, EventArgs e)
        {

        }
    }
}
