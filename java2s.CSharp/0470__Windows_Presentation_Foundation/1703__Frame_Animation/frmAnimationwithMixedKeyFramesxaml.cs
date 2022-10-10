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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AnimationwithMixedKeyFramesxaml.htm
    public partial  class frmAnimationwithMixedKeyFramesxaml:Form
    {
        public frmAnimationwithMixedKeyFramesxaml()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnimationwithMixedKeyFramesxaml
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnimationwithMixedKeyFramesxaml";
            this.Text = "frmAnimationwithMixedKeyFramesxaml";
            this.Load += new System.EventHandler(this.frmAnimationwithMixedKeyFramesxaml_Load);
            this.ResumeLayout(false);

        }

        private void frmAnimationwithMixedKeyFramesxaml_Load(object sender, EventArgs e)
        {

        }
    }
}
