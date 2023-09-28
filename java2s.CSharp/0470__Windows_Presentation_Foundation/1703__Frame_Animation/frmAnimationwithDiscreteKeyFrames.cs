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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AnimationwithDiscreteKeyFrames.htm
    public partial  class frmAnimationwithDiscreteKeyFrames:Form
    {
        public frmAnimationwithDiscreteKeyFrames()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnimationwithDiscreteKeyFrames
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnimationwithDiscreteKeyFrames";
            this.Text = "frmAnimationwithDiscreteKeyFrames";
            this.Load += new System.EventHandler(this.frmAnimationwithDiscreteKeyFrames_Load);
            this.ResumeLayout(false);

        }

        private void frmAnimationwithDiscreteKeyFrames_Load(object sender, EventArgs e)
        {

        }
    }
}
