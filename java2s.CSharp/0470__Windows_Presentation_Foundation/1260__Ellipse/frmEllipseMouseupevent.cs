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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/EllipseMouseupevent.htm
    public partial  class frmEllipseMouseupevent:Form
    {
        public frmEllipseMouseupevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEllipseMouseupevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEllipseMouseupevent";
            this.Text = "frmEllipseMouseupevent";
            this.Load += new System.EventHandler(this.frmEllipseMouseupevent_Load);
            this.ResumeLayout(false);

        }

        private void frmEllipseMouseupevent_Load(object sender, EventArgs e)
        {

        }
    }
}
