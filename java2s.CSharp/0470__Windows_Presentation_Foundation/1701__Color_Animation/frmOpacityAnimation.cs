using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1701__Color_Animation
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/OpacityAnimation.htm
    public partial  class frmOpacityAnimation:Form
    {
        public frmOpacityAnimation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOpacityAnimation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOpacityAnimation";
            this.Text = "frmOpacityAnimation";
            this.Load += new System.EventHandler(this.frmOpacityAnimation_Load);
            this.ResumeLayout(false);

        }

        private void frmOpacityAnimation_Load(object sender, EventArgs e)
        {

        }
    }
}
