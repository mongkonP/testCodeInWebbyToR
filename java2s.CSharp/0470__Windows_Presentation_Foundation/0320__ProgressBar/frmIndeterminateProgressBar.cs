using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0320__ProgressBar
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/IndeterminateProgressBar.htm
    public partial  class frmIndeterminateProgressBar:Form
    {
        public frmIndeterminateProgressBar()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIndeterminateProgressBar
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIndeterminateProgressBar";
            this.Text = "frmIndeterminateProgressBar";
            this.Load += new System.EventHandler(this.frmIndeterminateProgressBar_Load);
            this.ResumeLayout(false);

        }

        private void frmIndeterminateProgressBar_Load(object sender, EventArgs e)
        {

        }
    }
}
