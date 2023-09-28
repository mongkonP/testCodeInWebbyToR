using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1380__Rectangle
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Rectanglemousedownpreview.htm
    public partial  class frmRectanglemousedownpreview:Form
    {
        public frmRectanglemousedownpreview()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRectanglemousedownpreview
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRectanglemousedownpreview";
            this.Text = "frmRectanglemousedownpreview";
            this.Load += new System.EventHandler(this.frmRectanglemousedownpreview_Load);
            this.ResumeLayout(false);

        }

        private void frmRectanglemousedownpreview_Load(object sender, EventArgs e)
        {

        }
    }
}
