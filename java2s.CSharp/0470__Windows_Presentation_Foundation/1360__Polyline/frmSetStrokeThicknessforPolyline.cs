using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1360__Polyline
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SetStrokeThicknessforPolyline.htm
    public partial  class frmSetStrokeThicknessforPolyline:Form
    {
        public frmSetStrokeThicknessforPolyline()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetStrokeThicknessforPolyline
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetStrokeThicknessforPolyline";
            this.Text = "frmSetStrokeThicknessforPolyline";
            this.Load += new System.EventHandler(this.frmSetStrokeThicknessforPolyline_Load);
            this.ResumeLayout(false);

        }

        private void frmSetStrokeThicknessforPolyline_Load(object sender, EventArgs e)
        {

        }
    }
}
