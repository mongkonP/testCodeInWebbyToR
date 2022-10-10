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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UsingDiscreteStringKeyFrame.htm
    public partial  class frmUsingDiscreteStringKeyFrame:Form
    {
        public frmUsingDiscreteStringKeyFrame()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingDiscreteStringKeyFrame
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingDiscreteStringKeyFrame";
            this.Text = "frmUsingDiscreteStringKeyFrame";
            this.Load += new System.EventHandler(this.frmUsingDiscreteStringKeyFrame_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingDiscreteStringKeyFrame_Load(object sender, EventArgs e)
        {

        }
    }
}
