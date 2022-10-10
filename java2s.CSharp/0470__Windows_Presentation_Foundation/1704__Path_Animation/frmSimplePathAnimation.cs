using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1704__Path_Animation
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SimplePathAnimation.htm
    public partial  class frmSimplePathAnimation:Form
    {
        public frmSimplePathAnimation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimplePathAnimation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimplePathAnimation";
            this.Text = "frmSimplePathAnimation";
            this.Load += new System.EventHandler(this.frmSimplePathAnimation_Load);
            this.ResumeLayout(false);

        }

        private void frmSimplePathAnimation_Load(object sender, EventArgs e)
        {

        }
    }
}
