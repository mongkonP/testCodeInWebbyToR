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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/EllipseMouseMoveevent.htm
    public partial  class frmEllipseMouseMoveevent:Form
    {
        public frmEllipseMouseMoveevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEllipseMouseMoveevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEllipseMouseMoveevent";
            this.Text = "frmEllipseMouseMoveevent";
            this.Load += new System.EventHandler(this.frmEllipseMouseMoveevent_Load);
            this.ResumeLayout(false);

        }

        private void frmEllipseMouseMoveevent_Load(object sender, EventArgs e)
        {

        }
    }
}
