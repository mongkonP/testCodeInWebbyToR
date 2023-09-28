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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/TreeViewwithDataSource.htm
    public partial  class frmTreeViewwithDataSource:Form
    {
        public frmTreeViewwithDataSource()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTreeViewwithDataSource
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTreeViewwithDataSource";
            this.Text = "frmTreeViewwithDataSource";
            this.Load += new System.EventHandler(this.frmTreeViewwithDataSource_Load);
            this.ResumeLayout(false);

        }

        private void frmTreeViewwithDataSource_Load(object sender, EventArgs e)
        {

        }
    }
}
