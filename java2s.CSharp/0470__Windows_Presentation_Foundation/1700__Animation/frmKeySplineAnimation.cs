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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/KeySplineAnimation.htm
    public partial  class frmKeySplineAnimation:Form
    {
        public frmKeySplineAnimation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmKeySplineAnimation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmKeySplineAnimation";
            this.Text = "frmKeySplineAnimation";
            this.Load += new System.EventHandler(this.frmKeySplineAnimation_Load);
            this.ResumeLayout(false);

        }

        private void frmKeySplineAnimation_Load(object sender, EventArgs e)
        {

        }
    }
}
