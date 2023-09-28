using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1020__Window
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/LoadtheDataforaWindowAsynchronouslyAfterItHasRendered.htm
    public partial  class frmLoadtheDataforaWindowAsynchronouslyAfterItHasRendered:Form
    {
        public frmLoadtheDataforaWindowAsynchronouslyAfterItHasRendered()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLoadtheDataforaWindowAsynchronouslyAfterItHasRendered
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLoadtheDataforaWindowAsynchronouslyAfterItHasRendered";
            this.Text = "frmLoadtheDataforaWindowAsynchronouslyAfterItHasRendered";
            this.Load += new System.EventHandler(this.frmLoadtheDataforaWindowAsynchronouslyAfterItHasRendered_Load);
            this.ResumeLayout(false);

        }

        private void frmLoadtheDataforaWindowAsynchronouslyAfterItHasRendered_Load(object sender, EventArgs e)
        {

        }
    }
}
