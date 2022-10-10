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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/CanvaswithoutViewbox.htm
    public partial  class frmCanvaswithoutViewbox:Form
    {
        public frmCanvaswithoutViewbox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCanvaswithoutViewbox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCanvaswithoutViewbox";
            this.Text = "frmCanvaswithoutViewbox";
            this.Load += new System.EventHandler(this.frmCanvaswithoutViewbox_Load);
            this.ResumeLayout(false);

        }

        private void frmCanvaswithoutViewbox_Load(object sender, EventArgs e)
        {

        }
    }
}
