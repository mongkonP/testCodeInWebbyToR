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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/DirectoryTreeView.htm
    public partial  class frmDirectoryTreeView:Form
    {
        public frmDirectoryTreeView()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDirectoryTreeView
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDirectoryTreeView";
            this.Text = "frmDirectoryTreeView";
            this.Load += new System.EventHandler(this.frmDirectoryTreeView_Load);
            this.ResumeLayout(false);

        }

        private void frmDirectoryTreeView_Load(object sender, EventArgs e)
        {

        }
    }
}
