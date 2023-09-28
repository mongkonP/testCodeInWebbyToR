using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1705__Ball_Animation
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/BouncingBallwithDoubleAnimation.htm
    public partial  class frmBouncingBallwithDoubleAnimation:Form
    {
        public frmBouncingBallwithDoubleAnimation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBouncingBallwithDoubleAnimation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBouncingBallwithDoubleAnimation";
            this.Text = "frmBouncingBallwithDoubleAnimation";
            this.Load += new System.EventHandler(this.frmBouncingBallwithDoubleAnimation_Load);
            this.ResumeLayout(false);

        }

        private void frmBouncingBallwithDoubleAnimation_Load(object sender, EventArgs e)
        {

        }
    }
}
