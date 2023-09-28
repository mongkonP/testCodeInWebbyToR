using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1700__Animation
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AnimationInCode.htm
    public partial  class frmAnimationInCode:Form
    {
        public frmAnimationInCode()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnimationInCode
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnimationInCode";
            this.Text = "frmAnimationInCode";
            this.Load += new System.EventHandler(this.frmAnimationInCode_Load);
            this.ResumeLayout(false);

        }

        private void frmAnimationInCode_Load(object sender, EventArgs e)
        {

        }
    }
}
