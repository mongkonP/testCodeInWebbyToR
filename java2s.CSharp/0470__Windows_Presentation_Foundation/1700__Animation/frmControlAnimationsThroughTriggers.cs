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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ControlAnimationsThroughTriggers.htm
    public partial  class frmControlAnimationsThroughTriggers:Form
    {
        public frmControlAnimationsThroughTriggers()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmControlAnimationsThroughTriggers
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmControlAnimationsThroughTriggers";
            this.Text = "frmControlAnimationsThroughTriggers";
            this.Load += new System.EventHandler(this.frmControlAnimationsThroughTriggers_Load);
            this.ResumeLayout(false);

        }

        private void frmControlAnimationsThroughTriggers_Load(object sender, EventArgs e)
        {

        }
    }
}
