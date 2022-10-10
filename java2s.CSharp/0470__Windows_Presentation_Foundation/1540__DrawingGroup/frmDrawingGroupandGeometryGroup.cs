using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1540__DrawingGroup
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/DrawingGroupandGeometryGroup.htm
    public partial  class frmDrawingGroupandGeometryGroup:Form
    {
        public frmDrawingGroupandGeometryGroup()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDrawingGroupandGeometryGroup
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDrawingGroupandGeometryGroup";
            this.Text = "frmDrawingGroupandGeometryGroup";
            this.Load += new System.EventHandler(this.frmDrawingGroupandGeometryGroup_Load);
            this.ResumeLayout(false);

        }

        private void frmDrawingGroupandGeometryGroup_Load(object sender, EventArgs e)
        {

        }
    }
}
