using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1720__DoubleAnimation
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/DoubleAnimationLoopfor30seconds.htm
    public partial  class frmDoubleAnimationLoopfor30seconds:Form
    {
        public frmDoubleAnimationLoopfor30seconds()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDoubleAnimationLoopfor30seconds
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDoubleAnimationLoopfor30seconds";
            this.Text = "frmDoubleAnimationLoopfor30seconds";
            this.Load += new System.EventHandler(this.frmDoubleAnimationLoopfor30seconds_Load);
            this.ResumeLayout(false);

        }

        private void frmDoubleAnimationLoopfor30seconds_Load(object sender, EventArgs e)
        {

        }
    }
}
