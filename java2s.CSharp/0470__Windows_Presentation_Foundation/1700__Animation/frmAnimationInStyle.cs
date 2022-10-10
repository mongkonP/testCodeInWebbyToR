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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AnimationInStyle.htm
    public partial  class frmAnimationInStyle:Form
    {
        public frmAnimationInStyle()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnimationInStyle
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnimationInStyle";
            this.Text = "frmAnimationInStyle";
            this.Load += new System.EventHandler(this.frmAnimationInStyle_Load);
            this.ResumeLayout(false);

        }

        private void frmAnimationInStyle_Load(object sender, EventArgs e)
        {

        }
    }
}
