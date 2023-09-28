using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1703__Frame_Animation
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UseStringAnimationUsingKeyFramestoColor.htm
    public partial  class frmUseStringAnimationUsingKeyFramestoColor:Form
    {
        public frmUseStringAnimationUsingKeyFramestoColor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseStringAnimationUsingKeyFramestoColor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseStringAnimationUsingKeyFramestoColor";
            this.Text = "frmUseStringAnimationUsingKeyFramestoColor";
            this.Load += new System.EventHandler(this.frmUseStringAnimationUsingKeyFramestoColor_Load);
            this.ResumeLayout(false);

        }

        private void frmUseStringAnimationUsingKeyFramestoColor_Load(object sender, EventArgs e)
        {

        }
    }
}
