using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0640__TreeView
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/HandlestheSelectedeventforallTreeViewItems.htm
    public partial  class frmHandlestheSelectedeventforallTreeViewItems:Form
    {
        public frmHandlestheSelectedeventforallTreeViewItems()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmHandlestheSelectedeventforallTreeViewItems
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmHandlestheSelectedeventforallTreeViewItems";
            this.Text = "frmHandlestheSelectedeventforallTreeViewItems";
            this.Load += new System.EventHandler(this.frmHandlestheSelectedeventforallTreeViewItems_Load);
            this.ResumeLayout(false);

        }

        private void frmHandlestheSelectedeventforallTreeViewItems_Load(object sender, EventArgs e)
        {

        }
    }
}
