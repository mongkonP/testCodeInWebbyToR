using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0620__TreeView
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/TreeViewAddNodes.htm
    public partial  class frmTreeViewAddNodes:Form
    {
        public frmTreeViewAddNodes()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTreeViewAddNodes
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTreeViewAddNodes";
            this.Text = "frmTreeViewAddNodes";
            this.Load += new System.EventHandler(this.frmTreeViewAddNodes_Load);
            this.ResumeLayout(false);

        }

        private void frmTreeViewAddNodes_Load(object sender, EventArgs e)
        {

        }
    }
}
