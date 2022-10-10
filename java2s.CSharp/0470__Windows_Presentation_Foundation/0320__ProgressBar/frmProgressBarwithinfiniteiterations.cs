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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ProgressBarwithinfiniteiterations.htm
    public partial  class frmProgressBarwithinfiniteiterations:Form
    {
        public frmProgressBarwithinfiniteiterations()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmProgressBarwithinfiniteiterations
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmProgressBarwithinfiniteiterations";
            this.Text = "frmProgressBarwithinfiniteiterations";
            this.Load += new System.EventHandler(this.frmProgressBarwithinfiniteiterations_Load);
            this.ResumeLayout(false);

        }

        private void frmProgressBarwithinfiniteiterations_Load(object sender, EventArgs e)
        {

        }
    }
}
