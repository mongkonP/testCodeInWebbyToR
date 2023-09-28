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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ViewandSelectItemsUsingaTree.htm
    public partial  class frmViewandSelectItemsUsingaTree:Form
    {
        public frmViewandSelectItemsUsingaTree()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmViewandSelectItemsUsingaTree
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmViewandSelectItemsUsingaTree";
            this.Text = "frmViewandSelectItemsUsingaTree";
            this.Load += new System.EventHandler(this.frmViewandSelectItemsUsingaTree_Load);
            this.ResumeLayout(false);

        }

        private void frmViewandSelectItemsUsingaTree_Load(object sender, EventArgs e)
        {

        }
    }
}
