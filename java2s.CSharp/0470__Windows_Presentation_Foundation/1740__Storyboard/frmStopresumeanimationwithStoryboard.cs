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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/StopresumeanimationwithStoryboard.htm
    public partial  class frmStopresumeanimationwithStoryboard:Form
    {
        public frmStopresumeanimationwithStoryboard()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStopresumeanimationwithStoryboard
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStopresumeanimationwithStoryboard";
            this.Text = "frmStopresumeanimationwithStoryboard";
            this.Load += new System.EventHandler(this.frmStopresumeanimationwithStoryboard_Load);
            this.ResumeLayout(false);

        }

        private void frmStopresumeanimationwithStoryboard_Load(object sender, EventArgs e)
        {

        }
    }
}
