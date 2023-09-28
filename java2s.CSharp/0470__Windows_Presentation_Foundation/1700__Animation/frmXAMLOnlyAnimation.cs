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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/XAMLOnlyAnimation.htm
    public partial  class frmXAMLOnlyAnimation:Form
    {
        public frmXAMLOnlyAnimation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmXAMLOnlyAnimation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmXAMLOnlyAnimation";
            this.Text = "frmXAMLOnlyAnimation";
            this.Load += new System.EventHandler(this.frmXAMLOnlyAnimation_Load);
            this.ResumeLayout(false);

        }

        private void frmXAMLOnlyAnimation_Load(object sender, EventArgs e)
        {

        }
    }
}
