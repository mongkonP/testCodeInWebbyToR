using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0540__GridSplitter
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UseGridSplitter.htm
    public partial  class frmUseGridSplitter:Form
    {
        public frmUseGridSplitter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseGridSplitter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseGridSplitter";
            this.Text = "frmUseGridSplitter";
            this.Load += new System.EventHandler(this.frmUseGridSplitter_Load);
            this.ResumeLayout(false);

        }

        private void frmUseGridSplitter_Load(object sender, EventArgs e)
        {

        }
    }
}
