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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/BouncingBallwithParallelTimeline.htm
    public partial  class frmBouncingBallwithParallelTimeline:Form
    {
        public frmBouncingBallwithParallelTimeline()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBouncingBallwithParallelTimeline
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBouncingBallwithParallelTimeline";
            this.Text = "frmBouncingBallwithParallelTimeline";
            this.Load += new System.EventHandler(this.frmBouncingBallwithParallelTimeline_Load);
            this.ResumeLayout(false);

        }

        private void frmBouncingBallwithParallelTimeline_Load(object sender, EventArgs e)
        {

        }
    }
}
