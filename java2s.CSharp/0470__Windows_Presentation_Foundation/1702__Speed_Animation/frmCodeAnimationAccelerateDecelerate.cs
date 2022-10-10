using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1702__Speed_Animation
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/CodeAnimationAccelerateDecelerate.htm
    public partial  class frmCodeAnimationAccelerateDecelerate:Form
    {
        public frmCodeAnimationAccelerateDecelerate()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCodeAnimationAccelerateDecelerate
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCodeAnimationAccelerateDecelerate";
            this.Text = "frmCodeAnimationAccelerateDecelerate";
            this.Load += new System.EventHandler(this.frmCodeAnimationAccelerateDecelerate_Load);
            this.ResumeLayout(false);

        }

        private void frmCodeAnimationAccelerateDecelerate_Load(object sender, EventArgs e)
        {

        }
    }
}
