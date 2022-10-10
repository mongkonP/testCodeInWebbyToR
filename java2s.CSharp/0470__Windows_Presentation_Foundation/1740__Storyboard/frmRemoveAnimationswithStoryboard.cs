using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1740__Storyboard
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/RemoveAnimationswithStoryboard.htm
    public partial  class frmRemoveAnimationswithStoryboard:Form
    {
        public frmRemoveAnimationswithStoryboard()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRemoveAnimationswithStoryboard
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRemoveAnimationswithStoryboard";
            this.Text = "frmRemoveAnimationswithStoryboard";
            this.Load += new System.EventHandler(this.frmRemoveAnimationswithStoryboard_Load);
            this.ResumeLayout(false);

        }

        private void frmRemoveAnimationswithStoryboard_Load(object sender, EventArgs e)
        {

        }
    }
}
