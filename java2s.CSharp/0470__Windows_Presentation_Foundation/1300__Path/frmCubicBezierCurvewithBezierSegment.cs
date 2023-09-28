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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/CubicBezierCurvewithBezierSegment.htm
    public partial  class frmCubicBezierCurvewithBezierSegment:Form
    {
        public frmCubicBezierCurvewithBezierSegment()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCubicBezierCurvewithBezierSegment
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCubicBezierCurvewithBezierSegment";
            this.Text = "frmCubicBezierCurvewithBezierSegment";
            this.Load += new System.EventHandler(this.frmCubicBezierCurvewithBezierSegment_Load);
            this.ResumeLayout(false);

        }

        private void frmCubicBezierCurvewithBezierSegment_Load(object sender, EventArgs e)
        {

        }
    }
}
