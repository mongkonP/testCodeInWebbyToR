using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1705__Shape_Animation
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/WidthandHeightanimation.htm
    public partial  class frmWidthandHeightanimation:Form
    {
        public frmWidthandHeightanimation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWidthandHeightanimation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWidthandHeightanimation";
            this.Text = "frmWidthandHeightanimation";
            this.Load += new System.EventHandler(this.frmWidthandHeightanimation_Load);
            this.ResumeLayout(false);

        }

        private void frmWidthandHeightanimation_Load(object sender, EventArgs e)
        {

        }
    }
}
