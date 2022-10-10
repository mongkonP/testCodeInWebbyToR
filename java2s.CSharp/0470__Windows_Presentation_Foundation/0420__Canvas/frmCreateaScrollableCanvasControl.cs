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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/CreateaScrollableCanvasControl.htm
    public partial  class frmCreateaScrollableCanvasControl:Form
    {
        public frmCreateaScrollableCanvasControl()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateaScrollableCanvasControl
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateaScrollableCanvasControl";
            this.Text = "frmCreateaScrollableCanvasControl";
            this.Load += new System.EventHandler(this.frmCreateaScrollableCanvasControl_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateaScrollableCanvasControl_Load(object sender, EventArgs e)
        {

        }
    }
}
