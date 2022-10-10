using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0062__TextBlock_Animation
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/TextBlockOpacityAnimation.htm
    public partial  class frmTextBlockOpacityAnimation:Form
    {
        public frmTextBlockOpacityAnimation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTextBlockOpacityAnimation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTextBlockOpacityAnimation";
            this.Text = "frmTextBlockOpacityAnimation";
            this.Load += new System.EventHandler(this.frmTextBlockOpacityAnimation_Load);
            this.ResumeLayout(false);

        }

        private void frmTextBlockOpacityAnimation_Load(object sender, EventArgs e)
        {

        }
    }
}
