using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1702__Speed_Animation
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Animationwithaslowspeed.htm
    public partial  class frmAnimationwithaslowspeed:Form
    {
        public frmAnimationwithaslowspeed()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnimationwithaslowspeed
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnimationwithaslowspeed";
            this.Text = "frmAnimationwithaslowspeed";
            this.Load += new System.EventHandler(this.frmAnimationwithaslowspeed_Load);
            this.ResumeLayout(false);

        }

        private void frmAnimationwithaslowspeed_Load(object sender, EventArgs e)
        {

        }
    }
}
