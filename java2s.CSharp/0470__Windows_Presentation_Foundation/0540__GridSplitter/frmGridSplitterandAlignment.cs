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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/GridSplitterandAlignment.htm
    public partial  class frmGridSplitterandAlignment:Form
    {
        public frmGridSplitterandAlignment()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGridSplitterandAlignment
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGridSplitterandAlignment";
            this.Text = "frmGridSplitterandAlignment";
            this.Load += new System.EventHandler(this.frmGridSplitterandAlignment_Load);
            this.ResumeLayout(false);

        }

        private void frmGridSplitterandAlignment_Load(object sender, EventArgs e)
        {

        }
    }
}
