using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1701__Color_Animation
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AnimateOpacity.htm
    public partial  class frmAnimateOpacity:Form
    {
        public frmAnimateOpacity()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnimateOpacity
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnimateOpacity";
            this.Text = "frmAnimateOpacity";
            this.Load += new System.EventHandler(this.frmAnimateOpacity_Load);
            this.ResumeLayout(false);

        }

        private void frmAnimateOpacity_Load(object sender, EventArgs e)
        {

        }
    }
}
