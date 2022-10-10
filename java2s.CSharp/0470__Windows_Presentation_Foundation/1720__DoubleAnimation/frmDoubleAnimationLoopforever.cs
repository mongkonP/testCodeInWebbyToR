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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/DoubleAnimationLoopforever.htm
    public partial  class frmDoubleAnimationLoopforever:Form
    {
        public frmDoubleAnimationLoopforever()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDoubleAnimationLoopforever
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDoubleAnimationLoopforever";
            this.Text = "frmDoubleAnimationLoopforever";
            this.Load += new System.EventHandler(this.frmDoubleAnimationLoopforever_Load);
            this.ResumeLayout(false);

        }

        private void frmDoubleAnimationLoopforever_Load(object sender, EventArgs e)
        {

        }
    }
}
