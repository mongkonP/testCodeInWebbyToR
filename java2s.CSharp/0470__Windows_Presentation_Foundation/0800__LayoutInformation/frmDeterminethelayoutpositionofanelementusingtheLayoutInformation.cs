using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0800__LayoutInformation
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/DeterminethelayoutpositionofanelementusingtheLayoutInformation.htm
    public partial  class frmDeterminethelayoutpositionofanelementusingtheLayoutInformation:Form
    {
        public frmDeterminethelayoutpositionofanelementusingtheLayoutInformation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDeterminethelayoutpositionofanelementusingtheLayoutInformation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDeterminethelayoutpositionofanelementusingtheLayoutInformation";
            this.Text = "frmDeterminethelayoutpositionofanelementusingtheLayoutInformation";
            this.Load += new System.EventHandler(this.frmDeterminethelayoutpositionofanelementusingtheLayoutInformation_Load);
            this.ResumeLayout(false);

        }

        private void frmDeterminethelayoutpositionofanelementusingtheLayoutInformation_Load(object sender, EventArgs e)
        {

        }
    }
}
