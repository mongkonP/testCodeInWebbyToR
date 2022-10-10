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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/TriggerAnimationbyMouseinoutaction.htm
    public partial  class frmTriggerAnimationbyMouseinoutaction:Form
    {
        public frmTriggerAnimationbyMouseinoutaction()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTriggerAnimationbyMouseinoutaction
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTriggerAnimationbyMouseinoutaction";
            this.Text = "frmTriggerAnimationbyMouseinoutaction";
            this.Load += new System.EventHandler(this.frmTriggerAnimationbyMouseinoutaction_Load);
            this.ResumeLayout(false);

        }

        private void frmTriggerAnimationbyMouseinoutaction_Load(object sender, EventArgs e)
        {

        }
    }
}
