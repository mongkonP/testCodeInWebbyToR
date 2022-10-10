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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SetTreeViewwithTreeViewItem.htm
    public partial  class frmSetTreeViewwithTreeViewItem:Form
    {
        public frmSetTreeViewwithTreeViewItem()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetTreeViewwithTreeViewItem
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetTreeViewwithTreeViewItem";
            this.Text = "frmSetTreeViewwithTreeViewItem";
            this.Load += new System.EventHandler(this.frmSetTreeViewwithTreeViewItem_Load);
            this.ResumeLayout(false);

        }

        private void frmSetTreeViewwithTreeViewItem_Load(object sender, EventArgs e)
        {

        }
    }
}
