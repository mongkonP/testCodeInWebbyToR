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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SimpleCanvasLayout.htm
    public partial  class frmSimpleCanvasLayout:Form
    {
        public frmSimpleCanvasLayout()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimpleCanvasLayout
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimpleCanvasLayout";
            this.Text = "frmSimpleCanvasLayout";
            this.Load += new System.EventHandler(this.frmSimpleCanvasLayout_Load);
            this.ResumeLayout(false);

        }

        private void frmSimpleCanvasLayout_Load(object sender, EventArgs e)
        {

        }
    }
}
