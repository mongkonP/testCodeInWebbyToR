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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/RemoveAnimationswithAnimationClock.htm
    public partial  class frmRemoveAnimationswithAnimationClock:Form
    {
        public frmRemoveAnimationswithAnimationClock()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRemoveAnimationswithAnimationClock
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRemoveAnimationswithAnimationClock";
            this.Text = "frmRemoveAnimationswithAnimationClock";
            this.Load += new System.EventHandler(this.frmRemoveAnimationswithAnimationClock_Load);
            this.ResumeLayout(false);

        }

        private void frmRemoveAnimationswithAnimationClock_Load(object sender, EventArgs e)
        {

        }
    }
}
