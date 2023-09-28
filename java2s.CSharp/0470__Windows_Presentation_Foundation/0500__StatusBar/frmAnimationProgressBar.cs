using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0500__StatusBar
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AnimationProgressBar.htm
    public partial  class frmAnimationProgressBar:Form
    {
        public frmAnimationProgressBar()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnimationProgressBar
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnimationProgressBar";
            this.Text = "frmAnimationProgressBar";
            this.Load += new System.EventHandler(this.frmAnimationProgressBar_Load);
            this.ResumeLayout(false);

        }

        private void frmAnimationProgressBar_Load(object sender, EventArgs e)
        {

        }
    }
}
