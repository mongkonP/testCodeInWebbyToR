using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0022__Button_Animation
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ShakingaButtonwithDoubleAnimation.htm
    public partial  class frmShakingaButtonwithDoubleAnimation:Form
    {
        public frmShakingaButtonwithDoubleAnimation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmShakingaButtonwithDoubleAnimation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmShakingaButtonwithDoubleAnimation";
            this.Text = "frmShakingaButtonwithDoubleAnimation";
            this.Load += new System.EventHandler(this.frmShakingaButtonwithDoubleAnimation_Load);
            this.ResumeLayout(false);

        }

        private void frmShakingaButtonwithDoubleAnimation_Load(object sender, EventArgs e)
        {

        }
    }
}
