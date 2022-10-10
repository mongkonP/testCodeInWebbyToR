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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/GridSplitterExample.htm
    public partial  class frmGridSplitterExample:Form
    {
        public frmGridSplitterExample()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGridSplitterExample
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGridSplitterExample";
            this.Text = "frmGridSplitterExample";
            this.Load += new System.EventHandler(this.frmGridSplitterExample_Load);
            this.ResumeLayout(false);

        }

        private void frmGridSplitterExample_Load(object sender, EventArgs e)
        {

        }
    }
}
