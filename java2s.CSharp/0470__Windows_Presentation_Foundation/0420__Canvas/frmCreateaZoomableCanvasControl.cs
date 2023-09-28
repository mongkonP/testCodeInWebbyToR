using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0420__Canvas
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/CreateaZoomableCanvasControl.htm
    public partial  class frmCreateaZoomableCanvasControl:Form
    {
        public frmCreateaZoomableCanvasControl()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateaZoomableCanvasControl
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateaZoomableCanvasControl";
            this.Text = "frmCreateaZoomableCanvasControl";
            this.Load += new System.EventHandler(this.frmCreateaZoomableCanvasControl_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateaZoomableCanvasControl_Load(object sender, EventArgs e)
        {

        }
    }
}
