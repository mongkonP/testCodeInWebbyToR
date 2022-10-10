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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/RotateButtonAnimation.htm
    public partial  class frmRotateButtonAnimation:Form
    {
        public frmRotateButtonAnimation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRotateButtonAnimation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRotateButtonAnimation";
            this.Text = "frmRotateButtonAnimation";
            this.Load += new System.EventHandler(this.frmRotateButtonAnimation_Load);
            this.ResumeLayout(false);

        }

        private void frmRotateButtonAnimation_Load(object sender, EventArgs e)
        {

        }
    }
}
