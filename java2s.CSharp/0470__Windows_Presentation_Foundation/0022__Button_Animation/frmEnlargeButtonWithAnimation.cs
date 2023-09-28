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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/EnlargeButtonWithAnimation.htm
    public partial  class frmEnlargeButtonWithAnimation:Form
    {
        public frmEnlargeButtonWithAnimation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEnlargeButtonWithAnimation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEnlargeButtonWithAnimation";
            this.Text = "frmEnlargeButtonWithAnimation";
            this.Load += new System.EventHandler(this.frmEnlargeButtonWithAnimation_Load);
            this.ResumeLayout(false);

        }

        private void frmEnlargeButtonWithAnimation_Load(object sender, EventArgs e)
        {

        }
    }
}
