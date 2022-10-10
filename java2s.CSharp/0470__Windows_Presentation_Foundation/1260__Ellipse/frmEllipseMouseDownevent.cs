using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1260__Ellipse
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/EllipseMouseDownevent.htm
    public partial  class frmEllipseMouseDownevent:Form
    {
        public frmEllipseMouseDownevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEllipseMouseDownevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEllipseMouseDownevent";
            this.Text = "frmEllipseMouseDownevent";
            this.Load += new System.EventHandler(this.frmEllipseMouseDownevent_Load);
            this.ResumeLayout(false);

        }

        private void frmEllipseMouseDownevent_Load(object sender, EventArgs e)
        {

        }
    }
}
