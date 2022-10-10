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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ProgressBarandAnimation.htm
    public partial  class frmProgressBarandAnimation:Form
    {
        public frmProgressBarandAnimation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmProgressBarandAnimation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmProgressBarandAnimation";
            this.Text = "frmProgressBarandAnimation";
            this.Load += new System.EventHandler(this.frmProgressBarandAnimation_Load);
            this.ResumeLayout(false);

        }

        private void frmProgressBarandAnimation_Load(object sender, EventArgs e)
        {

        }
    }
}
